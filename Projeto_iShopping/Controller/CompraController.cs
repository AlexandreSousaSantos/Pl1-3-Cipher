using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_iShopping.Controller
{
    public class CompraController
    {
        public static List<Compra> ListarTodas()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.Include("CriadoPor")
                    .OrderByDescending(c => c.DataCriacao)
                    .ToList();
            }
        }
        /*public static List<Compra> ListarComprasAbertas()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.Include("CriadoPor")
                    .Where(c => c.Estado == "Aberta")
                    .OrderByDescending(c => c.DataCriacao)
                    .ToList();
            }*/


        //Criar compra
        public static void CriarCompra(string nomeCompra, int criadoPorId)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    Compra novaCompra = new Compra
                    {
                        NomeCompra = nomeCompra,
                        DataCriacao = DateTime.Now,
                        CriadoPorId = criadoPorId,
                        Estado = "Aberta"
                    };
                    db.Compras.Add(novaCompra);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar compra: " + ex.Message);
                return;
            }
        }

        //Atualizar Compra
        public static void AtualizarCompra(int compraId, string nomeCompra)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    Compra compra = db.Compras.Find(compraId);
                    if (compra == null)
                    {
                        MessageBox.Show("Compra não encontrada.");
                        return;
                    }
                    if (compra.Estado == "Fechada")
                    {
                        MessageBox.Show("Não é possível atualizar uma compra fechada.");
                        return;
                    }
                    compra.NomeCompra = nomeCompra;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar compra: " + ex.Message);
                return;
            }
        }


        //Eliminar compra
        public static void EliminarCompra(int compraId)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    Compra compra = db.Compras.Find(compraId);
                    if (compra == null)
                    {
                        MessageBox.Show("Compra não encontrada.");
                        return;
                    }
                    if (compra.Estado == "Fechada")
                    {
                        MessageBox.Show("Não é possível eliminar uma compra fechada.");
                        return;
                    }
                    var itens = db.ItemCompra.Where(i => i.CompraId == compraId).ToList();
                    foreach (var item in itens)
                    {
                        db.ItemCompra.Remove(item);
                    }
                    db.SaveChanges();

                    db.Compras.Remove(compra);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar compra: " + ex.Message);
                return;
            }

        }
        public static Compra ObterPorId(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras
                    .Include("CriadoPor")
                    .Include("AlteradoPor")
                    .FirstOrDefault(c => c.Id == id);
            }
        }

        //Fechar Compra
        public static void FecharCompra(int compraId, int fechadoPorId)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    Compra compra = db.Compras.Find(compraId);
                    if (compra == null)
                    {
                        MessageBox.Show("Compra não encontrada.");
                        return;
                    }
                    if (compra.Estado == "Fechada")
                    {
                        MessageBox.Show("Esta compra já foi fechada.");
                        return;
                    }

                    // Calcular custo total da compra
                    decimal custoTotal = CalcularCustoTotal(compraId, db);
                    compra.CustoTotal = custoTotal;

                    // Obter orçamento do mês atual
                    string mesAtual = DateTime.Now.ToString("MM/yyyy");
                    Orcamento orcamento = db.Orcamento.FirstOrDefault(o => o.Mes == mesAtual);

                    if (orcamento == null)
                    {
                        MessageBox.Show("Orçamento não encontrado para o mês atual.");
                        return;
                    }

                    // Validar se há orçamento disponível
                    decimal saldoDisponivel = orcamento.ValorMaximo - orcamento.CustoGasto;
                    if (custoTotal > saldoDisponivel)
                    {
                        MessageBox.Show($"Orçamento insuficiente.\nCusto da compra: €{custoTotal:F2}\nSaldo disponível: €{saldoDisponivel:F2}");
                        return;
                    }

                    // Fechar compra
                    compra.Estado = "Fechada";
                    compra.DataFechada = DateTime.Now;
                    compra.FechadaPorId = fechadoPorId.ToString();
                    compra.AlteradoPorId = fechadoPorId;
                    compra.OrcamentoId = orcamento.Id;

                    // Descontar do orçamento
                    orcamento.CustoGasto += custoTotal;
                    orcamento.AlteradoPorId = fechadoPorId;

                    db.SaveChanges();
                    MessageBox.Show($"Compra fechada com sucesso!\nCusto: €{custoTotal:F2}\nSaldo restante: €{orcamento.ValorMaximo - orcamento.CustoGasto:F2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar compra: " + ex.Message);
                return;
            }
        }

        // Calcular o custo total de uma compra
        private static decimal CalcularCustoTotal(int compraId, iShoppingContext db)
        {
            var itens = db.ItemCompra.Where(i => i.CompraId == compraId).ToList();
            decimal total = 0;

            foreach (var item in itens)
            {
                decimal quantidade = item.QuantidadeAdquirida ?? 0;
                decimal preco = item.PrecoUnitario ?? 0;
                total += quantidade * preco;
            }

            return total;
        }

        // Exportar compras fechadas para CSV
        public static void ExportarComprasParaCsv(string filePath)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    // Obter todas as compras fechadas
                    var comprasFechadas = db.Compras
                        .Where(c => c.FechadaPorId != null)
                        .ToList();

                    if (comprasFechadas.Count == 0)
                    {
                        MessageBox.Show("Não existem compras fechadas para exportar.");
                        return;
                    }

                    StringBuilder csvContent = new StringBuilder();

                    // Adicionar cabeçalho
                    csvContent.AppendLine("NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

                    // Iterar sobre cada compra fechada
                    foreach (var compra in comprasFechadas)
                    {
                        // Obter itens previstos
                        var itensPrevisto = db.ItensPrevisto
                            .Where(i => i.CompraId == compra.Id)
                            .Include(i => i.Artigo)
                            .ToList();

                        // Obter itens não previstos
                        var itensNaoPrevisto = db.ItensNaoPrevisto
                            .Where(i => i.CompraId == compra.Id)
                            .Include(i => i.Artigo)
                            .ToList();

                        // Se houver itens, adicionar linha para cada item
                        if (itensPrevisto.Count > 0 || itensNaoPrevisto.Count > 0)
                        {
                            // Adicionar itens previstos
                            foreach (var item in itensPrevisto)
                            {
                                string nomeArtigo = item.Artigo != null ? item.Artigo.NomeArtigo : "";
                                csvContent.AppendLine(
                                    $"{compra.NomeCompra};" +
                                    $"{compra.DataCriacao:dd/MM/yyyy};" +
                                    $"{(compra.DataFechada.HasValue ? compra.DataFechada.Value.ToString("dd/MM/yyyy") : "")};" +
                                    $"{nomeArtigo};" +
                                    $"Sim;" +
                                    $"Não;" +
                                    $"{item.QuantidadePrevista.ToString("F2").Replace(',', '.')};" +
                                    $"{(item.QuantidadeAdquirida.HasValue ? item.QuantidadeAdquirida.Value.ToString("F2").Replace(',', '.') : "")};" +
                                    $"{(item.PrecoUnitario.HasValue ? item.PrecoUnitario.Value.ToString("F2").Replace(',', '.') : "")}"
                                );
                            }

                            // Adicionar itens não previstos
                            foreach (var item in itensNaoPrevisto)
                            {
                                string nomeArtigo = item.Artigo != null ? item.Artigo.NomeArtigo : "";
                                csvContent.AppendLine(
                                    $"{compra.NomeCompra};" +
                                    $"{compra.DataCriacao:dd/MM/yyyy};" +
                                    $"{(compra.DataFechada.HasValue ? compra.DataFechada.Value.ToString("dd/MM/yyyy") : "")};" +
                                    $"{nomeArtigo};" +
                                    $"Não;" +
                                    $"Sim;" +
                                    $"0;" +
                                    $"{(item.QuantidadeAdquirida.HasValue ? item.QuantidadeAdquirida.Value.ToString("F2").Replace(',', '.') : "")};" +
                                    $"{(item.PrecoUnitario.HasValue ? item.PrecoUnitario.Value.ToString("F2").Replace(',', '.') : "")}"
                                );
                            }
                        }
                    }

                    // Escrever arquivo
                    System.IO.File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
                    MessageBox.Show($"Compras exportadas com sucesso para: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar compras: " + ex.Message);
            }
        }

    }
}


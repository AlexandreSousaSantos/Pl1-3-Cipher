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
        // Lista todas as compras ordenadas por data de criação
        public static List<Compra> ListarTodas()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.Include("CriadoPor")
                    .OrderByDescending(c => c.DataCriacao)
                    .ToList();
            }
        }

        // Criar nova compra
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

        // Atualizar nome da compra
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

        // Eliminar compra (remove itens antes de remover compra)
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

        // Obter compra por ID com dados do utilizador
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

        // Fechar compra com validação de orçamento e deduções
        public static void FecharCompra(int compraId, int fechadoPorId)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    // Validar existência da compra e estado atual se está aberta para permitir fechamento.
                    Compra compra = db.Compras.Find(compraId);
                    if (compra == null)
                    {
                        MessageBox.Show("Compra não encontrada.");
                        return;
                    }
                    //Conclui o fechamento.
                    if (compra.Estado == "Fechada")
                    {
                        MessageBox.Show("Esta compra já foi fechada.");
                        return;
                    }

                    // Observação: o custo é calculado somando (QuantidadeAdquirida * PrecoUnitario) para todos os itens
                    // (ver método CalcularCustoTotal). Este valor será usado para validar e debitar do orçamento.
                    // Calcular custo total da compra
                    decimal custoTotal = CalcularCustoTotal(compraId, db);
                    compra.CustoTotal = custoTotal;

                    // Obter orçamento do mês atual
                    string mesAtual = DateTime.Now.ToString("MM/yyyy");
                    Orcamento orcamento = db.Orcamento.FirstOrDefault(o => o.Mes == mesAtual);
                    // A pesquisa do orçamento usa o formato "MM/yyyy" (mês/ano) para localizar o orçamento corrente.

                    if (orcamento == null)
                    {
                        MessageBox.Show("Orçamento não encontrado para o mês atual.");
                        return;
                    }

                    // Validar se há orçamento disponível
                    // Saldo disponível = Valor máximo definido para o mês menos o custo já gasto até o momento.
                    decimal saldoDisponivel = orcamento.ValorMaximo - orcamento.CustoGasto;
                    if (custoTotal > saldoDisponivel)
                    {
                        MessageBox.Show($"Orçamento insuficiente.\nCusto da compra: €{custoTotal:F2}\nSaldo disponível: €{saldoDisponivel:F2}");
                        return;
                    }

                    // Atualizar dados da compra
                    compra.Estado = "Fechada";
                    compra.DataFechada = DateTime.Now;
                    compra.FechadaPorId = fechadoPorId.ToString();
                    compra.AlteradoPorId = fechadoPorId;
                    compra.OrcamentoId = orcamento.Id;

                    // Descontar custo do orçamento
                    // Ao fechar a compra atualiza-se o total gasto do orçamento e registra-se quem fez a alteração.
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

        // Calcula custo total multiplicando quantidade x preço de todos os itens
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

        // Exportar compras fechadas para arquivo CSV com todos os itens
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

                    // Adicionar linha de cabeçalho
                    csvContent.AppendLine("NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

                    // Percorrer cada compra fechada
                    foreach (var compra in comprasFechadas)
                    {
                        // Buscar itens previstos da compra
                        var itensPrevisto = db.ItensPrevisto
                            .Where(i => i.CompraId == compra.Id)
                            .Include(i => i.Artigo)
                            .ToList();

                        // Buscar itens não previstos da compra
                        var itensNaoPrevisto = db.ItensNaoPrevisto
                            .Where(i => i.CompraId == compra.Id)
                            .Include(i => i.Artigo)
                            .ToList();

                        // Adicionar linhas se houver itens
                        if (itensPrevisto.Count > 0 || itensNaoPrevisto.Count > 0)
                        {
                            // Adicionar linhas para itens previstos
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

                            // Adicionar linhas para itens não previstos
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

                    // Guardar arquivo no caminho especificado
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

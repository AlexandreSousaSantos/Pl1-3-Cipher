using Projeto_iShopping.Models;
using System;
using System.Linq;

namespace Projeto_iShopping.Controller
{
    // Controlador para gerir estatísticas e relatórios
    public class EstatisticasController
    {
        private iShoppingContext db = new iShoppingContext();

        // Calcula semana do mês
        private int ObterSemanaDoMes(DateTime data)
        {
            return ((data.Day - 1) / 7) + 1;
        }

        // Mostra resumo mensal com orçamentos
        public object MostrarResumoMensal()
        {
            var compras = db.Compras.ToList();
            var orcamentos = db.Orcamento.ToList();

            var resultado =
                from c in compras
                group c by new
                {
                    Mes = c.DataCriacao.Month,
                    Ano = c.DataCriacao.Year
                }
                into g
                select new
                {
                    Mes = g.Key.Mes,
                    Ano = g.Key.Ano,

                    Orcamento = orcamentos
                    .Where(o => o.Mes == g.Key.Mes.ToString())
                    .Sum(o => (decimal?)o.ValorMaximo) ?? 0,

                    TotalCompras = g.Count(),

                    Diferenca =
                    (orcamentos
                    .Where(o => o.Mes == g.Key.Mes.ToString())
                    .Sum(o => (decimal?)o.ValorMaximo) ?? 0) -
                    g.Count()
                };
            return resultado.ToList();
        }

        // Mostra compras fechadas com percentagem de itens previstos vs não previstos
        public object MostrarComprasFechadas()
        {
            var compras = db.Compras
                .Where(c => c.DataFechada != null)
                .ToList();

            var itens = db.ItemCompra.ToList();

            var resultado = from c in compras
                            select new
                            {
                                Compra = c.NomeCompra,
                                Mes = c.DataCriacao.Month,

                                TotalItems = itens.Count(
                                    i => i.CompraId == c.Id),
                                Previstos = itens.Count(
                                    i => i.CompraId == c.Id
                                    && i.QuantidadePrevista > 0),
                                NaoPrevistos = itens.Count(
                                    i => i.CompraId == c.Id
                                    && i.QuantidadePrevista == 0),

                                PercentagemPrevistos = itens.Count(
                                    i => i.CompraId == c.Id) == 0
                                    ? 0
                                    : (double)itens.Count(i => i.CompraId == c.Id
                                    && i.QuantidadePrevista > 0) /
                                    itens.Count(i => i.CompraId == c.Id) * 100
                            };
            return resultado.ToList();
        }

        // Mostra sugestão de orçamento baseada na média e último valor
        public object MostrarSugestaoOrcamento()
        {
            var orcamentos = db.Orcamento.ToList();

            var media = orcamentos.Any() ?
                orcamentos.Average(o => o.ValorMaximo)
                : 0;

            var ultimo = orcamentos.LastOrDefault()?.ValorMaximo ?? 0;

            return new[]
            {
                new
                {
                    MediaHistorica = media,
                    UltimoOrcamento = ultimo,
                    SugestaoProximoMes = (media + ultimo) / 2
                }
            };
        }

        // Mostra sugestão de compras baseada no histórico por semana
        public object MostrarSugestaoCompras()
        {
            var compras = db.Compras.ToList();

            var dados =
                compras.Select(c => new
                {
                    Semana = ObterSemanaDoMes(c.DataCriacao),
                    Mes = c.DataCriacao.Month,
                    Ano = c.DataCriacao.Year
                });

            var resultado =
                dados
                .GroupBy(x => new { x.Semana, x.Mes })
                .Select(g => new
                {
                    SemanaDoMes = g.Key.Semana,
                    Mes = g.Key.Mes,

                    TotalCompras = g.Count(),

                    Sugestao =
                        Math.Round(g.Count() / (double)db.Compras.Count(), 2)
                });

            return resultado.ToList();
        }
    }
}

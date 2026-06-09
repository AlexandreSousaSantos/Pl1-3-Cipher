using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_iShopping.Controller
{
    // Controlador para gerir operações de orçamento
    public class OrcamentoController
    {
        // Obter orçamento por mês específico
        public static Orcamento ObterporMes(string mes)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamento
                    .Include("CriadoPor")
                    .Include("AlteradoPor")
                    .FirstOrDefault(o => o.Mes == mes);
            }
        }

        // Obter orçamento do mês atual
        public static Orcamento ObterMesAtual()
        {
            string mes = DateTime.Today.ToString("MM/yyyy");
            return ObterporMes(mes);
        }

        // Lista todos os orçamentos
        public static List<Orcamento> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamento.Include("CriadoPor").Include("AlteradoPor").ToList();
            }
        }

        // Criar ou atualizar orçamento para um mês específico
        public static void CriarOuAtualizar(string mes, decimal valorMaximo, int Id_utilizador)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                var orcamento = db.Orcamento.FirstOrDefault(o => o.Mes == mes);
                if (orcamento == null)
                {
                    orcamento = new Orcamento
                    {
                        Mes = mes,
                        ValorMaximo = valorMaximo,
                        CriadoPorId = Id_utilizador,
                        AlteradoPorId = Id_utilizador
                    };
                    db.Orcamento.Add(orcamento);
                }
                else
                {
                    orcamento.ValorMaximo = valorMaximo;
                    orcamento.AlteradoPorId = Id_utilizador;
                }
                db.SaveChanges();
            }
        }

        // Eliminar orçamento por mês
        public static void Eliminar(string mes)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                Orcamento orcamento = db.Orcamento.FirstOrDefault(o => o.Mes == mes);
                if (orcamento != null)
                {
                    db.Orcamento.Remove(orcamento);
                    db.SaveChanges();
                }
            }
        }

        // Lista orçamentos ordenados por valor máximo
        public static List<Orcamento> ListarOrcamentos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamento
                   .Include("CriadoPor")
                   .Include("AlteradoPor")
                   .OrderBy(v => v.ValorMaximo)
                   .ToList();
            }
        }
    }
}

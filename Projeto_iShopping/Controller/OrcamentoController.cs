using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Projeto_iShopping.Controller
{
    public class OrcamentoController
    {
        public static Orcamento ObterporMes(string mes)
        {
            // Verificar se o orçamento para o mês já existe
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamento
                    .Include("CriadoPorId")
                    .Include("AlteradoPorId")
                    .FirstOrDefault(o => o.Mes == mes);
            }
        }
        // Obter o orçamento do mês selecionado com base na db
        public static Orcamento ObterMesAtual()
        {
            string mes = DateTime.Today.ToString("MM/yyyy");
            return ObterporMes(mes);

        }

        public static List<Orcamento> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamento.Include("CriadoPorId").Include("AlteradoPorId").ToList();
            }
        }

        //Criar ou atualizar o orçamento para um mês específico
        public static void CriarOuAtualizar(string mes, decimal valorMaximo, int Id_utilizador)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                var orcamento = db.Orcamento.FirstOrDefault(o => o.Mes == mes);
                if (orcamento == null)
                {
                    // Criar novo orçamento
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
                    // Atualizar orçamento existente
                    orcamento.ValorMaximo = valorMaximo;
                    orcamento.AlteradoPorId = Id_utilizador;
                }
                db.SaveChanges();
            }
        }
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
        public static  List<Orcamento> ListarOrcamentos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamento
                   .OrderBy(v => v.ValorMaximo)
                   .ToList();
              
            }
        }
    }
}

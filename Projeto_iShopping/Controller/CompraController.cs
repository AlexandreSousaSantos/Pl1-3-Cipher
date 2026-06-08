using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}


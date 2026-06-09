using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Projeto_iShopping.Controller
{
    public class ItemCompraController
    {
        //Listar todos os itens de compra
        public static List<ItemCompra> ListarItensCompra()
        {
            using (var context = new iShoppingContext())
            {
                return context.ItemCompra.ToList();
            }
        }
    
    //Adicionar um novo item de compra previsto
    public static void AdicionarItemCompra(ItemCompra itemPrevisto)
        {
            using (var context = new iShoppingContext())
            {
                context.ItemCompra.Add(itemPrevisto);
                context.SaveChanges();
            }
        }
        //Adicionar um novo item de compra não previsto
        public static void AdicionarItemCompraNaoPrevisto(ItemNaoPrevisto itemNaoPrevisto)
        {
            using (var context = new iShoppingContext())
            {
                itemNaoPrevisto.DataCriacao = DateTime.Now;
                context.ItensNaoPrevisto.Add(itemNaoPrevisto);
                context.SaveChanges();
            }
        }
        //Listar itens previstos
        public static List<ItemPrevisto> ListarPrevistosDeCompra(int compraId)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.ItensPrevisto
                    .Include("Artigo")
                    .Where(i => i.CompraId == compraId)
                    .ToList();
            }
        }
        public static List<ItemNaoPrevisto> ListarNaoPrevistosDeCompra(int compraId)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.ItensNaoPrevisto
                    .Include("Artigo")
                    .Where(i => i.CompraId == compraId)
                    .ToList();
            }
        }

        public static void MarcarComoAdquirido(int itemId, decimal qtAdquirida, decimal precoUnitario)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                ItemPrevisto item = db.ItensPrevisto.Find(itemId);
                if (item == null)
                {
                    throw new Exception("Item não encontrado.");
                }

                item.Adquirido = true;
                item.QuantidadeAdquirida = qtAdquirida;
                item.PrecoUnitario = precoUnitario;
                item.DataAlteracao = DateTime.Now;
                db.SaveChanges();
            }
        }

    }
}

using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void AdicionarItemCompraNaoPrevisto(ItemCompra itemNaoPrevisto)
        {
            using (var context = new iShoppingContext())
            {
                context.ItemCompra.Add(itemNaoPrevisto);
                context.SaveChanges();
            }
        }
        //Não percebi!
    }
}

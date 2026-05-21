using Projeto_iShopping.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    // Item planeado antes de ir às compras
    [Table("ItensPrevisto")]
    public class ItemPrevisto : ItemCompra
    {

       public float quantidadeAdquirida { get; set; }
    }
}
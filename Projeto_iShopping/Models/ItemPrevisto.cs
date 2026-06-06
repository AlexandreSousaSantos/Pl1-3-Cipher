using Projeto_iShopping.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    // Item planeado antes de ir às compras
    [Table("ItensPrevisto")]
    public class ItemPrevisto : ItemCompra
    {

        public bool Adquirido { get; set; }
        public float quantidadeAdquirida { get; set; }
    }
}
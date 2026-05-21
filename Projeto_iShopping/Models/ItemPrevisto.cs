using Projeto_iShopping.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    // Item planeado antes de ir às compras
    [Table("ItensPrevisto")]
    public class ItemPrevisto : ItemCompra
    {

        public bool Adquirido { get; set; }

        public int? AlteradoPorId { get; set; }

        [ForeignKey("AlteradoPorId")]
        public virtual Utilizador AlteradoPor { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
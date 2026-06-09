
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    // Item planeado antes de ir às compras (herda de ItemCompra)
    [Table("ItensPrevisto")]
    public class ItemPrevisto : ItemCompra
    {
        public bool Adquirido { get; set; }
        public float quantidadeAdquirida { get; set; }
    }
}

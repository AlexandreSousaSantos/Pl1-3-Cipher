
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    // Item planeado antes de ir às compras (herda de ItemCompra)
    [Table("ItensPrevisto")]
    public class ItemPrevisto : ItemCompra
    {
        public bool Adquirido { get; set; }
        // Nota: existe já QuantidadeAdquirida no base class (decimal?).
        // Este campo "quantidadeAdquirida" (float) parece redundante e pode causar confusão.
        // Preferir utilizar QuantidadeAdquirida (decimal?) da classe base para evitar problemas de precisão.
        public float quantidadeAdquirida { get; set; }
    }
}

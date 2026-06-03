

using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public string Mes { get; set; }

        public decimal ValorMaximo { get; set; }
        public int CriadoPorId { get; set; }

        [ForeignKey("CriadoPorId")]
        public virtual Utilizador CriadoPor { get; set; }

        public int AlteradoPorId { get; set; }

        [ForeignKey("AlteradoPorId")]
        public virtual Utilizador AlteradoPor { get; set; }
    }
}

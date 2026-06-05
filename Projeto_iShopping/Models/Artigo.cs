

using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    public  class Artigo
    {
        public int Id { get; set; }
        public string NomeArtigo { get; set; }
        public int? TipoArtigoId { get; set; }

        [ForeignKey("TipoArtigoId")]
        public virtual TipoArtigo TipoArtigo { get; set; }
    }
}

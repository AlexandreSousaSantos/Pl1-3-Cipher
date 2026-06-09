using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    // Modelo para artigo
    // Representa um produto/entrada que pode pertencer a um TipoArtigo.
    // Nota: mantém uma ForeignKey para TipoArtigo e expõe a navegação virtual.
    public class Artigo
    {
        public int Id { get; set; }
        public string NomeArtigo { get; set; }
        public int? TipoArtigoId { get; set; }

        [ForeignKey("TipoArtigoId")]
        public virtual TipoArtigo TipoArtigo { get; set; }

        public static explicit operator Artigo(int v)
        {
            // Este operador explícito não está implementado e não é usado atualmente.
            // Mantido apenas para compatibilidade com código anterior que tentou converter por Id.
            throw new NotImplementedException();
        }
    }
}


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    [Table("ItensCompra")]
    public abstract class ItemCompra
    {
        public int Id { get; set; }

        public int CompraId { get; set; }

        [ForeignKey("CompraId")]
        public virtual Compra Compra { get; set; }

        public decimal? QuantidadeAdquirida { get; set; }

        [Required]
        public decimal QuantidadePrevista { get; set; }
        public int ArtigoId { get; set; }

        [ForeignKey("ArtigoId")]
        public virtual Artigo Artigo { get; set; }

        public decimal? PrecoUnitario { get; set; }

        public DateTime DataCriacao { get; set; }

        public int CriadoPorId { get; set; }

        [ForeignKey("CriadoPorId")]
        public Utilizador CriadoPor { get; set; }
        public string Observacoes { get; set; }

        public decimal QuantidadeNPrevista
        {
            get
            {
                decimal i = (this.QuantidadeAdquirida ?? 0) - this.QuantidadePrevista;
                if (i > 0)
                {
                    return i;
                }
                return 0;
            }
            set { }
        }

        public bool Previsto
        {
            get { return QuantidadeNPrevista > 0; }
            set { }
        }
    }
}

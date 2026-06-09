
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    // Modelo base para itens de compra (herança com tipos ItemPrevisto e ItemNaoPrevisto)
    [Table("ItensCompra")]
    public class ItemCompra
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

        public int? CriadoPorId { get; set; }

        [ForeignKey("CriadoPorId")]
        public Utilizador CriadoPor { get; set; }

        public string Observacoes { get; set; }

        public DateTime? DataAlteracao { get; set; }

        // Calcula quantidade adquirida além do previsto
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

        // Verifica se item foi não previsto
        // Previsto indica se foi comprado acima da quantidade prevista
        // (calc. como verdadeiro quando QuantidadeNPrevista > 0)
        public bool Previsto
        {
            get { return QuantidadeNPrevista > 0; }
            set { }
        }
    }
}

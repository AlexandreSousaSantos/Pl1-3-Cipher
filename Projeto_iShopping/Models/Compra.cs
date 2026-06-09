using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_iShopping.Models
{
    // Modelo para compra
    public class Compra
    {
        public int Id { get; set; }
        public string NomeCompra { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? CriadoPorId { get; set; }

        [ForeignKey("CriadoPorId")]
        public virtual Utilizador CriadoPor { get; set; }

        public string Estado { get; set; }
        public DateTime? DataFechada { get; set; }
        // FechadaPorId guarda o identificador do utilizador que fechou a compra.
        // Observação: é string (não int) provavelmente por erro; idealmente deveria ser int? para FK.
        public string FechadaPorId { get; set; }
        public int? AlteradoPorId { get; set; }

       [ForeignKey("AlteradoPorId")]
        public virtual Utilizador AlteradoPor { get; set; }

        public int? OrcamentoId { get; set; }

        [ForeignKey("OrcamentoId")]
        public virtual Orcamento Orcamento { get; set; }

        public decimal? CustoTotal { get; set; }
    }
}

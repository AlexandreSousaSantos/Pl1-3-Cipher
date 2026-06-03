using System;


namespace Projeto_iShopping.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public string NomeCompra { get; set; }
        public DateTime DataCriacao { get; set; }
        public int CriadoPorId { get; set; }
        public string Estado { get; set; }
        public DateTime DataFechada { get; set; }
        public string FechadaPorId { get; set; }
        public int AlteradoPorId { get; set; }

    }
}

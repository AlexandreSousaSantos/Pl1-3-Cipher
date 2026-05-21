

namespace Projeto_iShopping.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public string Mes { get; set; }

        public decimal ValorMaximo { get; set; }
        public int CriadoPorId { get; set; }

        public int AlteradoPorId { get; set; }
    }
}

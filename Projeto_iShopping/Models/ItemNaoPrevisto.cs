namespace Projeto_iShopping.Models
{
    // Item não planeado adicionado durante as compras (herda de ItemCompra)
    public class ItemNaoPrevisto : ItemCompra
    {
        public new string Observacoes { get; set; }
    }
}

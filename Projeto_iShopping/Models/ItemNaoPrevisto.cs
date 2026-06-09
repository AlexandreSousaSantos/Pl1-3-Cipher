namespace Projeto_iShopping.Models
{
    // Item não planeado adicionado durante as compras (herda de ItemCompra)
    public class ItemNaoPrevisto : ItemCompra
    {
        // Observacoes específicas para itens não previstos.
        // 'new' esconde a propriedade Observacoes da base; isso foi feito possivelmente para
        // permitir comportamento diferente para itens não previstos.
        public new string Observacoes { get; set; }
    }
}

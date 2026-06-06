using System.Data.Entity;

namespace Projeto_iShopping.Models
{
    public class iShoppingContext : DbContext
    {
        public iShoppingContext()   { }
            public DbSet<Utilizador> Utilizadores { get; set; }
            public DbSet<Orcamento> Orcamento { get; set; }
            public DbSet<TipoArtigo> TipoArtigo { get; set; }
            public DbSet<Artigo> Artigos { get; set; }
            public DbSet<ItemCompra> ItemCompra { get; set; }
            public DbSet<Compra> Compras { get; set; }


        public DbSet <ItemPrevisto> ItensPrevisto { get; set; }
        public DbSet <ItemNaoPrevisto> ItensNaoPrevisto { get; set; }
    }

    
}


using System.Data.Entity;

namespace Projeto_iShopping.Models
{
    public class iShoppingContext : DbContext
    {
        public iShoppingContext() : base("name=iShoppingContext") { }
            public DbSet<Utilizador> Utilizadores { get; set; }
            public DbSet<Orcamento> Orcamento { get; set; }
            public DbSet<TipoArtigo> TipoArtigo { get; set; }
            public DbSet<Artigo> Artigos { get; set; }
            public DbSet<ItemCompra> ItemCompra { get; set; }
            public DbSet<Compra> Compras { get; set; }
    }
}

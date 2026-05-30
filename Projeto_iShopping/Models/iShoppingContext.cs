
using System.Data.Entity;

namespace Projeto_iShopping.Models
{
    public class iShoppingContext : DbContext
    {
        public iShoppingContext() { }

        public DbSet<Utilizador> Utilizadores { get; set; }

        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<TipoArtigo> TipoArtigo { get; set; }

    }
}

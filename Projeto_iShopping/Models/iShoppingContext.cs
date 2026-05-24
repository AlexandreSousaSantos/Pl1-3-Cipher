
using System.Data.Entity;

namespace Projeto_iShopping.Models
{
    public class iShoppingContext : DbContext
    {
        public iShoppingContext() { }

        public DbSet<Utilizador> Utilizadores { get; set; }

    }
}

using System.Data.Entity;
using System.Linq;

namespace Projeto_iShopping.Models
{
    // Inicializador de base de dados com seed de dados padrão
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<iShoppingContext>
    {
        // Popula a base de dados com dados iniciais
        protected override void Seed(iShoppingContext context)
        {
            base.Seed(context);
            if (!context.Utilizadores.Any(u => u.Username == "admin"))
            {
                Utilizador admin = new Utilizador { Username = "admin", Password = "admin123" };
                context.Utilizadores.Add(admin);
                context.SaveChanges();
            }
        }
    }
}

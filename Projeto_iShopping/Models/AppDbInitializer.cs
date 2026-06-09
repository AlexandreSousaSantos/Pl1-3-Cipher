using System.Data.Entity;
using System.Linq;

namespace Projeto_iShopping.Models
{
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<iShoppingContext>
    {
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

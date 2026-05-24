using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_iShopping.Models
{
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<iShoppingContext>
    {

        protected override void Seed(iShoppingContext context)
        {
            Utilizador admin = new Utilizador { Username = "admin", Password = "admin123" };
            context.Utilizadores.Add(admin);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}

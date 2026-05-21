
using System.Data.Entity;

namespace Projeto_iShopping.Models
{
    public class iShoppingContext : DbContext
    {
        public iShoppingContext() : base("name=iShoppingContext") { }

    }
}

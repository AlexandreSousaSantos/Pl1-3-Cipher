using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_iShopping.Controller
{
    public class UtilizadorController
    {
        public static bool Autenticar(string login, string password, out string mensagem)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                Utilizador utilizador = db.Utilizadores.FirstOrDefault(
                    u => u.Username == login && u.Password == password);
                if (utilizador == null)
                {
                    mensagem = "Login ou password incorretos.";
                    return false;
                }
                Sessao.InicializarUtilizador(utilizador);
                mensagem = "Autenticação efetuada com sucesso.";
                return true;
            }

        }
    }
}

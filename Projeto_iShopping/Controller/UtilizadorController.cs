using Projeto_iShopping.Models;
using System.Linq;

namespace Projeto_iShopping.Controller
{
    // Controlador para gerir autenticação e utilizadores
    public class UtilizadorController
    {
        // Autentica utilizador com login e password
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

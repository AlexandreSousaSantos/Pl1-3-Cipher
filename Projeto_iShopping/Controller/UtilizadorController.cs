using Projeto_iShopping.Models;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

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

        // Lista todos os utilizadores
        public static List<Utilizador> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Utilizadores.ToList();
            }
        }

        // Obter utilizador por ID
        public static Utilizador ObterPorId(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Utilizadores.Find(id);
            }
        }

        // Criar novo utilizador (username único)
        public static bool Criar(string username, string password, out string mensagem)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                mensagem = "O username é obrigatório.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                mensagem = "A password é obrigatória.";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                if (db.Utilizadores.Any(u => u.Username == username.Trim()))
                {
                    mensagem = "Já existe um utilizador com este username.";
                    return false;
                }

                Utilizador novo = new Utilizador
                {
                    Username = username.Trim(),
                    Password = password
                };
                db.Utilizadores.Add(novo);
                db.SaveChanges();
                mensagem = "Utilizador criado com sucesso.";
                return true;
            }
        }

        // Atualizar dados de utilizador existente
        public static bool Atualizar(int id, string novoUsername, string novaPassword, out string mensagem)
        {
            if (string.IsNullOrWhiteSpace(novoUsername))
            {
                mensagem = "O username é obrigatório.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(novaPassword))
            {
                mensagem = "A password é obrigatória.";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                var utilizador = db.Utilizadores.Find(id);
                if (utilizador == null)
                {
                    mensagem = "Utilizador não encontrado.";
                    return false;
                }

                // Verificar unicidade do username (excluindo o próprio)
                if (db.Utilizadores.Any(u => u.Username == novoUsername.Trim() && u.Id != id))
                {
                    mensagem = "Já existe um utilizador com este username.";
                    return false;
                }

                utilizador.Username = novoUsername.Trim();
                utilizador.Password = novaPassword;
                db.SaveChanges();
                mensagem = "Utilizador atualizado com sucesso.";
                return true;
            }
        }

        // Eliminar utilizador pelo ID
        public static bool Eliminar(int id, out string mensagem)
        {
            // Não permitir eliminar o utilizador da sessão atual
            if (Sessao.UtilizadorAtual != null && Sessao.UtilizadorAtual.Id == id)
            {
                mensagem = "Não é possível eliminar o utilizador com sessão ativa.";
                return false;
            }

            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    var utilizador = db.Utilizadores.Find(id);
                    if (utilizador == null)
                    {
                        mensagem = "Utilizador não encontrado.";
                        return false;
                    }
                    db.Utilizadores.Remove(utilizador);
                    db.SaveChanges();
                    mensagem = "Utilizador eliminado com sucesso.";
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                mensagem = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return false;
            }
        }
    }
}

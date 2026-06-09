
namespace Projeto_iShopping.Models
{
    // Classe para gerir sessão do utilizador autenticado
    public class Sessao
    {
        public static Utilizador UtilizadorAtual { get; set; }

        // Inicializa a sessão com o utilizador autenticado
        public static void InicializarUtilizador(Utilizador utilizador)
        {
            UtilizadorAtual = utilizador;
        }
    }
}

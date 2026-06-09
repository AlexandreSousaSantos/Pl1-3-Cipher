
namespace Projeto_iShopping.Models
{
    public class Sessao
    {
        public static Utilizador UtilizadorAtual { get; set; }
        public static void InicializarUtilizador(Utilizador utilizador)
        {
            UtilizadorAtual = utilizador;
        }
    }
}


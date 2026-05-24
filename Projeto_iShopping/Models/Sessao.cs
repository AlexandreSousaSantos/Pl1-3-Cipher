using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


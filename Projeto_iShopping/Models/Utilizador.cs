
using System;

namespace Projeto_iShopping.Models
{
    // Modelo para utilizador do sistema
    public class Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static implicit operator Utilizador(int v)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Username;
        }
    }
}

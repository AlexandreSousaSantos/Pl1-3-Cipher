using Projeto_iShopping.Models;
using Projeto_iShopping.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using iShopping.Models;

namespace Projeto_iShopping
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializar a base de dados
            try
            {
                Database.SetInitializer(new AppDbInitializer());
                using (iShoppingContext db = new iShoppingContext())
                {
                    db.Database.Initialize(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inicializar a base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            using (FormLogin login = new FormLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormPrincipal());
                }
            }

        }
    }
}

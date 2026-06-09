using System;
using System.Windows.Forms;
using Projeto_iShopping.Controller;

namespace Projeto_iShopping.Views
{
    // Formulário de autenticação do utilizador
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Autentica o utilizador com as credenciais introduzidas
        private void btentrar_Click(object sender, EventArgs e)
        {
            string login = TButilizador.Text.Trim();
            string password = TBpassword.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Deve introduzir o login e a password.");
            }
            else
            {
                string mensagem;
                bool ok = UtilizadorController.Autenticar(login,
                    password, out mensagem);

                if (ok)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensagem);
                    TBpassword.Clear();
                    TButilizador.Focus();
                }
            }
        }
    }
}

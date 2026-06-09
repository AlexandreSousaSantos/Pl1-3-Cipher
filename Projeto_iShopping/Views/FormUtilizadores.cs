using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    // Formulário para gerir utilizadores (CRUD)
    public partial class FormUtilizadores : Form
    {
        public FormUtilizadores()
        {
            InitializeComponent();
        }

        // Carrega utilizadores ao abrir o formulário
        private void FormUtilizadores_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        // Carrega lista de utilizadores na grid
        private void Carregar()
        {
            try
            {
                List<Utilizador> utilizadores = UtilizadorController.ListarTodos();
                dgvUtilizadores.DataSource = utilizadores;
                dgvUtilizadores.ClearSelection();
                dgvUtilizadores.CurrentCell = null;
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os utilizadores: " + ex.Message);
            }
        }

        // Limpa os campos do formulário
        private void LimparCampos()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbPasswordConfirm.Clear();
        }

        // Botão Novo — limpa seleção e campos para criar novo utilizador
        private void btnNovo_Click(object sender, EventArgs e)
        {
            dgvUtilizadores.ClearSelection();
            dgvUtilizadores.CurrentCell = null;
            LimparCampos();
            tbUsername.Focus();
        }

        // Preenche campos ao selecionar linha na grid
        private void dgvUtilizadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUtilizadores.CurrentRow != null)
            {
                Utilizador u = (Utilizador)dgvUtilizadores.CurrentRow.DataBoundItem;
                if (u != null)
                {
                    tbUsername.Text = u.Username;
                    tbPassword.Text = u.Password;
                    tbPasswordConfirm.Text = u.Password;
                }
            }
        }

        // Guardar (criar ou atualizar utilizador)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar passwords iguais
                if (tbPassword.Text != tbPasswordConfirm.Text)
                {
                    MessageBox.Show("As passwords não coincidem.", "Erro de validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensagem;
                bool sucesso;

                if (dgvUtilizadores.CurrentRow != null && dgvUtilizadores.CurrentRow.DataBoundItem != null)
                {
                    // Atualizar utilizador existente
                    Utilizador u = (Utilizador)dgvUtilizadores.CurrentRow.DataBoundItem;
                    sucesso = UtilizadorController.Atualizar(u.Id, tbUsername.Text, tbPassword.Text, out mensagem);
                }
                else
                {
                    // Criar novo utilizador
                    sucesso = UtilizadorController.Criar(tbUsername.Text, tbPassword.Text, out mensagem);
                }

                MessageBox.Show(mensagem, sucesso ? "Sucesso" : "Erro",
                    MessageBoxButtons.OK, sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (sucesso)
                    Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o utilizador: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar utilizador selecionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUtilizadores.SelectedRows.Count > 0 && dgvUtilizadores.CurrentRow?.DataBoundItem != null)
            {
                Utilizador u = (Utilizador)dgvUtilizadores.CurrentRow.DataBoundItem;

                DialogResult confirm = MessageBox.Show(
                    $"Tem a certeza que pretende eliminar o utilizador \"{u.Username}\"?",
                    "Confirmar eliminação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                string mensagem;
                bool sucesso = UtilizadorController.Eliminar(u.Id, out mensagem);

                MessageBox.Show(mensagem, sucesso ? "Sucesso" : "Erro",
                    MessageBoxButtons.OK, sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (sucesso)
                    Carregar();
            }
            else
            {
                MessageBox.Show("Tem que selecionar um utilizador.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

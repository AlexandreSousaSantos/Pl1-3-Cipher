using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    // Formulário para gerir tipos de artigo
    public partial class FormTiposArtigo : Form
    {
        public FormTiposArtigo()
        {
            InitializeComponent();
        }

        // Carrega tipos de artigo ao abrir o formulário
        private void FormTiposArtigo_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        // Carrega lista de tipos de artigo na grid
        private void Carregar()
        {
            try
            {
                List<TipoArtigo> tipos = TipoArtigoController.ListarTodos();
                dvgTipos.DataSource = tipos;
                dvgTipos.ClearSelection();
                dvgTipos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tipos de artigo: " + ex.Message);
            }
        }

        // Limpa campos para adicionar novo tipo de artigo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            dvgTipos.ClearSelection();
            dvgTipos.CurrentCell = null;
            tbDescricao.Clear();
            tbDescricao.Focus();
        }

        // Guardar novo ou atualizar tipo de artigo existente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se existe linha selecionada, atualizar
                if (dvgTipos.CurrentRow != null)
                {
                    int id = (int)dvgTipos.CurrentRow.Cells["Id"].Value;
                    TipoArtigoController.Atualizar(id, tbDescricao.Text);
                }
                else
                {
                    // Caso contrário, criar novo tipo
                    TipoArtigoController.Criar(tbDescricao.Text);
                }
                Carregar();
                tbDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o tipo de artigo: " + ex.Message);
            }
        }

        // Elimina tipo de artigo selecionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgTipos.SelectedRows.Count > 0)
            {
                // 1. Obter a linha selecionada
                DataGridViewRow linha = dvgTipos.SelectedRows[0];

                // 2. Obter o objeto Artigo associado à linha
                TipoArtigo tipoArtigoSelecionado = (TipoArtigo)linha.DataBoundItem;

                // 3. Eliminar pelo ID
                TipoArtigoController.Eliminar(tipoArtigoSelecionado.Id);

                // 4. Atualizar a grelha
                dvgTipos.DataSource = TipoArtigoController.ListarTodos();

                MessageBox.Show("Tipo de artigo eliminado com sucesso!");
            }
            else
            {
                MessageBox.Show("Tem que selecionar uma linha");
            }
        }
    }
}

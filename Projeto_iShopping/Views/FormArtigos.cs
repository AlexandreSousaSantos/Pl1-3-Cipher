using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{

    public partial class FormArtigos : Form
    {
        private DataGridView dgvArtigos;

        public FormArtigos()
        {
            InitializeComponent();
            dgvArtigos = new System.Windows.Forms.DataGridView();
        }

        private void FrmArtigos_Load(object sender, EventArgs e)
        {
            CarregarTipos();
            CarregarArtigos();
        }

        private void CarregarTipos()
        {
          cmbTipo.Items.Clear();

            // Carregar os tipos de artigo do banco de dados ou de uma lista
            List<TipoArtigo> tipos = TipoArtigoController.ListarTodos();
            foreach (TipoArtigo t in tipos)
                {
                // Adicionar cada tipo de artigo ao ComboBox   
                cmbTipo.Items.Add(t);
                }
        }

        private void CarregarArtigos()
        {
             
            try
            {
                List<Artigo> artigos = ArtigoController.ListarTodos();
                dgvArtigos.DataSource = artigos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os artigos: ");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // quando clicar no botão "Novo", abrirá um formulário para adicionar um novo artigo
            dgvArtigos.ClearSelection();
            tbNomeArtigo.Clear();
            //tem que ser -1 porque é o valor que representa "nenhum item selecionado" em um ComboBox
            cmbTipo.SelectedIndex = -1;




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter o ID do tipo de artigo selecionado
                int tipoId = (int)cmbTipo.SelectedValue;

                // Se existe uma linha selecionada → atualizar
                if (dgvArtigos.SelectedRows.Count > 0)
                {
                    int id = (int)dgvArtigos.SelectedRows[0].Cells["Id"].Value;

                    ArtigoController.Atualizar(
                        id,
                        tbNomeArtigo.Text,
                        tipoId 
                    );

                    MessageBox.Show("Artigo atualizado com sucesso!");
                }
                else
                {
                    // Caso contrário → criar novo artigo
                    ArtigoController.Criar(
                        tbNomeArtigo.Text,
                        tipoId
                    );

                    MessageBox.Show("Artigo criado com sucesso!");
                }

                // Atualizar a grelha depois de guardar
                dgvArtigos.DataSource = ArtigoController.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o artigo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArtigos.SelectedRows.Count > 0)
            {
                // 1. Obter a linha selecionada
                DataGridViewRow linha = dgvArtigos.SelectedRows[0];

                // 2. Obter o objeto Artigo associado à linha
                Artigo artigoSelecionado = (Artigo)linha.DataBoundItem;

                // 3. Eliminar pelo ID
                ArtigoController.Eliminar(artigoSelecionado.Id);

                // 4. Atualizar a grelha
                dgvArtigos.DataSource = ArtigoController.ListarTodos();

                MessageBox.Show("Artigo eliminado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro");
            }

        }
    }
}

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
            // quando clicar no botão "Guardar", os dados do artigo serão salvos
            string nomeArtigo = tbNomeArtigo.Text;
            if (nomeArtigo.Length == 0)
            {
                MessageBox.Show("O nome do artigo não pode estar vazio.");

            }
            else
            {
                // Aqui você pode adicionar o código para salvar o artigo no banco de dados ou em uma lista
                MessageBox.Show("Artigo salvo com sucesso!");
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

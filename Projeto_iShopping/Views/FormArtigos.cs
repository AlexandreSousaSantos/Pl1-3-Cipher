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
       

        public FormArtigos()
        {
            InitializeComponent();
            dvgArtigos = new System.Windows.Forms.DataGridView();
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
                cmbTipo.Items.Add(t.Descricao);
                }
          
        }

        private void CarregarArtigos()
        {
             
            try
            {
                List<Artigo> artigos = ArtigoController.ListarTodos();
                dvgArtigos.DataSource = artigos;
                MessageBox.Show(artigos.First().ToString());

            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao carregar os artigos: " + err.InnerException.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // quando clicar no botão "Novo", abrirá um formulário para adicionar um novo artigo
            dvgArtigos.ClearSelection();
            tbNomeArtigo.Clear();
            //tem que ser -1 porque é o valor que representa "nenhum item selecionado" em um ComboBox
            cmbTipo.SelectedIndex = -1;




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter o ID do tipo de artigo selecionado
                int tipoId = (int)cmbTipo.SelectedIndex + 1;
               

                // Se existe uma linha selecionada → atualizar
                if (dvgArtigos.SelectedRows.Count > 0)
                {
                    int id = (int)dvgArtigos.SelectedRows[0].Cells["Id"].Value;

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
                dvgArtigos.DataSource = ArtigoController.ListarTodos();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao guardar o artigo: ");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgArtigos.SelectedRows.Count > 0)
            {
                // 1. Obter a linha selecionada
                DataGridViewRow linha = dvgArtigos.SelectedRows[0];

                // 2. Obter o objeto Artigo associado à linha
                Artigo artigoSelecionado = (Artigo)linha.DataBoundItem;

                // 3. Eliminar pelo ID
                ArtigoController.Eliminar(artigoSelecionado.Id);

                // 4. Atualizar a grelha
                dvgArtigos.DataSource = ArtigoController.ListarTodos();

                MessageBox.Show("Artigo eliminado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro");
            }

        }
    }
}

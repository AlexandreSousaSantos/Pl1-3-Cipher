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
            //dvgArtigos = new System.Windows.Forms.DataGridView();
        }

        private void FrmArtigos_Load(object sender, EventArgs e)
        {
            CarregarTipos();
            CarregarArtigos();
        }

        private void CarregarTipos()
        {
			var tipos = TipoArtigoController.ListarTodos();

			cmbTipo.DataSource = tipos;
			cmbTipo.DisplayMember = "Descricao";
			cmbTipo.ValueMember = "Id";
		}

		private void CarregarArtigos()
		{
			try
			{
				var artigos = ArtigoController.ListarTodos() ?? new List<Artigo>();

				dvgArtigos.DataSource = artigos.Select(a => new
				{
					a.Id,
					a.NomeArtigo,
					Tipo = a.TipoArtigo.Descricao
				}).ToList();

				if (artigos.Count == 0)
				{
					MessageBox.Show("Não existem artigos.");
					return;
				}

				MessageBox.Show(artigos[0].NomeArtigo);
			}
			catch (Exception err)
			{
				MessageBox.Show("Erro ao carregar os artigos: " + err.Message);
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
				if (cmbTipo.SelectedValue == null)
				{
					MessageBox.Show("Selecione um tipo.");
					return;
				}

				// Obter o ID do tipo de artigo selecionado
				int tipoId = (int)cmbTipo.SelectedValue;
               

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
                
                MessageBox.Show("Erro ao guardar o artigo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgArtigos.SelectedRows.Count > 0)
            {
				var artigoSelecionado = (Artigo)dvgArtigos.SelectedRows[0].DataBoundItem;

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

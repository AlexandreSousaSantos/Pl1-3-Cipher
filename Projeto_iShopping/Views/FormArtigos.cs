using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    // Formulário para gerir artigos
    public partial class FormArtigos : Form
    {
        public FormArtigos()
        {
            InitializeComponent();
        }

        // Carrega tipos e artigos ao abrir o formulário
        private void FrmArtigos_Load(object sender, EventArgs e)
        {
            CarregarTipos();
            CarregarArtigos();
        }

        // Carrega lista de tipos no ComboBox
        private void CarregarTipos()
        {
            var tipos = TipoArtigoController.ListarTodos();

            cmbTipo.DataSource = tipos;
            cmbTipo.DisplayMember = "Descricao";
            cmbTipo.ValueMember = "Id";
        }

        // Carrega lista de artigos na grid
        private void CarregarArtigos()
        {
            try
            {
                var artigos = ArtigoController.ListarTodos() ?? new List<Artigo>();

                dvgArtigos.DataSource = artigos.Select(a => new
                {
                    a.Id,
                    a.NomeArtigo,
                    Tipo = a.TipoArtigo != null ? a.TipoArtigo.Descricao : ""
                }).ToList();

                if (artigos.Count == 0)
                {
                    MessageBox.Show("Não existem artigos.");
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao carregar os artigos: " + err.Message);
            }
        }

        // Limpa campos para adicionar novo artigo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            dvgArtigos.ClearSelection();
            tbNomeArtigo.Clear();
            cmbTipo.SelectedIndex = -1;
        }

        // Guardar novo ou atualizar artigo existente
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

                CarregarTipos();
                CarregarArtigos();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao guardar o artigo: " + ex.Message);
            }
            
        }

        // Elimina artigo selecionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgArtigos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dvgArtigos.SelectedRows[0].Cells["Id"].Value);
        

                // 3. Eliminar pelo ID
                ArtigoController.Eliminar(id);

                // 4. Atualizar a grelha
                CarregarArtigos();

                MessageBox.Show("Artigo eliminado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro");
            }

        }
    }
}

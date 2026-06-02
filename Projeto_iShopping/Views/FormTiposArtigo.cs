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
    public partial class FormTiposArtigo : Form
    {
        public FormTiposArtigo()
        {
            InitializeComponent();
        }

        private void FormTiposArtigo_Load(object sender, EventArgs e)
        {
            Carregar();
        }
        private void Carregar()
        {
            try
            {
                //a lista de tipos de artigo é obtida através do controlador e atribuída ao DataGridView
                List<TipoArtigo> tipos = TipoArtigoController.ListarTodos();
                dvgTipos.DataSource = tipos;
            }
            // caso aconteça algum erro durante a obtenção dos dados, uma mensagem de erro é exibida para o usuário
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tipos de artigo: " + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            dvgTipos.ClearSelection();
            tbDescricao.Clear();
            //o focus serve para colocar o cursor no campo de descrição, facilitando a inserção de um novo tipo de artigo
            tbDescricao.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgTipos.CurrentRow != null)
                {
                    //atualizar o tipo de artigo selecionado
                    int id = (int)dvgTipos.CurrentRow.Cells["Id"].Value; //obtém o ID do tipo de artigo selecionado na celula "Id"
                    TipoArtigoController.Atualizar(id, tbDescricao.Text);
                }
                else
                {
                    //criar um novo tipo de artigo
                    TipoArtigoController.Criar(tbDescricao.Text);
                }
                Carregar(); //recarrega a lista de tipos de artigo para refletir as alterações feitas
                tbDescricao.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar o tipo de artigo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgTipos.SelectedRows.Count > 0)
            {
                // 1. Obter a linha selecionada
                DataGridViewRow linha = dvgTipos.SelectedRows[0];

                // 2. Obter o objeto Artigo associado à linha
                Artigo artigoSelecionado = (Artigo)linha.DataBoundItem;

                // 3. Eliminar pelo ID
                ArtigoController.Eliminar(artigoSelecionado.Id);

                // 4. Atualizar a grelha
                dvgTipos.DataSource = ArtigoController.ListarTodos();

                MessageBox.Show("Tipo de artigo eliminado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}

using Projeto_iShopping.Models;
using Projeto_iShopping.Controller;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            carregarCompras();
        }

        // Carrega compras abertas na grid
        private void carregarCompras()
        {
            using (var db = new iShoppingContext())
            {
                var compras = db.Compras
                    .Where(c => c.FechadaPorId == null)
                    .ToList();

                // Limpa a fonte de dados antes de atribuir a nova lista
                dgvComprasAberto.DataSource = null;
                // Atribui a nova lista de compras abertas à grid
                dgvComprasAberto.DataSource = compras.
                     Select(c => new
                     {
                         c.Id,
                         c.NomeCompra,
                         c.DataCriacao,
                         Utilizador = c.CriadoPor.Username
                     })
                     .ToList();
            }
        }

        // Abre formulário de tipos de artigos
        private void BTtiposdeartigos_Click(object sender, EventArgs e)
        {
            FormTiposArtigo frm = new FormTiposArtigo();
            frm.ShowDialog();
        }

        // Abre formulário de artigos
        private void BTartigos_Click(object sender, EventArgs e)
        {
            FormArtigos frm = new FormArtigos();
            frm.ShowDialog();
        }

        // Abre formulário para editar compra
        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            FormEditarCompra frm = new FormEditarCompra();
            frm.ShowDialog();
        }

        // Abre planeamento de compras
        private void BTplaneamento_Click(object sender, EventArgs e)
        {
            FormPlaneamentoCompra frm = new FormPlaneamentoCompra();
            frm.ShowDialog();
            carregarCompras();
        }

        // Abre estatísticas
        private void BTestatisticas_Click(object sender, EventArgs e)
        {
            FormEstatisticas frm = new FormEstatisticas();
            frm.ShowDialog();
        }

        // Exporta compras fechadas para CSV
        private void BTexportarcsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Ficheiros CSV (.csv)|*.csv";
            sfd.Title = "Guardar ficheiro CSV";
            sfd.FileName = "Compras_Fechadas.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CompraController.ExportarComprasParaCsv(sfd.FileName);
            }
        }

        // Fecha a aplicação
        private void BTSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        // Abre modo de compra para a compra selecionada
        private void btModoCompra_Click(object sender, EventArgs e)
        {
            // Verifica se há linhas na grid
            if (dgvComprasAberto.Rows.Count == 0)
            {
                MessageBox.Show("Não existem compras em aberto!!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verifica se há uma linha selecionada
            if (dgvComprasAberto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona uma compra primeiro!!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tenta obter o ID
            if (!int.TryParse(dgvComprasAberto.SelectedRows[0].Cells["Id"].Value?.ToString(), out int id))
            {
                MessageBox.Show("Não foi possível obter a compra selecionada!!!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre o formulário
            FormModoCompra frm = new FormModoCompra(id);
            frm.ShowDialog();
        }

        // Abre formulário de orçamento
        private void BTorcamento_Click_1(object sender, EventArgs e)
        {
            FormOrcamento frm = new FormOrcamento();
            frm.ShowDialog();
        }

        // Abre formulário de gestão de utilizadores
        private void BTutilizadores_Click(object sender, EventArgs e)
        {
            FormUtilizadores frm = new FormUtilizadores();
            frm.ShowDialog();
        }
    }
}


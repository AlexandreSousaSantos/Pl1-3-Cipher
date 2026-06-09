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

        private void carregarCompras()
        {
            using (var db = new iShoppingContext())
            {
                var compras = db.Compras
                    .Where(c => c.FechadaPorId == null)
                    .ToList();  



                dgvComprasAberto.DataSource = null;

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

        private void BTtiposdeartigos_Click(object sender, EventArgs e)
        {
            FormTiposArtigo frm = new FormTiposArtigo();
            frm.ShowDialog();
        }

        private void BTartigos_Click(object sender, EventArgs e)
        {
            FormArtigos frm = new FormArtigos();
            frm.ShowDialog();
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            FormEditarCompra frm = new FormEditarCompra();
            frm.ShowDialog();
        }

        private void BTplaneamento_Click(object sender, EventArgs e)
        {
            FormPlaneamentoCompra frm = new FormPlaneamentoCompra();
            frm.ShowDialog();

            carregarCompras();
        }

        private void BTestatisticas_Click(object sender, EventArgs e)
        {
            FormEstatisticas frm = new FormEstatisticas();
            frm.ShowDialog();
        }

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

        
        

        private void BTSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btModoCompra_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = (int)dgvComprasAberto.SelectedRows[0].Cells["Id"].Value;
            }
            catch { 
                   }

            FormModoCompra frm = new FormModoCompra(id);
            frm.ShowDialog();
        }

        private void BTorcamento_Click_1(object sender, EventArgs e)
        {
            FormOrcamento frm = new FormOrcamento();
            frm.ShowDialog();
        }
    }
}

using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    public partial class FormPlaneamentoCompra : Form
    {
        public FormPlaneamentoCompra()
        {
            InitializeComponent();
        }

        private void FormPlaneamentoCompra_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Todas");
            cmbEstado.Items.Add("Abertas");
            cmbEstado.Items.Add("Fechadas");

            cmbEstado.SelectedIndex = 0;

            carregarCompras();
        }

        private void carregarCompras()
        {
            using (var db = new iShoppingContext())
            {
                var compras = db.Compras
                .Include(c => c.CriadoPor)
                .ToList();

                switch (cmbEstado.Text)
                {
                    case "Abertas":
                        compras = compras
                            .Where(c => c.FechadaPorId == null)
                            .ToList();
                        break;

                    case "Fechadas":
                        compras = compras
                            .Where(c => c.FechadaPorId != null)
                            .ToList();
                        break;
                }

                dgvCompras.DataSource = null;

                dgvCompras.DataSource = compras.
                    Select(c => new
                    {
                        c.Id,
                        c.NomeCompra, 
                        c.DataCriacao,
                        Estado = c.FechadaPorId == null
                        ? "Aberta"
                        : "Fechada",
                        DataFecho = c.DataFechada,
                        Utilizador = c.CriadoPor.Username
                    })
                    .ToList();
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCompras();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            FormEditarCompra frm = new FormEditarCompra();
            frm.ShowDialog();
            carregarCompras();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra!!!");
                return;
            }

            int idCompra = Convert.ToInt32
                (dgvCompras.CurrentRow.Cells["Id"].Value);

            using (var db = new iShoppingContext())
            {
                var compra = db.Compras.FirstOrDefault
                    (c => c.Id == idCompra);

                if (compra == null)
                {
                    return;
                }

                if (!string.IsNullOrEmpty(compra.FechadaPorId))
                {
                    MessageBox.Show("A compra já está fechada.");
                    return;
                }

                FormEditarCompra frm = new FormEditarCompra();
                frm.ShowDialog();
                carregarCompras();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                // 1. Obter a linha selecionada
                DataGridViewRow linha = dgvCompras.SelectedRows[0];

                // 2. Obter o objeto Compra associado à linha
                int id = Convert.ToInt32(linha.Cells["Id"].Value);

                // 3. Eliminar pelo ID
                CompraController.EliminarCompra(id);

                // 4. Atualizar a grelha
                carregarCompras();

                MessageBox.Show("Compra eliminado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}

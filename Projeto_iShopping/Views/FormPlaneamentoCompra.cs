using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    public partial class FormPlaneamentoCompra : Form
    {
        // Formulário de planeamento de compras
        // Permite listar compras (todas / abertas / fechadas), criar, editar e eliminar compras planeadas.
        // Observações:
        // - As compras só podem ser editadas enquanto não estiverem fechadas.
        // - A grelha mostra informações essenciais (Id, nome, data, estado e utilizador criador).
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
            // Quando o filtro de estado muda, recarregar a lista com o filtro selecionado
            carregarCompras();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de edição/criação de compra.
            // Depois de fechar o formulário, recarregamos a lista para refletir alterações.
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
                    // Não permitir edição de compras já fechadas: mostrar aviso ao utilizador
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

                // Confirmar remoção ao utilizador
                MessageBox.Show("Compra eliminada com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}

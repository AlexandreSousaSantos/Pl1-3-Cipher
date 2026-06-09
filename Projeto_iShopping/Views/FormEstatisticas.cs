using Projeto_iShopping.Controller;
using System;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    // Formulário para exibir estatísticas e sugestões
    public partial class FormEstatisticas : Form
    {
        EstatisticasController controller = new EstatisticasController();

        public FormEstatisticas()
        {
            InitializeComponent();
        }

        // Carrega todas as estatísticas ao abrir o formulário
        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            dgvResumoMes.DataSource = controller.MostrarResumoMensal();
            dgvComprasFechadas.DataSource = controller.MostrarComprasFechadas();
            dgvSugestoesOrcamento.DataSource = controller.MostrarSugestaoOrcamento();
            dgvSugestoesCompra.DataSource = controller.MostrarSugestaoCompras();
        }

        private void dgvResumoMes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

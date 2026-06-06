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
    public partial class FormEstatisticas : Form
    {
        EstatisticasController controller = new EstatisticasController();

        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            dgvResumoMes.DataSource = controller.MostrarResumoMensal();
            dgvComprasFechadas.DataSource = controller.MostrarComprasFechadas();
            dgvSugestoesOrcamento.DataSource = controller.MostrarSugestaoOrcamento();
            dgvSugestoesCompra.DataSource = controller.MostrarSugestaoCompras();
            
        }

    }
}

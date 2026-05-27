using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_iShopping.Models;
using Projeto_iShopping.Controller;

namespace Projeto_iShopping.Views
{
    public partial class FormOrcamento : Form
    {
        public FormOrcamento()
        {
            InitializeComponent();
        }

        private bool ValidarDados(out int mes, out float ValorMaximo)
        {
            mes = 0;
            ValorMaximo = 0;
            if (!int.TryParse(tbMes.Text, out mes) || mes < 1 || mes > 12)
            {
                MessageBox.Show("Por favor, insira um mês válido (1-12).");
                return false;
            }

            if (tbMes.Text.Trim() == "")
            {
                MessageBox.Show("O campo do mês não pode estar vazio.");
                return false;
            }

            if (!float.TryParse(TBvalorMaximo.Text, out ValorMaximo))
            {
                MessageBox.Show("Por favor, insira um valor máximo válido.");
                return false;
            }

            return true;
        }

        private void tbMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int mes;
            float ValorMaximo;

            if (!ValidarDados(out mes, out ValorMaximo))
            {
                return;
            }

            // Formatar o mês como MM/yyyy
            string mesFormatado = mes.ToString("D2") + "/" + DateTime.Now.Year.ToString();

            int Id_utilizador = Sessao.UtilizadorAtual.Id;

            // Criar ou atualizar o orçamento
            OrcamentoController.CriarOuAtualizar(mesFormatado, (decimal)ValorMaximo, Id_utilizador);

            MessageBox.Show("Orçamento adicionado/atualizado com sucesso!");

            // Limpar os campos de entrada
            tbMes.Clear();
            TBvalorMaximo.Clear();
        }

        private void DGV_Historico_de_Orcamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnElininar_Click(object sender, EventArgs e)
        {
            //Selecionar Orçamento e fazer delete
            int Id_utilizaodr = Sessao.UtilizadorAtual.Id;
            using (iShoppingContext db = new iShoppingContext())
            {
                Orcamento orcamento = db.Orcamento.Find(Id_utilizaodr);
                db.Orcamento.Remove(orcamento);
                db.SaveChanges();

            }
            MessageBox.Show("Orçamento eliminado com sucesso");
            LimparCampos();
            //AtualizarGrelha()
        }

        private void LimparCampos()
        {
            tbMes.Text = "";
            TBvalorMaximo.Text = "";
            DGV_Historico_de_Orcamentos.ClearSelection();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Orcamento orcamentoAtual = OrcamentoController.ObterMesAtual();
            if (orcamentoAtual == null)
            {
                MessageBox.Show("Nenhum orçamento encontrado para o mês atual.");
                return;
            }

            int Id_utilizador = Sessao.UtilizadorAtual.Id;
            OrcamentoController.CriarOuAtualizar(orcamentoAtual.Mes, orcamentoAtual.ValorMaximo, Id_utilizador);
        }
    }
}
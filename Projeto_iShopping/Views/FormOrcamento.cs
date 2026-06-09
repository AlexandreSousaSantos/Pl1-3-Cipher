using System;
using System.Windows.Forms;
using Projeto_iShopping.Models;
using Projeto_iShopping.Controller;

namespace Projeto_iShopping.Views
{
    // Formulário para gerir orçamentos mensais
    public partial class FormOrcamento : Form
    {
        public FormOrcamento()
        {
            InitializeComponent();
        }

        // Carrega orçamentos ao abrir o formulário
        private void FormOrcamento_Load(object sender, EventArgs e)
        {
            AtualizarGrelha();
        }

        // Valida dados do orçamento (mês e valor máximo)
        private bool ValidarDados( out decimal ValorMaximo)
        {
            string mesString = tbMes.Text.Split('/')[0];
            string anoString = tbMes.Text.Split('/')[1];
            if(mesString == null || anoString == null || tbMes.Text.Split('/').Length != 2)
            {
                MessageBox.Show("Por favor, insira um mês e ano válidos no formato MM/yyyy.");
                
                ValorMaximo = 0;
                return false;
            }
           int mes = 0;

            ValorMaximo = 0;
            if (!int.TryParse(mesString, out mes) || mes < 1 || mes > 12)
            {
                MessageBox.Show("Por favor, insira um mês válido (1-12).");
                return false;
            }

            if (tbMes.Text.Trim() == "")
            {
                MessageBox.Show("O campo do mês não pode estar vazio.");
                return false;
            }

            if (!decimal.TryParse(TBvalorMaximo.Text, out ValorMaximo))
            {
                MessageBox.Show("Por favor, insira um valor máximo válido.");
                return false;
            }

            return true;
        }

        // Adiciona ou atualiza orçamento
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            decimal ValorMaximo = 0;

            if (!ValidarDados(out ValorMaximo))
            {
                return;
            }

           
            int Id_utilizador = Sessao.UtilizadorAtual.Id;

            // Criar ou atualizar o orçamento
            OrcamentoController.CriarOuAtualizar(tbMes.Text,ValorMaximo, Id_utilizador);

            MessageBox.Show("Orçamento adicionado/atualizado com sucesso!");

            // Limpar os campos de entrada
            tbMes.Clear();
            TBvalorMaximo.Clear();

            LimparCampos();
            AtualizarGrelha();
        }

        // Elimina orçamento selecionado
        private void btnElininar_Click(object sender, EventArgs e)
        {
            // Verifica se alguma linha está selecionada na grelha
            if (DGV_Historico_de_Orcamentos.SelectedRows.Count == 0)
            {
                // Exibe uma mensagem de aviso se nenhuma linha estiver selecionada
                MessageBox.Show("Por favor, selecione um orçamento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o mês da linha selecionada
            string mes = DGV_Historico_de_Orcamentos.SelectedRows[0].Cells["Mes"].Value.ToString();

            // Chama o método de eliminação do orçamento
            OrcamentoController.Eliminar(mes);
            // Exibe uma mensagem de sucesso após a eliminação
            MessageBox.Show("Orçamento eliminado com sucesso");

            // Limpa os campos de entrada e atualiza a grelha
            LimparCampos();
            AtualizarGrelha();
        }

        // Limpa campos de entrada
        private void LimparCampos()
        {
            tbMes.Text = "";
            TBvalorMaximo.Text = "";
            DGV_Historico_de_Orcamentos.ClearSelection();
        }

        // Atualiza grid com lista de orçamentos
        private void AtualizarGrelha()
        {
            DGV_Historico_de_Orcamentos.DataSource = OrcamentoController.ListarOrcamentos();

            if (DGV_Historico_de_Orcamentos.Columns["DataHoraAlteracao"] != null)
            {
                DGV_Historico_de_Orcamentos.Columns["DataHoraAlteracao"].HeaderText = "Data / Hora da alteração";
                DGV_Historico_de_Orcamentos.Columns["DataHoraAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }

            if (DGV_Historico_de_Orcamentos.Columns["Mes"] != null)
            {
                DGV_Historico_de_Orcamentos.Columns["Mes"].HeaderText = "Mes Alterado";
                DGV_Historico_de_Orcamentos.Columns["Mes"].DefaultCellStyle.Format = "MM/yyyy";
            }

            if (DGV_Historico_de_Orcamentos.Columns["AlteradoPor"] != null)
            {
                DGV_Historico_de_Orcamentos.Columns["AlteradoPor"].HeaderText = "Alterado por";
            }

            if (DGV_Historico_de_Orcamentos.Columns["VezesVisto"] != null)
            {
                DGV_Historico_de_Orcamentos.Columns["VezesVisto"].HeaderText = "N.º de visualizações";
            }
        }

        // Encerra a aplicação
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Atualiza orçamento do mês selecionado
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            decimal ValorMaximo = 0;

            if (!ValidarDados (out  ValorMaximo))
            {
                return;
            }


            Orcamento orcamentoAtual = OrcamentoController.ObterporMes(tbMes.Text);
            if (orcamentoAtual == null)
            {
                MessageBox.Show("Nenhum orçamento encontrado para o mês atual.");
                return;
            }

            int Id_utilizador = Sessao.UtilizadorAtual.Id;
            OrcamentoController.CriarOuAtualizar(orcamentoAtual.Mes,ValorMaximo, Id_utilizador);

            LimparCampos();
            AtualizarGrelha();
        }
    }
}
using Projeto_iShopping.Controller;
using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_iShopping.Views
{
    
    public partial class FormModoCompra : Form
    {
        private int _compraId;
        private object txtObservacoes;
        private Compra compra;

        public FormModoCompra(int compraId)
        {

            InitializeComponent();
            _compraId = compraId;
            
             compra = CompraController.ObterPorId(_compraId);
            if (compra == null)
            {
                MessageBox.Show("Erro");
                this.Close();
                return;

            }
            CarregarArtigos();

            CarregarItens();

        }

        private void NudQtAdquirida_ValueChanged(object sender, EventArgs e)
        {

        }
        private void CarregarArtigos()
        {
            cmbArtigo.Items.Clear();
            List<Artigo> artigos = ArtigoController.ListarTodos();
            foreach (var artigo in artigos)
            {
                cmbArtigo.Items.Add(artigo);
            }
            cmbArtigo.DisplayMember = "NomeArtigo";
            cmbArtigo.ValueMember = "Id";
        }

        

        private void CarregarItens()
        {
            DgvModocompra.DataSource = null;
            DgvModocompra.Rows.Clear();
            DgvModocompra.Columns.Clear();

            DgvModocompra.Columns.Add("colId", "Id");
            DgvModocompra.Columns.Add("colTipo", "Tipo");
            DgvModocompra.Columns.Add("colArt", "Artigo");
            DgvModocompra.Columns.Add("colQtP", "Qt Prevista");
            DgvModocompra.Columns.Add("colQtA", "Qt Adquirida");
            DgvModocompra.Columns.Add("colPreco", "Preço Unit.");
            DgvModocompra.Columns.Add("colAdq", "Adquirido");
            DgvModocompra.Columns.Add("colObs", "Observações");
            DgvModocompra.Columns["colId"].Visible = false;


            //itens previstos
            List<ItemPrevisto> previsto = ItemCompraController.ListarPrevistosDeCompra(_compraId);
            foreach (ItemPrevisto i in previsto)
            {
                string art = (i.Artigo != null) ? i.Artigo.NomeArtigo : "";
                DgvModocompra.Rows.Add(i.Id, "Previsto", art, i.QuantidadePrevista, i.QuantidadeAdquirida, i.PrecoUnitario, "", "");
            }

            //itens não previstos
            List<ItemNaoPrevisto> nprevisto = ItemCompraController.ListarNaoPrevistosDeCompra(_compraId);
            foreach (ItemNaoPrevisto i in nprevisto)
            {
                string art = (i.Artigo != null) ? i.Artigo.NomeArtigo : "";
                DgvModocompra.Rows.Add(i.Id, "Não Previsto", art, 0, i.QuantidadeAdquirida, i.PrecoUnitario, "", i.Observacoes);
            }
        }

        private void btnMarcarAquirido_Click(object sender, EventArgs e)
        {
            // Verificar se há uma linha selecionada
            if (DgvModocompra.CurrentRow == null)  return;

            string tipo = DgvModocompra.CurrentRow.Cells["colTipo"].Value.ToString();
            if(tipo != "Previsto")
            {
                MessageBox.Show("Apenas itens previstos podem ser marcados como adquiridos.");
                return;
            }

            int id = Convert.ToInt32(DgvModocompra.CurrentRow.Cells["colId"].Value);

            try
            {
                ItemCompraController.MarcarComoAdquirido(id, NudQtAdquirida.Value, numericUpDown1.Value); // Passar valores padrão para qtAdquirida e precoUnitario
                CarregarItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao marcar item como adquirido: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Artigo art = cmbArtigo.SelectedItem as Artigo;
            if(art == null)
            {
               MessageBox.Show("Selecione um artigo para adicionar.");
                return;
            }

            try
            {
                ItemNaoPrevisto novoItem = new ItemNaoPrevisto
                {
                    CompraId = _compraId,
                    ArtigoId = art.Id,
                    QuantidadeAdquirida = Convert.ToDecimal(NudQt.Value),
                    PrecoUnitario = NudPreço.Value,
                    Observacoes = txtObservacoes?.ToString()
                };
                ItemCompraController.AdicionarItemCompraNaoPrevisto(novoItem);
                CarregarItens();
                NudQt.Value = 0;
                NudPreço.Value = 0;
                cmbArtigo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar item: " + ex.Message);
            }
            }

        private void btnFecharCompra_Click(object sender, EventArgs e)
        {
            if (Sessao.UtilizadorAtual == null)
            {
                MessageBox.Show("Erro: Utilizador não identificado.");
                return;
            }

            if (MessageBox.Show("Tem a certeza que deseja fechar esta compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CompraController.FecharCompra(_compraId, Sessao.UtilizadorAtual.Id);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fechar compra: " + ex.Message);
                }
            }
        }

        
    }
    }


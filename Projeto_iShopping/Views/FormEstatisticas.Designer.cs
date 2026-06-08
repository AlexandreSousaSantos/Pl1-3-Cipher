namespace Projeto_iShopping.Views
{
    partial class FormEstatisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlEstatisticas = new System.Windows.Forms.TabControl();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComprasFechadas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResumoMes = new System.Windows.Forms.DataGridView();
            this.tabSugestoes = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSugestoesCompra = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSugestoesOrcamento = new System.Windows.Forms.DataGridView();
            this.tabControlEstatisticas.SuspendLayout();
            this.tabEstatisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasFechadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumoMes)).BeginInit();
            this.tabSugestoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestoesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestoesOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEstatisticas
            // 
            this.tabControlEstatisticas.Controls.Add(this.tabEstatisticas);
            this.tabControlEstatisticas.Controls.Add(this.tabSugestoes);
            this.tabControlEstatisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEstatisticas.Location = new System.Drawing.Point(0, 0);
            this.tabControlEstatisticas.Name = "tabControlEstatisticas";
            this.tabControlEstatisticas.SelectedIndex = 0;
            this.tabControlEstatisticas.Size = new System.Drawing.Size(1227, 656);
            this.tabControlEstatisticas.TabIndex = 6;
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Controls.Add(this.label2);
            this.tabEstatisticas.Controls.Add(this.dgvComprasFechadas);
            this.tabEstatisticas.Controls.Add(this.label1);
            this.tabEstatisticas.Controls.Add(this.dgvResumoMes);
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 25);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstatisticas.Size = new System.Drawing.Size(1219, 627);
            this.tabEstatisticas.TabIndex = 0;
            this.tabEstatisticas.Text = "Estatísticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(9, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compras Fechadas - % Previstos versus Não Previstos";
            // 
            // dgvComprasFechadas
            // 
            this.dgvComprasFechadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasFechadas.Location = new System.Drawing.Point(14, 364);
            this.dgvComprasFechadas.Name = "dgvComprasFechadas";
            this.dgvComprasFechadas.RowHeadersWidth = 51;
            this.dgvComprasFechadas.RowTemplate.Height = 24;
            this.dgvComprasFechadas.Size = new System.Drawing.Size(1187, 243);
            this.dgvComprasFechadas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumo por Mês";
            // 
            // dgvResumoMes
            // 
            this.dgvResumoMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumoMes.Location = new System.Drawing.Point(14, 62);
            this.dgvResumoMes.Name = "dgvResumoMes";
            this.dgvResumoMes.RowHeadersWidth = 51;
            this.dgvResumoMes.RowTemplate.Height = 24;
            this.dgvResumoMes.Size = new System.Drawing.Size(1187, 223);
            this.dgvResumoMes.TabIndex = 0;
            // 
            // tabSugestoes
            // 
            this.tabSugestoes.Controls.Add(this.label4);
            this.tabSugestoes.Controls.Add(this.dgvSugestoesCompra);
            this.tabSugestoes.Controls.Add(this.label3);
            this.tabSugestoes.Controls.Add(this.dgvSugestoesOrcamento);
            this.tabSugestoes.Location = new System.Drawing.Point(4, 25);
            this.tabSugestoes.Name = "tabSugestoes";
            this.tabSugestoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSugestoes.Size = new System.Drawing.Size(1219, 627);
            this.tabSugestoes.TabIndex = 1;
            this.tabSugestoes.Text = "Sugestões";
            this.tabSugestoes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(10, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(696, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sugestões de lista de compras baseada em compras anteriores";
            // 
            // dgvSugestoesCompra
            // 
            this.dgvSugestoesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugestoesCompra.Location = new System.Drawing.Point(15, 355);
            this.dgvSugestoesCompra.Name = "dgvSugestoesCompra";
            this.dgvSugestoesCompra.RowHeadersWidth = 51;
            this.dgvSugestoesCompra.RowTemplate.Height = 24;
            this.dgvSugestoesCompra.Size = new System.Drawing.Size(1187, 249);
            this.dgvSugestoesCompra.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sugestões do Orçamento";
            // 
            // dgvSugestoesOrcamento
            // 
            this.dgvSugestoesOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugestoesOrcamento.Location = new System.Drawing.Point(15, 61);
            this.dgvSugestoesOrcamento.Name = "dgvSugestoesOrcamento";
            this.dgvSugestoesOrcamento.RowHeadersWidth = 51;
            this.dgvSugestoesOrcamento.RowTemplate.Height = 24;
            this.dgvSugestoesOrcamento.Size = new System.Drawing.Size(1187, 223);
            this.dgvSugestoesOrcamento.TabIndex = 2;
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 656);
            this.Controls.Add(this.tabControlEstatisticas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstatisticas";
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.tabControlEstatisticas.ResumeLayout(false);
            this.tabEstatisticas.ResumeLayout(false);
            this.tabEstatisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasFechadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumoMes)).EndInit();
            this.tabSugestoes.ResumeLayout(false);
            this.tabSugestoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestoesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestoesOrcamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEstatisticas;
        private System.Windows.Forms.TabPage tabEstatisticas;
        private System.Windows.Forms.TabPage tabSugestoes;
        private System.Windows.Forms.DataGridView dgvResumoMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvComprasFechadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSugestoesOrcamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSugestoesCompra;
    }
}
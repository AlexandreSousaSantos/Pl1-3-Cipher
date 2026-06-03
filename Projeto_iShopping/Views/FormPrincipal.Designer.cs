namespace Projeto_iShopping.Views
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Historico_de_Orcamentos = new System.Windows.Forms.DataGridView();
            this.btModoCompra = new System.Windows.Forms.Button();
            this.BTtiposdeartigos = new System.Windows.Forms.Button();
            this.BTartigos = new System.Windows.Forms.Button();
            this.BTplaneamento = new System.Windows.Forms.Button();
            this.BTestatisticas = new System.Windows.Forms.Button();
            this.BTexportarcsv = new System.Windows.Forms.Button();
            this.BTSair = new System.Windows.Forms.Button();
            this.btnEditarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(60, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras em Aberto";
            // 
            // DGV_Historico_de_Orcamentos
            // 
            this.DGV_Historico_de_Orcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historico_de_Orcamentos.Location = new System.Drawing.Point(65, 176);
            this.DGV_Historico_de_Orcamentos.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Historico_de_Orcamentos.Name = "DGV_Historico_de_Orcamentos";
            this.DGV_Historico_de_Orcamentos.RowHeadersWidth = 51;
            this.DGV_Historico_de_Orcamentos.Size = new System.Drawing.Size(907, 265);
            this.DGV_Historico_de_Orcamentos.TabIndex = 1;
            // 
            // btModoCompra
            // 
            this.btModoCompra.Location = new System.Drawing.Point(65, 478);
            this.btModoCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btModoCompra.Name = "btModoCompra";
            this.btModoCompra.Size = new System.Drawing.Size(139, 42);
            this.btModoCompra.TabIndex = 2;
            this.btModoCompra.Text = "Modo Compra";
            this.btModoCompra.UseVisualStyleBackColor = true;
            // 
            // BTtiposdeartigos
            // 
            this.BTtiposdeartigos.Location = new System.Drawing.Point(16, 15);
            this.BTtiposdeartigos.Margin = new System.Windows.Forms.Padding(4);
            this.BTtiposdeartigos.Name = "BTtiposdeartigos";
            this.BTtiposdeartigos.Size = new System.Drawing.Size(128, 30);
            this.BTtiposdeartigos.TabIndex = 3;
            this.BTtiposdeartigos.Text = "Tipos de Artigos";
            this.BTtiposdeartigos.UseVisualStyleBackColor = true;
            this.BTtiposdeartigos.Click += new System.EventHandler(this.BTtiposdeartigos_Click);
            // 
            // BTartigos
            // 
            this.BTartigos.Location = new System.Drawing.Point(16, 52);
            this.BTartigos.Margin = new System.Windows.Forms.Padding(4);
            this.BTartigos.Name = "BTartigos";
            this.BTartigos.Size = new System.Drawing.Size(128, 30);
            this.BTartigos.TabIndex = 4;
            this.BTartigos.Text = "Artigos";
            this.BTartigos.UseVisualStyleBackColor = true;
            this.BTartigos.Click += new System.EventHandler(this.BTartigos_Click);
            // 
            // BTplaneamento
            // 
            this.BTplaneamento.Location = new System.Drawing.Point(152, 15);
            this.BTplaneamento.Margin = new System.Windows.Forms.Padding(4);
            this.BTplaneamento.Name = "BTplaneamento";
            this.BTplaneamento.Size = new System.Drawing.Size(148, 30);
            this.BTplaneamento.TabIndex = 7;
            this.BTplaneamento.Text = "Planeamento";
            this.BTplaneamento.UseVisualStyleBackColor = true;
            this.BTplaneamento.Click += new System.EventHandler(this.BTplaneamento_Click);
            // 
            // BTestatisticas
            // 
            this.BTestatisticas.Location = new System.Drawing.Point(308, 15);
            this.BTestatisticas.Margin = new System.Windows.Forms.Padding(4);
            this.BTestatisticas.Name = "BTestatisticas";
            this.BTestatisticas.Size = new System.Drawing.Size(115, 30);
            this.BTestatisticas.TabIndex = 8;
            this.BTestatisticas.Text = "Estatísticas";
            this.BTestatisticas.UseVisualStyleBackColor = true;
            this.BTestatisticas.Click += new System.EventHandler(this.BTestatisticas_Click);
            // 
            // BTexportarcsv
            // 
            this.BTexportarcsv.Location = new System.Drawing.Point(431, 15);
            this.BTexportarcsv.Margin = new System.Windows.Forms.Padding(4);
            this.BTexportarcsv.Name = "BTexportarcsv";
            this.BTexportarcsv.Size = new System.Drawing.Size(115, 30);
            this.BTexportarcsv.TabIndex = 9;
            this.BTexportarcsv.Text = "Exportar CSV";
            this.BTexportarcsv.UseVisualStyleBackColor = true;
            this.BTexportarcsv.Click += new System.EventHandler(this.BTexportarcsv_Click);
            // 
            // BTSair
            // 
            this.BTSair.Location = new System.Drawing.Point(553, 15);
            this.BTSair.Margin = new System.Windows.Forms.Padding(4);
            this.BTSair.Name = "BTSair";
            this.BTSair.Size = new System.Drawing.Size(72, 30);
            this.BTSair.TabIndex = 10;
            this.BTSair.Text = "Sair";
            this.BTSair.UseVisualStyleBackColor = true;
            this.BTSair.Click += new System.EventHandler(this.BTSair_Click);
            // 
            // btnEditarCompra
            // 
            this.btnEditarCompra.Location = new System.Drawing.Point(152, 52);
            this.btnEditarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCompra.Name = "btnEditarCompra";
            this.btnEditarCompra.Size = new System.Drawing.Size(170, 30);
            this.btnEditarCompra.TabIndex = 11;
            this.btnEditarCompra.Text = "Criar/Editar Compra";
            this.btnEditarCompra.UseVisualStyleBackColor = true;
            this.btnEditarCompra.Click += new System.EventHandler(this.btnEditarCompra_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEditarCompra);
            this.Controls.Add(this.BTSair);
            this.Controls.Add(this.BTexportarcsv);
            this.Controls.Add(this.BTestatisticas);
            this.Controls.Add(this.BTplaneamento);
            this.Controls.Add(this.BTartigos);
            this.Controls.Add(this.BTtiposdeartigos);
            this.Controls.Add(this.btModoCompra);
            this.Controls.Add(this.DGV_Historico_de_Orcamentos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Historico_de_Orcamentos;
        private System.Windows.Forms.Button btModoCompra;
        private System.Windows.Forms.Button BTtiposdeartigos;
        private System.Windows.Forms.Button BTartigos;
        private System.Windows.Forms.Button BTplaneamento;
        private System.Windows.Forms.Button BTestatisticas;
        private System.Windows.Forms.Button BTexportarcsv;
        private System.Windows.Forms.Button BTSair;
        private System.Windows.Forms.Button btnEditarCompra;
    }
}
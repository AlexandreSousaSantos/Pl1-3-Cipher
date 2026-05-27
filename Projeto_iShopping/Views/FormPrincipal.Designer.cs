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
            this.BTorcamento = new System.Windows.Forms.Button();
            this.BTplaneamento = new System.Windows.Forms.Button();
            this.BTestatisticas = new System.Windows.Forms.Button();
            this.BTexportarcsv = new System.Windows.Forms.Button();
            this.BTSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(45, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras em Aberto";
            // 
            // DGV_Historico_de_Orcamentos
            // 
            this.DGV_Historico_de_Orcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historico_de_Orcamentos.Location = new System.Drawing.Point(49, 143);
            this.DGV_Historico_de_Orcamentos.Name = "DGV_Historico_de_Orcamentos";
            this.DGV_Historico_de_Orcamentos.Size = new System.Drawing.Size(680, 215);
            this.DGV_Historico_de_Orcamentos.TabIndex = 1;
            // 
            // btModoCompra
            // 
            this.btModoCompra.Location = new System.Drawing.Point(49, 388);
            this.btModoCompra.Name = "btModoCompra";
            this.btModoCompra.Size = new System.Drawing.Size(104, 34);
            this.btModoCompra.TabIndex = 2;
            this.btModoCompra.Text = "Modo Compra";
            this.btModoCompra.UseVisualStyleBackColor = true;
            // 
            // BTtiposdeartigos
            // 
            this.BTtiposdeartigos.Location = new System.Drawing.Point(12, 12);
            this.BTtiposdeartigos.Name = "BTtiposdeartigos";
            this.BTtiposdeartigos.Size = new System.Drawing.Size(96, 24);
            this.BTtiposdeartigos.TabIndex = 3;
            this.BTtiposdeartigos.Text = "Tipos de Artigos";
            this.BTtiposdeartigos.UseVisualStyleBackColor = true;
            this.BTtiposdeartigos.Click += new System.EventHandler(this.BTtiposdeartigos_Click);
            // 
            // BTartigos
            // 
            this.BTartigos.Location = new System.Drawing.Point(12, 42);
            this.BTartigos.Name = "BTartigos";
            this.BTartigos.Size = new System.Drawing.Size(96, 24);
            this.BTartigos.TabIndex = 4;
            this.BTartigos.Text = "Artigos";
            this.BTartigos.UseVisualStyleBackColor = true;
            this.BTartigos.Click += new System.EventHandler(this.BTartigos_Click);
            // 
            // BTorcamento
            // 
            this.BTorcamento.Location = new System.Drawing.Point(12, 72);
            this.BTorcamento.Name = "BTorcamento";
            this.BTorcamento.Size = new System.Drawing.Size(96, 24);
            this.BTorcamento.TabIndex = 5;
            this.BTorcamento.Text = "Orçamento";
            this.BTorcamento.UseVisualStyleBackColor = true;
            this.BTorcamento.Click += new System.EventHandler(this.BTorcamento_Click);
            // 
            // BTplaneamento
            // 
            this.BTplaneamento.Location = new System.Drawing.Point(114, 12);
            this.BTplaneamento.Name = "BTplaneamento";
            this.BTplaneamento.Size = new System.Drawing.Size(111, 24);
            this.BTplaneamento.TabIndex = 7;
            this.BTplaneamento.Text = "Planeamento";
            this.BTplaneamento.UseVisualStyleBackColor = true;
            this.BTplaneamento.Click += new System.EventHandler(this.BTplaneamento_Click);
            // 
            // BTestatisticas
            // 
            this.BTestatisticas.Location = new System.Drawing.Point(231, 12);
            this.BTestatisticas.Name = "BTestatisticas";
            this.BTestatisticas.Size = new System.Drawing.Size(86, 24);
            this.BTestatisticas.TabIndex = 8;
            this.BTestatisticas.Text = "Estatísticas";
            this.BTestatisticas.UseVisualStyleBackColor = true;
            this.BTestatisticas.Click += new System.EventHandler(this.BTestatisticas_Click);
            // 
            // BTexportarcsv
            // 
            this.BTexportarcsv.Location = new System.Drawing.Point(323, 12);
            this.BTexportarcsv.Name = "BTexportarcsv";
            this.BTexportarcsv.Size = new System.Drawing.Size(86, 24);
            this.BTexportarcsv.TabIndex = 9;
            this.BTexportarcsv.Text = "Exportar CSV";
            this.BTexportarcsv.UseVisualStyleBackColor = true;
            this.BTexportarcsv.Click += new System.EventHandler(this.BTexportarcsv_Click);
            // 
            // BTSair
            // 
            this.BTSair.Location = new System.Drawing.Point(415, 12);
            this.BTSair.Name = "BTSair";
            this.BTSair.Size = new System.Drawing.Size(54, 24);
            this.BTSair.TabIndex = 10;
            this.BTSair.Text = "Sair";
            this.BTSair.UseVisualStyleBackColor = true;
            this.BTSair.Click += new System.EventHandler(this.BTSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTSair);
            this.Controls.Add(this.BTexportarcsv);
            this.Controls.Add(this.BTestatisticas);
            this.Controls.Add(this.BTplaneamento);
            this.Controls.Add(this.BTorcamento);
            this.Controls.Add(this.BTartigos);
            this.Controls.Add(this.BTtiposdeartigos);
            this.Controls.Add(this.btModoCompra);
            this.Controls.Add(this.DGV_Historico_de_Orcamentos);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
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
        private System.Windows.Forms.Button BTorcamento;
        private System.Windows.Forms.Button BTplaneamento;
        private System.Windows.Forms.Button BTestatisticas;
        private System.Windows.Forms.Button BTexportarcsv;
        private System.Windows.Forms.Button BTSair;
    }
}
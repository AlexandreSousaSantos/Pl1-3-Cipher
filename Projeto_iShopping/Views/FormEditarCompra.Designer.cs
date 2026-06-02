namespace Projeto_iShopping.Views
{
    partial class FormEditarCompra
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCompra = new System.Windows.Forms.TextBox();
            this.DGV_Historico_de_Orcamentos = new System.Windows.Forms.DataGridView();
            this.comboBoxArtigos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar/Editar Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Compra";
            // 
            // txtNomeCompra
            // 
            this.txtNomeCompra.Location = new System.Drawing.Point(23, 86);
            this.txtNomeCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCompra.Name = "txtNomeCompra";
            this.txtNomeCompra.Size = new System.Drawing.Size(457, 22);
            this.txtNomeCompra.TabIndex = 2;
            // 
            // DGV_Historico_de_Orcamentos
            // 
            this.DGV_Historico_de_Orcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historico_de_Orcamentos.Location = new System.Drawing.Point(23, 165);
            this.DGV_Historico_de_Orcamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Historico_de_Orcamentos.Name = "DGV_Historico_de_Orcamentos";
            this.DGV_Historico_de_Orcamentos.RowHeadersWidth = 51;
            this.DGV_Historico_de_Orcamentos.Size = new System.Drawing.Size(997, 308);
            this.DGV_Historico_de_Orcamentos.TabIndex = 3;
            // 
            // comboBoxArtigos
            // 
            this.comboBoxArtigos.FormattingEnabled = true;
            this.comboBoxArtigos.Location = new System.Drawing.Point(129, 498);
            this.comboBoxArtigos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxArtigos.Name = "comboBoxArtigos";
            this.comboBoxArtigos.Size = new System.Drawing.Size(365, 24);
            this.comboBoxArtigos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 504);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artigo:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(559, 500);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(160, 22);
            this.numQuantidade.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(787, 498);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 25);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.Location = new System.Drawing.Point(864, 86);
            this.btnGuardarCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(156, 43);
            this.btnGuardarCompra.TabIndex = 10;
            this.btnGuardarCompra.Text = "Guardar Compra";
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(899, 498);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(121, 25);
            this.btnRemoverItem.TabIndex = 11;
            this.btnRemoverItem.Text = "Remover item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Itens Previstos";
            // 
            // FormEditarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnGuardarCompra);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxArtigos);
            this.Controls.Add(this.DGV_Historico_de_Orcamentos);
            this.Controls.Add(this.txtNomeCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditarCompra";
            this.Text = "FormEditarCompra";
            this.Load += new System.EventHandler(this.FormEditarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCompra;
        private System.Windows.Forms.DataGridView DGV_Historico_de_Orcamentos;
        private System.Windows.Forms.ComboBox comboBoxArtigos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Label label5;
    }
}
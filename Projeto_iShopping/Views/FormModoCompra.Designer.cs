namespace Projeto_iShopping.Views
{
    partial class FormModoCompra
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
            this.DgvModocompra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudQtAdquirida = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnMarcarAquirido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbArtigo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NudQt = new System.Windows.Forms.NumericUpDown();
            this.NudPreço = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFecharCompra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModocompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtAdquirida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreço)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvModocompra
            // 
            this.DgvModocompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvModocompra.Location = new System.Drawing.Point(24, 69);
            this.DgvModocompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvModocompra.Name = "DgvModocompra";
            this.DgvModocompra.RowHeadersWidth = 51;
            this.DgvModocompra.Size = new System.Drawing.Size(1105, 297);
            this.DgvModocompra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marcar como adquirido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 439);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qt Adquirida:";
            // 
            // NudQtAdquirida
            // 
            this.NudQtAdquirida.Location = new System.Drawing.Point(131, 437);
            this.NudQtAdquirida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudQtAdquirida.Name = "NudQtAdquirida";
            this.NudQtAdquirida.Size = new System.Drawing.Size(101, 22);
            this.NudQtAdquirida.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço Unit:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(328, 439);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // btnMarcarAquirido
            // 
            this.btnMarcarAquirido.Location = new System.Drawing.Point(484, 431);
            this.btnMarcarAquirido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarcarAquirido.Name = "btnMarcarAquirido";
            this.btnMarcarAquirido.Size = new System.Drawing.Size(152, 33);
            this.btnMarcarAquirido.TabIndex = 6;
            this.btnMarcarAquirido.Text = "Marcar Adquirido";
            this.btnMarcarAquirido.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 487);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adicionar Item Não Previsto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 524);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Artigo";
            // 
            // cmbArtigo
            // 
            this.cmbArtigo.FormattingEnabled = true;
            this.cmbArtigo.Location = new System.Drawing.Point(96, 518);
            this.cmbArtigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArtigo.Name = "cmbArtigo";
            this.cmbArtigo.Size = new System.Drawing.Size(201, 24);
            this.cmbArtigo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 522);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Qt:";
            // 
            // NudQt
            // 
            this.NudQt.Location = new System.Drawing.Point(389, 518);
            this.NudQt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudQt.Name = "NudQt";
            this.NudQt.Size = new System.Drawing.Size(101, 22);
            this.NudQt.TabIndex = 11;
            // 
            // NudPreço
            // 
            this.NudPreço.Location = new System.Drawing.Point(599, 522);
            this.NudPreço.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NudPreço.Name = "NudPreço";
            this.NudPreço.Size = new System.Drawing.Size(101, 22);
            this.NudPreço.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 521);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preço:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(733, 513);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(152, 33);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnFecharCompra
            // 
            this.btnFecharCompra.Location = new System.Drawing.Point(948, 566);
            this.btnFecharCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFecharCompra.Name = "btnFecharCompra";
            this.btnFecharCompra.Size = new System.Drawing.Size(152, 33);
            this.btnFecharCompra.TabIndex = 15;
            this.btnFecharCompra.Text = "Fechar Compra";
            this.btnFecharCompra.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Modo Compra";
            // 
            // FormModoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFecharCompra);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudPreço);
            this.Controls.Add(this.NudQt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbArtigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMarcarAquirido);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudQtAdquirida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvModocompra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormModoCompra";
            this.Text = "FormsModoCompra";
            ((System.ComponentModel.ISupportInitialize)(this.DgvModocompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQtAdquirida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreço)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvModocompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudQtAdquirida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnMarcarAquirido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbArtigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudQt;
        private System.Windows.Forms.NumericUpDown NudPreço;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFecharCompra;
        private System.Windows.Forms.Label label8;
    }
}
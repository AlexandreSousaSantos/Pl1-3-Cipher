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
            this.dgvEditar = new System.Windows.Forms.DataGridView();
            this.comboBoxArtigos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditarArtigo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar/Editar Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Compra";
            // 
            // txtNomeCompra
            // 
            this.txtNomeCompra.Location = new System.Drawing.Point(17, 70);
            this.txtNomeCompra.Name = "txtNomeCompra";
            this.txtNomeCompra.Size = new System.Drawing.Size(344, 20);
            this.txtNomeCompra.TabIndex = 2;
            // 
            // dgvEditar
            // 
            this.dgvEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditar.Location = new System.Drawing.Point(17, 134);
            this.dgvEditar.Name = "dgvEditar";
            this.dgvEditar.RowHeadersWidth = 51;
            this.dgvEditar.Size = new System.Drawing.Size(748, 250);
            this.dgvEditar.TabIndex = 3;
            // 
            // comboBoxArtigos
            // 
            this.comboBoxArtigos.FormattingEnabled = true;
            this.comboBoxArtigos.Location = new System.Drawing.Point(66, 406);
            this.comboBoxArtigos.Name = "comboBoxArtigos";
            this.comboBoxArtigos.Size = new System.Drawing.Size(275, 21);
            this.comboBoxArtigos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artigo:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(379, 405);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numQuantidade.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(506, 405);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(78, 20);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.Location = new System.Drawing.Point(648, 70);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(117, 35);
            this.btnGuardarCompra.TabIndex = 10;
            this.btnGuardarCompra.Text = "Guardar Compra";
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(674, 405);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(91, 20);
            this.btnRemoverItem.TabIndex = 11;
            this.btnRemoverItem.Text = "Remover item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Itens Previstos";
            // 
            // btnEditarArtigo
            // 
            this.btnEditarArtigo.Location = new System.Drawing.Point(590, 407);
            this.btnEditarArtigo.Name = "btnEditarArtigo";
            this.btnEditarArtigo.Size = new System.Drawing.Size(78, 20);
            this.btnEditarArtigo.TabIndex = 13;
            this.btnEditarArtigo.Text = "Editar Artigo";
            this.btnEditarArtigo.UseVisualStyleBackColor = true;
            this.btnEditarArtigo.Click += new System.EventHandler(this.btnEditarArtigo_Click);
            // 
            // FormEditarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarArtigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnGuardarCompra);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxArtigos);
            this.Controls.Add(this.dgvEditar);
            this.Controls.Add(this.txtNomeCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarCompra";
            this.Text = "Criar ou editar uma compra";
            this.Load += new System.EventHandler(this.FormEditarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCompra;
        private System.Windows.Forms.DataGridView dgvEditar;
        private System.Windows.Forms.ComboBox comboBoxArtigos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditarArtigo;
    }
}
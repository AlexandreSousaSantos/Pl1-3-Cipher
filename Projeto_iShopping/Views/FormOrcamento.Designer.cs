namespace Projeto_iShopping.Views
{
    partial class FormOrcamento
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarOrcamento = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbMes = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Historico_de_Orcamentos = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBvalorMaximo = new System.Windows.Forms.TextBox();
            this.btnElininar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mês (MM/yyyy):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(39, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Máximo (€):";
            // 
            // btnGuardarOrcamento
            // 
            this.btnGuardarOrcamento.Location = new System.Drawing.Point(870, 185);
            this.btnGuardarOrcamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarOrcamento.Name = "btnGuardarOrcamento";
            this.btnGuardarOrcamento.Size = new System.Drawing.Size(174, 28);
            this.btnGuardarOrcamento.TabIndex = 3;
            this.btnGuardarOrcamento.Text = "Guardar Orçamento";
            this.btnGuardarOrcamento.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(188, 107);
            this.tbMes.Margin = new System.Windows.Forms.Padding(4);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(175, 22);
            this.tbMes.TabIndex = 6;
            this.tbMes.TextChanged += new System.EventHandler(this.tbMes_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(870, 98);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(79, 31);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(13, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Histórico de Orçamentos";
            // 
            // DGV_Historico_de_Orcamentos
            // 
            this.DGV_Historico_de_Orcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historico_de_Orcamentos.Location = new System.Drawing.Point(18, 297);
            this.DGV_Historico_de_Orcamentos.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Historico_de_Orcamentos.Name = "DGV_Historico_de_Orcamentos";
            this.DGV_Historico_de_Orcamentos.RowHeadersWidth = 51;
            this.DGV_Historico_de_Orcamentos.Size = new System.Drawing.Size(1026, 208);
            this.DGV_Historico_de_Orcamentos.TabIndex = 9;
            this.DGV_Historico_de_Orcamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Historico_de_Orcamentos_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(957, 135);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 32);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(957, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TBvalorMaximo
            // 
            this.TBvalorMaximo.Location = new System.Drawing.Point(203, 149);
            this.TBvalorMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.TBvalorMaximo.Name = "TBvalorMaximo";
            this.TBvalorMaximo.Size = new System.Drawing.Size(159, 22);
            this.TBvalorMaximo.TabIndex = 12;
            // 
            // btnElininar
            // 
            this.btnElininar.Location = new System.Drawing.Point(870, 135);
            this.btnElininar.Margin = new System.Windows.Forms.Padding(4);
            this.btnElininar.Name = "btnElininar";
            this.btnElininar.Size = new System.Drawing.Size(79, 32);
            this.btnElininar.TabIndex = 13;
            this.btnElininar.Text = "Eliminar";
            this.btnElininar.UseVisualStyleBackColor = true;
            this.btnElininar.Click += new System.EventHandler(this.btnElininar_Click);
            // 
            // FormOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 516);
            this.Controls.Add(this.btnElininar);
            this.Controls.Add(this.TBvalorMaximo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.DGV_Historico_de_Orcamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.btnGuardarOrcamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrcamento";
            this.Text = "FormOrcamento";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historico_de_Orcamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarOrcamento;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_Historico_de_Orcamentos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBvalorMaximo;
        private System.Windows.Forms.Button btnElininar;
    }
}
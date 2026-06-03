namespace Projeto_iShopping.Views
{
    partial class FormLogin
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
            this.TButilizador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.btentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(404, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ishopping";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(264, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilizador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TButilizador
            // 
            this.TButilizador.Location = new System.Drawing.Point(269, 241);
            this.TButilizador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TButilizador.Name = "TButilizador";
            this.TButilizador.Size = new System.Drawing.Size(493, 22);
            this.TButilizador.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(265, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // TBpassword
            // 
            this.TBpassword.Location = new System.Drawing.Point(269, 320);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(493, 22);
            this.TBpassword.TabIndex = 4;
            // 
            // btentrar
            // 
            this.btentrar.Location = new System.Drawing.Point(464, 423);
            this.btentrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(109, 39);
            this.btentrar.TabIndex = 5;
            this.btentrar.Text = "Entrar";
            this.btentrar.UseVisualStyleBackColor = true;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TButilizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TButilizador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Button btentrar;
    }
}
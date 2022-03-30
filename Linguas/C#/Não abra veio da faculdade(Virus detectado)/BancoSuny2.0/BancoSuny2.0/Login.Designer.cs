namespace BancoSuny2._0
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.bttEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(12, 38);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(65, 20);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Numero";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(12, 81);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(92, 38);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(108, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(92, 81);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(95, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // bttEntrar
            // 
            this.bttEntrar.Location = new System.Drawing.Point(137, 115);
            this.bttEntrar.Name = "bttEntrar";
            this.bttEntrar.Size = new System.Drawing.Size(75, 23);
            this.bttEntrar.TabIndex = 4;
            this.bttEntrar.Text = "entrar";
            this.bttEntrar.UseVisualStyleBackColor = true;
            this.bttEntrar.Click += new System.EventHandler(this.bttEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 150);
            this.Controls.Add(this.bttEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblnumero);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button bttEntrar;
    }
}


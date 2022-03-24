namespace PROJETO
{
    partial class form1
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
            this.mostrarversão = new System.Windows.Forms.Button();
            this.ButtonListarpartidas = new System.Windows.Forms.Button();
            this.LbLCartas = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.LbLVersão = new System.Windows.Forms.Label();
            this.listBoxPartidas = new System.Windows.Forms.ListBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidpartida = new System.Windows.Forms.TextBox();
            this.IdNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrarversão
            // 
            this.mostrarversão.Location = new System.Drawing.Point(63, 70);
            this.mostrarversão.Name = "mostrarversão";
            this.mostrarversão.Size = new System.Drawing.Size(92, 46);
            this.mostrarversão.TabIndex = 0;
            this.mostrarversão.Text = "Versão";
            this.mostrarversão.UseVisualStyleBackColor = true;
            this.mostrarversão.Click += new System.EventHandler(this.mostrarversão_Click);
            // 
            // ButtonListarpartidas
            // 
            this.ButtonListarpartidas.Location = new System.Drawing.Point(63, 17);
            this.ButtonListarpartidas.Name = "ButtonListarpartidas";
            this.ButtonListarpartidas.Size = new System.Drawing.Size(92, 47);
            this.ButtonListarpartidas.TabIndex = 1;
            this.ButtonListarpartidas.Text = "Listar partidas";
            this.ButtonListarpartidas.UseVisualStyleBackColor = true;
            this.ButtonListarpartidas.Click += new System.EventHandler(this.Listarpartidas_Click);
            // 
            // LbLCartas
            // 
            this.LbLCartas.AutoSize = true;
            this.LbLCartas.Location = new System.Drawing.Point(647, 17);
            this.LbLCartas.Name = "LbLCartas";
            this.LbLCartas.Size = new System.Drawing.Size(37, 13);
            this.LbLCartas.TabIndex = 2;
            this.LbLCartas.Text = "Cartas";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(456, 62);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(253, 285);
            this.text1.TabIndex = 3;
            // 
            // LbLVersão
            // 
            this.LbLVersão.AutoSize = true;
            this.LbLVersão.Location = new System.Drawing.Point(722, 428);
            this.LbLVersão.Name = "LbLVersão";
            this.LbLVersão.Size = new System.Drawing.Size(43, 13);
            this.LbLVersão.TabIndex = 4;
            this.LbLVersão.Text = "Versão:";
            this.LbLVersão.Click += new System.EventHandler(this.LbLVersão_Click);
            // 
            // listBoxPartidas
            // 
            this.listBoxPartidas.FormattingEnabled = true;
            this.listBoxPartidas.Location = new System.Drawing.Point(165, 17);
            this.listBoxPartidas.Name = "listBoxPartidas";
            this.listBoxPartidas.Size = new System.Drawing.Size(120, 95);
            this.listBoxPartidas.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(63, 324);
            this.txtnome.Multiline = true;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 23);
            this.txtnome.TabIndex = 6;
            // 
            // txtidpartida
            // 
            this.txtidpartida.Location = new System.Drawing.Point(169, 324);
            this.txtidpartida.Multiline = true;
            this.txtidpartida.Name = "txtidpartida";
            this.txtidpartida.Size = new System.Drawing.Size(100, 23);
            this.txtidpartida.TabIndex = 7;
            // 
            // IdNome
            // 
            this.IdNome.Location = new System.Drawing.Point(132, 276);
            this.IdNome.Name = "IdNome";
            this.IdNome.Size = new System.Drawing.Size(75, 42);
            this.IdNome.TabIndex = 8;
            this.IdNome.Text = "ID/Nome";
            this.IdNome.UseVisualStyleBackColor = true;
            this.IdNome.Click += new System.EventHandler(this.IdNome_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdNome);
            this.Controls.Add(this.txtidpartida);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.listBoxPartidas);
            this.Controls.Add(this.LbLVersão);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.LbLCartas);
            this.Controls.Add(this.ButtonListarpartidas);
            this.Controls.Add(this.mostrarversão);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrarversão;
        private System.Windows.Forms.Button ButtonListarpartidas;
        private System.Windows.Forms.Label LbLCartas;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label LbLVersão;
        private System.Windows.Forms.ListBox listBoxPartidas;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidpartida;
        private System.Windows.Forms.Button IdNome;
    }
}


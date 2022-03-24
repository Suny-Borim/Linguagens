namespace CadastroDprodutos
{
    partial class Form1
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
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.bttSavar = new System.Windows.Forms.Button();
            this.cbxProdutos = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.bttInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(73, 12);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(128, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(32, 15);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 1;
            this.lblNomeProduto.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(32, 41);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(73, 38);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(37, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // bttSavar
            // 
            this.bttSavar.Location = new System.Drawing.Point(178, 108);
            this.bttSavar.Name = "bttSavar";
            this.bttSavar.Size = new System.Drawing.Size(75, 23);
            this.bttSavar.TabIndex = 4;
            this.bttSavar.Text = "Savar";
            this.bttSavar.UseVisualStyleBackColor = true;
            this.bttSavar.Click += new System.EventHandler(this.bttSavar_Click);
            // 
            // cbxProdutos
            // 
            this.cbxProdutos.FormattingEnabled = true;
            this.cbxProdutos.Location = new System.Drawing.Point(73, 110);
            this.cbxProdutos.Name = "cbxProdutos";
            this.cbxProdutos.Size = new System.Drawing.Size(85, 21);
            this.cbxProdutos.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 62);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(180, 40);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 77);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição";
            // 
            // bttInfo
            // 
            this.bttInfo.Location = new System.Drawing.Point(15, 110);
            this.bttInfo.Name = "bttInfo";
            this.bttInfo.Size = new System.Drawing.Size(52, 21);
            this.bttInfo.TabIndex = 8;
            this.bttInfo.Text = "info";
            this.bttInfo.UseVisualStyleBackColor = true;
            this.bttInfo.Click += new System.EventHandler(this.bttInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 151);
            this.Controls.Add(this.bttInfo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbxProdutos);
            this.Controls.Add(this.bttSavar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button bttSavar;
        private System.Windows.Forms.ComboBox cbxProdutos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button bttInfo;
    }
}


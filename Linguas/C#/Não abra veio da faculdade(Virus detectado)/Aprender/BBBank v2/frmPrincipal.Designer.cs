namespace BBBank_v2
{
    partial class frmPrincipal
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPIX = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.lbxExtrato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Usuario";
            // 
            // lblPIX
            // 
            this.lblPIX.Location = new System.Drawing.Point(202, 9);
            this.lblPIX.Name = "lblPIX";
            this.lblPIX.Size = new System.Drawing.Size(212, 13);
            this.lblPIX.TabIndex = 1;
            this.lblPIX.Text = "Chave PIX";
            this.lblPIX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPIX.DoubleClick += new System.EventHandler(this.lblPIX_DoubleClick);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(12, 32);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 20);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "R$0,00";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(12, 65);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(89, 23);
            this.btnDeposito.TabIndex = 3;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(12, 94);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(89, 23);
            this.btnSaque.TabIndex = 4;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(12, 123);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(89, 23);
            this.btnTransferencia.TabIndex = 5;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // lbxExtrato
            // 
            this.lbxExtrato.FormattingEnabled = true;
            this.lbxExtrato.Location = new System.Drawing.Point(136, 32);
            this.lbxExtrato.Name = "lbxExtrato";
            this.lbxExtrato.Size = new System.Drawing.Size(278, 121);
            this.lbxExtrato.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 165);
            this.Controls.Add(this.lbxExtrato);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblPIX);
            this.Controls.Add(this.lblNome);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPIX;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.ListBox lbxExtrato;
    }
}


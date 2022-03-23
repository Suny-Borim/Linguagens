namespace Empresa
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
            this.Dona = new System.Windows.Forms.Label();
            this.NOME_SALVAR = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.CPF_SALVAR = new System.Windows.Forms.Label();
            this.groupBox_Cadastro = new System.Windows.Forms.GroupBox();
            this.RUA_SALVAR = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.NUMERO_SALVAR = new System.Windows.Forms.Label();
            this.CEP_SALVAR = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.COMPLEMENTO_SALVAR = new System.Windows.Forms.Label();
            this.BUTTON_SALVAR = new System.Windows.Forms.Button();
            this.adm = new System.Windows.Forms.Button();
            this.cbxFuncionarios = new System.Windows.Forms.ComboBox();
            this.groupBox_Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dona
            // 
            this.Dona.AutoSize = true;
            this.Dona.Location = new System.Drawing.Point(12, 185);
            this.Dona.Name = "Dona";
            this.Dona.Size = new System.Drawing.Size(33, 13);
            this.Dona.TabIndex = 0;
            this.Dona.Text = "Dona";
            // 
            // NOME_SALVAR
            // 
            this.NOME_SALVAR.AutoSize = true;
            this.NOME_SALVAR.Location = new System.Drawing.Point(21, 12);
            this.NOME_SALVAR.Name = "NOME_SALVAR";
            this.NOME_SALVAR.Size = new System.Drawing.Size(35, 13);
            this.NOME_SALVAR.TabIndex = 1;
            this.NOME_SALVAR.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(54, 35);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(109, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // CPF_SALVAR
            // 
            this.CPF_SALVAR.AutoSize = true;
            this.CPF_SALVAR.Location = new System.Drawing.Point(22, 38);
            this.CPF_SALVAR.Name = "CPF_SALVAR";
            this.CPF_SALVAR.Size = new System.Drawing.Size(27, 13);
            this.CPF_SALVAR.TabIndex = 5;
            this.CPF_SALVAR.Text = "CPF";
            // 
            // groupBox_Cadastro
            // 
            this.groupBox_Cadastro.Controls.Add(this.COMPLEMENTO_SALVAR);
            this.groupBox_Cadastro.Controls.Add(this.txtComplemento);
            this.groupBox_Cadastro.Controls.Add(this.CEP_SALVAR);
            this.groupBox_Cadastro.Controls.Add(this.NUMERO_SALVAR);
            this.groupBox_Cadastro.Controls.Add(this.txtCep);
            this.groupBox_Cadastro.Controls.Add(this.txtNumero);
            this.groupBox_Cadastro.Controls.Add(this.txtRua);
            this.groupBox_Cadastro.Controls.Add(this.RUA_SALVAR);
            this.groupBox_Cadastro.Location = new System.Drawing.Point(15, 61);
            this.groupBox_Cadastro.Name = "groupBox_Cadastro";
            this.groupBox_Cadastro.Size = new System.Drawing.Size(263, 108);
            this.groupBox_Cadastro.TabIndex = 6;
            this.groupBox_Cadastro.TabStop = false;
            this.groupBox_Cadastro.Text = "Cadastro";
            // 
            // RUA_SALVAR
            // 
            this.RUA_SALVAR.AutoSize = true;
            this.RUA_SALVAR.Location = new System.Drawing.Point(6, 26);
            this.RUA_SALVAR.Name = "RUA_SALVAR";
            this.RUA_SALVAR.Size = new System.Drawing.Size(27, 13);
            this.RUA_SALVAR.TabIndex = 7;
            this.RUA_SALVAR.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(38, 23);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(194, 20);
            this.txtRua.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(189, 49);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(43, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(38, 49);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(97, 20);
            this.txtCep.TabIndex = 9;
            // 
            // NUMERO_SALVAR
            // 
            this.NUMERO_SALVAR.AutoSize = true;
            this.NUMERO_SALVAR.Location = new System.Drawing.Point(141, 52);
            this.NUMERO_SALVAR.Name = "NUMERO_SALVAR";
            this.NUMERO_SALVAR.Size = new System.Drawing.Size(44, 13);
            this.NUMERO_SALVAR.TabIndex = 7;
            this.NUMERO_SALVAR.Text = "Numero";
            // 
            // CEP_SALVAR
            // 
            this.CEP_SALVAR.AutoSize = true;
            this.CEP_SALVAR.Location = new System.Drawing.Point(6, 52);
            this.CEP_SALVAR.Name = "CEP_SALVAR";
            this.CEP_SALVAR.Size = new System.Drawing.Size(28, 13);
            this.CEP_SALVAR.TabIndex = 10;
            this.CEP_SALVAR.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(78, 75);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(154, 20);
            this.txtComplemento.TabIndex = 8;
            // 
            // COMPLEMENTO_SALVAR
            // 
            this.COMPLEMENTO_SALVAR.AutoSize = true;
            this.COMPLEMENTO_SALVAR.Location = new System.Drawing.Point(6, 78);
            this.COMPLEMENTO_SALVAR.Name = "COMPLEMENTO_SALVAR";
            this.COMPLEMENTO_SALVAR.Size = new System.Drawing.Size(71, 13);
            this.COMPLEMENTO_SALVAR.TabIndex = 11;
            this.COMPLEMENTO_SALVAR.Text = "Complemento";
            // 
            // BUTTON_SALVAR
            // 
            this.BUTTON_SALVAR.AutoSize = true;
            this.BUTTON_SALVAR.Location = new System.Drawing.Point(203, 175);
            this.BUTTON_SALVAR.Name = "BUTTON_SALVAR";
            this.BUTTON_SALVAR.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_SALVAR.TabIndex = 7;
            this.BUTTON_SALVAR.Text = "Salvar";
            this.BUTTON_SALVAR.UseVisualStyleBackColor = true;
            this.BUTTON_SALVAR.Click += new System.EventHandler(this.BUTTON_SALVAR_Click);
            // 
            // adm
            // 
            this.adm.Location = new System.Drawing.Point(173, 38);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(75, 23);
            this.adm.TabIndex = 8;
            this.adm.Text = "adm";
            this.adm.UseVisualStyleBackColor = true;
            this.adm.Click += new System.EventHandler(this.adm_Click);
            // 
            // cbxFuncionarios
            // 
            this.cbxFuncionarios.FormattingEnabled = true;
            this.cbxFuncionarios.Location = new System.Drawing.Point(53, 171);
            this.cbxFuncionarios.Name = "cbxFuncionarios";
            this.cbxFuncionarios.Size = new System.Drawing.Size(146, 21);
            this.cbxFuncionarios.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(277, 204);
            this.Controls.Add(this.cbxFuncionarios);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.BUTTON_SALVAR);
            this.Controls.Add(this.groupBox_Cadastro);
            this.Controls.Add(this.CPF_SALVAR);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.NOME_SALVAR);
            this.Controls.Add(this.Dona);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Cadastro.ResumeLayout(false);
            this.groupBox_Cadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dona;
        private System.Windows.Forms.Label NOME_SALVAR;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label CPF_SALVAR;
        private System.Windows.Forms.GroupBox groupBox_Cadastro;
        private System.Windows.Forms.Label NUMERO_SALVAR;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label RUA_SALVAR;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label CEP_SALVAR;
        private System.Windows.Forms.Label COMPLEMENTO_SALVAR;
        private System.Windows.Forms.Button BUTTON_SALVAR;
        private System.Windows.Forms.Button adm;
        private System.Windows.Forms.ComboBox cbxFuncionarios;
    }
}


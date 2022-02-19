namespace Primeiro_Forms
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
            this.jogos = new System.Windows.Forms.ComboBox();
            this.ComboBoxButton = new System.Windows.Forms.Button();
            this.Entrega = new System.Windows.Forms.CheckBox();
            this.AddComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jogos
            // 
            this.jogos.FormattingEnabled = true;
            this.jogos.Items.AddRange(new object[] {
            "Dark Souls ",
            "Dark Souls 2 ",
            "Dark Souls 3",
            "BloodBorne",
            "Elder Scrolls",
            ""});
            this.jogos.Location = new System.Drawing.Point(180, 202);
            this.jogos.Name = "jogos";
            this.jogos.Size = new System.Drawing.Size(121, 21);
            this.jogos.TabIndex = 0;
            this.jogos.SelectedIndexChanged += new System.EventHandler(this.jogos_SelectedIndexChanged);
            // 
            // ComboBoxButton
            // 
            this.ComboBoxButton.Location = new System.Drawing.Point(201, 229);
            this.ComboBoxButton.Name = "ComboBoxButton";
            this.ComboBoxButton.Size = new System.Drawing.Size(75, 23);
            this.ComboBoxButton.TabIndex = 1;
            this.ComboBoxButton.Text = "button1";
            this.ComboBoxButton.UseVisualStyleBackColor = true;
            this.ComboBoxButton.Click += new System.EventHandler(this.ComboBoxButton_Click);
            // 
            // Entrega
            // 
            this.Entrega.AutoSize = true;
            this.Entrega.Location = new System.Drawing.Point(339, 205);
            this.Entrega.Name = "Entrega";
            this.Entrega.Size = new System.Drawing.Size(118, 17);
            this.Entrega.TabIndex = 2;
            this.Entrega.Text = "Entrega pra viagem";
            this.Entrega.UseVisualStyleBackColor = true;
            // 
            // AddComboBox
            // 
            this.AddComboBox.Location = new System.Drawing.Point(99, 205);
            this.AddComboBox.Name = "AddComboBox";
            this.AddComboBox.Size = new System.Drawing.Size(75, 23);
            this.AddComboBox.TabIndex = 3;
            this.AddComboBox.Text = "Add";
            this.AddComboBox.UseVisualStyleBackColor = true;
            this.AddComboBox.Click += new System.EventHandler(this.AddComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddComboBox);
            this.Controls.Add(this.Entrega);
            this.Controls.Add(this.ComboBoxButton);
            this.Controls.Add(this.jogos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox jogos;
        private System.Windows.Forms.Button ComboBoxButton;
        private System.Windows.Forms.CheckBox Entrega;
        private System.Windows.Forms.Button AddComboBox;
    }
}


namespace Forms_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ADD = new System.Windows.Forms.Button();
            this.Jogos = new System.Windows.Forms.ComboBox();
            this.Comprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(150, 150);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Jogos
            // 
            this.Jogos.FormattingEnabled = true;
            this.Jogos.Location = new System.Drawing.Point(249, 151);
            this.Jogos.Name = "Jogos";
            this.Jogos.Size = new System.Drawing.Size(121, 23);
            this.Jogos.TabIndex = 1;
            this.Jogos.SelectedIndexChanged += new System.EventHandler(this.Jogos_SelectedIndexChanged);
            // 
            // Comprar
            // 
            this.Comprar.Location = new System.Drawing.Point(388, 150);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(75, 23);
            this.Comprar.TabIndex = 2;
            this.Comprar.Text = "Comprar";
            this.Comprar.UseVisualStyleBackColor = true;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.Jogos);
            this.Controls.Add(this.ADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ADD;
        private ComboBox Jogos;
        private Button Comprar;
    }
}
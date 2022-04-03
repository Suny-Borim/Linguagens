namespace BancoTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo";
            // 
            // bttlogin
            // 
            this.bttlogin.AutoSize = true;
            this.bttlogin.Location = new System.Drawing.Point(236, 339);
            this.bttlogin.Name = "bttlogin";
            this.bttlogin.Size = new System.Drawing.Size(106, 85);
            this.bttlogin.TabIndex = 1;
            this.bttlogin.Text = "Login";
            this.bttlogin.UseVisualStyleBackColor = true;
            this.bttlogin.Click += new System.EventHandler(this.bttlogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "ID";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttHelp
            // 
            this.bttHelp.AutoSize = true;
            this.bttHelp.Location = new System.Drawing.Point(-6, 339);
            this.bttHelp.Name = "bttHelp";
            this.bttHelp.Size = new System.Drawing.Size(106, 85);
            this.bttHelp.TabIndex = 3;
            this.bttHelp.Text = "Help";
            this.bttHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 420);
            this.Controls.Add(this.bttHelp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttlogin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 459);
            this.Name = "Form1";
            this.Text = "Banco Suny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bttlogin;
        private Button button1;
        private Button bttHelp;
    }
}
namespace Primeiro_Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Dialogo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ADDcarta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dialogo
            // 
            this.Dialogo.Location = new System.Drawing.Point(256, 136);
            this.Dialogo.Name = "Dialogo";
            this.Dialogo.Size = new System.Drawing.Size(75, 23);
            this.Dialogo.TabIndex = 0;
            this.Dialogo.Text = "Dialogo";
            this.Dialogo.UseVisualStyleBackColor = true;
            this.Dialogo.Click += new System.EventHandler(this.Dialogo_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(214, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 206);
            this.panel1.TabIndex = 1;
            // 
            // ADDcarta
            // 
            this.ADDcarta.Location = new System.Drawing.Point(114, 118);
            this.ADDcarta.Name = "ADDcarta";
            this.ADDcarta.Size = new System.Drawing.Size(75, 23);
            this.ADDcarta.TabIndex = 2;
            this.ADDcarta.Text = "ADD carta";
            this.ADDcarta.UseVisualStyleBackColor = true;
            this.ADDcarta.Click += new System.EventHandler(this.ADDcarta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.ADDcarta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dialogo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dialogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ADDcarta;
    }
}
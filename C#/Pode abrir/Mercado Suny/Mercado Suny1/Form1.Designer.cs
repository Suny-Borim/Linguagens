namespace Mercado_Suny1
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
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.ListaItems = new System.Windows.Forms.ListBox();
            this.txtBoxAdditem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Location = new System.Drawing.Point(134, 9);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(66, 23);
            this.ButtonAddItem.TabIndex = 0;
            this.ButtonAddItem.Text = "Adicionar";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // ListaItems
            // 
            this.ListaItems.FormattingEnabled = true;
            this.ListaItems.Location = new System.Drawing.Point(28, 80);
            this.ListaItems.Name = "ListaItems";
            this.ListaItems.Size = new System.Drawing.Size(120, 95);
            this.ListaItems.TabIndex = 1;
            // 
            // txtBoxAdditem
            // 
            this.txtBoxAdditem.Location = new System.Drawing.Point(28, 12);
            this.txtBoxAdditem.Name = "txtBoxAdditem";
            this.txtBoxAdditem.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdditem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxAdditem);
            this.Controls.Add(this.ListaItems);
            this.Controls.Add(this.ButtonAddItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.ListBox ListaItems;
        private System.Windows.Forms.TextBox txtBoxAdditem;
    }
}


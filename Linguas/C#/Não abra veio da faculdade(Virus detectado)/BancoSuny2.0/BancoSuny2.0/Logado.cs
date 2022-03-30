using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSuny2._0
{
    public partial class _ : Form
    {
        private Label txtNome;
        private Button bttsacar;
        private Button btttransferir;
        private ListBox lbxLog;
        private Label txtSaldo;
        private Button bttSair;
        private Button bttDepositar;
        private Label lblPIX;

        public _()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.lblPIX = new System.Windows.Forms.Label();
            this.bttsacar = new System.Windows.Forms.Button();
            this.btttransferir = new System.Windows.Forms.Button();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.txtSaldo = new System.Windows.Forms.Label();
            this.bttSair = new System.Windows.Forms.Button();
            this.bttDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(328, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(51, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            this.txtNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPIX
            // 
            this.lblPIX.AutoSize = true;
            this.lblPIX.Location = new System.Drawing.Point(632, 16);
            this.lblPIX.Name = "lblPIX";
            this.lblPIX.Size = new System.Drawing.Size(24, 13);
            this.lblPIX.TabIndex = 1;
            this.lblPIX.Text = "PIX";
            this.lblPIX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bttsacar
            // 
            this.bttsacar.Location = new System.Drawing.Point(12, 128);
            this.bttsacar.Name = "bttsacar";
            this.bttsacar.Size = new System.Drawing.Size(104, 36);
            this.bttsacar.TabIndex = 6;
            this.bttsacar.Text = "Sacar";
            this.bttsacar.UseVisualStyleBackColor = true;
            // 
            // btttransferir
            // 
            this.btttransferir.Location = new System.Drawing.Point(12, 170);
            this.btttransferir.Name = "btttransferir";
            this.btttransferir.Size = new System.Drawing.Size(104, 36);
            this.btttransferir.TabIndex = 7;
            this.btttransferir.Text = "Transferir";
            this.btttransferir.UseVisualStyleBackColor = true;
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.Location = new System.Drawing.Point(147, 71);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(509, 147);
            this.lbxLog.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.AutoSize = true;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(40, 16);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(76, 29);
            this.txtSaldo.TabIndex = 9;
            this.txtSaldo.Text = "Saldo";
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(593, 224);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 23);
            this.bttSair.TabIndex = 10;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            // 
            // bttDepositar
            // 
            this.bttDepositar.Location = new System.Drawing.Point(12, 85);
            this.bttDepositar.Name = "bttDepositar";
            this.bttDepositar.Size = new System.Drawing.Size(104, 36);
            this.bttDepositar.TabIndex = 3;
            this.bttDepositar.Text = "Depositar";
            this.bttDepositar.UseVisualStyleBackColor = true;
            // 
            // _
            // 
            this.ClientSize = new System.Drawing.Size(680, 250);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.btttransferir);
            this.Controls.Add(this.bttsacar);
            this.Controls.Add(this.bttDepositar);
            this.Controls.Add(this.lblPIX);
            this.Controls.Add(this.txtNome);
            this.Name = "_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

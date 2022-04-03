using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBBank_v2
{
    public partial class frmDeposito : Form
    {
        public double valor { get; private set; }

        public frmDeposito()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.valor = Double.Parse(txtValor.Text);
            this.Close();
        }
    }
}

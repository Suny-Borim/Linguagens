using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTest
{
    public partial class ContaAtual : Form
    {
        Conta contaatual { get; set; }
        public ContaAtual(Conta conta)
        {
            InitializeComponent();
            contaatual = conta;
        }

        private void ContaAtual_Load(object sender, EventArgs e)
        {
            lblNome.Text = contaatual.usuario.nome;
        }
    }
}

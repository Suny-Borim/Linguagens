using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBoxButton_Click(object sender, EventArgs e)
        {
            String jogo = jogos.SelectedItem.ToString();
            
            if (Entrega.Checked)
            {
                jogo += " e sera entregue na sua casa";
            }
            MessageBox.Show("Você escolheu um joguin e comprou " + jogo);
        }

        private void jogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddComboBox_Click(object sender, EventArgs e)
        {
            jogos.Items.Add(jogos.Text);
        }
    }
}

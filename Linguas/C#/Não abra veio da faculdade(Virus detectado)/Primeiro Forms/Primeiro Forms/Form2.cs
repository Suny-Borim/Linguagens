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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Dialogo_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog(); 
        }

        private void ADDcarta_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.Left = 30;
            p.Top = 30;

            int[] x = new int[3];
            string[] y = new string[3];
            string comida = "agua,refri,suco";
            y = comida.Split(',');
            MessageBox.Show(y[1].ToLower());
        }
    }
}

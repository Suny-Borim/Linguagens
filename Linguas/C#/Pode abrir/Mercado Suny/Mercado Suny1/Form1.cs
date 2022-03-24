using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Suny1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if(txtBoxAdditem.Text != "")
            {
                ListaItems.Items.Add(txtBoxAdditem.Text);
            }
        }
    }
}

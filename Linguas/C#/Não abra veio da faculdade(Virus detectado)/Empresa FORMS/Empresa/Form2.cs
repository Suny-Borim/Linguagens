using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class formAdm : Form
    {
        List<funcionario> Lista;
        public string nome { get;private set; }
        public formAdm(string nome,List<funcionario> funcionarios)
        {
            InitializeComponent();
            Lista = funcionarios;
            lblAdm.Text = nome;
            Lista = funcionarios;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Quantidade de funcionarios
            MessageBox.Show(Lista.Count.ToString());
        }
    }
}

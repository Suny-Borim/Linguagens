using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDprodutos
{
    public partial class Form2 : Form
    {
        produto Produto { get; set; }
        public Form2(produto aProduto)
        {
            InitializeComponent();
            Produto = aProduto;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtNome.Text = Produto.nome;
            txtPreco.Text = Produto.preco;
        }
    }
}

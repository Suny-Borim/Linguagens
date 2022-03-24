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
    public partial class Form1 : Form
    {
        List<produto> produtos = new List<produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttSavar_Click(object sender, EventArgs e)
        {
            produto produto = new produto(txtNomeProduto.Text, txtPreco.Text, txtDescricao.Text);
            produtos.Add(produto);
            cbxProdutos.Items.Add(produto.nome);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttInfo_Click(object sender, EventArgs e)
        {
            Form info = new Form2(produtos.ElementAt<produto>(cbxProdutos.SelectedIndex));
            info.ShowDialog();
        }
    }
}

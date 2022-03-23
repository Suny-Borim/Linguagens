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
    public partial class Form1 : Form
    {


        List<funcionario> ListaFuncionarios;
        public Form1()
        {
            InitializeComponent();
            ListaFuncionarios = new List<funcionario>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            funcionario Suny = new funcionario(ListaFuncionarios.Count+1, "Suny", "200.200.300-10",
                new Endereco("rua aconchoado", "10", "APT-32", "00005-100"));
                Dona.Text = Suny.name;
                ListaFuncionarios.Add(Suny);
        }

        private void BUTTON_SALVAR_Click(object sender, EventArgs e)
        {
            try
            {
                funcionario generico = new funcionario(
                    ListaFuncionarios.Count + 1,
                    txtNome.Text,
                    txtCpf.Text,
                    new Endereco(txtRua.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtCep.Text)
                    );

                ListaFuncionarios.Add(generico);
                txtNome.Text = "";
                txtCpf.Text = "";
                txtRua.Text = "";
                txtNumero.Text = "";
                txtCep.Text = "";
                txtComplemento.Text = "";
                MessageBox.Show("Funcionario cadastrado!");
                cbxFuncionarios.Items.Add(generico.name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void adm_Click(object sender, EventArgs e)
        {
            formAdm admin = new formAdm(Dona.Text,ListaFuncionarios);
            
            admin.ShowDialog();
        }
    }
}

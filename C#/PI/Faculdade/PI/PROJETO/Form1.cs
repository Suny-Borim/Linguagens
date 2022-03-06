using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodeOfWarServer;
using System.Windows.Forms;

namespace PROJETO
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void mostrarversão_Click(object sender, EventArgs e)
        {
            LbLVersão.Text = "Versão:"+Jogo.Versao;
            LbLCartas.Text = Jogo.ListarCartas();
        }

        private void LbLVersão_Click(object sender, EventArgs e)
        {

        }

        private void Listarpartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                listBoxPartidas.Items.Add(partidas[i]);
            }
        }

        private void IdNome_Click(object sender, EventArgs e)
        {
            string partida = listBoxPartidas.SelectedItem.ToString();
            string[] items = partida.Split(',');
            txtidpartida.Text = items[0];
            txtnome.Text = items[1];
        }
    }
}

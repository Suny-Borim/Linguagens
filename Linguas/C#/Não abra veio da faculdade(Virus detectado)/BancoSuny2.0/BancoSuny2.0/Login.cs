using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSuny2._0
{
    public partial class Login : Form
    {
        List<Conta> ListadeContas = new List<Conta>();
        public Login()
        {
            ListadeContas = new List<Conta>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta millie = new Conta(new Usuario("Millie", "666"),"10102020", "Miley Cyrus", "1010", "mileyCaguei@cuzcuz.juliette.org.senacsp.edu.com.br", 200);
            Conta BritineiSpeatss = new Conta(new Usuario("Millie", "666"), "10102020","Britiney Speachs", "0101", "britinitisti@gmail.com", 200);
            ListadeContas.Add(millie);
            ListadeContas.Add((BritineiSpeatss));
        }

        private void bttEntrar_Click(object sender, EventArgs e)
        {
            foreach(this.ListadeContas in ListadeContas)
        }
    }
}

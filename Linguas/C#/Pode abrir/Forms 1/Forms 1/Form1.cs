namespace Forms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
                Jogos.Items.Add(Jogos.Text);
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            if (Jogos.SelectedItem != null)
            {
                string jogo = Jogos.SelectedItem.ToString();
                MessageBox.Show("Parabens, você acaba de comprar " + jogo);
            }
            else
            MessageBox.Show("Escreva um jogo");

        }

        private void Jogos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
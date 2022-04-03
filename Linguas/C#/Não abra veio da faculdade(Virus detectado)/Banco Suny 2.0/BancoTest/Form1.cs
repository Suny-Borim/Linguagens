namespace BancoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttlogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }
    }
}
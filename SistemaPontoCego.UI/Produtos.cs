namespace EstiloUrbano.UI
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComprar1_Click(object sender, EventArgs e)
        {
            // O sistema checa a classe que você criou
            if (UsuarioSessao.EstaLogado)
            {
                // Se estiver logado, abre a tela de Compra
                Comprar telaCompra = new Comprar();
                telaCompra.Show();
                this.Hide();
            }
            else
            {
                // Se não estiver logado, manda para o Cadastro
                MessageBox.Show("Você precisa estar logado para comprar!");
                Cadastro telaCadastro = new Cadastro();
                telaCadastro.Show();
                this.Hide();
            }
        }

        private void Produtos_Click(object sender, EventArgs e)
        {

        }
    }
}

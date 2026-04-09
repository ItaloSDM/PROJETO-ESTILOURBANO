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
            if (UsuarioLogado.IsAutenticado)
            {
                // Adiciona o produto na nossa lista global
                UsuarioLogado.Carrinho.Add("Camisa Urbano");
                MessageBox.Show("Camisa Urbano adicionada ao carrinho!");
            }
            else
            {
                MessageBox.Show("Você precisa estar logado!");
                new Cadastro().Show();
                this.Hide();
            }
        }

        private void Produtos_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarCarrinho_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.IsAutenticado)
            {
                // Se estiver logado, abre a tela de Comprar.cs
                new Comprar().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Faça login para ver seu carrinho.");
                new Cadastro().Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }
    }
}

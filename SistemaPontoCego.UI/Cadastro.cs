using System;
using System.Windows.Forms;
using System.Data.SqlClient;       // Adicionado para o SQL
using EstiloUrbano.Infrastructure.Data; // Adicionado para achar sua conexão

namespace EstiloUrbano.UI
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        // --- BOTÃO DE LOGIN (button1) ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtEmailLogin.Text.Contains("@"))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.");
                return;
            }

            try
            {
                using (SqlConnection conexao = DbConnection.GetConnection())
                {
                    // Busca o usuário no banco de dados
                    string query = "SELECT IdUsuario, Nome FROM Usuarios WHERE Email = @email AND Senha = @senha";
                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@email", txtEmailLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Se encontrou alguém no banco
                    {
                        // Salva quem logou para usar na tela de pagamento depois
                        UsuarioLogado.IsAutenticado = true;
                        UsuarioLogado.Nome = reader["Nome"].ToString();
                        // Dica: Se você tiver UsuarioLogado.Id, salve aqui também: 
                        // UsuarioLogado.Id = Convert.ToInt32(reader["IdUsuario"]);

                        MessageBox.Show("Login realizado com sucesso!");
                        new Produtos().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email ou Senha incorretos!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no banco: " + ex.Message);
            }
        }

        // --- BOTÃO DE CADASTRO (button2) ---
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCadastro.Text) || string.IsNullOrWhiteSpace(txtEmailCadastro.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }

            try
            {
                using (SqlConnection conexao = DbConnection.GetConnection())
                {
                    // COMANDO PARA SALVAR NO SQL SERVER
                    string query = "INSERT INTO Usuarios (Nome, Email, Senha, DataCadastro) VALUES (@nome, @email, @senha, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", txtNomeCadastro.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenhaCadastro.Text);

                    cmd.ExecuteNonQuery(); // Grava no banco!
                }

                MessageBox.Show("Cadastro realizado e salvo no Banco de Dados!");

                // Define quem está logado após cadastrar
                UsuarioLogado.IsAutenticado = true;
                UsuarioLogado.Nome = txtNomeCadastro.Text;

                new Produtos().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cadastro: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void Cadastro_Load(object sender, EventArgs e) { }
    }
}
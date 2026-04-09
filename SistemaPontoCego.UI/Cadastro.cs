using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using EstiloUrbano.Infrastructure.Data;

namespace EstiloUrbano.UI
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        // --- BOTÃO DE LOGIN ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailLogin.Text))
            {
                MessageBox.Show("Insira o e-mail.");
                return;
            }

            try
            {
                using (SqlConnection conexao = DbConnection.GetConnection())
                {
                    // Buscamos o IdUsuario e o Nome do banco
                    string query = "SELECT IdUsuario, Nome FROM Usuarios WHERE Email = @email AND Senha = @senha";
                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@email", txtEmailLogin.Text.Trim());
                    cmd.Parameters.AddWithValue("@senha", txtSenhaLogin.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // ATUALIZAÇÃO: Guardamos o ID e o Nome na sessão
                            UsuarioLogado.IsAutenticado = true;
                            UsuarioLogado.Nome = reader["Nome"].ToString();
                            UsuarioLogado.Id = Convert.ToInt32(reader["IdUsuario"]);

                            MessageBox.Show($"Bem-vindo, {UsuarioLogado.Nome}!");
                            new Produtos().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou Senha incorretos!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        // --- BOTÃO DE CADASTRO ---
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCadastro.Text) || string.IsNullOrWhiteSpace(txtEmailCadastro.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                using (SqlConnection conexao = DbConnection.GetConnection())
                {
                    string query = "INSERT INTO Usuarios (Nome, Email, Senha) VALUES (@nome, @email, @senha)";
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNomeCadastro.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmailCadastro.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", txtSenhaCadastro.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cadastro realizado! Por favor, faça login para continuar.");
                // Limpa os campos para o usuário logar
                txtNomeCadastro.Clear();
                txtEmailCadastro.Clear();
                txtSenhaCadastro.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void Cadastro_Load(object sender, EventArgs e) { }
    }
}
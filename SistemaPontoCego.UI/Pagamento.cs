using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using EstiloUrbano.Infrastructure.Data;

namespace EstiloUrbano.UI
{
    public partial class Pagamento : Form
    {
        string modoSelecionado = "";

        public Pagamento(string valorDaCompra)
        {
            InitializeComponent();
            label2.Text = valorDaCompra;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            modoSelecionado = "PIX";
            MessageBox.Show("Selecionado: PIX");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            modoSelecionado = "Cartão de Crédito";
            MessageBox.Show("Selecionado: Cartão");
        }

        private void pictureBoxBoleto_Click(object sender, EventArgs e)
        {
            modoSelecionado = "Boleto Bancário";
            MessageBox.Show("Selecionado: Boleto");
        }

        // --- BOTÃO CONFIRMAR PAGAMENTO ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modoSelecionado))
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                return;
            }

            try
            {
                using (SqlConnection conexao = DbConnection.GetConnection())
                {
                    // ATUALIZAÇÃO: Agora enviamos o IdUsuario capturado no login
                    string query = "INSERT INTO Vendas (IdUsuario, ValorTotal, MetodoPagamento) VALUES (@id, @valor, @metodo)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        // Aqui o @id recebe o valor que guardamos na classe UsuarioLogado
                        cmd.Parameters.AddWithValue("@id", UsuarioLogado.Id);
                        cmd.Parameters.AddWithValue("@valor", label2.Text.Replace("R$", "").Trim());
                        cmd.Parameters.AddWithValue("@metodo", modoSelecionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Sucesso! Venda registrada para o cliente {UsuarioLogado.Nome}.");

                new Produtos().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar venda: " + ex.Message);
            }
        }

        private void Pagamento_Load(object sender, EventArgs e) { }
    }
}
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
            MessageBox.Show("Você selecionou: PIX");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            modoSelecionado = "Cartão de Crédito";
            MessageBox.Show("Você selecionou: Cartão");
        }

        private void pictureBoxBoleto_Click(object sender, EventArgs e)
        {
            modoSelecionado = "Boleto Bancário";
            MessageBox.Show("Você selecionou: Boleto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modoSelecionado))
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento!");
                return;
            }

            try
            {
                using (SqlConnection conexao = DbConnection.GetConnection())
                {
                    string query = "INSERT INTO Vendas (ValorTotal, MetodoPagamento, DataVenda) VALUES (@valor, @metodo, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@valor", label2.Text);
                        cmd.Parameters.AddWithValue("@metodo", modoSelecionado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venda salva com sucesso!");
                Produtos telaLoja = new Produtos();
                telaLoja.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void Pagamento_Load(object sender, EventArgs e) { }
    } // Aqui fecha a classe
} // Aqui fecha o namespace
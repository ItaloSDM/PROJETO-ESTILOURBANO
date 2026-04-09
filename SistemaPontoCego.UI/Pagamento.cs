using System;
using System.Windows.Forms;

namespace EstiloUrbano.UI
{
    public partial class Pagamento : Form
    {
        // Variável que guarda o modo de pagamento escolhido
        string modoSelecionado = "";

        // CONSTRUTOR: Recebe o valor total da tela de compra
        public Pagamento(string valorDaCompra)
        {
            InitializeComponent();

            // Exibe "Total : " mais o valor que veio da label23
            label2.Text = "Total : " + valorDaCompra;
        }

        // --- EVENTOS DE CLIQUE NAS IMAGENS ---

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

        // --- BOTÃO CONFIRMAR PAGAMENTO (button1) ---

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Verifica se algo foi selecionado
            if (string.IsNullOrEmpty(modoSelecionado))
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento antes de confirmar!");
                return;
            }

            // 2. Mostra a mensagem de finalização
            MessageBox.Show($"Compra realizada com sucesso!\n{label2.Text}\nForma: {modoSelecionado}\n\nVoltando para a loja...");

            // 3. Abre a tela inicial de Produtos
            Produtos telaLoja = new Produtos();
            telaLoja.Show();

            // 4. Fecha a tela de pagamento (encerrando o processo)
            this.Close();
        }
    }
}
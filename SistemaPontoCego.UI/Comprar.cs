using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstiloUrbano.UI
{
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            // ... seus códigos de panel.Visible aqui ...

            // ESSA LINHA ABAIXO LIMPA OS VALORES ANTIGOS E COLOCA OS REAIS:
            AtualizarValores();
        }

        private void AtualizarValores()
        {
            double precoUnitario = 129.99;
            int totalItens = 0;

            if (UsuarioLogado.Carrinho.Contains("Moletom Urbano")) totalItens += UsuarioLogado.QtdMoletom;
            if (UsuarioLogado.Carrinho.Contains("Calça Urbano")) totalItens += UsuarioLogado.QtdCalca;
            if (UsuarioLogado.Carrinho.Contains("Short Urbano")) totalItens += UsuarioLogado.QtdShort;
            if (UsuarioLogado.Carrinho.Contains("Camisa Urbano")) totalItens += UsuarioLogado.QtdCamisa;

            double totalGeral = totalItens * precoUnitario;

            label17.Text = totalGeral.ToString("C2"); // Subtotal
            label23.Text = totalGeral.ToString("C2"); // Total

            // Labels do meio (os números 1, 2, 3...)
            label4.Text = UsuarioLogado.QtdMoletom.ToString();
            label6.Text = UsuarioLogado.QtdCalca.ToString();
            label10.Text = UsuarioLogado.QtdShort.ToString();
            label14.Text = UsuarioLogado.QtdCamisa.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioLogado.QtdMoletom++;
            AtualizarValores();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioLogado.QtdCalca++;
            AtualizarValores();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UsuarioLogado.QtdShort++;
            AtualizarValores();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UsuarioLogado.QtdCamisa++;
            AtualizarValores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.QtdMoletom > 0)
            {
                UsuarioLogado.QtdMoletom--;
                AtualizarValores();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.QtdCalca > 0)
            {
                UsuarioLogado.QtdCalca--;
                AtualizarValores();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.QtdShort > 0)
            {
                UsuarioLogado.QtdShort--;
                AtualizarValores();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.QtdCamisa > 0)
            {
                UsuarioLogado.QtdCamisa--;
                AtualizarValores();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstiloUrbano.UI
{
    public partial class Cadastro : Form
    {
        private string emailCadastrado;
        private string senhaCadastrada;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validação do '@' no login
            if (!txtEmailLogin.Text.Contains("@"))
            {
                MessageBox.Show("Por favor, insira um e-mail válido para logar.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 2. Comparação com os dados salvos
            if (txtEmailLogin.Text == emailCadastrado && txtSenhaLogin.Text == senhaCadastrada)
            {
                MessageBox.Show("Login realizado!");
                new Produtos().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados incorretos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Verificação de campos vazios
            if (string.IsNullOrWhiteSpace(txtNomeCadastro.Text) ||
                 string.IsNullOrWhiteSpace(txtEmailCadastro.Text) ||
                 string.IsNullOrWhiteSpace(txtCpf.Text) ||
                 string.IsNullOrWhiteSpace(txtSenhaCadastro.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validação do '@' no e-mail do cadastro
            if (!txtEmailCadastro.Text.Contains("@"))
            {
                MessageBox.Show("O e-mail de cadastro precisa ser válido (conter '@')!", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailCadastro.Focus();
                return;
            }

            // ... (resto do seu código de salvar nas variáveis globais e MessageBox de sucesso)
            emailCadastrado = txtEmailCadastro.Text;
            senhaCadastrada = txtSenhaCadastro.Text;

            MessageBox.Show("Cadastrado com sucesso!");
            // (Limpar campos...)
        }
    }
}

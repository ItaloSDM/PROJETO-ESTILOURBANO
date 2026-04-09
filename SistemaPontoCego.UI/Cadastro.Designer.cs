namespace EstiloUrbano.UI
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btnEntrar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSenhaLogin = new TextBox();
            txtEmailLogin = new TextBox();
            panel1 = new Panel();
            txtCpf = new MaskedTextBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtSenhaCadastro = new TextBox();
            txtEmailCadastro = new TextBox();
            txtNomeCadastro = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSenhaLogin);
            panel2.Controls.Add(txtEmailLogin);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(50, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 280);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(32, 33, 36);
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.Gold;
            btnEntrar.Location = new Point(66, 220);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(114, 43);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button1_Click;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.MenuBar;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 33, 36);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(85, 65);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 2;
            label4.Text = "Entrar";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 33, 36);
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 23);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 2;
            label3.Text = "Bem - Vindo!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 33, 36);
            label2.CausesValidation = false;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 110);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 33, 36);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 170);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Senha";
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.FromArgb(45, 50, 56);
            txtSenhaLogin.BorderStyle = BorderStyle.None;
            txtSenhaLogin.ForeColor = Color.White;
            txtSenhaLogin.Location = new Point(31, 188);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PasswordChar = '*';
            txtSenhaLogin.Size = new Size(188, 16);
            txtSenhaLogin.TabIndex = 1;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BackColor = Color.FromArgb(45, 50, 56);
            txtEmailLogin.BorderStyle = BorderStyle.None;
            txtEmailLogin.ForeColor = Color.White;
            txtEmailLogin.Location = new Point(31, 128);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(188, 16);
            txtEmailLogin.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSenhaCadastro);
            panel1.Controls.Add(txtEmailCadastro);
            panel1.Controls.Add(txtNomeCadastro);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(384, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 346);
            panel1.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.FromArgb(45, 50, 56);
            txtCpf.BorderStyle = BorderStyle.None;
            txtCpf.ForeColor = Color.White;
            txtCpf.Location = new Point(33, 209);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(186, 16);
            txtCpf.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 33, 36);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(22, 297);
            button2.Name = "button2";
            button2.Size = new Size(207, 37);
            button2.TabIndex = 3;
            button2.Text = "Finalizar Cadastro";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.MenuBar;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 33, 36);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(67, 56);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 2;
            label5.Text = "Criar Conta";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(32, 33, 36);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 14);
            label6.Name = "label6";
            label6.Size = new Size(221, 32);
            label6.TabIndex = 2;
            label6.Text = "Cadastro de conta";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(32, 33, 36);
            label10.CausesValidation = false;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(31, 143);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 2;
            label10.Text = "E-mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(32, 33, 36);
            label7.CausesValidation = false;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 89);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 2;
            label7.Text = "Nome";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(32, 33, 36);
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(31, 246);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 2;
            label9.Text = "Senha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(32, 33, 36);
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(31, 194);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 2;
            label8.Text = "CPF";
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.BackColor = Color.FromArgb(45, 50, 56);
            txtSenhaCadastro.BorderStyle = BorderStyle.None;
            txtSenhaCadastro.ForeColor = Color.White;
            txtSenhaCadastro.Location = new Point(31, 264);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PasswordChar = '*';
            txtSenhaCadastro.Size = new Size(188, 16);
            txtSenhaCadastro.TabIndex = 1;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.BackColor = Color.FromArgb(45, 50, 56);
            txtEmailCadastro.BorderStyle = BorderStyle.None;
            txtEmailCadastro.ForeColor = Color.White;
            txtEmailCadastro.Location = new Point(31, 161);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(188, 16);
            txtEmailCadastro.TabIndex = 1;
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.BackColor = Color.FromArgb(45, 50, 56);
            txtNomeCadastro.BorderStyle = BorderStyle.None;
            txtNomeCadastro.ForeColor = Color.White;
            txtNomeCadastro.Location = new Point(31, 107);
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.Size = new Size(188, 16);
            txtNomeCadastro.TabIndex = 1;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(693, 370);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(32, 33, 36);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox txtSenhaLogin;
        private TextBox txtEmailLogin;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btnEntrar;
        private Panel panel1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNomeCadastro;
        private TextBox txtSenhaCadastro;
        private Label label9;
        private TextBox txtEmailCadastro;
        private Label label10;
        private MaskedTextBox txtCpf;
    }
}
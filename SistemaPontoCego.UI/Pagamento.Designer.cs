namespace EstiloUrbano.UI
{
    partial class Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            panel3 = new Panel();
            pictureBoxBoleto = new PictureBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoleto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 195);
            panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(207, 122);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(32, 33, 36);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(85, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 28);
            textBox2.TabIndex = 4;
            textBox2.Text = "PIX";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 159);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 5;
            label1.Text = "(Aprovação Imediata)";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(273, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(213, 195);
            panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-231, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(207, 122);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(207, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 33, 36);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(30, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "Cartão De Crédito";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBoxBoleto);
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(508, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(213, 195);
            panel3.TabIndex = 1;
            // 
            // pictureBoxBoleto
            // 
            pictureBoxBoleto.Image = (Image)resources.GetObject("pictureBoxBoleto.Image");
            pictureBoxBoleto.Location = new Point(3, 0);
            pictureBoxBoleto.Name = "pictureBoxBoleto";
            pictureBoxBoleto.Size = new Size(207, 122);
            pictureBoxBoleto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBoleto.TabIndex = 0;
            pictureBoxBoleto.TabStop = false;
            pictureBoxBoleto.Click += pictureBoxBoleto_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(32, 33, 36);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.Window;
            textBox4.Location = new Point(36, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 26);
            textBox4.TabIndex = 4;
            textBox4.Text = "Boleto Bancário";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(32, 33, 36);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.Window;
            textBox5.Location = new Point(193, 29);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(380, 50);
            textBox5.TabIndex = 4;
            textBox5.Text = "Escolha o Pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(303, 345);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 5;
            label2.Text = "Total label2";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(260, 380);
            button1.Name = "button1";
            button1.Size = new Size(259, 38);
            button1.TabIndex = 6;
            button1.Text = "Confirmar Pagamento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(764, 429);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pagamento";
            Padding = new Padding(8);
            Text = "Pagamento";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoleto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private PictureBox pictureBoxBoleto;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private Label label2;
        private Button button1;
    }
}
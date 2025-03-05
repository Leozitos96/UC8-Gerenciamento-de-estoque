namespace GerenciamentoDeEstoque
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            button2 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(213, 29);
            label1.Name = "label1";
            label1.Size = new Size(126, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(674, 195);
            label2.Name = "label2";
            label2.Size = new Size(100, 27);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(674, 302);
            label3.Name = "label3";
            label3.Size = new Size(83, 27);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(672, 482);
            label4.Name = "label4";
            label4.Size = new Size(185, 18);
            label4.TabIndex = 3;
            label4.Text = "Ainda não tem cadastro?,";
            label4.Click += label4_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.Location = new Point(674, 225);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(270, 27);
            textBoxUsuario.TabIndex = 4;
            textBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.None;
            textBoxSenha.BackColor = Color.White;
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.Cursor = Cursors.IBeam;
            textBoxSenha.Location = new Point(674, 332);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(270, 27);
            textBoxSenha.TabIndex = 5;
            textBoxSenha.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(178, 201, 171);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(761, 398);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 201, 171);
            label5.Location = new Point(852, 482);
            label5.Name = "label5";
            label5.Size = new Size(92, 18);
            label5.TabIndex = 8;
            label5.Text = "Clique aqui!";
            label5.Click += label5_Click;
            label5.MouseClick += label5_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 106, 134);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 721);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(144, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 256);
            panel2.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 721);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button button2;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
    }
}

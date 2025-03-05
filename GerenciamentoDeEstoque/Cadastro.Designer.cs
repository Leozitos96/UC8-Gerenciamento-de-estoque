
namespace GerenciamentoDeEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            label1 = new Label();
            button2 = new Button();
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textBoxConfirmarSenha = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 29);
            label1.Name = "label1";
            label1.Size = new Size(192, 46);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(178, 201, 171);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(795, 511);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.None;
            textBoxSenha.BackColor = Color.White;
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.Cursor = Cursors.IBeam;
            textBoxSenha.Location = new Point(659, 274);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(270, 27);
            textBoxSenha.TabIndex = 15;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.Location = new Point(659, 202);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(270, 27);
            textBoxUsuario.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(659, 244);
            label3.Name = "label3";
            label3.Size = new Size(83, 27);
            label3.TabIndex = 11;
            label3.Text = "Senha";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(659, 172);
            label2.Name = "label2";
            label2.Size = new Size(100, 27);
            label2.TabIndex = 10;
            label2.Text = "Usuario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.TabIndex = 18;
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
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Anchor = AnchorStyles.None;
            textBoxConfirmarSenha.BackColor = Color.White;
            textBoxConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxConfirmarSenha.Cursor = Cursors.IBeam;
            textBoxConfirmarSenha.Location = new Point(659, 351);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(270, 27);
            textBoxConfirmarSenha.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(659, 321);
            label5.Name = "label5";
            label5.Size = new Size(200, 27);
            label5.TabIndex = 19;
            label5.Text = "Confirmar Senha";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(178, 201, 171);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(677, 511);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(659, 396);
            label4.Name = "label4";
            label4.Size = new Size(79, 27);
            label4.TabIndex = 26;
            label4.Text = "Cargo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vendedor", "Administrador" });
            comboBox1.Location = new Point(659, 426);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 28);
            comboBox1.TabIndex = 27;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 721);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Cadastro";
            Text = "Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private TextBox textBoxSenha;
        private TextBox textBoxUsuario;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxConfirmarSenha;
        private Label label5;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
    }
}
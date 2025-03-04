namespace GerenciamentoDeEstoque
{
    partial class CadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNome = new TextBox();
            textBoxPreco = new TextBox();
            textBoxCodigo = new TextBox();
            buttonFinalizar = new Button();
            buttonCancelar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 15);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 0;
            label1.Text = "Preencha os campos!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(220, 82);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome do produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(382, 82);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(220, 141);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 3;
            label4.Text = "Preco";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(382, 141);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 4;
            label5.Text = "Codigo";
            label5.Click += label5_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Location = new Point(220, 105);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(138, 27);
            textBoxNome.TabIndex = 5;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPreco
            // 
            textBoxPreco.BorderStyle = BorderStyle.FixedSingle;
            textBoxPreco.Cursor = Cursors.IBeam;
            textBoxPreco.Location = new Point(220, 162);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(138, 27);
            textBoxPreco.TabIndex = 7;
            textBoxPreco.TextChanged += textBox3_TextChanged;
            textBoxPreco.KeyPress += textBoxPreco_KeyPress;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigo.Cursor = Cursors.IBeam;
            textBoxCodigo.Location = new Point(381, 162);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(138, 27);
            textBoxCodigo.TabIndex = 8;
            textBoxCodigo.TextChanged += textBox4_TextChanged;
            textBoxCodigo.KeyPress += textBoxCodigo_KeyPress;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(178, 201, 171);
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.FlatAppearance.BorderSize = 0;
            buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonFinalizar.Location = new Point(383, 236);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(92, 29);
            buttonFinalizar.TabIndex = 9;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += button1_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(178, 201, 171);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(265, 236);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(92, 29);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 106, 134);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 305);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(30, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 128);
            panel2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 15);
            label6.Name = "label6";
            label6.Size = new Size(180, 24);
            label6.TabIndex = 12;
            label6.Text = "Adicionar produto";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownQuantidade.Location = new Point(381, 103);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(138, 27);
            numericUpDownQuantidade.TabIndex = 12;
            // 
            // CadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 302);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(panel1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonFinalizar);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroProdutos";
            Text = "CadastroProdutos";
            Load += CadastroProdutos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNome;
        private TextBox textBoxPreco;
        private TextBox textBoxCodigo;
        private Button buttonFinalizar;
        private Button buttonCancelar;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private NumericUpDown numericUpDownQuantidade;
    }
}
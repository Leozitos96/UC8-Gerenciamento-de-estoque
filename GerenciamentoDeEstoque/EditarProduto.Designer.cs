namespace GerenciamentoDeEstoque
{
    partial class EditarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProduto));
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBoxCodigo = new TextBox();
            textBoxPreco = new TextBox();
            textBoxNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 106, 134);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 305);
            panel1.TabIndex = 23;
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
            label6.Location = new Point(24, 15);
            label6.Name = "label6";
            label6.Size = new Size(147, 24);
            label6.TabIndex = 12;
            label6.Text = "Editar produto";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(178, 201, 171);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(265, 235);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 22;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(178, 201, 171);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(383, 235);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 21;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigo.Cursor = Cursors.No;
            textBoxCodigo.Enabled = false;
            textBoxCodigo.Location = new Point(381, 161);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.ReadOnly = true;
            textBoxCodigo.Size = new Size(138, 27);
            textBoxCodigo.TabIndex = 20;
            // 
            // textBoxPreco
            // 
            textBoxPreco.BorderStyle = BorderStyle.FixedSingle;
            textBoxPreco.Cursor = Cursors.IBeam;
            textBoxPreco.Location = new Point(220, 161);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(138, 27);
            textBoxPreco.TabIndex = 19;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Cursor = Cursors.No;
            textBoxNome.Enabled = false;
            textBoxNome.Location = new Point(220, 104);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.ReadOnly = true;
            textBoxNome.Size = new Size(138, 27);
            textBoxNome.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(382, 140);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 16;
            label5.Text = "Codigo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(220, 140);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 15;
            label4.Text = "Preco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(382, 81);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 14;
            label3.Text = "Quantidade";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(220, 81);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 13;
            label2.Text = "Nome do produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 14);
            label1.Name = "label1";
            label1.Size = new Size(174, 24);
            label1.TabIndex = 12;
            label1.Text = "Edite os campos!";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownQuantidade.Location = new Point(381, 102);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(138, 27);
            numericUpDownQuantidade.TabIndex = 24;
            // 
            // EditarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 302);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarProduto";
            Text = "EditarProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Button button2;
        private Button button1;
        private TextBox textBoxCodigo;
        private TextBox textBoxPreco;
        private TextBox textBoxNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownQuantidade;
    }
}
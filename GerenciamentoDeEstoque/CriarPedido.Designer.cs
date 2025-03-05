namespace GerenciamentoDeEstoque
{
    partial class CriarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarPedido));
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            buttonCancelar = new Button();
            buttonFinalizar = new Button();
            textBoxNomeCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            comboBoxProdutos = new ComboBox();
            maskedTextBoxCpf = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 106, 134);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, -1);
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
            label6.Location = new Point(13, 15);
            label6.Name = "label6";
            label6.Size = new Size(169, 24);
            label6.TabIndex = 12;
            label6.Text = "Adicionar pedido";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(178, 201, 171);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(266, 235);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(92, 29);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(178, 201, 171);
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.FlatAppearance.BorderSize = 0;
            buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonFinalizar.Location = new Point(384, 235);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(92, 29);
            buttonFinalizar.TabIndex = 21;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeCliente.Cursor = Cursors.IBeam;
            textBoxNomeCliente.Location = new Point(221, 104);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(138, 27);
            textBoxNomeCliente.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(383, 140);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 17;
            label5.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(221, 140);
            label4.Name = "label4";
            label4.Size = new Size(38, 18);
            label4.TabIndex = 16;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(383, 81);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 15;
            label3.Text = "Quantidade";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(221, 81);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 14;
            label2.Text = "Nome do Cliente";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 14);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 13;
            label1.Text = "Preencha os campos!";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownQuantidade.Location = new Point(382, 102);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(138, 27);
            numericUpDownQuantidade.TabIndex = 24;
            numericUpDownQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxProdutos
            // 
            comboBoxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProdutos.FormattingEnabled = true;
            comboBoxProdutos.Location = new Point(382, 161);
            comboBoxProdutos.Name = "comboBoxProdutos";
            comboBoxProdutos.Size = new Size(138, 28);
            comboBoxProdutos.TabIndex = 25;
            comboBoxProdutos.KeyPress += comboBoxProdutos_KeyPress;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(221, 162);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(138, 27);
            maskedTextBoxCpf.TabIndex = 26;
            // 
            // CriarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 302);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(comboBoxProdutos);
            Controls.Add(panel1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonFinalizar);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownQuantidade);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CriarPedido";
            Text = "CriarPedido";
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
        private Button buttonCancelar;
        private Button buttonFinalizar;
        private TextBox textBoxCpf;
        private TextBox textBoxNomeCliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownQuantidade;
        private ComboBox comboBoxProdutos;
        private MaskedTextBox maskedTextBoxCpf;
    }
}
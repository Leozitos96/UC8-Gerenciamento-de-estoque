namespace GerenciamentoDeEstoque
{
    partial class InicioForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CLIENTE = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            PRODUTO = new DataGridViewTextBoxColumn();
            PRECO = new DataGridViewTextBoxColumn();
            VALOR = new DataGridViewTextBoxColumn();
            QUANTIDADE = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(146, 182, 177);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 56);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 27);
            label1.TabIndex = 1;
            label1.Text = "Ultimos pedidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, CLIENTE, CPF, PRODUTO, PRECO, VALOR, QUANTIDADE });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(178, 201, 171);
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 665);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 20F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            ID.Width = 90;
            // 
            // CLIENTE
            // 
            CLIENTE.HeaderText = "CLIENTE";
            CLIENTE.MinimumWidth = 6;
            CLIENTE.Name = "CLIENTE";
            CLIENTE.ReadOnly = true;
            CLIENTE.Resizable = DataGridViewTriState.False;
            CLIENTE.Width = 130;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.MinimumWidth = 6;
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            CPF.Resizable = DataGridViewTriState.False;
            CPF.Width = 120;
            // 
            // PRODUTO
            // 
            PRODUTO.HeaderText = "PRODUTO";
            PRODUTO.MinimumWidth = 6;
            PRODUTO.Name = "PRODUTO";
            PRODUTO.ReadOnly = true;
            PRODUTO.Resizable = DataGridViewTriState.False;
            PRODUTO.Width = 120;
            // 
            // PRECO
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            PRECO.DefaultCellStyle = dataGridViewCellStyle2;
            PRECO.HeaderText = "PRECO(U)";
            PRECO.MinimumWidth = 6;
            PRECO.Name = "PRECO";
            PRECO.ReadOnly = true;
            PRECO.Resizable = DataGridViewTriState.False;
            PRECO.Width = 120;
            // 
            // VALOR
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            VALOR.DefaultCellStyle = dataGridViewCellStyle3;
            VALOR.HeaderText = "TOTAL";
            VALOR.MinimumWidth = 6;
            VALOR.Name = "VALOR";
            VALOR.ReadOnly = true;
            VALOR.Resizable = DataGridViewTriState.False;
            VALOR.Width = 120;
            // 
            // QUANTIDADE
            // 
            QUANTIDADE.HeaderText = "QUANTIDADE";
            QUANTIDADE.MinimumWidth = 6;
            QUANTIDADE.Name = "QUANTIDADE";
            QUANTIDADE.ReadOnly = true;
            QUANTIDADE.Resizable = DataGridViewTriState.False;
            QUANTIDADE.Width = 110;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(797, 721);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioForm";
            Text = "InicioForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CLIENTE;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn PRODUTO;
        private DataGridViewTextBoxColumn PRECO;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn QUANTIDADE;
    }
}
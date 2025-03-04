namespace GerenciamentoDeEstoque
{
    partial class ProdutosFrom
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
            panel1 = new Panel();
            label1 = new Label();
            flowProdutos = new FlowLayoutPanel();
            panel1.SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 1;
            label1.Text = "Produtos";
            // 
            // flowProdutos
            // 
            flowProdutos.BackColor = Color.WhiteSmoke;
            flowProdutos.Dock = DockStyle.Fill;
            flowProdutos.Location = new Point(0, 56);
            flowProdutos.Name = "flowProdutos";
            flowProdutos.Size = new Size(797, 617);
            flowProdutos.TabIndex = 3;
            flowProdutos.Paint += flowProdutos_Paint;
            // 
            // ProdutosFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 673);
            Controls.Add(flowProdutos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProdutosFrom";
            Text = "ProdutosFrom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowProdutos;
    }
}
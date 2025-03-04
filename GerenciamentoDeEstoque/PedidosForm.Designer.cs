namespace GerenciamentoDeEstoque
{
    partial class PedidosForm
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
            flowPedidos = new FlowLayoutPanel();
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
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 1;
            label1.Text = "Pedidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // flowPedidos
            // 
            flowPedidos.BackColor = Color.WhiteSmoke;
            flowPedidos.Dock = DockStyle.Fill;
            flowPedidos.Location = new Point(0, 0);
            flowPedidos.Name = "flowPedidos";
            flowPedidos.Size = new Size(797, 673);
            flowPedidos.TabIndex = 7;
            // 
            // PedidosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 673);
            Controls.Add(panel1);
            Controls.Add(flowPedidos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PedidosForm";
            Text = "PedidosForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowPedidos;
    }
}
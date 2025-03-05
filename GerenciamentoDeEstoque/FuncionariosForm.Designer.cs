namespace GerenciamentoDeEstoque
{
    partial class FuncionariosForm
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
            flowFuncionarios = new FlowLayoutPanel();
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
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 27);
            label1.TabIndex = 1;
            label1.Text = "Funcionarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowFuncionarios
            // 
            flowFuncionarios.AutoScroll = true;
            flowFuncionarios.BackColor = Color.WhiteSmoke;
            flowFuncionarios.Dock = DockStyle.Bottom;
            flowFuncionarios.Location = new Point(0, 55);
            flowFuncionarios.Name = "flowFuncionarios";
            flowFuncionarios.Size = new Size(797, 666);
            flowFuncionarios.TabIndex = 9;
            flowFuncionarios.Paint += flowFuncionarios_Paint;
            // 
            // FuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 721);
            Controls.Add(panel1);
            Controls.Add(flowFuncionarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionariosForm";
            Text = "FuncionariosForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowFuncionarios;
    }
}
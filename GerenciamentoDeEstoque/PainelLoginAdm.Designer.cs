
namespace GerenciamentoDeEstoque
{
    partial class PainelLoginAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelLoginAdm));
            panelBotoes = new Panel();
            buttonSair = new Button();
            buttonVendas = new Button();
            buttonProdutos = new Button();
            buttonFuncionarios = new Button();
            buttonHome = new Button();
            panel3 = new Panel();
            panelFormAtivo = new Panel();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = Color.FromArgb(102, 106, 134);
            panelBotoes.Controls.Add(buttonSair);
            panelBotoes.Controls.Add(buttonVendas);
            panelBotoes.Controls.Add(buttonProdutos);
            panelBotoes.Controls.Add(buttonFuncionarios);
            panelBotoes.Controls.Add(buttonHome);
            panelBotoes.Controls.Add(panel3);
            panelBotoes.Dock = DockStyle.Left;
            panelBotoes.Location = new Point(0, 0);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(209, 721);
            panelBotoes.TabIndex = 1;
            panelBotoes.Paint += panel1_Paint;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Transparent;
            buttonSair.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSair.Dock = DockStyle.Bottom;
            buttonSair.FlatAppearance.BorderSize = 0;
            buttonSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(146, 182, 177);
            buttonSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 138, 163);
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonSair.ForeColor = SystemColors.ControlText;
            buttonSair.Image = (Image)resources.GetObject("buttonSair.Image");
            buttonSair.ImageAlign = ContentAlignment.MiddleRight;
            buttonSair.Location = new Point(0, 643);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(209, 78);
            buttonSair.TabIndex = 12;
            buttonSair.Text = "Sair";
            buttonSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.BackColor = Color.Transparent;
            buttonVendas.BackgroundImageLayout = ImageLayout.Stretch;
            buttonVendas.Dock = DockStyle.Top;
            buttonVendas.FlatAppearance.BorderSize = 0;
            buttonVendas.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 183, 255);
            buttonVendas.FlatAppearance.MouseDownBackColor = Color.FromArgb(146, 182, 177);
            buttonVendas.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 138, 163);
            buttonVendas.FlatStyle = FlatStyle.Flat;
            buttonVendas.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonVendas.ForeColor = SystemColors.ControlText;
            buttonVendas.Image = (Image)resources.GetObject("buttonVendas.Image");
            buttonVendas.ImageAlign = ContentAlignment.MiddleRight;
            buttonVendas.Location = new Point(0, 318);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(209, 66);
            buttonVendas.TabIndex = 11;
            buttonVendas.Text = "Pedidos";
            buttonVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVendas.UseVisualStyleBackColor = false;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.Transparent;
            buttonProdutos.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProdutos.Dock = DockStyle.Top;
            buttonProdutos.FlatAppearance.BorderSize = 0;
            buttonProdutos.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 183, 255);
            buttonProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(146, 182, 177);
            buttonProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 138, 163);
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonProdutos.ForeColor = SystemColors.ControlText;
            buttonProdutos.Image = (Image)resources.GetObject("buttonProdutos.Image");
            buttonProdutos.ImageAlign = ContentAlignment.MiddleRight;
            buttonProdutos.Location = new Point(0, 252);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(209, 66);
            buttonProdutos.TabIndex = 10;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonFuncionarios
            // 
            buttonFuncionarios.BackColor = Color.Transparent;
            buttonFuncionarios.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFuncionarios.Dock = DockStyle.Top;
            buttonFuncionarios.FlatAppearance.BorderSize = 0;
            buttonFuncionarios.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 183, 255);
            buttonFuncionarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(146, 182, 177);
            buttonFuncionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 138, 163);
            buttonFuncionarios.FlatStyle = FlatStyle.Flat;
            buttonFuncionarios.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonFuncionarios.ForeColor = SystemColors.ControlText;
            buttonFuncionarios.Image = (Image)resources.GetObject("buttonFuncionarios.Image");
            buttonFuncionarios.ImageAlign = ContentAlignment.MiddleRight;
            buttonFuncionarios.Location = new Point(0, 186);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(209, 66);
            buttonFuncionarios.TabIndex = 9;
            buttonFuncionarios.Text = "Funcionarios";
            buttonFuncionarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFuncionarios.UseVisualStyleBackColor = false;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Transparent;
            buttonHome.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 183, 255);
            buttonHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(146, 182, 177);
            buttonHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 138, 163);
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = SystemColors.ControlText;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleRight;
            buttonHome.Location = new Point(0, 120);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(209, 66);
            buttonHome.TabIndex = 8;
            buttonHome.Text = "Inicio";
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 120);
            panel3.TabIndex = 3;
            // 
            // panelFormAtivo
            // 
            panelFormAtivo.Location = new Point(209, 0);
            panelFormAtivo.Name = "panelFormAtivo";
            panelFormAtivo.Size = new Size(797, 721);
            panelFormAtivo.TabIndex = 13;
            panelFormAtivo.Paint += panelFormAtivo_Paint;
            // 
            // PainelLoginAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1006, 721);
            Controls.Add(panelFormAtivo);
            Controls.Add(panelBotoes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PainelLoginAdm";
            Text = "PainelLoginAdm";
            Load += PainelLoginAdm_Load;
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotoes;
        private Panel panel3;
        private Button buttonHome;
        private Button buttonProdutos;
        private Button buttonFuncionarios;
        private Button buttonSair;
        private Button buttonVendas;
        private Panel panelFormAtivo;
    }
}
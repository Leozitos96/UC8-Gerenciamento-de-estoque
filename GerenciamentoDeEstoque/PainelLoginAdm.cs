using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque
{

    public partial class PainelLoginAdm : Form
    {
        private Form formAtivo;
        public PainelLoginAdm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ActiveFormClose();
            BotaoAtivo(buttonHome);
            FormShow(new InicioForm());
        }

        private void FormShow(Form form)
        {
            formAtivo = form;
            form.TopLevel = false;
            panelFormAtivo.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void ActiveFormClose()
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
        }
        private void BotaoAtivo(Button button)
        {
            foreach (Control control in panelBotoes.Controls)
            {
                control.ForeColor = Color.Black;
            }
            button.ForeColor = Color.White;
        }



        private void label4_Click(object sender, EventArgs e)
        {
            // LOGO
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Bem-vindo Usuario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // usuario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // função
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // botao de funcionario
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // botao de estoque
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // botao de vendas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botao de sair            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonHome);
            FormShow(new InicioForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonFuncionarios);

            FormShow(new FuncionariosForm());
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonProdutos);
            FormShow(new ProdutosFrom());
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonVendas);
            FormShow(new PedidosForm());
        }

        private void PainelLoginAdm_Load(object sender, EventArgs e)
        {

        }
    }
}

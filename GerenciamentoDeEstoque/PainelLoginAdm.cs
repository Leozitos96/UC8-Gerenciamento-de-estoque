using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque
{

    public partial class PainelLoginAdm : Form
    {
        private Thread thread;
        private Form formAtivo;
        public PainelLoginAdm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ActiveFormClose();
            BotaoAtivo(buttonHome);
            FormShow(new InicioForm());
        }

        //Abre um form dentro do form Inicial
        private void FormShow(Form form)
        {
            formAtivo = form;
            form.TopLevel = false;
            panelFormAtivo.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        //Fecha o antigo form antes de abrir o novo
        private void ActiveFormClose()
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
        }

        //Checa para ver qual botao esta ativo e muda ele de cor
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

        //Abre o form home dentro no Painel do administrador
        private void buttonHome_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonHome);
            FormShow(new InicioForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Abre o form funcionarios dentro no Painel do administrador
        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonFuncionarios);

            FormShow(new FuncionariosForm());
        }

        //Abre o form produtos dentro no Painel do administrador
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonProdutos);
            FormShow(new ProdutosFrom());
        }

        //Abre o form vendas dentro no Painel do administrador
        private void buttonVendas_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonVendas);
            FormShow(new PedidosForm());
        }

        private void PainelLoginAdm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //Botao para sair, apaga a sessao atual e volta para a tela de login
        private void buttonSair_Click(object sender, EventArgs e)
        {
            SessaoAtual.Usuario = "";
            SessaoAtual.Cargo = "";
            this.Close();
            thread = new Thread(AbrirLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AbrirLogin(object? obj)
        {
            Application.Run(new Login());
        }

        private void panelFormAtivo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

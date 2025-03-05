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
    public partial class PainelLoginVendedor : Form
    {

        private Form formAtivo;
        private Thread thread;
        public PainelLoginVendedor()
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

        private void label1_Click(object sender, EventArgs e)
        {
            // LOGO
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Bem-Vindo usuario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Usuario
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // vendedor
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // botao do Registro de vendas
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // botao do Historico de Estoque
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // botao de estoque
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botao de Sair           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {

        }

        private void panelFormAtivo_Paint(object sender, PaintEventArgs e)
        {

        }

        //Abre o form produtos dentro no Painel do vendedor
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonProdutos);
            FormShow(new ProdutosFrom());
        }

        //Abre o form home dentro no Painel do vendedor
        private void buttonHome_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonHome);
            FormShow(new InicioForm());
        }

        //Abre o form vendas dentro no Painel do vendedor
        private void buttonVendas_Click_1(object sender, EventArgs e)
        {
            ActiveFormClose();
            BotaoAtivo(buttonVendas);
            FormShow(new PedidosForm());
        }

        private void panelFormAtivo_Paint_1(object sender, PaintEventArgs e)
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

        //Metodo para abrir o form Login
        private void AbrirLogin(object? obj)
        {
            Application.Run(new Login());
        }
    }
}


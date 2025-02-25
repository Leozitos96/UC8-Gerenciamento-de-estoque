namespace GerenciamentoDeEstoque
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // LOGIN
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // login
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // caixa de login
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // senha
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // caixa de senha
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // ainda nao tem cadastro.            
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            // botao de clique aqui

            Cadastro cadastroForm = new Cadastro(); // Cria uma instância do formulário de cadastro
            cadastroForm.ShowDialog(); // Abre o formulário de cadastro como uma janela modal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // botao entrar
            PainelLoginAdm painelLoginAdmForm = new PainelLoginAdm(); // Cria uma instância do formulário de cadastro
            painelLoginAdmForm.ShowDialog(); // Abre o formulário de cadastro como uma janela modal
        }
    }
}


using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace GerenciamentoDeEstoque
{
    public partial class Login : Form
    {
        Thread thread;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.Close();
            thread = new Thread(AbrirTelaInicialAdm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            thread = new Thread(AbrirCadastro);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AbrirCadastro(Object obj)
        {
            Application.Run(new Cadastro());

        }
        private void AbrirTelaInicialAdm(Object obj)
        {
            Application.Run(new PainelLoginAdm());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}


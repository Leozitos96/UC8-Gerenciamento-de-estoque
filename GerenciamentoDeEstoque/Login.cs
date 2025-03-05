using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Data.Sqlite;

namespace GerenciamentoDeEstoque
{
    public partial class Login : Form
    {
        Thread thread;
        private Database database = new Database();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            atualizarContas();
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

            Cadastro cadastroForm = new Cadastro();
            cadastroForm.ShowDialog(); 
        }

        /*Faz um select e verifica todas as contas cadastradas antes do login*/
        private void atualizarContas()
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT * FROM Usuarios";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;
            }
        }

        /*Botao logar, verifica o USUARIO e SENHA se esta cadastrado no banco de dados, e separa os forms de tela inicial
         pelo CARGO, SessaoAtual recebe o USUARIO e CARGO para fazer checagem em outros lugares*/
        private void button2_Click(object sender, EventArgs e)
        {
            string senha = textBoxSenha.Text;
            string usuario = textBoxUsuario.Text;
            string cargo = database.ContaExistente(usuario, senha);
            
            if(cargo == "Administrador")
            {
                SessaoAtual.Usuario = usuario;
                SessaoAtual.Cargo = cargo;
                this.Close();
                thread = new Thread(AbrirTelaInicialAdm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (cargo == "Vendedor")
            {
                SessaoAtual.Usuario = usuario;
                SessaoAtual.Cargo = cargo;
                this.Close();
                thread = new Thread(AbrirTelaInicialVendedor);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
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

        /*Abre o form Cadastro caso ele clique em CLIQUE AQUI no form LOGIN*/
        private void AbrirCadastro(Object obj)
        {
            Application.Run(new Cadastro());

        }

        /*Abre o form TelaInicialAdm*/
        private void AbrirTelaInicialAdm(Object obj)
        {
            Application.Run(new PainelLoginAdm());
        }

        /*Abre o form TelaInicialVendedor*/
        private void AbrirTelaInicialVendedor(Object obj)
        {
            Application.Run(new PainelLoginVendedor());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}


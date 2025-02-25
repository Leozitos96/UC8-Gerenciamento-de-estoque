using Microsoft.Data.Sqlite;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GerenciamentoDeEstoque
{
    internal static class Program
    {
        [STAThread]
        static void Main(String[] args)
        {
            //ApplicationConfiguration.Initialize();
            //CriarTabelasNoBanco();
            Application.Run(new Login());

        }
        public class BancoDeDados
        {
            private SqliteConnection connection;

            public BancoDeDados()
            {
                connection = new SqliteConnection("Data Source=estoque.db;Version=3;");
            }
            public void AbrirConexao() => connection.Open();
            public void FecharConexao() => connection.Close();

            // Método para cadastrar um novo usuário
        }
        
    public static void CriarTabelasNoBanco()
        {
            string conectar = "Data Source=estoque.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();

                string createTableProdutos = @"
                CREATE TABLE IF NOT EXISTS Produtos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Codigo TEXT UNIQUE NOT NULL,
                    Preco REAL NOT NULL,
                    Quantidade INTEGER NOT NULL
                );";

                string createTableUsuarios = @"
                CREATE TABLE IF NOT EXISTS Usuarios (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Tipo TEXT NOT NULL, 
                    Senha TEXT NOT NULL

                );";

                string createTablePedidos = @"
                CREATE TABLE IF NOT EXISTS Pedidos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Data TEXT NOT NULL,
                    CPF_Cliente TEXT NOT NULL,
                    Nome_Cliente TEXT NOT NULL,
                    Total REAL NOT NULL
                );";

                string createTableItensPedido = @"
                CREATE TABLE IF NOT EXISTS ItensPedido (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PedidoId INTEGER NOT NULL,
                    ProdutoId INTEGER NOT NULL,
                    Quantidade INTEGER NOT NULL,
                    PrecoUnitario REAL NOT NULL,
                    FOREIGN KEY(PedidoId) REFERENCES Pedidos(Id),
                    FOREIGN KEY(ProdutoId) REFERENCES Produtos(Id)
                );";

                var comando = connection.CreateCommand();
                comando.CommandText = createTableProdutos;
                comando.CommandText = createTableUsuarios;
                comando.CommandText = createTablePedidos;
                comando.CommandText = createTableItensPedido;
                comando.ExecuteNonQuery();
                MessageBox.Show("Tabela criada.");
            }
        }
    }


    public class ProdutoService
    {
        public bool CadastrarUsuario(string usuario, string senha)
        {
            string conectar = "Data Source=estoque.db";
            using (var connection = new SqliteConnection(conectar))

                try
            {
                connection.Open();

                string inserir = "INSERT INTO Usuarios (Usuario, Senha) VALUES (@usuario, @senha)";
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = inserir;

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.ExecuteNonQuery();

                int resultado = cmd.ExecuteNonQuery();
                    FecharConexao();
                return resultado > 0; // Retorna verdadeiro se o cadastro foi bem-sucedido
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                FecharConexao();
                return false;
            }
        }

        private void FecharConexao()
        {
            throw new NotImplementedException();
        }

        public void CadastrarProduto(string nome, string codigo, decimal preco, int quantidade)
        {
            string conectar = "Data Source=estoque.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();

                string inserir = "INSERT INTO Produtos (Nome, Codigo, Preco, Quantidade) VALUES (@Nome, @Codigo, @Preco, @Quantidade)";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.ExecuteNonQuery();
            }
        }

        public void AlterarProduto(string codigo, decimal preco, int quantidade)
        {
            string conectar = "Data Source=estoque.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string inserir = "UPDATE Produtos SET Preco = @Preco, Quantidade = @Quantidade WHERE Codigo = @Codigo";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                {
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoverProduto(string codigo)
        {
            string conectar = "Data Source=estoque.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string inserir = "DELETE FROM Produtos WHERE Codigo = @Codigo";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


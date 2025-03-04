using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    class Database
    {
        private SqliteConnection connection;

        public Database()
        {

        }
        public void AbrirConexao() => connection.Open();
        public void FecharConexao() => connection.Close();


        //cria as tabelas no banco de dados
        public static void CriarTabelasNoBanco()
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();

                string createTables = @"
                CREATE TABLE IF NOT EXISTS Produtos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Codigo TEXT UNIQUE NOT NULL,
                    Preco REAL NOT NULL,
                    Quantidade INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Usuarios (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Cargo TEXT NOT NULL,
                    Senha TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Pedidos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Data TEXT NOT NULL,
                    ClienteCPF TEXT NOT NULL,
                    ClienteNome TEXT NOT NULL,
                    ProdutoId INTEGER NOT NULL,
                    QuantidadeVendida INTEGER NOT NULL,
                    Total REAL NOT NULL,
                    FOREIGN KEY(ProdutoId) REFERENCES Produtos(Id)
                );";

                var comando = connection.CreateCommand();
                comando.CommandText = createTables;
                comando.ExecuteNonQuery();
            }
        }

        // Método para cadastrar um novo usuário
        public bool CadastrarUsuario(Usuario usuario)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

                try
                {
                    connection.Open();

                    string inserir = "INSERT INTO Usuarios (Usuario, Cargo, Senha) VALUES (@usuario, @cargo, @senha)";
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = inserir;

                    cmd.Parameters.AddWithValue("@usuario", usuario.Nome);
                    cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
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

        // Método para cadastrar um novo produto
        public void CadastrarProduto(Produto produto)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();

                string inserir = "INSERT INTO Produtos (Nome, Codigo, Preco, Quantidade) VALUES (@Nome, @Codigo, @Preco, @Quantidade)";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                cmd.ExecuteNonQuery();
            }
        }
        // Método para atualizar um produto
        public void AtualizarProduto(Produto produto)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string inserir = "UPDATE Produtos SET Preco = @Preco, Quantidade = @Quantidade WHERE Codigo = @Codigo";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                {
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para remover um produto
        public void RemoverProduto(int id)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string inserir = "DELETE FROM Produtos WHERE Id = @id";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para cadastrar um novo pedido
        public void CriarPedido(Usuario usuario, int produtoId, int quantidade)
        {
            string data = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();
                var cmd = connection.CreateCommand();

                string selectPreco = "Select Preco FROM Produtos WHERE Id = @produtoid";
                cmd.CommandText = selectPreco;
                cmd.Parameters.AddWithValue("@produtoid", produtoId);
                object precoObj = cmd.ExecuteScalar();

                decimal precoUnitario = Convert.ToDecimal(precoObj);
                decimal total = precoUnitario * quantidade;

                string inserir = "INSERT INTO Pedidos (ClienteNome, ClienteCPF, Data, QuantidadeVendida, Total, ProdutoId) VALUES (@nomecliente, @cpfcliente, @data, @quantidade, @total, @produtoid)";
                cmd.CommandText = inserir;
                cmd.Parameters.AddWithValue("@nomecliente", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpfcliente", usuario.Cpf);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@produtoid", produtoId);
                cmd.ExecuteNonQuery();
                FecharConexao();
            }
        }

    }

    public class Usuario
    {
        public string Nome { get; private set; }

        public string Senha { get; private set; }
        public int Cpf { get; private set; }

        public string Cargo { get; private set; }

        public Usuario(string nome, string senha, string cargo)
        {
            Nome = nome;
            Senha = senha;
            Cargo = cargo;
        }

        public Usuario(string nome, int cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

    public class Produto
    {
        public string Nome { set; get; }
        public int Quantidade { set; get; }
        public int Codigo { set; get; }
        public decimal Preco { set; get; }
        public int Id { set; get; }

        public Produto(string nome, int quantidade, int codigo, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Codigo = codigo;
            Preco = preco;
        }

        public Produto(string nome, int quantidade, int codigo, decimal preco, int id)
        {
            Nome = nome;
            Quantidade = quantidade;
            Codigo = codigo;
            Preco = preco;
            Id = id;
        }
    }

}

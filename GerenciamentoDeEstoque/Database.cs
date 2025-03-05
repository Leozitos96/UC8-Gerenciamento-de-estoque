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
        public void AbrirConexao() =>  connection.Open();
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
        public void CadastrarUsuario(Usuario usuario)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();

                string inserir = "INSERT INTO Usuarios (Nome, Cargo, Senha) VALUES (@nome, @cargo, @senha)";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.ExecuteNonQuery();
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
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Pedidos WHERE ProdutoId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Produtos WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para cadastrar um novo pedido e atualiza no banco a quantia que foi removida
        public void CriarPedido(Pedido pedido, Cliente cliente)
        {
            string conectar = "Data Source=database.db";

            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();

                string inserir = "INSERT INTO Pedidos (ClienteNome, ClienteCPF, Data, QuantidadeVendida, Total, ProdutoId) VALUES (@nomecliente, @cpfcliente, @data, @quantidade, @total, @produtoid)";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = inserir;
                    cmd.Parameters.AddWithValue("@nomecliente", cliente.Nome);
                    cmd.Parameters.AddWithValue("@cpfcliente", cliente.Cpf);
                    cmd.Parameters.AddWithValue("@data", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                    cmd.Parameters.AddWithValue("@total", pedido.Total);
                    cmd.Parameters.AddWithValue("@produtoid", pedido.ProdutoId);
                    cmd.ExecuteNonQuery();
                }
                string update = "UPDATE Produtos SET Quantidade = Quantidade - @quantidade WHERE Id = @Id";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = update;
                    cmd.Parameters.AddWithValue("@Id", pedido.ProdutoId);
                    cmd.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        // Método para verificar se a conta existe no bando de dados
        public string ContaExistente(string usuario, string senha)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT * FROM Usuarios WHERE Nome = @nome";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;
                cmd.Parameters.AddWithValue("@nome", usuario);

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string cargo = reader["Cargo"].ToString();
                        if (senha == reader["Senha"].ToString())
                        {
                            MessageBox.Show("Logado com sucesso!", "Sucesso");
                            return cargo;
                        }
                        else
                        {
                            MessageBox.Show("Verifique seu usuario e senha!", "Erro");
                            return null;
                        }
                    }
                }
            }
            MessageBox.Show("Usuario nao encontrado!", "Erro");
            return null;
        }

    }

    public class Usuario
    {
        public string Nome { get; private set; }

        public string Senha { get; private set; }

        public string Cargo { get; private set; }

        public Usuario(string nome, string cargo, string senha)
        {
            Nome = nome;
            Senha = senha;
            Cargo = cargo;
        }

        public Usuario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

    }

    public class Cliente
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public Cliente(string nome, string cpf)
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

    public class Pedido
    {
        public Cliente cliente { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get;set; }

        public string ProdutoNome { get; set; }

        public Pedido(Cliente cliente, int quantidade, decimal precoUnitario, int produtoId)
        {
            this.cliente = cliente;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Total = quantidade * precoUnitario;
        }

        public Pedido(Cliente cliente, int quantidade, decimal precoUnitario, int produtoId, string produtoNome)
        {
            this.cliente = cliente;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Total = quantidade * precoUnitario;
            ProdutoNome = produtoNome;
        }
    }

    public static class SessaoAtual
    {
       public static string  Usuario { set; get; }
       public static string Cargo { set;get; }
    }
}

using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GerenciamentoDeEstoque
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
            AtualizarLista();
            dataGridView1.Sort(dataGridView1.Columns["ID"], System.ComponentModel.ListSortDirection.Descending);

        }
        /*Faz uma pesquisa no banco e Adiciona as informacoes nas colunas*/
        private void AtualizarLista()
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT Pedidos.Id AS PedidoId, Pedidos.Data, Pedidos.ClienteCPF, Pedidos.ClienteNome, Pedidos.ProdutoId, Pedidos.QuantidadeVendida, Pedidos.Total, Produtos.Preco AS Preco, Produtos.Nome AS NomeProduto FROM Pedidos INNER JOIN Produtos ON Pedidos.ProdutoId = Produtos.Id";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string cpf = reader["ClienteCPF"].ToString();
                        string data = reader["Data"].ToString();
                        string nome = reader["ClienteNome"].ToString();
                        int quantidade = int.Parse(reader["QuantidadeVendida"].ToString());
                        int produtoId = int.Parse(reader["ProdutoId"].ToString());
                        int id = int.Parse(reader["PedidoId"].ToString());
                        decimal precoUnitario = decimal.Parse(reader["Preco"].ToString());
                        string nomeProduto = reader["NomeProduto"].ToString();
                        decimal total = precoUnitario * quantidade;
                        dataGridView1.Rows.Add(id, nome, cpf, nomeProduto, precoUnitario, total, quantidade);

                    }
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

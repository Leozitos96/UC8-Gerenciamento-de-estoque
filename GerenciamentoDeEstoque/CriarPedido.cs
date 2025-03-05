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
    public partial class CriarPedido : Form
    {

        private Database database = new Database();
        public CriarPedido()
        {
            InitializeComponent();
            SelectProdutos();
            comboBoxProdutos.SelectedIndex = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Faz uma busca no banco de dados e concatena o NOME com o ESTOQUE e sao adicionados no combobox para ser selecionado*/
        private void SelectProdutos()
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT Id, Nome || ' - Estoque: ' || Quantidade AS NomeEstoque FROM Produtos";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBoxProdutos.DataSource = dataTable;
                    comboBoxProdutos.DisplayMember = "NomeEstoque";
                    comboBoxProdutos.ValueMember = "Id";
                }
            }
        }

        /*Faz uma busca no banco de dados pelo ID e retorna o preco que um produto tem de estoque*/
        private decimal SelectPrecoProduto(int produtoId)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT Preco FROM Produtos WHERE Id = @id";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;
                cmd.Parameters.AddWithValue("@id", produtoId);
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetDecimal(0);
                    }
                }
            }
            return 0;
        }

        /*Faz uma busca no banco de dados pelo ID e retorna a quantidade que um produto tem de estoque*/
        private int QuantidadeEstoque(int produtoId)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();
                string select = "SELECT Quantidade FROM Produtos WHERE Id = @id";

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = select;
                    cmd.Parameters.AddWithValue("@id", produtoId);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            int quantidade = (int)numericUpDownQuantidade.Value;
            string clienteNome = textBoxNomeCliente.Text.Trim();
            string clienteCpf = maskedTextBoxCpf.Text.Trim();
            int produtoId = Convert.ToInt32(comboBoxProdutos.SelectedValue);
            decimal precoUnitario = SelectPrecoProduto(produtoId);
            int estoque = QuantidadeEstoque(produtoId);
            if (!(quantidade <= 0 || string.IsNullOrEmpty(clienteCpf) || string.IsNullOrEmpty(clienteNome)))
            {
                if (quantidade <= estoque)
                {
                    Cliente cliente = new Cliente(clienteNome, clienteCpf);
                    Pedido pedido = new Pedido(cliente, quantidade, precoUnitario, produtoId);
                    database.CriarPedido(pedido, cliente);
                    MessageBox.Show("Pedido criado com sucesso!", "Sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Produtos insuficientes no estoque!", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro");
            }

        }

        private void comboBoxProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}

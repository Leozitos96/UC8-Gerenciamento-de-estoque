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

namespace GerenciamentoDeEstoque
{
    public partial class EditarProduto : Form
    {
        private Database database = new Database();
        private decimal precoInicial = 0;
        private int quantidadeInicial = 0;
        public EditarProduto(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SelectProduto(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int codigo = int.Parse(textBoxCodigo.Text);
            decimal preco = decimal.Parse(textBoxPreco.Text);
            int quantidade = (int)numericUpDownQuantidade.Value;
            if (!(preco <= 0 || quantidade <= 0))
            {
                if(!(preco == precoInicial && quantidade == quantidadeInicial))
                {
                    Produto produto = new Produto(nome, quantidade, codigo, preco);
                    database.AtualizarProduto(produto);
                    this.Close();
                    MessageBox.Show("Produto editado!", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Voce deve colocar um preco ou quantidade novas!", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Voce deve colocar um preco ou quantidade validas!", "Erro", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectProduto(int id)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT * FROM Produtos WHERE Id = @id";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;
                cmd.Parameters.AddWithValue("@id", id);
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome = reader["Nome"].ToString();
                        decimal preco = decimal.Parse(reader["Preco"].ToString());
                        int quantidade = int.Parse(reader["Quantidade"].ToString());
                        int codigo = int.Parse(reader["Codigo"].ToString());
                        Produto produto = new Produto(nome, quantidade, codigo, preco);

                        textBoxNome.Text = produto.Nome;
                        textBoxCodigo.Text = produto.Codigo.ToString();
                        textBoxPreco.Text = produto.Preco.ToString();
                        numericUpDownQuantidade.Value = produto.Quantidade;
                        precoInicial = produto.Preco;
                        quantidadeInicial = produto.Quantidade;

                    }
                }
            }
        }
    }
}

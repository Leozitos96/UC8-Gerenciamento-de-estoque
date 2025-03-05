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
    public partial class CadastroProdutos : Form
    {
        private Database database = new Database();
        private ProdutosFrom produtosFrom = new ProdutosFrom();
        public CadastroProdutos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // PERFIL
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // login
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // caixa do login
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // cadastro produto
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // listagem estoque
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // caixa de listagem estoque
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // registro de vendas
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // caixa de registro de vendas
        }

        /*Verifica no banco se um codigo ja esta cadastrado ou nao*/
        private bool CodigoExistente(string codigo)
        {
            bool codigoExiste = false;

            string select = "SELECT COUNT(*) FROM Produtos WHERE Codigo = @Codigo";

            using (SqliteConnection conexao = new SqliteConnection("Data Source=database.db"))
            {
                conexao.Open();
                using (SqliteCommand cmd = new SqliteCommand(select, conexao))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    long count = (long)cmd.ExecuteScalar();
                    codigoExiste = count > 0;
                }
            }
            return codigoExiste;
        }

        /*Verifica se nao existe nenhuma lacuna nas textbox e verifica se a quantidade e preco sao maiores que 0,
         sendo assim ele cadastra o produto*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxCodigo.Text) || string.IsNullOrEmpty(textBoxNome.Text) || numericUpDownQuantidade.Value <= 0))
            {
                decimal preco = decimal.Parse(textBoxPreco.Text);
                int quantidade = (int)numericUpDownQuantidade.Value;
                string nome = textBoxNome.Text.Trim();
                string codigo = textBoxCodigo.Text;
                if (!(preco <= 0))
                {
                    if (!CodigoExistente(codigo.ToString()))
                    {
                        Produto produto = new Produto(nome, quantidade, int.Parse(codigo), preco);
                        database.CadastrarProduto(produto);
                        this.Close();
                        MessageBox.Show("Produto cadastrado!", "Sucesso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Codigo ja existente, coloque outro codigo!", "Erro", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Voce deve colocar um preco valido!", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Voce deve preencher todos os campos!", "Erro", MessageBoxButtons.OK);
            }
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {

        }
        /*Fecha o form*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Verifica no textBoxPreco quais teclas ele pressionou dentro no campo, CANCELANDO caracteres e deixando apenas numeros,
         virgula, e ponto podendo ser pressionado, e se ele colocar uma virgula, transforma em .*/
        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        /*Verifica no textBoxCodigo quais teclas ele pressionou dentro no campo,
         * CANCELANDO caracteres e deixando apenas numeros*/
        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

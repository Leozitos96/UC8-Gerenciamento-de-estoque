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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxCodigo.Text) || string.IsNullOrEmpty(textBoxNome.Text) || numericUpDownQuantidade.Value <= 0))
            {
                decimal preco = decimal.Parse(textBoxPreco.Text);
                int quantidade = (int)numericUpDownQuantidade.Value;
                string nome = textBoxNome.Text.Trim();
                int codigo = int.Parse(textBoxCodigo.Text);
                if (!(preco <= 0))
                {
                    Produto produto = new Produto(nome, quantidade, codigo, preco);
                    database.CadastrarProduto(produto);
                    this.Close();
                    MessageBox.Show("Produto cadastrado!", "Sucesso", MessageBoxButtons.OK);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

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
    public partial class ProdutosFrom : Form
    {
        private List<Produto> produtos = new List<Produto>();
        private Database database = new Database();
        public ProdutosFrom()
        {
            InitializeComponent();
            AtualizarFlowPanel();
            SelectProdutos();
        }

        private void AdicionarProduto()
        {
            Form cadastrarProduto = new CadastroProdutos();
            cadastrarProduto.Show();
        }

        private void EditarProdutos(int id)
        {
            Form editarProdutos = new EditarProduto(id);
            editarProdutos.Show();
        }

        private void SelectProdutos()
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT * FROM Produtos";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;

                using(SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) // Verifica se há uma linha para ler
                    {
                        string nome = reader["Nome"].ToString();
                        decimal preco = decimal.Parse(reader["Preco"].ToString());
                        int quantidade = int.Parse(reader["Quantidade"].ToString());
                        int id = int.Parse(reader["Id"].ToString());
                        int codigo = int.Parse(reader["Codigo"].ToString());

                        Produto produto = new Produto(nome, quantidade, codigo, preco, id);
                        produtos.Add(produto);
                    }
                }
            }
        }
        
        public void AtualizarFlowPanel()
        {
            SelectProdutos();
            flowProdutos.Controls.Clear();
            foreach (var produto in produtos.ToList())
            {
                Panel panel = new Panel
                {
                    Width = 107,
                    Height = 150,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(178, 201, 177),
                };

                Label labelInfo = new Label
                {
                    Text = $"Nome: {produto.Nome}\nPreço: R${produto.Preco:F2}\nCodigo: {produto.Codigo}\nQuantidade: {produto.Quantidade}",
                    Location = new Point(panel.Width - 95, panel.Height - 120),
                    AutoSize = true
                };

                Button btnEditar = new Button
                {
                    Text = "Editar",
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom,
                    Tag = produto.Id
                };

                Button btnRemover = new Button
                {
                    Text = "Remover",
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom,
                    Tag = produto.Id
                };

                btnRemover.FlatAppearance.BorderSize = 0;
                btnEditar.FlatAppearance.BorderSize = 0;
                btnEditar.Click += (s, e) =>
                {
                    Button botaoSender = (Button)s;
                    int produtoId = (int)botaoSender.Tag;
                    EditarProdutos(produtoId);
                    };
                btnRemover.Click += (s, e) =>
                {
                    Button botaoSender = (Button)s;
                    int produtoId = (int)botaoSender.Tag;
                    DialogResult escolha = MessageBox.Show("Voce deseja remover este produto?", "Remocao", MessageBoxButtons.YesNo);
                    if(escolha == DialogResult.Yes)
                    {
                        database.RemoverProduto(produtoId);
                        MessageBox.Show("Produto removido!", "Sucesso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Remocao cancelada!", "Cancelado", MessageBoxButtons.OK);
                    }
                };

                panel.Controls.Add(labelInfo);
                panel.Controls.Add(btnEditar);
                panel.Controls.Add(btnRemover);
                flowProdutos.Controls.Add(panel);
            }

            string caminho = Directory.GetCurrentDirectory();
            Panel panelAdicionar = new Panel
            {
                Width = 110,
                Height = 150,
                BackColor = Color.FromArgb(178, 201, 177),
                BackgroundImage = Image.FromFile(@"C:\\Users\\User\\Documents\\GitHub\\UC8-Gerenciamento-de-estoque\\GerenciamentoDeEstoque\\Images\\adicionar_pequeno.png"),
                BackgroundImageLayout = ImageLayout.Zoom
            };
            Label labelAdicionar = new Label
            {
                Text = "Adicionar",
                Location = new Point(panelAdicionar.Width - 80, panelAdicionar.Height - 30),
                ForeColor = Color.Black,
            };
            panelAdicionar.Click += (s, e) => AdicionarProduto();
            panelAdicionar.Controls.Add(labelAdicionar);
            flowProdutos.Controls.Add(panelAdicionar);
        }

        private void flowProdutos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    

}

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
        public ProdutosFrom()
        {
            InitializeComponent();
            Produto produto = new Produto("Teste", 50, 52525, 35);
            produtos.Add(produto);
            AtualizarFlowPanel();
        }


        private void AdicionarProduto()
        {
            Form cadastrarProduto = new CadastroProdutos();
            cadastrarProduto.Show();

        }

        private void EditarProdutos()
        {
            Form editarProdutos = new EditarProduto();
            editarProdutos.Show();
        }

        
        private void AtualizarFlowPanel()
        {
            flowProdutos.Controls.Clear();

            foreach (var produto in produtos.ToList())
            {
                Panel panel = new Panel
                {
                    Width = 110,
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
                    Dock = DockStyle.Bottom
                };

                Button btnRemover = new Button
                {
                    Text = "Remover",
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom
                };

                btnRemover.FlatAppearance.BorderSize = 0;
                btnEditar.FlatAppearance.BorderSize = 0;
                btnEditar.Click += (s, e) => EditarProdutos();

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
    
    public class Produto
    {
        public string Nome { set; get; }
        public int Quantidade { set; get; }
        public int Codigo { set; get; }
        public decimal Preco { set; get; }

        public Produto(string nome, int quantidade, int codigo, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Codigo = codigo;
            Preco = preco;
        }
    }
}

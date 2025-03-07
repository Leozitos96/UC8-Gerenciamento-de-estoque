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
    public partial class PedidosForm : Form
    {
        private List<Pedido> pedidos = new List<Pedido>();
        public PedidosForm()
        {
            InitializeComponent();
            AtualizarFlowPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowPedidos_Paint(object sender, PaintEventArgs e)
        {

        }


        /*Metodo para criar os produtos, abre o form CadastrarProduto*/
        private void AdicionarPedido()
        {
            Form criarPedido = new CriarPedido();
            criarPedido.Show();
        }

        /*Faz um select no banco de dados para retornar todos pedidos cadastrados*/
        private void SelectPedidos()
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
                        decimal precoUnitario = int.Parse(reader["Preco"].ToString());
                        string nomeProduto = reader["NomeProduto"].ToString();

                        Cliente cliente = new Cliente(nome, cpf);
                        Pedido pedido = new Pedido(cliente, quantidade, precoUnitario, produtoId, nomeProduto);
                        pedidos.Add(pedido);
                    }
                }
            }
        }


        /*Atualiza o flowPanel de acordo com o cargo da pessoa, e cria cards com as informacoes dos produtos
         junto dos botoes editar e remover(caso o cargo seja Administrador)*/
        public void AtualizarFlowPanel()
        {
            SelectPedidos();
            flowPedidos.Controls.Clear();
            foreach (var pedido in pedidos.ToList())
            {
                Panel panel = new Panel
                {
                    Width = 130,
                    Height = 150,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(178, 201, 177),
                };

                Label labelInfo = new Label
                {
                    Text = $"Cliente: {pedido.cliente.Nome}\nCpf: {pedido.cliente.Cpf}\nProduto: {pedido.ProdutoNome}\nQuantidade: {pedido.Quantidade}\nPreco Total: R${pedido.Total:F2}",
                    Location = new Point(panel.Width - 120, panel.Height - 120),
                    AutoSize = true
                };

                panel.Controls.Add(labelInfo);
                flowPedidos.Controls.Add(panel);
            }

            string caminho = Directory.GetCurrentDirectory();
            Panel panelAdicionar = new Panel
            {
                Width = 130,
                Height = 150,
                BackColor = Color.FromArgb(178, 201, 177),
            };
            Label labelAdicionar = new Label
            {
                Text = "Adicionar",
                Location = new Point(panelAdicionar.Width - 95, panelAdicionar.Height - 30),
                ForeColor = Color.Black,
            };
            panelAdicionar.Click += (s, e) => AdicionarPedido();
            panelAdicionar.Controls.Add(labelAdicionar);
            flowPedidos.Controls.Add(panelAdicionar);
        }
    }
}

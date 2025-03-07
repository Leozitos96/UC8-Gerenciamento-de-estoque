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
    public partial class FuncionariosForm : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public FuncionariosForm()
        {
            InitializeComponent();
            AtualizarFlowPanel();
        }

        /*Faz um select para pegar todos os USUARIOS e CARGOS cadastrados*/
        private void SelectUsuarios()
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string select = "SELECT * FROM Usuarios";
                var cmd = connection.CreateCommand();
                cmd.CommandText = select;

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        string nome = reader["Nome"].ToString();
                        string cargo = reader["Cargo"].ToString();
                        Usuario usuario = new Usuario(nome, cargo);
                        usuarios.Add(usuario);
                    }
                }
            }
        }

        /*Atualiza o flowPanel funcionarios, adicionando cards com as informacoes de cada funcionario*/
        public void AtualizarFlowPanel()
        {
            SelectUsuarios();
            flowFuncionarios.Controls.Clear();
            foreach (var usuario in usuarios.ToList())
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
                    Text = $"Nome: {usuario.Nome}\nCargo: {usuario.Cargo}",
                    Location = new Point(panel.Width - 130, panel.Height - 26),
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    AutoSize = true
                };

                panel.Controls.Add(labelInfo);
                flowFuncionarios.Controls.Add(panel);
            }
        }

        private void flowFuncionarios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using Microsoft.Data.Sqlite;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GerenciamentoDeEstoque
{
    internal static class Program
    {
        private static Database database = new Database();
        [STAThread]
        static void Main(String[] args)
        {
            Database.CriarTabelasNoBanco();
            Application.Run(new Login());
        }
    }
}


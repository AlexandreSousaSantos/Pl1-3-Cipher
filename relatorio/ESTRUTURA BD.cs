using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace ProjetoDA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string databaseFile = "iShopping.db";

            // Verificar se o ficheirom da base de dados existe, caso contrário, criar um novo
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);
            }

            //Estabelece uma ligação com o ficheiro criado
            using (var connection = new SQLiteConnection($"Data Source={databaseFile};Version=3;"))
            {
                connection.Open(); // Abre a ligação com o bd


                string SqlUtilizadores = "CREATE TABLE IF NOT EXISTS Utilizadores (" +
                        "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                        "Username TEXT UNIQUE NOT NULL," +
                        "Password TEXT NOT NULL)" +
                        ";";

                string SqlOrcamentos = "CREATE TABLE IF NOT EXISTS Orcamentos (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "Mes TEXT NOT NULL," +
                    "ValorMaximo DECIMAL NOT NULL," +
                    "CriadoPorId INTEGER NOT NULL," +
                    "AlteradoPorId INTEGER NOT NULL," +
                    "FOREIGN KEY(CriadoPorId) REFERENCES Utilizadores(Id)," +
                    "FOREIGN KEY(AlteradoPorId) REFERENCES Utilizadores(Id)" +
                    ");";

                string SqlCompras = "CREATE TABLE IF NOT EXISTS Compras (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "NomeCompra TEXT NOT NULL," +
                    "DataCriacao DATETIME NOT NULL," +
                    "CriadaPorId INTEGER NOT NULL," +
                    "Estado TEXT NOT NULL," +
                    "DataFechada DATETIME," +
                    "FechadaPorId INTEGER," +
                    "FOREIGN KEY(CriadaPorId) REFERENCES Utilizadores(Id)," +
                    "FOREIGN KEY(FechadaPorId) REFERENCES Utilizadores(Id)" +
                    ");";

                string SqlTipoArtigos = "CREATE TABLE IF NOT EXISTS TipoArtigos (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "Descricao TEXT NOT NULL)" +
                    ";";

                string SqlArtigos = "CREATE TABLE IF NOT EXISTS Artigos (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "NomeArtigo TEXT NOT NULL," +
                    "TipoArtigoId INTEGER NOT NULL," +
                    "FOREIGN KEY(TipoArtigoId) REFERENCES TipoArtigos(Id)" +
                    ");";

                string SqlItemCompras = "CREATE TABLE IF NOT EXISTS ItemCompras (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "CompraId INTEGER NOT NULL," +
                    "ArtigoId INTEGER NOT NULL," +
                    "QuantidadePrevista DECIMAL NOT NULL," +
                    "QuantidadeAdquirida DECIMAL NOT NULL," +
                    "PrecoUnitario DECIMAL NOT NULL," +
                    "Observacoes TEXT NOT NULL," +
                    "CriadoPorId INTEGER NOT NULL," +
                    "DataCriacao DATETIME NOT NULL," +
                    "AlteradoPorId INTEGER NOT NULL," +
                    "DataAlteracao DATETIME NOT NULL," +
                    "FOREIGN KEY(CompraId) REFERENCES Compras(Id)," +
                    "FOREIGN KEY(ArtigoId) REFERENCES Artigos(Id)," +
                    "FOREIGN KEY(CriadoPorId) REFERENCES Utilizadores(Id)," +
                    "FOREIGN KEY(AlteradoPorId) REFERENCES Utilizadores(Id)" +
                    ");";

                string SqlItensPrevistos = "CREATE TABLE IF NOT EXISTS ItemPrevisto (" +
                    "Id INTEGER PRIMARY KEY NOT NULL," +
                    "QuantPrevista DECIMAL NOT NULL," +
                    "CriadoPor INTEGER NOT NULL," +
                    "AlteradoPor INTEGER NOT NULL," +
                    "FOREIGN KEY(Id) REFERENCES ItemCompras(Id)," +
                    "FOREIGN KEY(CriadoPor) REFERENCES Utilizadores(Id)," +
                    "FOREIGN KEY(AlteradoPor) REFERENCES Utilizadores(Id)" +
                    ");";

                string ItensNaoPrevistos = "CREATE TABLE IF NOT EXISTS ItemNaoPrevisto (" +
                    "Id INTEGER PRIMARY KEY NOT NULL," +
                    "QuantAdquirida DECIMAL NOT NULL," +
                    "PrecoUnitario DECIMAL NOT NULL," +
                    "Observacaoes TEXT," +
                    "FOREIGN KEY(Id) REFERENCES ItemCompras(Id)" +
                    ");";

                Application.Run(new Form1());

            }
        }
    }
}

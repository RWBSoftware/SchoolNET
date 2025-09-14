using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNET.Data
{
    public class Conexao
    {
        public SqliteDataReader dr;
        public string GetDatabasePath()
        {
    #if DEBUG
            string dbPath = Path.Combine(@"C:\Projetos\SchoolNET\SchoolNET\Data", "SchoolNET.db");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
#else
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string appFolder = Path.Combine(folder, "SchoolNET", "Data");
        Directory.CreateDirectory(appFolder);

        string dbPath = Path.Combine(appFolder, "SchoolNET.db");

        if (!File.Exists(dbPath))
        {
            string origem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "SchoolNET.db");
            if (File.Exists(origem))
                File.Copy(origem, dbPath);
        }
#endif

            return dbPath;
        }

        public SqliteConnection GetConnection()
        {
            Batteries.Init();
            string con = $"Data Source={GetDatabasePath()};";
            return new SqliteConnection(con);
        }

        public bool Login(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Usuario WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool VerificarSeUsuarioExiste(string usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Usuario WHERE Usuario = @usuario";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }
        public bool Cadastro(string usuario, string senha)
        {
            if(VerificarSeUsuarioExiste(usuario))
            {
                MessageBox.Show("Usuário já cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Usuario (Usuario, Senha, Acesso) VALUES (@usuario, @senha, NULL )";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}

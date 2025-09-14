using SchoolNET.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNET.Data
{
    public class ConexaoSala : Conexao
    {
        public bool InserirSala(string nomeSala, int capacidade)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Salas (NomeSala, Capacidade) VALUES (@nomeSala, @capacidade)";
                    command.Parameters.AddWithValue("@nomeSala", nomeSala);
                    command.Parameters.AddWithValue("@capacidade", capacidade);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public List<DadosSala> BuscarTodasAsSalas()
        {
            List<DadosSala> salas = new List<DadosSala>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Salas ORDER BY NomeSala";
                    using (var dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                salas.Add(new DadosSala
                                {
                                    Id = dr.GetInt32(0),
                                    NomeSala = dr["NomeSala"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            return salas;
        }

        public void ExibirSalaForms(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Salas";

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                }
            }
        }

        public void ExibirSalaProcuradoNoForms(DataGridView dgv, string sala)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Salas WHERE NomeSala LIKE @sala";
                    command.Parameters.AddWithValue("@sala", "%" + sala + "%");

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                }
            }

        }

        public bool AtualizarSala(string nomeSala, int capacidade, string nomeSalaOriginal)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE Salas SET NomeSala = @nomeSala, Capacidade = @capacidade WHERE NomeSala = @nomeSalaOriginal";
                    command.Parameters.AddWithValue("@nomeSala", nomeSala);
                    command.Parameters.AddWithValue("@capacidade", capacidade);
                    command.Parameters.AddWithValue("@nomeSalaOriginal", nomeSalaOriginal);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;

                }
            }
        }

        public bool ExcluirSala(string nomeSala)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM Salas WHERE NomeSala = @nomeSala";
                    command.Parameters.AddWithValue("@nomeSala", nomeSala);
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

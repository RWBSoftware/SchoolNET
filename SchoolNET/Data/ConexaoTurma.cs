using SchoolNET.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolNET.Data
{
    internal class ConexaoTurma : Conexao
    {
        public bool InserirTurma(int IdSala, string nomeTurma, string ano)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Turma (IDSala, NomeTurma, Ano) VALUES (@IdSala, @NomeTurma, @Ano)";
                    command.Parameters.AddWithValue("@IdSala", IdSala);
                    command.Parameters.AddWithValue("@NomeTurma", nomeTurma);
                    command.Parameters.AddWithValue("@Ano", ano);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public List<DadoTurma> SelecionarTurma(string ano)
        {
            List<DadoTurma> turmas = new List<DadoTurma>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Turma WHERE Ano = @ano";
                    command.Parameters.AddWithValue("@ano", ano);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            turmas.Add(new DadoTurma
                            {
                                Id = dr.GetInt32(0),
                                NomeTurma = dr["NomeTurma"].ToString()
                            });
                        }
                    }
                    return turmas;
                }
            }
        }
    }
}

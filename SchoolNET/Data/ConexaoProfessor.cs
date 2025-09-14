using SchoolNET.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNET.Data
{
    public class ConexaoProfessor : Conexao
    {
        public bool InserirProfessor(Professor professor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Professor " +
                        "(Nome, CPF, DataNascimento, Telefone, Endereco, Obs) " +
                        "VALUES" +
                        "(@Nome, @CPF, @DataNascimento, @Telefone, @Endereco, @Obs)";
                    command.Parameters.AddWithValue("@Nome", professor.NomeProfessor);
                    command.Parameters.AddWithValue("@CPF", professor.CPF);
                    command.Parameters.AddWithValue("@DataNascimento", professor.DataNascimento);
                    command.Parameters.AddWithValue("@Telefone", professor.Telefone);
                    command.Parameters.AddWithValue("@Endereco", professor.Endereco);
                    command.Parameters.AddWithValue("@Obs", professor.Observacoes);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

            public bool AlterarProfessor(Professor professor, string cpfAntigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE Professor SET " +
                        "Nome = @Nome, " +
                        "CPF = @CPF, " +
                        "DataNascimento = @DataNascimento, " +
                        "Telefone = @Telefone, " +
                        "Endereco = @Endereco, " +
                        "Obs = @Obs " +
                        "WHERE CPF = @CPFAntigo";
                    command.Parameters.AddWithValue("@Nome", professor.NomeProfessor);
                    command.Parameters.AddWithValue("@CPF", professor.CPF);
                    command.Parameters.AddWithValue("@DataNascimento", professor.DataNascimento);
                    command.Parameters.AddWithValue("@Telefone", professor.Telefone);
                    command.Parameters.AddWithValue("@Endereco", professor.Endereco);
                    command.Parameters.AddWithValue("@Obs", professor.Observacoes);
                    command.Parameters.AddWithValue("@CPFAntigo", cpfAntigo);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public Professor ProcurarProfessor(string cpf)
        {
            Professor professor = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Professor WHERE CPF = @cpf";
                    command.Parameters.AddWithValue("@cpf", cpf);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            professor = new Professor();
                            professor.NomeProfessor = dr["Nome"].ToString();
                            professor.CPF = dr["CPF"].ToString();
                            professor.DataNascimento = dr["DataNascimento"].ToString();
                            professor.Telefone = dr["Telefone"].ToString();
                            professor.Endereco = dr["Endereco"].ToString();
                            professor.Observacoes = dr["Obs"].ToString();
                        }
                    }
                }
            }
            return professor;
        }

        public void ExibirProfessorForms(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT Nome, CPF FROM Professor";

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                }
            }
        }

        public void ExibirProfessorProcuradoNoForms(DataGridView dgv, string cpf)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT Nome, CPF FROM Professor WHERE CPF LIKE @cpf";
                    command.Parameters.AddWithValue("@cpf", "%" + cpf + "%");

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                }
            }
        }

        public bool DeletarProfessor(string professor, string cpf)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM Professor WHERE Nome= @professor AND CPF = @cpf";
                    command.Parameters.AddWithValue("@professor", professor);
                    command.Parameters.AddWithValue("@cpf", cpf);
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

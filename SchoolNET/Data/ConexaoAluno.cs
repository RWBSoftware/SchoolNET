using SchoolNET.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNET.Data
{
    public class ConexaoAluno : Conexao
    {
        ConexaoNotaAluno conexaoNotaAluno = new ConexaoNotaAluno();
        public bool InserirAluno(Aluno aluno)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Aluno " +
                        "(NomeAluno, CPF, DataNascimento, Matricula, TelefoneAluno, NomeResponsavel, TelefoneResponsavel, Endereco, Obs, Ano, Turma) " +
                        "VALUES" +
                        "(@NomeAluno, @CPF, @DataNascimento, @Matricula, @TelefoneAluno, @NomeResponsavel, @TelefoneResponsavel, @Endereco, @Obs, @Ano, @Turma)";
                    command.Parameters.AddWithValue("@NomeAluno", aluno.NomeAluno);
                    command.Parameters.AddWithValue("@CPF", aluno.CPF);
                    command.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);
                    command.Parameters.AddWithValue("@Matricula", aluno.Matricula);
                    command.Parameters.AddWithValue("@TelefoneAluno", aluno.Telefone);
                    command.Parameters.AddWithValue("@NomeResponsavel", aluno.Responsavel);
                    command.Parameters.AddWithValue("@TelefoneResponsavel", aluno.TelefoneResponsavel);
                    command.Parameters.AddWithValue("@Endereco", aluno.Endereco);
                    command.Parameters.AddWithValue("@Obs", aluno.Observacoes);
                    command.Parameters.AddWithValue("@Ano", aluno.Ano);
                    command.Parameters.AddWithValue("@Turma", aluno.Turma);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        conexaoNotaAluno.InserirNota(aluno.Matricula);
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool AlterarAluno(Aluno aluno, string matriculaAntiga)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE Aluno SET " +
                        "NomeAluno = @NomeAluno, " +
                        "CPF = @CPF, " +
                        "DataNascimento = @DataNascimento, " +
                        "TelefoneAluno = @TelefoneAluno, " +
                        "NomeResponsavel = @NomeResponsavel, " +
                        "TelefoneResponsavel = @TelefoneResponsavel, " +
                        "Endereco = @Endereco, " +
                        "Obs = @Obs, " +
                        "Ano = @Ano, " +
                        "Turma = @Turma " +
                        "WHERE Matricula = @MatriculaAntiga";
                    command.Parameters.AddWithValue("@NomeAluno", aluno.NomeAluno);
                    command.Parameters.AddWithValue("@CPF", aluno.CPF);
                    command.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);
                    command.Parameters.AddWithValue("@Matricula", aluno.Matricula);
                    command.Parameters.AddWithValue("@TelefoneAluno", aluno.Telefone);
                    command.Parameters.AddWithValue("@NomeResponsavel", aluno.Responsavel);
                    command.Parameters.AddWithValue("@TelefoneResponsavel", aluno.TelefoneResponsavel);
                    command.Parameters.AddWithValue("@Endereco", aluno.Endereco);
                    command.Parameters.AddWithValue("@Obs", aluno.Observacoes);
                    command.Parameters.AddWithValue("@Ano", aluno.Ano);
                    command.Parameters.AddWithValue("@Turma", aluno.Turma);
                    command.Parameters.AddWithValue("@MatriculaAntiga", matriculaAntiga);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }


        public void ExibirAlunosForms(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT NomeAluno, Matricula FROM Aluno";

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                }
            }
        }

        public void ExibirAlunoProcuradoNoForms(DataGridView dgv, string matricula)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT NomeAluno, Matricula FROM Aluno WHERE Matricula LIKE @matricula";
                    command.Parameters.AddWithValue("@matricula", "%" + matricula + "%");

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                }
            }
        }

        public Aluno ProcurarAluno(string matricula)
        {
            Aluno aluno = null; // Inicializa o aluno como nulo
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM Aluno WHERE Matricula = @matricula";
                    command.Parameters.AddWithValue("@matricula", matricula);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            aluno = new Aluno(); // Cria o objeto somente se encontrar o aluno
                            aluno.NomeAluno = dr["NomeAluno"].ToString();
                            aluno.CPF = dr["CPF"].ToString();
                            aluno.DataNascimento = dr["DataNascimento"].ToString();
                            aluno.Matricula = dr["Matricula"].ToString();
                            aluno.Telefone = dr["TelefoneAluno"].ToString();
                            aluno.Responsavel = dr["NomeResponsavel"].ToString();
                            aluno.TelefoneResponsavel = dr["TelefoneResponsavel"].ToString();
                            aluno.Endereco = dr["Endereco"].ToString();
                            aluno.Observacoes = dr["Obs"].ToString();
                            aluno.Turma = dr["Turma"].ToString();
                            aluno.Ano = dr["Ano"].ToString();
                        }
                    }
                }
            }
            return aluno;
        }

        public bool DeletarAluno(string aluno, string matricula)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM Aluno WHERE NomeAluno = @aluno AND Matricula = @matricula";
                    command.Parameters.AddWithValue("@aluno", aluno);
                    command.Parameters.AddWithValue("@matricula", matricula);
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

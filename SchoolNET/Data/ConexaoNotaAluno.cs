using SchoolNET.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNET.Data
{
    public class ConexaoNotaAluno : Conexao
    {
        public void InserirNota(string matricula)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO NotaAluno " +
                        "(Matricula, PrimeiroBimestre, SegundoBimestre, TerceiroBimestre, QuartoBimestre) " +
                        "VALUES" +
                        "(@Matricula, NULL, NULL, NULL, NULL)";
                    command.Parameters.AddWithValue("@Matricula", matricula);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool AlterarNota(NotaAluno notaAluno)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE NotaAluno SET " +
                        "PrimeiroBimestre = @PrimeiroBimestre, " +
                        "SegundoBimestre = @SegundoBimestre, " +
                        "TerceiroBimestre = @TerceiroBimestre, " +
                        "QuartoBimestre = @QuartoBimestre " +
                        "WHERE Matricula = @Matricula";
                    command.Parameters.AddWithValue("@Matricula", notaAluno.Matricula);
                    command.Parameters.AddWithValue("@PrimeiroBimestre", notaAluno.PrimeiroBimestre == 0 ? DBNull.Value : (object)notaAluno.PrimeiroBimestre);
                    command.Parameters.AddWithValue("@SegundoBimestre", notaAluno.SegundoBimestre == 0 ? DBNull.Value : (object)notaAluno.SegundoBimestre);
                    command.Parameters.AddWithValue("@TerceiroBimestre", notaAluno.TerceiroBimestre == 0 ? DBNull.Value : (object)notaAluno.TerceiroBimestre);
                    command.Parameters.AddWithValue("@QuartoBimestre", notaAluno.QuartoBimestre == 0 ? DBNull.Value : (object)notaAluno.QuartoBimestre);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public NotaAluno ProcurarMatricula(string matricula)
        {
            NotaAluno notaAluno = new NotaAluno();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM NotaAluno WHERE Matricula = @matricula";
                    command.Parameters.AddWithValue("@matricula", matricula);
                    using (var dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            notaAluno.Matricula = matricula;
                            notaAluno.PrimeiroBimestre = dr["PrimeiroBimestre"] is DBNull ? 0 : Convert.ToDecimal(dr["PrimeiroBimestre"]);
                            notaAluno.SegundoBimestre = dr["SegundoBimestre"] is DBNull ? 0 : Convert.ToDecimal(dr["SegundoBimestre"]);
                            notaAluno.TerceiroBimestre = dr["TerceiroBimestre"] is DBNull ? 0 : Convert.ToDecimal(dr["TerceiroBimestre"]);
                            notaAluno.QuartoBimestre = dr["QuartoBimestre"] is DBNull ? 0 : Convert.ToDecimal(dr["QuartoBimestre"]);
                        }
                        else
                            notaAluno = null;
                    }
                    return notaAluno;
                }
            }
        }

        public void ExibirNotasForms(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT Matricula, PrimeiroBimestre, SegundoBimestre, TerceiroBimestre, QuartoBimestre FROM NotaAluno";

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.Columns["Matricula"].HeaderText = "Matrícula do Aluno";
                    dgv.Columns["PrimeiroBimestre"].HeaderText = "1º Bi";
                    dgv.Columns["SegundoBimestre"].HeaderText = "2º Bi";
                    dgv.Columns["TerceiroBimestre"].HeaderText = "3º Bi";
                    dgv.Columns["QuartoBimestre"].HeaderText = "4º Bi";
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
                    command.CommandText = "SELECT Matricula, PrimeiroBimestre, SegundoBimestre, TerceiroBimestre, QuartoBimestre FROM NotaAluno WHERE Matricula LIKE @matricula";
                    command.Parameters.AddWithValue("@matricula", "%" + matricula + "%");

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;
                    dgv.Columns["Matricula"].HeaderText = "Matrícula do Aluno";
                    dgv.Columns["PrimeiroBimestre"].HeaderText = "1º Bi";
                    dgv.Columns["SegundoBimestre"].HeaderText = "2º Bi";
                    dgv.Columns["TerceiroBimestre"].HeaderText = "3º Bi";
                    dgv.Columns["QuartoBimestre"].HeaderText = "4º Bi";
                    dgv.AutoResizeColumns();
                }
            }
        }

    }
}

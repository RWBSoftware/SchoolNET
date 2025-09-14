using SchoolNET.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNET
{
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
            PopularDGV();
        }

        private void PopularDGV()
        {
            ConexaoAluno conexaoAluno = new ConexaoAluno();
            conexaoAluno.ExibirAlunosForms(dgv1);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

                if (row["Matricula"] != DBNull.Value && !string.IsNullOrEmpty(row["Matricula"].ToString()))
                {
                    var matricula = row["Matricula"].ToString();
                    frmInserirAluno frmInserirAluno = new frmInserirAluno(matricula);
                    frmInserirAluno.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("A matrícula da linha selecionada é nula ou vazia. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (dgv1.SelectedRows.Count > 0)
                {
                    var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

                    if (row["Matricula"] != DBNull.Value && !string.IsNullOrEmpty(row["Matricula"].ToString()))
                    {
                        var aluno = row["NomeAluno"].ToString();
                        var matricula = row["Matricula"].ToString();
                        ConexaoAluno conexaoAluno = new ConexaoAluno();
                        if (conexaoAluno.DeletarAluno(aluno, matricula))
                            MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("A matrícula da linha selecionada é nula ou vazia. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            PopularDGV();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAluno frmMenuAluno = new frmMenuAluno();
            frmMenuAluno.Show();
            this.Close();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           ConexaoAluno conexaoAluno = new ConexaoAluno();
           conexaoAluno.ExibirAlunoProcuradoNoForms(dgv1, txtNome.Text);
        }
    }
}

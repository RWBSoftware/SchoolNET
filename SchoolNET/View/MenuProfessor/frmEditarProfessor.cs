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
    public partial class frmEditarProfessor : Form
    {
        public frmEditarProfessor()
        {
            InitializeComponent();
            PopularDGV();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PopularDGV()
        {
            ConexaoProfessor professor = new ConexaoProfessor();
            professor.ExibirProfessorForms(dgv1);
        }


        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            {
                if (dgv1.SelectedRows.Count > 0)
                {
                    var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

                    if (row["CPF"] != DBNull.Value && !string.IsNullOrEmpty(row["CPF"].ToString()))
                    {
                        var cpf = row["CPF"].ToString();
                        frmInserirFuncionario frmInserirFuncionario = new frmInserirFuncionario(cpf);
                        frmInserirFuncionario.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("O CPF da linha selecionada é nulo ou vazio. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este professor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.Yes)
                {
                    if (dgv1.SelectedRows.Count > 0)
                    {
                        var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

                        if (row["CPF"] != DBNull.Value && !string.IsNullOrEmpty(row["CPF"].ToString()))
                        {
                            var professor = row["Nome"].ToString();
                            var cpf = row["CPF"].ToString();
                            ConexaoProfessor conexaoProfessor = new ConexaoProfessor();
                            if (conexaoProfessor.DeletarProfessor(professor, cpf))
                                MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("O CPF da linha selecionada é nulo ou vazio. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                PopularDGV();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuProfessor frmMenuProfessor = new frmMenuProfessor();
            frmMenuProfessor.Show();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ConexaoProfessor professor = new ConexaoProfessor();
            professor.ExibirProfessorProcuradoNoForms(dgv1, txtNome.Text);
        }
    }
}

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

namespace SchoolNET.View.MenuEscola
{
    public partial class frmExibirSalas : Form
    {
        public frmExibirSalas()
        {
            InitializeComponent();
            PopularDGV();
        }

        private void PopularDGV()
        {
            ConexaoSala conexaoSala = new ConexaoSala();
            conexaoSala.ExibirSalaForms(dgv1);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

                if (row["NomeSala"] != DBNull.Value && !string.IsNullOrEmpty(row["NomeSala"].ToString()))
                {
                    var NomeSala = row["NomeSala"].ToString();
                    var Capacidade = row["Capacidade"].ToString();
                    frmInserirSala frmInserirSala = new frmInserirSala(NomeSala, Capacidade);
                    frmInserirSala.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("o Nome da Sala na linha selecionada é nula ou vazia. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ConexaoSala conexaoSala = new ConexaoSala();
            conexaoSala.ExibirSalaProcuradoNoForms(dgv1, txtNome.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuEscola frmMenuEscola = new frmMenuEscola();
            frmMenuEscola.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir esta sala?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (dgv1.SelectedRows.Count > 0)
                {
                    var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

                    if (row["NomeSala"] != DBNull.Value && !string.IsNullOrEmpty(row["NomeSala"].ToString()))
                    {
                        var nomeSala = row["NomeSala"].ToString();
                        ConexaoSala conexaoSala = new ConexaoSala();
                        if (conexaoSala.ExcluirSala(nomeSala))
                            MessageBox.Show("Sala excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("A sala da linha selecionada é nula ou vazia. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            PopularDGV();
        }
    }
}

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

namespace SchoolNET.View.MenuAluno
{
    public partial class frmHistoricoAluno : Form
    {
        ConexaoNotaAluno conexaoNotaAluno = new ConexaoNotaAluno();
        public frmHistoricoAluno()
        {
            InitializeComponent();
            PopularDGV();
        }

        private void PopularDGV()
        {
            conexaoNotaAluno.ExibirNotasForms(dgv1);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAluno frmMenuAluno = new frmMenuAluno();
            frmMenuAluno.Show();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            conexaoNotaAluno.ExibirAlunoProcuradoNoForms(dgv1, txtNome.Text);
        }
    }
}

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
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            frmInserirAluno frmInserirAluno = new frmInserirAluno("G813715");
            frmInserirAluno.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAluno frmMenuAluno = new frmMenuAluno();
            frmMenuAluno.Show();
            this.Close();
        }
    }
}

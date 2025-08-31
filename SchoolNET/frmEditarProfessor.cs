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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            frmInserirFuncionario frmInserirFuncionario = new frmInserirFuncionario("000.000.000-00");
            frmInserirFuncionario.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                MessageBox.Show("Funcionário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuProfessor frmMenuProfessor = new frmMenuProfessor();
            frmMenuProfessor.Show();
            this.Close();
        }
    }
}

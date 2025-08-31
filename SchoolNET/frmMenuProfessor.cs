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
    public partial class frmMenuProfessor : Form
    {
        public frmMenuProfessor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirFuncionario frmInserirFuncionario = new frmInserirFuncionario();
            frmInserirFuncionario.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarProfessor frmEditarProfessor = new frmEditarProfessor();
            frmEditarProfessor.Show();
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            frmProfessorSala frmProfessorSala = new frmProfessorSala();
            frmProfessorSala.Show();
            this.Close();
        }
    }
}

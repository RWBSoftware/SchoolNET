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
    public partial class frmInserirAluno : Form
    {
        public string matricula;

        public frmInserirAluno(string Matricula = "")
        {
            InitializeComponent();
            ModoDeEditarAluno(Matricula);
        }

        public void ModoDeEditarAluno(string Matricula)
        {
            if (string.IsNullOrEmpty(Matricula))
                return;
            else
                txtMatricula.Text = Matricula;

            this.matricula = Matricula;
        }


        public void Limpar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtMatricula.Clear();
            txtTelefone.Clear();
            txtResponsavel.Clear();
            txtTelefoneResponsavel.Clear();
            txtEndereco.Clear();
            txtObs.Clear();
            cBoxAno.SelectedIndex = -1;
            cBoxAno.SelectedValue = "Ano";
            cBoxTurma.SelectedIndex = -1;
            cBoxTurma.SelectedValue = "Turma";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(matricula))
            {
                frmMenuAluno frmMenuAluno = new frmMenuAluno();
                frmMenuAluno.Show();
                this.Close();
            }
            else
            {
                frmEditar frmEditar = new frmEditar();
                frmEditar.Show();
                this.Close();
            }
        }

        private void cBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAno.SelectedIndex != -1)
                cBoxTurma.Enabled = true;
            else
                cBoxTurma.Enabled = false;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

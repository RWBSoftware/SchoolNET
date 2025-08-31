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
    public partial class frmInserirFuncionario : Form
    {
        public string cpf;
        public frmInserirFuncionario(string CPF = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(CPF))
                txtCPF.Text = CPF;
        }

        public void Apagar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtObs.Clear();
            txtEndereco.Clear();
            cBoxAno.SelectedIndex = -1;
            cBoxTurma.SelectedIndex = -1;
            cBoxTurmaSelecionada.Items.Clear();
            cBoxTurma.Enabled = false;
        }

        private void cBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAno.SelectedIndex != -1)
                cBoxTurma.Enabled = true;
            else
                cBoxTurma.Enabled = false;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cBoxTurma.SelectedIndex != -1)
                cBoxTurmaSelecionada.Items.Add($"{cBoxAno.SelectedItem}º Ano {cBoxTurma.SelectedItem}\r\n");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                frmMenuProfessor frmMenuProfessor = new frmMenuProfessor();
                frmMenuProfessor.Show();
                this.Close();
            }
            else
            {
                frmEditarProfessor frmEditarProfessor = new frmEditarProfessor();
                frmEditarProfessor.Show();
                this.Close();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cBoxTurmaSelecionada.SelectedIndex != -1)
                cBoxTurmaSelecionada.Items.RemoveAt(cBoxTurmaSelecionada.SelectedIndex);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }
    }
}

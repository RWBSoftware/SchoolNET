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
    public partial class frmInserirNota : Form
    {
        public frmInserirNota()
        {
            InitializeComponent();
            PopularObjetos();
        }

        public void PopularObjetos()
        {
            cBoxBimestre.SelectedIndex = 0;
        }

        public void LimparObjetos()
        {
            txtMatricula.Clear();
            cBoxBimestre.SelectedIndex = 0;
            txtNota.Clear();
            cBoxBimestre.Enabled = false;
            txtNota.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.ToUpper();
            if (matricula != "G813715")
            {
                MessageBox.Show("Por favor, insira uma matrícula válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cBoxBimestre.Enabled = true;
                txtNota.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparObjetos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAluno frmMenuAluno = new frmMenuAluno();
            frmMenuAluno.Show();
            this.Close();
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }
    }
}

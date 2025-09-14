using SchoolNET.Controller;
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
    public partial class frmInserirNota : Form
    {
        public NotaAluno notaAluno = new NotaAluno();
        public frmInserirNota()
        {
            InitializeComponent();
            PopularObjetos();
        }

        public void PopularObjetos()
        {
            cBoxBimestre.SelectedIndex = -1;
        }

        public void LimparObjetos()
        {
            txtMatricula.Clear();
            cBoxBimestre.SelectedIndex = -1;
            txtNota.Clear();
            cBoxBimestre.Enabled = false;
            txtNota.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoNotaAluno conexaoNotaAluno = new ConexaoNotaAluno();
            string matricula = txtMatricula.Text.ToUpper();
            notaAluno = conexaoNotaAluno.ProcurarMatricula(matricula);
            if (notaAluno == null)
            {
                MessageBox.Show("Por favor, insira uma matrícula válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblAluno.Text = "Aluno não encontrado";
                lblAluno.Visible = true;
                cBoxBimestre.Enabled = false;
                txtNota.Enabled = false;
                return;
            }
            else
            {
                lblAluno.Visible = true;
                lblAluno.Text = new ConexaoAluno().ProcurarAluno(matricula).NomeAluno;
                cBoxBimestre.Enabled = true;
                txtNota.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarNota();
        }

        public void VerificarNota()
        {
            if (string.IsNullOrWhiteSpace(txtNota.Text))
            {
                MessageBox.Show("Por favor, insira uma nota válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(txtNota.Text) < 0 || Convert.ToDecimal(txtNota.Text) > 10)
            {
                MessageBox.Show("A nota deve estar entre 0 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cBoxBimestre.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um bimestre.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PopularClasseComAsNotas();
        }

        private void PopularClasseComAsNotas()
        {
            if (cBoxBimestre.SelectedIndex == 0)
                notaAluno.PrimeiroBimestre = Convert.ToDecimal(txtNota.Text);
            else if (cBoxBimestre.SelectedIndex == 1)
                notaAluno.SegundoBimestre = Convert.ToDecimal(txtNota.Text);
            else if (cBoxBimestre.SelectedIndex == 2)
                notaAluno.TerceiroBimestre = Convert.ToDecimal(txtNota.Text);
            else if (cBoxBimestre.SelectedIndex == 3)
                notaAluno.QuartoBimestre = Convert.ToDecimal(txtNota.Text);
            SalvarNota();
        }

        private void SalvarNota()
        {
            ConexaoNotaAluno conexaoNotaAluno = new ConexaoNotaAluno();
            if (conexaoNotaAluno.AlterarNota(notaAluno))
                MessageBox.Show("Nota salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao salvar a nota.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cBoxBimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxBimestre.SelectedIndex == 0)
                txtNota.Text = notaAluno.PrimeiroBimestre.ToString();
            else if (cBoxBimestre.SelectedIndex == 1)
                txtNota.Text = notaAluno.SegundoBimestre.ToString();
            else if (cBoxBimestre.SelectedIndex == 2)
                txtNota.Text = notaAluno.TerceiroBimestre.ToString();
            else if (cBoxBimestre.SelectedIndex == 3)
                txtNota.Text = notaAluno.QuartoBimestre.ToString();
        }
    }
}

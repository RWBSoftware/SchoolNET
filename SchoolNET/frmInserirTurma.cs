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
    public partial class frmInserirTurma : Form
    {
        public string NomeTurma { get; private set; }
        public frmInserirTurma(string NomeTurma = "")
        {
            InitializeComponent();
            this.NomeTurma = NomeTurma;
        }

        public void Apagar()
        {
            cBoxAno.SelectedIndex = -1;
            cboxSala.SelectedIndex = -1;
            txtTurma.Clear();
            cboxSala.Enabled = false;
            txtTurma.Enabled = false;
        }

        private void cBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAno.SelectedIndex != -1)
                cboxSala.Enabled = true;
        }

        private void cboxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSala.SelectedIndex != -1)
                txtTurma.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuEscola frmMenuEscola = new frmMenuEscola();
            frmMenuEscola.Show();
            this.Close();
        }
    }
}

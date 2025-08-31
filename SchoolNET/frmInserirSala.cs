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
    public partial class frmInserirSala : Form
    {
        public frmInserirSala()
        {
            InitializeComponent();
        }

        public void Apagar()
        {
            txtSala.Clear();
            txtCapacidade.Clear();
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

        private void txtCapacidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}

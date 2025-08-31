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
    public partial class frmMenuEscola : Form
    {
        public frmMenuEscola()
        {
            InitializeComponent();
        }

        public void ObterData()
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnInserirTurma_Click(object sender, EventArgs e)
        {
            frmInserirTurma frmInserirTurma = new frmInserirTurma();
            frmInserirTurma.Show();
            this.Close();
        }

        private void btnInserirSala_Click(object sender, EventArgs e)
        {
            frmInserirSala frmInserirSala = new frmInserirSala();
            frmInserirSala.Show();
            this.Close();
        }
    }
}

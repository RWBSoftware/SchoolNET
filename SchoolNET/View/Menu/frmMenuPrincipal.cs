using SchoolNET.View.MenuConfig;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            ObterHoras();
        }

        public void ObterHoras()
        {
            var data = DateTime.Now;
            lblData.Text = data.ToString("dd/MM/yyyy");
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmMenuAluno frmAluno = new frmMenuAluno();
            frmAluno.Show();
            this.Close();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmMenuProfessor frmProfessor = new frmMenuProfessor();
            frmProfessor.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            frmMenuEscola frmMenuEscola = new frmMenuEscola();
            frmMenuEscola.Show();
            this.Close();
        }
    }
}

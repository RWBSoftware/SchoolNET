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
    public partial class frmProfessorSala : Form
    {
        public frmProfessorSala()
        {
            InitializeComponent();
        }

        private void cBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAno.SelectedIndex != 1)
                cBoxTurma.Enabled = true;
            else
                cBoxTurma.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuProfessor frmMenuProfessor = new frmMenuProfessor();
            frmMenuProfessor.Show();
            this.Close();
        }
    }
}

using SchoolNET.View.MenuAluno;
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
    public partial class frmMenuAluno : Form
    {
        public frmMenuAluno()
        {
            InitializeComponent();
            ObterHoras();
        }
        public void ObterHoras()
        {
            var data = DateTime.Now;
            lblData.Text = data.ToString("dd/MM/yyyy");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenu = new frmMenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirAluno frmInserirAluno = new frmInserirAluno();
            frmInserirAluno.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditar frmEditar = new frmEditar();
            frmEditar.Show();
            this.Close();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoAluno frmHistoricoAluno = new frmHistoricoAluno();
            frmHistoricoAluno.Show();
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            frmInserirNota frmInserirNota = new frmInserirNota();
            frmInserirNota.Show();
            this.Close();
        }
    }
}

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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            CarregarDadosUsuarios();
        }

        public void CarregarDadosUsuarios()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Usuario))
            {
                txtUsuario.Text = Properties.Settings.Default.Usuario;
                txtSenha.Text = Properties.Settings.Default.Senha;
                cBoxLembrarMim.Checked = Properties.Settings.Default.LembrarMim;
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void cBoxLembrarMim_CheckedChanged(object sender, EventArgs e)
        {
            LembrarDeMim lembrarDeMim = new LembrarDeMim();

            if (cBoxLembrarMim.Checked)
                lembrarDeMim.Salvar(txtUsuario.Text, txtSenha.Text, cBoxLembrarMim.Checked);
            else
                lembrarDeMim.Excluir();


        }
    }
}

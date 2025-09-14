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
    public partial class frmLogin : Form
    {
        public Conexao conexao = new Conexao();
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
            VerificarDadosUsuario();
        }

        private void VerificarDadosUsuario()
        {
            if (conexao.Login(txtUsuario.Text, txtSenha.Text))
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Close();
            }
            else
                MensagemErro("Usuário ou senha incorretos!", "Erro ao efetuar login");
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

        private void MensagemErro(string erro, string nomeErro)
        {
            MessageBox.Show(erro, nomeErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

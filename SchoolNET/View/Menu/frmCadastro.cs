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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarCadastro();
        }

        private void ExibirErro(string erro, string nomeErro)
        {
            MessageBox.Show(erro, nomeErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VerificarCadastro()
        {
            if(txtUsuario.Text.Length < 4)
            {
                ExibirErro("O nome de usuário deve ter no mínimo 4 caracteres.", "Erro de Cadastro");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtSenhaNovamente.Text))
            {
                ExibirErro("Os campos de senha não podem estar vazios.", "Erro de Cadastro");
                return;
            }
            if (txtSenha.Text.Length < 6)
            {
                ExibirErro("A senha deve ter no mínimo 6 caracteres.", "Erro de Cadastro");
                return;
            }
            if (txtSenha.Text != txtSenhaNovamente.Text)
            {
                ExibirErro("As senhas não coincidem.", "Erro de Cadastro");
                return;
            }
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            Conexao conexao = new Conexao();
            if(conexao.Cadastro(txtUsuario.Text, txtSenha.Text))
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Close();
            }
            else
                ExibirErro("Erro ao cadastrar usuário. Tente novamente.", "Erro de Cadastro");
        }

    }
}

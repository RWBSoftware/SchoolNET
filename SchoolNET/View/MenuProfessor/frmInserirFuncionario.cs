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
    public partial class frmInserirFuncionario : Form
    {
        Professor professor = new Professor();
        public string cpf = "";
        public frmInserirFuncionario(string CPF = "")
        {
            InitializeComponent();
            ModoDeEditarProfessor(CPF);
        }

        public void Apagar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtObs.Clear();
            txtEndereco.Clear();
        }

        public void CorrigiraDataNoDT()
        {
            dtNascimento.Value = DateTime.Now;
            dtNascimento.MaxDate = DateTime.Now;
        }

        public void ModoDeEditarProfessor(string CPF)
        {
            this.cpf = CPF;
            ConexaoProfessor conexaoProfessor = new ConexaoProfessor();
            if (string.IsNullOrEmpty(CPF))
                CorrigiraDataNoDT();
            else
                PopularCampos(conexaoProfessor.ProcurarProfessor(CPF));
        }

        private void PopularCampos(Professor professor)
        {
            txtNome.Text = professor.NomeProfessor;
            txtCPF.Text = professor.CPF;
            txtTelefone.Text = professor.Telefone;
            txtEndereco.Text = professor.Endereco;
            txtObs.Text = professor.Observacoes;
            DateTime dataConvertida = DateTime.ParseExact(professor.DataNascimento, "dd/MM/yyyy", null);
            dtNascimento.Value = dataConvertida;
            this.professor = professor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarDadosProfessor();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cpf))
                AcessarFormsProfessor();
            else
            {
                frmEditarProfessor frmEditarProfessor = new frmEditarProfessor();
                frmEditarProfessor.Show();
                this.Close();
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void MensagemErro(string mensagem, string nomeErro)
        {
            MessageBox.Show(mensagem, nomeErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensagemSucesso(string mensagem, string nomeErro)
        {
            MessageBox.Show(mensagem, nomeErro, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void VerificarDadosProfessor()
        {
            if (txtNome.Text.Length < 8)
            {
                MensagemErro("O nome do professor deve conter no mínimo 8 caracteres.", "Erro ao inserir professor");
                return;
            }
            if (txtCPF.Text.Length != 14 || string.IsNullOrEmpty(txtCPF.Text))
            {
                MensagemErro("O CPF deve conter 11 dígitos.", "Erro ao inserir professor");
                return;
            }
            if (string.IsNullOrEmpty(txtTelefone.Text) || txtTelefone.Text.Length < 10)
            {
                MensagemErro("O telefone deve conter no mínimo 10 dígitos.", "Erro ao inserir professor");
                return;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text) || txtEndereco.Text.Length < 10)
            {
                MensagemErro("O endereço deve conter no mínimo 10 caracteres.", "Erro ao inserir professor");
                return;
            }

            if (string.IsNullOrEmpty(cpf))
                InserirProfessor(InserindoDadosNaClasse());
            else
                AlterarProfessor(InserindoDadosNaClasse());
        }

        public Professor InserindoDadosNaClasse()
        {
            Professor professor1 = new Professor();
            professor1.NomeProfessor = txtNome.Text;
            professor1.CPF = txtCPF.Text;
            professor1.Telefone = txtTelefone.Text;
            professor1.Endereco = txtEndereco.Text;
            professor1.Observacoes = txtObs.Text;
            DateTime dataNascimento = dtNascimento.Value;
            professor1.DataNascimento = dataNascimento.ToString("dd/MM/yyyy");
            return professor1;
        }

        public void InserirProfessor(Professor professor)
        {
            ConexaoProfessor conexaoProfessor = new ConexaoProfessor();
            if (conexaoProfessor.InserirProfessor(professor))
            {
                MensagemSucesso("Professor inserido com sucesso!", "Sucesso");
                AcessarFormsProfessor();
            }
            else
                MensagemSucesso("Erro ao inserir professor.", "Erro");
        }

        public void AlterarProfessor(Professor professor1)
        {
            ConexaoProfessor conexaoProfessor = new ConexaoProfessor();
            if (conexaoProfessor.AlterarProfessor(professor1, cpf))
            {
                MensagemSucesso("Professor alterado com sucesso!", "Sucesso");
                AcessarFormsProfessor();
            }
            else
                MensagemSucesso("Erro ao alterar professor.", "Erro");
        }

        public void AcessarFormsProfessor()
        {
            frmMenuProfessor frmMenuProfessor = new frmMenuProfessor();
            frmMenuProfessor.Show();
            this.Close();
        }

    }
}

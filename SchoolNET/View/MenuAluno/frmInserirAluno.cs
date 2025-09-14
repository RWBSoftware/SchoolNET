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
    public partial class frmInserirAluno : Form
    {
        public string matricula;
        Aluno aluno = new Aluno();

        public frmInserirAluno(string Matricula = "")
        {
            InitializeComponent();
            ModoDeEditarAluno(Matricula);
        }

        public void CorrigiraDataNoDT()
        {
            dtNascimento.Value = DateTime.Now;
            dtNascimento.MaxDate = DateTime.Now;
        }

        public void ModoDeEditarAluno(string Matricula)
        {
            ConexaoAluno conexaoAluno = new ConexaoAluno();
            if (string.IsNullOrEmpty(Matricula))
                CorrigiraDataNoDT();
            else
                PopularCampos(conexaoAluno.ProcurarAluno(Matricula));
        }

        private void PopularCampos(Aluno aluno)
        {
            txtNome.Text = aluno.NomeAluno;
            txtCPF.Text = aluno.CPF;
            txtMatricula.Text = aluno.Matricula;
            txtTelefone.Text = aluno.Telefone;
            txtResponsavel.Text = aluno.Responsavel;
            txtTelefoneResponsavel.Text = aluno.TelefoneResponsavel;
            txtEndereco.Text = aluno.Endereco;
            txtObs.Text = aluno.Observacoes;
            cBoxAno.SelectedItem = aluno.Ano;
            cBoxTurma.SelectedItem = aluno.Turma;
            DateTime dataConvertida = DateTime.ParseExact(aluno.DataNascimento, "dd/MM/yyyy", null);
            dtNascimento.Value = dataConvertida;
            this.aluno = aluno;
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtMatricula.Clear();
            txtTelefone.Clear();
            txtResponsavel.Clear();
            txtTelefoneResponsavel.Clear();
            txtEndereco.Clear();
            txtObs.Clear();
            cBoxAno.SelectedIndex = -1;
            cBoxAno.SelectedValue = "Ano";
            cBoxTurma.SelectedIndex = -1;
            cBoxTurma.SelectedValue = "Turma";
            dtNascimento.Value = dtNascimento.MaxDate;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarDadosAluno();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(matricula))
                AcessarFormsAluno();
            else
            {
                frmEditar frmEditar = new frmEditar();
                frmEditar.Show();
                this.Close();
            }
        }

        private void cBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxTurma.Items.Clear();
            if (cBoxAno.SelectedIndex != -1)
            {
                PopularComboBox();
                cBoxTurma.Enabled = true;
            }
            else
                cBoxTurma.Enabled = false;
        }

        private void PopularComboBox()
        {
            ConexaoTurma conexaoTurma = new ConexaoTurma();
            List<DadoTurma> turmas = conexaoTurma.SelecionarTurma(cBoxAno.Text);
            foreach (var turma in turmas)
                cBoxTurma.Items.Add(turma.NomeTurma);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
        private void MensagemErro(string mensagem, string nomeErro)
        {
            MessageBox.Show(mensagem, nomeErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensagemSucesso(string mensagem, string nomeErro)
        {
            MessageBox.Show(mensagem, nomeErro, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void VerificarDadosAluno()
        {
            if (txtNome.Text.Length < 8)
            {
                MensagemErro("O nome do aluno deve conter no mínimo 8 caracteres.", "Erro ao inserir aluno");
                return;
            }
            if (txtCPF.Text.Length != 14 || string.IsNullOrEmpty(txtCPF.Text))
            {
                MensagemErro("O CPF deve conter 11 dígitos.", "Erro ao inserir aluno");
                return;
            }
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MensagemErro("A matrícula não pode estar vazia.", "Erro ao inserir aluno");
                return;
            }
            if (string.IsNullOrEmpty(txtTelefone.Text) || txtTelefone.Text.Length < 10)
            {
                MensagemErro("O telefone deve conter no mínimo 10 dígitos.", "Erro ao inserir aluno");
                return;
            }
            if (string.IsNullOrEmpty(txtResponsavel.Text) || txtResponsavel.Text.Length < 8)
            {
                MensagemErro("O nome do responsável deve conter no mínimo 8 caracteres.", "Erro ao inserir aluno");
                return;
            }
            if (string.IsNullOrEmpty(txtTelefoneResponsavel.Text) || txtTelefoneResponsavel.Text.Length < 10)
            {
                MensagemErro("O telefone do responsável deve conter no mínimo 10 dígitos.", "Erro ao inserir aluno");
                return;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text) || txtEndereco.Text.Length < 10)
            {
                MensagemErro("O endereço deve conter no mínimo 10 caracteres.", "Erro ao inserir aluno");
                return;
            }
            if (cBoxAno.SelectedIndex == -1)
            {
                MensagemErro("Selecione o ano do aluno.", "Erro ao inserir aluno");
                return;
            }
            if (cBoxTurma.SelectedIndex == -1)
            {
                MensagemErro("Selecione a turma do aluno.", "Erro ao inserir aluno");
                return;
            }

            if (string.IsNullOrEmpty(aluno.Matricula))
                InserirAluno(InserindoDadosNaClasse());
            else
                AlterarAluno(InserindoDadosNaClasse());
        }

        public Aluno InserindoDadosNaClasse()
        {
            Aluno aluno1 = new Aluno();
            aluno1.NomeAluno = txtNome.Text;
            aluno1.CPF = txtCPF.Text;
            aluno1.Matricula = txtMatricula.Text;
            aluno1.Telefone = txtTelefone.Text;
            aluno1.Responsavel = txtResponsavel.Text;
            aluno1.TelefoneResponsavel = txtTelefoneResponsavel.Text;
            aluno1.Endereco = txtEndereco.Text;
            aluno1.Observacoes = txtObs.Text;
            aluno1.Ano = cBoxAno.SelectedItem.ToString();
            aluno1.Turma = cBoxTurma.SelectedItem.ToString();
            DateTime dataNascimento = dtNascimento.Value;
            aluno1.DataNascimento = dataNascimento.ToString("dd/MM/yyyy");
            return aluno1;
        }

        public void InserirAluno(Aluno aluno)
        {
            ConexaoAluno conexaoAluno = new ConexaoAluno();
            if (conexaoAluno.InserirAluno(aluno))
            {
                MensagemSucesso("Aluno inserido com sucesso!", "Sucesso");
                AcessarFormsAluno();
            }
                
            else
                MensagemSucesso("Erro ao inserir aluno.", "Erro");
        }

        public void AlterarAluno(Aluno aluno1)
        {
            ConexaoAluno conexaoAluno = new ConexaoAluno();
            if (conexaoAluno.AlterarAluno(aluno1, aluno.Matricula))
            {
                MensagemSucesso("Aluno alterado com sucesso!", "Sucesso");
                AcessarFormsAluno();
            }
            else
                MensagemSucesso("Erro ao alterar aluno.", "Erro");
        }

        public void AcessarFormsAluno()
        {
            frmMenuAluno frmMenuAluno = new frmMenuAluno();
            frmMenuAluno.Show();
            this.Close();
        }


    }
}

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
    public partial class frmInserirSala : Form
    {
        public string  NomeSala { get; set; }
        public frmInserirSala(string nomeSala = "", string capacidade = "")
        {
            InitializeComponent();
            NomeSala = nomeSala;
            ModoEdicao(nomeSala, capacidade);
        }

        private void ModoEdicao(string nomeSala, string capacidade)
        {
            if (string.IsNullOrEmpty(nomeSala))
                return;
            else
            {
                txtSala.Text = nomeSala;
                txtCapacidade.Text = capacidade;
            }
        }

        public void Apagar()
        {
            txtSala.Clear();
            txtCapacidade.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Verificao();
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

        private void Verificao()
        {
            if (string.IsNullOrEmpty(txtSala.Text)){
                MessageBox.Show("Preencha o campo Sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(int.TryParse(txtCapacidade.Text, out int capacidade));
            {
                if (capacidade <= 0)
                {
                    MessageBox.Show("A capacidade deve ser um número positivo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrEmpty(NomeSala))
                SalvarSala();
            else
                AtualizarSala();
        }

        private void SalvarSala()
        {
            ConexaoSala conexaoSala = new ConexaoSala();
            if (conexaoSala.InserirSala(txtSala.Text, int.Parse(txtCapacidade.Text)))
            {
                MessageBox.Show("Sala inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Apagar();
            }
            else
                MessageBox.Show("Erro ao inserir sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AtualizarSala()
        {
            ConexaoSala conexaoSala = new ConexaoSala();
            if (conexaoSala.AtualizarSala(txtSala.Text, int.Parse(txtCapacidade.Text), NomeSala))
            {
                MessageBox.Show("Sala atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Apagar();
                NomeSala = string.Empty;
            }
            else
                MessageBox.Show("Erro ao atualizar sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

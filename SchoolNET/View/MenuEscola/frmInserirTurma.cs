using SchoolNET.Data;
using SchoolNET.Controller;
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
    public partial class frmInserirTurma : Form
    {
        public string NomeTurma { get; private set; }
        public List<DadosSala> Salas { get; private set; }

        public frmInserirTurma(string NomeTurma = "")
        {
            InitializeComponent();
            PopularComboBox();
            this.NomeTurma = NomeTurma;
        }

        private void PopularComboBox()
        {
            ConexaoSala conexaoSala = new ConexaoSala();
            Salas = conexaoSala.BuscarTodasAsSalas();
            cboxSala.SelectedIndex = -1;
            foreach(var sala in Salas)
                cboxSala.Items.Add(sala.NomeSala);
        }

        public void Apagar()
        {
            cBoxAno.SelectedIndex = -1;
            cboxSala.SelectedIndex = -1;
            txtTurma.Clear();
            cboxSala.Enabled = false;
            txtTurma.Enabled = false;
        }

        private void cBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAno.SelectedIndex != -1)
                cboxSala.Enabled = true;
        }

        private void cboxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSala.SelectedIndex != -1)
                txtTurma.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Verificao();
        }

        private void Verificao()
        {
            if (cBoxAno.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Ano!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboxSala.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a Sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTurma.Text))
            {
                MessageBox.Show("Preencha o campo Turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SalvarTurma();
        }

        private void SalvarTurma()
        {
            ConexaoTurma conexaoTurma = new ConexaoTurma();
            int idSala = Salas[cboxSala.SelectedIndex].Id;
            if(conexaoTurma.InserirTurma(idSala, txtTurma.Text, cBoxAno.Text))
            {
                MessageBox.Show("Turma inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Apagar();
            }
            else
                MessageBox.Show("Erro ao inserir a Turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

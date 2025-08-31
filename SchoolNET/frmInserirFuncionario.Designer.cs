namespace SchoolNET
{
    partial class frmInserirFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirFuncionario));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSelecionar = new Button();
            btnRelatorio = new Button();
            cBoxTurma = new ComboBox();
            label11 = new Label();
            cBoxAno = new ComboBox();
            label10 = new Label();
            txtCPF = new MaskedTextBox();
            label5 = new Label();
            btnSalvar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            txtEndereco = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            btnRemover = new Button();
            cBoxTurmaSelecionada = new ComboBox();
            label3 = new Label();
            btnLimpar = new Button();
            txtObs = new TextBox();
            label9 = new Label();
            btnVoltar = new Button();
            label4 = new Label();
            txtTelefone = new MaskedTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 41;
            label1.Text = "Insira O Professor(a)";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSelecionar);
            panel2.Controls.Add(btnRelatorio);
            panel2.Controls.Add(cBoxTurma);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cBoxAno);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCPF);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 562);
            panel2.TabIndex = 2;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(106, 13, 173);
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionar.Location = new Point(124, 313);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(152, 48);
            btnSelecionar.TabIndex = 62;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(106, 13, 173);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(124, 471);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(152, 48);
            btnRelatorio.TabIndex = 59;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // cBoxTurma
            // 
            cBoxTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTurma.Enabled = false;
            cBoxTurma.FlatStyle = FlatStyle.Flat;
            cBoxTurma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxTurma.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxTurma.FormattingEnabled = true;
            cBoxTurma.Items.AddRange(new object[] { "Sala 1", "Sala 2", "Sala 3" });
            cBoxTurma.Location = new Point(81, 271);
            cBoxTurma.Name = "cBoxTurma";
            cBoxTurma.Size = new Size(238, 36);
            cBoxTurma.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(81, 237);
            label11.Name = "label11";
            label11.Size = new Size(85, 31);
            label11.TabIndex = 60;
            label11.Text = "Turma:";
            // 
            // cBoxAno
            // 
            cBoxAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxAno.FlatStyle = FlatStyle.Flat;
            cBoxAno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxAno.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxAno.FormattingEnabled = true;
            cBoxAno.Items.AddRange(new object[] { "1º Ano EF", "2º Ano EF", "3º Ano EF", "4º Ano EF", "5º Ano EF", "6º Ano EF", "7º Ano EF", "8º Ano EF", "9º Ano EF", "1º Ano EM", "2º Ano EM", "3º Ano EM" });
            cBoxAno.Location = new Point(81, 196);
            cBoxAno.Name = "cBoxAno";
            cBoxAno.Size = new Size(238, 36);
            cBoxAno.TabIndex = 58;
            cBoxAno.SelectedIndexChanged += cBoxAno_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 24, 39);
            label10.Location = new Point(81, 162);
            label10.Name = "label10";
            label10.Size = new Size(62, 31);
            label10.TabIndex = 56;
            label10.Text = "Ano:";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPF.ForeColor = Color.FromArgb(55, 65, 81);
            txtCPF.Location = new Point(81, 125);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(238, 34);
            txtCPF.TabIndex = 50;
            txtCPF.KeyPress += txtTelefone_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(17, 24, 39);
            label5.Location = new Point(78, 91);
            label5.Name = "label5";
            label5.Size = new Size(59, 31);
            label5.TabIndex = 49;
            label5.Text = "CPF:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(106, 13, 173);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(124, 417);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(152, 48);
            btnSalvar.TabIndex = 44;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(55, 65, 81);
            txtNome.Location = new Point(81, 54);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(238, 34);
            txtNome.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(78, 20);
            label2.Name = "label2";
            label2.Size = new Size(84, 31);
            label2.TabIndex = 42;
            label2.Text = "Nome:";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.ForeColor = Color.FromArgb(55, 65, 81);
            txtEndereco.Location = new Point(81, 198);
            txtEndereco.MaxLength = 1000;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.Size = new Size(238, 34);
            txtEndereco.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(17, 24, 39);
            label6.Location = new Point(81, 164);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 52;
            label6.Text = "Endereço:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRemover);
            panel3.Controls.Add(cBoxTurmaSelecionada);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnLimpar);
            panel3.Controls.Add(txtEndereco);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtObs);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnVoltar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTelefone);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(400, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 562);
            panel3.TabIndex = 3;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(106, 13, 173);
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(124, 313);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(152, 48);
            btnRemover.TabIndex = 65;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // cBoxTurmaSelecionada
            // 
            cBoxTurmaSelecionada.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTurmaSelecionada.FlatStyle = FlatStyle.Flat;
            cBoxTurmaSelecionada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxTurmaSelecionada.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxTurmaSelecionada.FormattingEnabled = true;
            cBoxTurmaSelecionada.Location = new Point(78, 271);
            cBoxTurmaSelecionada.Name = "cBoxTurmaSelecionada";
            cBoxTurmaSelecionada.Size = new Size(238, 36);
            cBoxTurmaSelecionada.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(81, 237);
            label3.Name = "label3";
            label3.Size = new Size(216, 31);
            label3.TabIndex = 63;
            label3.Text = "Turma Selecionada:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(106, 13, 173);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(124, 417);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(152, 48);
            btnLimpar.TabIndex = 62;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObs.ForeColor = Color.FromArgb(55, 65, 81);
            txtObs.Location = new Point(81, 125);
            txtObs.MaxLength = 1000;
            txtObs.Name = "txtObs";
            txtObs.PlaceholderText = "Observação";
            txtObs.Size = new Size(238, 34);
            txtObs.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(17, 24, 39);
            label9.Location = new Point(81, 91);
            label9.Name = "label9";
            label9.Size = new Size(173, 31);
            label9.TabIndex = 58;
            label9.Text = "OBS (Opcional)";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(124, 471);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(152, 48);
            btnVoltar.TabIndex = 45;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(78, 20);
            label4.Name = "label4";
            label4.Size = new Size(108, 31);
            label4.TabIndex = 48;
            label4.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            txtTelefone.Location = new Point(81, 54);
            txtTelefone.Mask = "(00) 000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(238, 34);
            txtTelefone.TabIndex = 51;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // frmInserirFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(800, 640);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInserirFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnRelatorio;
        private ComboBox cBoxAno;
        private Label label10;
        private TextBox txtEndereco;
        private Label label6;
        private MaskedTextBox txtCPF;
        private Label label5;
        private Button btnSalvar;
        private TextBox txtNome;
        private Label label2;
        private Panel panel3;
        private Button btnLimpar;
        private ComboBox cBoxTurma;
        private Label label11;
        private TextBox txtObs;
        private Label label9;
        private Button btnVoltar;
        private Label label4;
        private MaskedTextBox txtTelefone;
        private Label label3;
        private Button btnSelecionar;
        private ComboBox cBoxTurmaSelecionada;
        private Button btnRemover;
    }
}
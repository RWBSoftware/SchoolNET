namespace SchoolNET
{
    partial class frmInserirAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirAluno));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnRelatorio = new Button();
            cBoxAno = new ComboBox();
            label10 = new Label();
            txtResponsavel = new TextBox();
            label7 = new Label();
            txtEndereco = new TextBox();
            label6 = new Label();
            txtCPF = new MaskedTextBox();
            label5 = new Label();
            btnSalvar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            btnVoltar = new Button();
            panel3 = new Panel();
            btnLimpar = new Button();
            cBoxTurma = new ComboBox();
            label11 = new Label();
            txtObs = new TextBox();
            label9 = new Label();
            txtTelefoneResponsavel = new MaskedTextBox();
            label8 = new Label();
            txtMatricula = new TextBox();
            label3 = new Label();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 41;
            label1.Text = "Insira O Aluno(a)";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRelatorio);
            panel2.Controls.Add(cBoxAno);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtResponsavel);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEndereco);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCPF);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 562);
            panel2.TabIndex = 1;
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
            // cBoxAno
            // 
            cBoxAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxAno.FlatStyle = FlatStyle.Flat;
            cBoxAno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxAno.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxAno.FormattingEnabled = true;
            cBoxAno.Items.AddRange(new object[] { "1º Ano EF", "2º Ano EF", "3º Ano EF", "4º Ano EF", "5º Ano EF", "6º Ano EF", "7º Ano EF", "8º Ano EF", "9º Ano EF", "1º Ano EM", "2º Ano EM", "3º Ano EM" });
            cBoxAno.Location = new Point(81, 338);
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
            label10.Location = new Point(81, 304);
            label10.Name = "label10";
            label10.Size = new Size(62, 31);
            label10.TabIndex = 56;
            label10.Text = "Ano:";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResponsavel.ForeColor = Color.FromArgb(55, 65, 81);
            txtResponsavel.Location = new Point(81, 196);
            txtResponsavel.MaxLength = 60;
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.PlaceholderText = "Responsável";
            txtResponsavel.Size = new Size(238, 34);
            txtResponsavel.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(17, 24, 39);
            label7.Location = new Point(81, 162);
            label7.Name = "label7";
            label7.Size = new Size(148, 31);
            label7.TabIndex = 54;
            label7.Text = "Responsável:";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.ForeColor = Color.FromArgb(55, 65, 81);
            txtEndereco.Location = new Point(81, 267);
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
            label6.Location = new Point(81, 233);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 52;
            label6.Text = "Endereço:";
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
            txtCPF.KeyPress += txtCPF_KeyPress;
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
            // panel3
            // 
            panel3.Controls.Add(btnLimpar);
            panel3.Controls.Add(cBoxTurma);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtObs);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtTelefoneResponsavel);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtMatricula);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnVoltar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTelefone);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(400, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 562);
            panel3.TabIndex = 2;
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
            // cBoxTurma
            // 
            cBoxTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTurma.Enabled = false;
            cBoxTurma.FlatStyle = FlatStyle.Flat;
            cBoxTurma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxTurma.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxTurma.FormattingEnabled = true;
            cBoxTurma.Location = new Point(81, 338);
            cBoxTurma.Name = "cBoxTurma";
            cBoxTurma.Size = new Size(238, 36);
            cBoxTurma.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(78, 304);
            label11.Name = "label11";
            label11.Size = new Size(85, 31);
            label11.TabIndex = 60;
            label11.Text = "Turma:";
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObs.ForeColor = Color.FromArgb(55, 65, 81);
            txtObs.Location = new Point(81, 267);
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
            label9.Location = new Point(78, 233);
            label9.Name = "label9";
            label9.Size = new Size(173, 31);
            label9.TabIndex = 58;
            label9.Text = "OBS (Opcional)";
            // 
            // txtTelefoneResponsavel
            // 
            txtTelefoneResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefoneResponsavel.ForeColor = Color.FromArgb(55, 65, 81);
            txtTelefoneResponsavel.Location = new Point(81, 196);
            txtTelefoneResponsavel.Mask = "(00) 000000000";
            txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            txtTelefoneResponsavel.Size = new Size(238, 34);
            txtTelefoneResponsavel.TabIndex = 57;
            txtTelefoneResponsavel.KeyPress += txtCPF_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(17, 24, 39);
            label8.Location = new Point(78, 162);
            label8.Name = "label8";
            label8.Size = new Size(108, 31);
            label8.TabIndex = 56;
            label8.Text = "Telefone:";
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.ForeColor = Color.FromArgb(55, 65, 81);
            txtMatricula.Location = new Point(81, 54);
            txtMatricula.MaxLength = 60;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(238, 34);
            txtMatricula.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(78, 20);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 46;
            label3.Text = "Matricula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(78, 91);
            label4.Name = "label4";
            label4.Size = new Size(108, 31);
            label4.TabIndex = 48;
            label4.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            txtTelefone.Location = new Point(81, 125);
            txtTelefone.Mask = "(00) 000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(238, 34);
            txtTelefone.TabIndex = 51;
            txtTelefone.KeyPress += txtCPF_KeyPress;
            // 
            // frmInserirAluno
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
            Name = "frmInserirAluno";
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
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox txtResponsavel;
        private Label label7;
        private TextBox txtEndereco;
        private Label label6;
        private MaskedTextBox txtCPF;
        private Label label5;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtObs;
        private Label label9;
        private MaskedTextBox txtTelefoneResponsavel;
        private Label label8;
        private TextBox txtMatricula;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtTelefone;
        private Label label10;
        private ComboBox cBoxAno;
        private ComboBox cBoxTurma;
        private Label label11;
        private CheckBox cBoxMostrarSenha;
        private Button btnRelatorio;
        private Button btnLimpar;
    }
}
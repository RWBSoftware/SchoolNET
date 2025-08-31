namespace SchoolNET
{
    partial class frmInserirNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirNota));
            txtMatricula = new TextBox();
            label3 = new Label();
            cBoxBimestre = new ComboBox();
            label10 = new Label();
            txtNota = new TextBox();
            label1 = new Label();
            btnLimpar = new Button();
            btnVoltar = new Button();
            label2 = new Label();
            btnSalvar = new Button();
            label4 = new Label();
            lblAluno = new Label();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.ForeColor = Color.FromArgb(55, 65, 81);
            txtMatricula.Location = new Point(81, 113);
            txtMatricula.MaxLength = 60;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(238, 34);
            txtMatricula.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(81, 79);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 48;
            label3.Text = "Matricula:";
            // 
            // cBoxBimestre
            // 
            cBoxBimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxBimestre.Enabled = false;
            cBoxBimestre.FlatStyle = FlatStyle.Flat;
            cBoxBimestre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxBimestre.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxBimestre.FormattingEnabled = true;
            cBoxBimestre.Items.AddRange(new object[] { "1º Bimestre", "2º Bimestre", "3º Bimestre", "4º Bimestre" });
            cBoxBimestre.Location = new Point(81, 312);
            cBoxBimestre.Name = "cBoxBimestre";
            cBoxBimestre.Size = new Size(238, 36);
            cBoxBimestre.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 24, 39);
            label10.Location = new Point(81, 278);
            label10.Name = "label10";
            label10.Size = new Size(111, 31);
            label10.TabIndex = 59;
            label10.Text = "Bimestre:";
            // 
            // txtNota
            // 
            txtNota.Enabled = false;
            txtNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.ForeColor = Color.FromArgb(55, 65, 81);
            txtNota.Location = new Point(81, 385);
            txtNota.MaxLength = 2;
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "Nota";
            txtNota.Size = new Size(238, 34);
            txtNota.TabIndex = 62;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(81, 351);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 61;
            label1.Text = "Nota:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(106, 13, 173);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(124, 496);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(152, 48);
            btnLimpar.TabIndex = 64;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(124, 550);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(152, 48);
            btnVoltar.TabIndex = 63;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(105, 9);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 65;
            label2.Text = "Insira A Nota";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(106, 13, 173);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(124, 442);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(152, 48);
            btnSalvar.TabIndex = 66;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(81, 194);
            label4.Name = "label4";
            label4.Size = new Size(109, 31);
            label4.TabIndex = 67;
            label4.Text = "Aluno(a):";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = Color.FromArgb(17, 24, 39);
            lblAluno.Location = new Point(81, 225);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(207, 28);
            lblAluno.TabIndex = 68;
            lblAluno.Text = "Nenhum Encontrado";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(106, 13, 173);
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(81, 153);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(238, 38);
            btnPesquisar.TabIndex = 69;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmInserirNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(400, 614);
            Controls.Add(btnPesquisar);
            Controls.Add(lblAluno);
            Controls.Add(label4);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(btnLimpar);
            Controls.Add(btnVoltar);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Controls.Add(cBoxBimestre);
            Controls.Add(label10);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInserirNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private Label label3;
        private ComboBox cBoxBimestre;
        private Label label10;
        private TextBox txtNota;
        private Label label1;
        private Button btnLimpar;
        private Button btnVoltar;
        private Label label2;
        private Button btnSalvar;
        private Label label4;
        private Label lblAluno;
        private Button btnPesquisar;
    }
}
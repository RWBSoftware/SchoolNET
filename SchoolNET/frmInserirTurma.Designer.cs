namespace SchoolNET
{
    partial class frmInserirTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirTurma));
            label1 = new Label();
            cboxSala = new ComboBox();
            label11 = new Label();
            cBoxAno = new ComboBox();
            label10 = new Label();
            txtTurma = new TextBox();
            label3 = new Label();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 71;
            label1.Text = "Inserir Turma";
            // 
            // cboxSala
            // 
            cboxSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSala.Enabled = false;
            cboxSala.FlatStyle = FlatStyle.Flat;
            cboxSala.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxSala.ForeColor = Color.FromArgb(55, 65, 81);
            cboxSala.FormattingEnabled = true;
            cboxSala.Items.AddRange(new object[] { "Sala 1", "Sala 2", "Sala 3" });
            cboxSala.Location = new Point(81, 186);
            cboxSala.Name = "cboxSala";
            cboxSala.Size = new Size(238, 36);
            cboxSala.TabIndex = 70;
            cboxSala.SelectedIndexChanged += cboxSala_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(81, 152);
            label11.Name = "label11";
            label11.Size = new Size(63, 31);
            label11.TabIndex = 69;
            label11.Text = "Sala:";
            // 
            // cBoxAno
            // 
            cBoxAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxAno.FlatStyle = FlatStyle.Flat;
            cBoxAno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxAno.ForeColor = Color.FromArgb(55, 65, 81);
            cBoxAno.FormattingEnabled = true;
            cBoxAno.Items.AddRange(new object[] { "1º Ano EF", "2º Ano EF", "3º Ano EF", "4º Ano EF", "5º Ano EF", "6º Ano EF", "7º Ano EF", "8º Ano EF", "9º Ano EF", "1º Ano EM", "2º Ano EM", "3º Ano EM" });
            cBoxAno.Location = new Point(81, 113);
            cBoxAno.Name = "cBoxAno";
            cBoxAno.Size = new Size(238, 36);
            cBoxAno.TabIndex = 68;
            cBoxAno.SelectedIndexChanged += cBoxAno_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 24, 39);
            label10.Location = new Point(81, 79);
            label10.Name = "label10";
            label10.Size = new Size(62, 31);
            label10.TabIndex = 67;
            label10.Text = "Ano:";
            // 
            // txtTurma
            // 
            txtTurma.Enabled = false;
            txtTurma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTurma.ForeColor = Color.FromArgb(55, 65, 81);
            txtTurma.Location = new Point(81, 263);
            txtTurma.MaxLength = 60;
            txtTurma.Name = "txtTurma";
            txtTurma.PlaceholderText = "Ex: 1 A";
            txtTurma.Size = new Size(238, 34);
            txtTurma.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(81, 229);
            label3.Name = "label3";
            label3.Size = new Size(155, 31);
            label3.TabIndex = 72;
            label3.Text = "Nome Turma:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(106, 13, 173);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(124, 328);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(152, 48);
            btnSalvar.TabIndex = 74;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(106, 13, 173);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(124, 382);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(152, 48);
            btnLimpar.TabIndex = 76;
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
            btnVoltar.Location = new Point(124, 436);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(152, 48);
            btnVoltar.TabIndex = 75;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmInserirTurma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(400, 516);
            Controls.Add(btnLimpar);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTurma);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cboxSala);
            Controls.Add(label11);
            Controls.Add(cBoxAno);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInserirTurma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboxSala;
        private Label label11;
        private ComboBox cBoxAno;
        private Label label10;
        private TextBox txtTurma;
        private Label label3;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}
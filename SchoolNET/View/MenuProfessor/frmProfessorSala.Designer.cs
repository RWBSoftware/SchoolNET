namespace SchoolNET
{
    partial class frmProfessorSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessorSala));
            cBoxTurma = new ComboBox();
            label11 = new Label();
            cBoxAno = new ComboBox();
            label10 = new Label();
            label1 = new Label();
            txtSalas = new TextBox();
            label3 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
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
            cBoxTurma.Location = new Point(81, 155);
            cBoxTurma.Name = "cBoxTurma";
            cBoxTurma.Size = new Size(238, 36);
            cBoxTurma.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(82, 121);
            label11.Name = "label11";
            label11.Size = new Size(85, 31);
            label11.TabIndex = 64;
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
            cBoxAno.Location = new Point(81, 82);
            cBoxAno.Name = "cBoxAno";
            cBoxAno.Size = new Size(238, 36);
            cBoxAno.TabIndex = 63;
            cBoxAno.SelectedIndexChanged += cBoxAno_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 24, 39);
            label10.Location = new Point(82, 48);
            label10.Name = "label10";
            label10.Size = new Size(62, 31);
            label10.TabIndex = 62;
            label10.Text = "Ano:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 38);
            label1.TabIndex = 66;
            label1.Text = "Professores Da Sala";
            // 
            // txtSalas
            // 
            txtSalas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalas.ForeColor = Color.FromArgb(55, 65, 81);
            txtSalas.Location = new Point(81, 228);
            txtSalas.MaxLength = 1000;
            txtSalas.Multiline = true;
            txtSalas.Name = "txtSalas";
            txtSalas.PlaceholderText = "Prof Selecionados";
            txtSalas.ReadOnly = true;
            txtSalas.Size = new Size(238, 138);
            txtSalas.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(82, 194);
            label3.Name = "label3";
            label3.Size = new Size(207, 31);
            label3.TabIndex = 67;
            label3.Text = "Prof Selecionados:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(124, 385);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(152, 48);
            btnVoltar.TabIndex = 69;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmProfessorSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(400, 474);
            Controls.Add(btnVoltar);
            Controls.Add(txtSalas);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cBoxTurma);
            Controls.Add(label11);
            Controls.Add(cBoxAno);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmProfessorSala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxTurma;
        private Label label11;
        private ComboBox cBoxAno;
        private Label label10;
        private Label label1;
        private TextBox txtSalas;
        private Label label3;
        private Button btnVoltar;
    }
}
namespace SchoolNET
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAluno = new Button();
            btnFuncionarios = new Button();
            btnEscola = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            lblData = new Label();
            panel2 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAlunos = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label8 = new Label();
            label10 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblData);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 450);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAluno);
            flowLayoutPanel1.Controls.Add(btnFuncionarios);
            flowLayoutPanel1.Controls.Add(btnEscola);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Location = new Point(0, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 396);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnAluno
            // 
            btnAluno.BackColor = Color.FromArgb(106, 13, 173);
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluno.Location = new Point(3, 3);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(225, 48);
            btnAluno.TabIndex = 6;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            btnAluno.Click += btnAluno_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.FromArgb(106, 13, 173);
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarios.Location = new Point(3, 57);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(225, 48);
            btnFuncionarios.TabIndex = 7;
            btnFuncionarios.Text = "Professores";
            btnFuncionarios.UseVisualStyleBackColor = false;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnEscola
            // 
            btnEscola.BackColor = Color.FromArgb(106, 13, 173);
            btnEscola.FlatAppearance.BorderSize = 0;
            btnEscola.FlatStyle = FlatStyle.Flat;
            btnEscola.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscola.Location = new Point(3, 111);
            btnEscola.Name = "btnEscola";
            btnEscola.Size = new Size(225, 48);
            btnEscola.TabIndex = 8;
            btnEscola.Text = "Escola";
            btnEscola.UseVisualStyleBackColor = false;
            btnEscola.Click += btnEscola_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.Gray;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(3, 165);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(225, 48);
            btnConfig.TabIndex = 9;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 219);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(225, 48);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.Gray;
            lblData.Location = new Point(12, 9);
            lblData.Name = "lblData";
            lblData.Size = new Size(53, 28);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblAlunos);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(231, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 450);
            panel2.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(126, 312);
            label11.Name = "label11";
            label11.Size = new Size(33, 38);
            label11.TabIndex = 31;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(17, 24, 39);
            label12.Location = new Point(99, 269);
            label12.Name = "label12";
            label12.Size = new Size(87, 38);
            label12.TabIndex = 30;
            label12.Text = "Atual";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(17, 24, 39);
            label9.Location = new Point(124, 254);
            label9.Name = "label9";
            label9.Size = new Size(0, 38);
            label9.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(17, 24, 39);
            label7.Location = new Point(60, 231);
            label7.Name = "label7";
            label7.Size = new Size(166, 38);
            label7.TabIndex = 26;
            label7.Text = "Capacidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(126, 184);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 25;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(17, 24, 39);
            label5.Location = new Point(101, 146);
            label5.Name = "label5";
            label5.Size = new Size(83, 38);
            label5.TabIndex = 24;
            label5.Text = "Salas";
            // 
            // lblAlunos
            // 
            lblAlunos.AutoSize = true;
            lblAlunos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlunos.ForeColor = Color.FromArgb(17, 24, 39);
            lblAlunos.Location = new Point(126, 89);
            lblAlunos.Name = "lblAlunos";
            lblAlunos.Size = new Size(33, 38);
            lblAlunos.TabIndex = 21;
            lblAlunos.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(89, 54);
            label1.Name = "label1";
            label1.Size = new Size(108, 38);
            label1.TabIndex = 20;
            label1.Text = "Alunos";
            // 
            // panel3
            // 
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(517, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 450);
            panel3.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(17, 24, 39);
            label13.Location = new Point(126, 312);
            label13.Name = "label13";
            label13.Size = new Size(33, 38);
            label13.TabIndex = 43;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(17, 24, 39);
            label14.Location = new Point(78, 269);
            label14.Name = "label14";
            label14.Size = new Size(130, 38);
            label14.TabIndex = 42;
            label14.Text = "Restante";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(17, 24, 39);
            label15.Location = new Point(198, 257);
            label15.Name = "label15";
            label15.Size = new Size(0, 38);
            label15.TabIndex = 41;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(17, 24, 39);
            label16.Location = new Point(60, 231);
            label16.Name = "label16";
            label16.Size = new Size(166, 38);
            label16.TabIndex = 40;
            label16.Text = "Capacidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(17, 24, 39);
            label8.Location = new Point(126, 184);
            label8.Name = "label8";
            label8.Size = new Size(33, 38);
            label8.TabIndex = 39;
            label8.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 24, 39);
            label10.Location = new Point(87, 146);
            label10.Name = "label10";
            label10.Size = new Size(112, 38);
            label10.TabIndex = 38;
            label10.Text = "Turmas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(126, 89);
            label2.Name = "label2";
            label2.Size = new Size(33, 38);
            label2.TabIndex = 37;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(59, 54);
            label3.Name = "label3";
            label3.Size = new Size(167, 38);
            label3.TabIndex = 36;
            label3.Text = "Professores";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(803, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblData;
        private Button btnAluno;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnFuncionarios;
        private Button btnEscola;
        private Button btnConfig;
        private Button btnSair;
        private Panel panel2;
        private Label label11;
        private Label label12;
        private Label label9;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label lblAlunos;
        private Label label1;
        private Panel panel3;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label8;
        private Label label10;
        private Label label2;
        private Label label3;
    }
}
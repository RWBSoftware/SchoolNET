namespace SchoolNET
{
    partial class frmMenuEscola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuEscola));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInserirTurma = new Button();
            btnEditarTurma = new Button();
            btnInserirSala = new Button();
            btnEditarSala = new Button();
            btnRelatorio = new Button();
            btnVoltar = new Button();
            lblData = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInserirTurma);
            flowLayoutPanel1.Controls.Add(btnEditarTurma);
            flowLayoutPanel1.Controls.Add(btnInserirSala);
            flowLayoutPanel1.Controls.Add(btnEditarSala);
            flowLayoutPanel1.Controls.Add(btnRelatorio);
            flowLayoutPanel1.Controls.Add(btnVoltar);
            flowLayoutPanel1.Location = new Point(0, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 396);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnInserirTurma
            // 
            btnInserirTurma.BackColor = Color.FromArgb(106, 13, 173);
            btnInserirTurma.FlatAppearance.BorderSize = 0;
            btnInserirTurma.FlatStyle = FlatStyle.Flat;
            btnInserirTurma.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirTurma.Location = new Point(3, 3);
            btnInserirTurma.Name = "btnInserirTurma";
            btnInserirTurma.Size = new Size(225, 48);
            btnInserirTurma.TabIndex = 6;
            btnInserirTurma.Text = "Inserir Turma";
            btnInserirTurma.UseVisualStyleBackColor = false;
            btnInserirTurma.Click += btnInserirTurma_Click;
            // 
            // btnEditarTurma
            // 
            btnEditarTurma.BackColor = Color.FromArgb(106, 13, 173);
            btnEditarTurma.FlatAppearance.BorderSize = 0;
            btnEditarTurma.FlatStyle = FlatStyle.Flat;
            btnEditarTurma.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarTurma.Location = new Point(3, 57);
            btnEditarTurma.Name = "btnEditarTurma";
            btnEditarTurma.Size = new Size(225, 48);
            btnEditarTurma.TabIndex = 7;
            btnEditarTurma.Text = "Editar Turma";
            btnEditarTurma.UseVisualStyleBackColor = false;
            // 
            // btnInserirSala
            // 
            btnInserirSala.BackColor = Color.FromArgb(106, 13, 173);
            btnInserirSala.FlatAppearance.BorderSize = 0;
            btnInserirSala.FlatStyle = FlatStyle.Flat;
            btnInserirSala.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirSala.Location = new Point(3, 111);
            btnInserirSala.Name = "btnInserirSala";
            btnInserirSala.Size = new Size(225, 48);
            btnInserirSala.TabIndex = 8;
            btnInserirSala.Text = "Inserir Sala";
            btnInserirSala.UseVisualStyleBackColor = false;
            btnInserirSala.Click += btnInserirSala_Click;
            // 
            // btnEditarSala
            // 
            btnEditarSala.BackColor = Color.FromArgb(106, 13, 173);
            btnEditarSala.FlatAppearance.BorderSize = 0;
            btnEditarSala.FlatStyle = FlatStyle.Flat;
            btnEditarSala.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarSala.Location = new Point(3, 165);
            btnEditarSala.Name = "btnEditarSala";
            btnEditarSala.Size = new Size(225, 48);
            btnEditarSala.TabIndex = 9;
            btnEditarSala.Text = "Editar Sala";
            btnEditarSala.UseVisualStyleBackColor = false;
            btnEditarSala.Click += btnEditarSala_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(106, 13, 173);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(3, 219);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(225, 48);
            btnRelatorio.TabIndex = 12;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(3, 273);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(225, 48);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
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
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.SchoolNET_Logo_Sem_Fundo;
            pictureBox1.Location = new Point(231, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmMenuEscola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuEscola";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnInserirTurma;
        private Button btnEditarTurma;
        private Label lblData;
        private PictureBox pictureBox1;
        private Button btnInserirSala;
        private Button btnEditarSala;
        private Button btnRelatorio;
        private Button btnVoltar;
    }
}
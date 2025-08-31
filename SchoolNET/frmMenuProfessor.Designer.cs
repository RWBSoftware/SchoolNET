namespace SchoolNET
{
    partial class frmMenuProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuProfessor));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInserir = new Button();
            btnEditar = new Button();
            btnSala = new Button();
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
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInserir);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnSala);
            flowLayoutPanel1.Controls.Add(btnRelatorio);
            flowLayoutPanel1.Controls.Add(btnVoltar);
            flowLayoutPanel1.Location = new Point(0, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 396);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(106, 13, 173);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(3, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(225, 48);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "Inserir Professor(a)";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(106, 13, 173);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(3, 57);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(225, 48);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar Professor(a)";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSala
            // 
            btnSala.BackColor = Color.FromArgb(106, 13, 173);
            btnSala.FlatAppearance.BorderSize = 0;
            btnSala.FlatStyle = FlatStyle.Flat;
            btnSala.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSala.Location = new Point(3, 111);
            btnSala.Name = "btnSala";
            btnSala.Size = new Size(225, 76);
            btnSala.TabIndex = 8;
            btnSala.Text = "Professores Da Sala";
            btnSala.UseVisualStyleBackColor = false;
            btnSala.Click += btnSala_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(106, 13, 173);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(3, 193);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(225, 48);
            btnRelatorio.TabIndex = 10;
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
            btnVoltar.Location = new Point(3, 247);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(225, 48);
            btnVoltar.TabIndex = 11;
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmMenuProfessor
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
            Name = "frmMenuProfessor";
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
        private Button btnInserir;
        private Button btnEditar;
        private Button btnSala;
        private Button btnRelatorio;
        private Button btnVoltar;
        private Label lblData;
        private PictureBox pictureBox1;
    }
}
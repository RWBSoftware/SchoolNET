namespace SchoolNET
{
    partial class frmEditarProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProfessor));
            dgv1 = new DataGridView();
            btnVoltar = new Button();
            btnExcluir = new Button();
            btnSelecionar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(0, 0);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(580, 497);
            dgv1.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(586, 191);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(202, 48);
            btnVoltar.TabIndex = 53;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(106, 13, 173);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(586, 137);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(202, 48);
            btnExcluir.TabIndex = 52;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(106, 13, 173);
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionar.Location = new Point(586, 83);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(202, 48);
            btnSelecionar.TabIndex = 51;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click_1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(55, 65, 81);
            txtNome.Location = new Point(586, 43);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome/CPF";
            txtNome.Size = new Size(202, 34);
            txtNome.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(586, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 49;
            label2.Text = "Pesquisa:";
            // 
            // frmEditarProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSelecionar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(dgv1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmEditarProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private Button btnVoltar;
        private Button btnExcluir;
        private Button btnSelecionar;
        private TextBox txtNome;
        private Label label2;
    }
}
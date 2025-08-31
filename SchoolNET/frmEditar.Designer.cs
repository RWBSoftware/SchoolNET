namespace SchoolNET
{
    partial class frmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Matricula = new DataGridViewTextBoxColumn();
            txtNome = new TextBox();
            label2 = new Label();
            btnSelecionar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Matricula });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(580, 497);
            dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.MinimumWidth = 6;
            Matricula.Name = "Matricula";
            Matricula.ReadOnly = true;
            Matricula.Width = 125;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(55, 65, 81);
            txtNome.Location = new Point(586, 41);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome/Matricula";
            txtNome.Size = new Size(202, 34);
            txtNome.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(586, 7);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 44;
            label2.Text = "Pesquisa:";
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(106, 13, 173);
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionar.Location = new Point(586, 81);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(202, 48);
            btnSelecionar.TabIndex = 46;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(106, 13, 173);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(586, 135);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(202, 48);
            btnExcluir.TabIndex = 47;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(586, 189);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(202, 48);
            btnVoltar.TabIndex = 48;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmEditar
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
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Matricula;
        private TextBox txtNome;
        private Label label2;
        private Button btnSelecionar;
        private Button btnExcluir;
        private Button btnVoltar;
    }
}
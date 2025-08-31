namespace SchoolNET
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            cBoxMostrarSenha = new CheckBox();
            btnVoltar = new Button();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSenhaNovamente = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.Location = new Point(128, 283);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(144, 27);
            cBoxMostrarSenha.TabIndex = 16;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(133, 370);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(134, 48);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(106, 13, 173);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(133, 316);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(134, 48);
            btnEntrar.TabIndex = 14;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(55, 65, 81);
            txtSenha.Location = new Point(81, 166);
            txtSenha.MaxLength = 60;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(238, 34);
            txtSenha.TabIndex = 13;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(81, 132);
            label3.Name = "label3";
            label3.Size = new Size(83, 31);
            label3.TabIndex = 12;
            label3.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(55, 65, 81);
            txtUsuario.Location = new Point(81, 93);
            txtUsuario.MaxLength = 60;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(238, 34);
            txtUsuario.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(81, 59);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 10;
            label2.Text = "Usuário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 9;
            label1.Text = "Efetue Seu Cadastro";
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaNovamente.ForeColor = Color.FromArgb(55, 65, 81);
            txtSenhaNovamente.Location = new Point(81, 243);
            txtSenhaNovamente.MaxLength = 60;
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PlaceholderText = "Senha Novamente";
            txtSenhaNovamente.Size = new Size(238, 34);
            txtSenhaNovamente.TabIndex = 19;
            txtSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(81, 209);
            label4.Name = "label4";
            label4.Size = new Size(210, 31);
            label4.TabIndex = 18;
            label4.Text = "Senha Novamente:";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(400, 456);
            Controls.Add(txtSenhaNovamente);
            Controls.Add(label4);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cBoxMostrarSenha;
        private Button btnVoltar;
        private Button btnEntrar;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private TextBox txtSenhaNovamente;
        private Label label4;
    }
}
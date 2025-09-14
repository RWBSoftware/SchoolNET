namespace SchoolNET.View.MenuConfig
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnSair = new Button();
            btnAvaliacao = new Button();
            btnTrocarConta = new Button();
            btnAlterarSenha = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(100, 220);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 55);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(106, 13, 173);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvaliacao.Location = new Point(100, 159);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(200, 55);
            btnAvaliacao.TabIndex = 4;
            btnAvaliacao.Text = "Avaliação";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // btnTrocarConta
            // 
            btnTrocarConta.BackColor = Color.FromArgb(106, 13, 173);
            btnTrocarConta.FlatAppearance.BorderSize = 0;
            btnTrocarConta.FlatStyle = FlatStyle.Flat;
            btnTrocarConta.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrocarConta.Location = new Point(100, 98);
            btnTrocarConta.Name = "btnTrocarConta";
            btnTrocarConta.Size = new Size(200, 55);
            btnTrocarConta.TabIndex = 6;
            btnTrocarConta.Text = "Trocar Conta";
            btnTrocarConta.UseVisualStyleBackColor = false;
            btnTrocarConta.Click += btnTrocarConta_Click;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.BackColor = Color.FromArgb(106, 13, 173);
            btnAlterarSenha.FlatAppearance.BorderSize = 0;
            btnAlterarSenha.FlatStyle = FlatStyle.Flat;
            btnAlterarSenha.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterarSenha.Location = new Point(100, 37);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(200, 55);
            btnAlterarSenha.TabIndex = 7;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = false;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(400, 310);
            Controls.Add(btnAlterarSenha);
            Controls.Add(btnTrocarConta);
            Controls.Add(btnSair);
            Controls.Add(btnAvaliacao);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolNET";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private Button btnAvaliacao;
        private Button btnTrocarConta;
        private Button btnAlterarSenha;
    }
}
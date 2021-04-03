
namespace App_SA
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAtencao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.linkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcessarConta = new System.Windows.Forms.Button();
            this.btnCadastroProfissional = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAtencao
            // 
            this.lblAtencao.AutoSize = true;
            this.lblAtencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAtencao.Location = new System.Drawing.Point(104, 68);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(216, 13);
            this.lblAtencao.TabIndex = 0;
            this.lblAtencao.Text = "ATENÇÃO - Informe os campos obrigatórios.";
            this.lblAtencao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(32, 117);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(348, 20);
            this.txtBoxLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(32, 171);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(348, 20);
            this.txtBoxSenha.TabIndex = 4;
            // 
            // linkEsqueceuSenha
            // 
            this.linkEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkEsqueceuSenha.AutoSize = true;
            this.linkEsqueceuSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.linkEsqueceuSenha.ForeColor = System.Drawing.Color.Green;
            this.linkEsqueceuSenha.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkEsqueceuSenha.Location = new System.Drawing.Point(143, 201);
            this.linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            this.linkEsqueceuSenha.Size = new System.Drawing.Size(122, 17);
            this.linkEsqueceuSenha.TabIndex = 5;
            this.linkEsqueceuSenha.TabStop = true;
            this.linkEsqueceuSenha.Text = "Esqueceu a senha?";
            this.linkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEsqueceuSenha_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "WORKERS";
            // 
            // btnAcessarConta
            // 
            this.btnAcessarConta.BackColor = System.Drawing.Color.Yellow;
            this.btnAcessarConta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAcessarConta.ForeColor = System.Drawing.Color.Black;
            this.btnAcessarConta.Location = new System.Drawing.Point(32, 225);
            this.btnAcessarConta.Name = "btnAcessarConta";
            this.btnAcessarConta.Size = new System.Drawing.Size(348, 27);
            this.btnAcessarConta.TabIndex = 7;
            this.btnAcessarConta.Text = "Acessar minha conta";
            this.btnAcessarConta.UseVisualStyleBackColor = false;
            this.btnAcessarConta.Click += new System.EventHandler(this.btnAcessarConta_Click);
            // 
            // btnCadastroProfissional
            // 
            this.btnCadastroProfissional.BackColor = System.Drawing.Color.Yellow;
            this.btnCadastroProfissional.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastroProfissional.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroProfissional.Location = new System.Drawing.Point(32, 321);
            this.btnCadastroProfissional.Name = "btnCadastroProfissional";
            this.btnCadastroProfissional.Size = new System.Drawing.Size(165, 27);
            this.btnCadastroProfissional.TabIndex = 8;
            this.btnCadastroProfissional.Text = "Cadastro Profissional";
            this.btnCadastroProfissional.UseVisualStyleBackColor = false;
            this.btnCadastroProfissional.Click += new System.EventHandler(this.btnCadastroProfissional_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.Yellow;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.Location = new System.Drawing.Point(215, 321);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(165, 27);
            this.btnCadastroCliente.TabIndex = 9;
            this.btnCadastroCliente.Text = "Cadastro Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 369);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnCadastroProfissional);
            this.Controls.Add(this.btnAcessarConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkEsqueceuSenha);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAtencao);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.LinkLabel linkEsqueceuSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcessarConta;
        private System.Windows.Forms.Button btnCadastroProfissional;
        private System.Windows.Forms.Button btnCadastroCliente;
    }
}


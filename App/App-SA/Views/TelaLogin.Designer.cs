
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.linkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcessarConta = new System.Windows.Forms.Button();
            this.btnCadastroProfissional = new System.Windows.Forms.Button();
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
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(32, 93);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 21);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.AcceptsTab = true;
            this.txtBoxLogin.BackColor = System.Drawing.Color.White;
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogin.Location = new System.Drawing.Point(32, 117);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(348, 20);
            this.txtBoxLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(28, 147);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 21);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.AcceptsTab = true;
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
            this.btnCadastroProfissional.Location = new System.Drawing.Point(32, 258);
            this.btnCadastroProfissional.Name = "btnCadastroProfissional";
            this.btnCadastroProfissional.Size = new System.Drawing.Size(348, 27);
            this.btnCadastroProfissional.TabIndex = 8;
            this.btnCadastroProfissional.Text = "Cadastre-se";
            this.btnCadastroProfissional.UseVisualStyleBackColor = false;
            this.btnCadastroProfissional.Click += new System.EventHandler(this.btnCadastroProfissional_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 306);
            this.Controls.Add(this.btnCadastroProfissional);
            this.Controls.Add(this.btnAcessarConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkEsqueceuSenha);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblAtencao);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.LinkLabel linkEsqueceuSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcessarConta;
        private System.Windows.Forms.Button btnCadastroProfissional;
    }
}


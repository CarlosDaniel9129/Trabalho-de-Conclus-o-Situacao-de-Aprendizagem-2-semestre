namespace App_SA.Views
{
    partial class TelaRecuperaSenha
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNewSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNewSenha = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConf1 = new System.Windows.Forms.Button();
            this.btnConf2 = new System.Windows.Forms.Button();
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(170, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Recupera Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(41, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(478, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtNewSenha
            // 
            this.txtNewSenha.Location = new System.Drawing.Point(41, 83);
            this.txtNewSenha.Name = "txtNewSenha";
            this.txtNewSenha.Size = new System.Drawing.Size(478, 20);
            this.txtNewSenha.TabIndex = 22;
            this.txtNewSenha.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(37, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Digite seu Email";
            // 
            // lblNewSenha
            // 
            this.lblNewSenha.AutoSize = true;
            this.lblNewSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewSenha.ForeColor = System.Drawing.Color.White;
            this.lblNewSenha.Location = new System.Drawing.Point(37, 61);
            this.lblNewSenha.Name = "lblNewSenha";
            this.lblNewSenha.Size = new System.Drawing.Size(90, 19);
            this.lblNewSenha.TabIndex = 25;
            this.lblNewSenha.Text = "Nova Senha";
            this.lblNewSenha.Visible = false;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(37, 141);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(122, 19);
            this.lblConfSenha.TabIndex = 26;
            this.lblConfSenha.Text = "Confirmar Senha";
            this.lblConfSenha.Visible = false;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(41, 163);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(478, 20);
            this.txtConfSenha.TabIndex = 27;
            this.txtConfSenha.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(41, 257);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(224, 50);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConf1
            // 
            this.btnConf1.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConf1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConf1.ForeColor = System.Drawing.Color.Black;
            this.btnConf1.Location = new System.Drawing.Point(295, 257);
            this.btnConf1.Name = "btnConf1";
            this.btnConf1.Size = new System.Drawing.Size(224, 50);
            this.btnConf1.TabIndex = 30;
            this.btnConf1.Text = "Confirmar";
            this.btnConf1.UseVisualStyleBackColor = false;
            this.btnConf1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConf2
            // 
            this.btnConf2.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConf2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConf2.ForeColor = System.Drawing.Color.Black;
            this.btnConf2.Location = new System.Drawing.Point(295, 254);
            this.btnConf2.Name = "btnConf2";
            this.btnConf2.Size = new System.Drawing.Size(224, 53);
            this.btnConf2.TabIndex = 31;
            this.btnConf2.Text = "Confirmar";
            this.btnConf2.UseVisualStyleBackColor = false;
            this.btnConf2.Visible = false;
            this.btnConf2.Click += new System.EventHandler(this.btnConfSenha_Click);
            // 
            // mkbCpf
            // 
            this.mkbCpf.Location = new System.Drawing.Point(41, 163);
            this.mkbCpf.Mask = "000\\.000\\.000\\-00";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(298, 20);
            this.mkbCpf.TabIndex = 32;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(37, 141);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(122, 19);
            this.lblCpf.TabIndex = 33;
            this.lblCpf.Text = "Informe seu CPF";
            // 
            // TelaRecuperaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(549, 350);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mkbCpf);
            this.Controls.Add(this.btnConf2);
            this.Controls.Add(this.btnConf1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblNewSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNewSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Name = "TelaRecuperaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperaSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNewSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNewSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConf1;
        private System.Windows.Forms.Button btnConf2;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.Label lblCpf;
    }
}
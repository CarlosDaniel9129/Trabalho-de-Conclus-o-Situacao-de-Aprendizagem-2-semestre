
namespace App_SA
{
    partial class TelaPesquisa
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
            this.gridProfissionais = new System.Windows.Forms.DataGridView();
            this.Profissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTxtValorMin = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProcurarPeloBairro = new System.Windows.Forms.CheckBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTxtValorMax = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfissionais
            // 
            this.gridProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profissional,
            this.Profissao,
            this.Estado,
            this.Cidade,
            this.Formacao,
            this.Preco,
            this.Descricao});
            this.gridProfissionais.Location = new System.Drawing.Point(-6, 333);
            this.gridProfissionais.Name = "gridProfissionais";
            this.gridProfissionais.Size = new System.Drawing.Size(973, 311);
            this.gridProfissionais.TabIndex = 1;
            this.gridProfissionais.Text = "dataGridView1";
            // 
            // Profissional
            // 
            this.Profissional.HeaderText = "Profissional";
            this.Profissional.Name = "Profissional";
            this.Profissional.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Profissional.Width = 130;
            // 
            // Profissao
            // 
            this.Profissao.HeaderText = "Profissão";
            this.Profissao.Name = "Profissao";
            this.Profissao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Profissao.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.Width = 102;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cidade.Width = 130;
            // 
            // Formacao
            // 
            this.Formacao.HeaderText = "Formação";
            this.Formacao.Name = "Formacao";
            this.Formacao.Width = 150;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Valor Hora / Preço";
            this.Preco.Name = "Preco";
            this.Preco.Width = 130;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 250;
            // 
            // maskedTxtValorMin
            // 
            this.maskedTxtValorMin.Location = new System.Drawing.Point(26, 146);
            this.maskedTxtValorMin.Mask = "$000\\.00";
            this.maskedTxtValorMin.Name = "maskedTxtValorMin";
            this.maskedTxtValorMin.Size = new System.Drawing.Size(161, 20);
            this.maskedTxtValorMin.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor Mínimo";
            // 
            // cbProcurarPeloBairro
            // 
            this.cbProcurarPeloBairro.AutoSize = true;
            this.cbProcurarPeloBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbProcurarPeloBairro.ForeColor = System.Drawing.Color.White;
            this.cbProcurarPeloBairro.Location = new System.Drawing.Point(26, 190);
            this.cbProcurarPeloBairro.Name = "cbProcurarPeloBairro";
            this.cbProcurarPeloBairro.Size = new System.Drawing.Size(279, 25);
            this.cbProcurarPeloBairro.TabIndex = 16;
            this.cbProcurarPeloBairro.Text = "Pesquisar pelo bairro do usuário.";
            this.cbProcurarPeloBairro.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(528, 239);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(401, 50);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbcidade
            // 
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Items.AddRange(new object[] {
            "50"});
            this.cbcidade.Location = new System.Drawing.Point(528, 146);
            this.cbcidade.Name = "cbcidade";
            this.cbcidade.Size = new System.Drawing.Size(401, 21);
            this.cbcidade.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(528, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cidade";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "100"});
            this.cbEstado.Location = new System.Drawing.Point(528, 79);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(401, 21);
            this.cbEstado.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(529, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Yellow;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.Location = new System.Drawing.Point(26, 239);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(408, 54);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(26, 80);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(408, 20);
            this.txtProfissao.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Profissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(332, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pesquisa dos Profissionais";
            // 
            // maskedTxtValorMax
            // 
            this.maskedTxtValorMax.Location = new System.Drawing.Point(261, 146);
            this.maskedTxtValorMax.Mask = "$000\\.00";
            this.maskedTxtValorMax.Name = "maskedTxtValorMax";
            this.maskedTxtValorMax.Size = new System.Drawing.Size(173, 20);
            this.maskedTxtValorMax.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(257, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor Máximo";
            // 
            // TelaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(966, 608);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTxtValorMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTxtValorMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProcurarPeloBairro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbcidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProfissionais);
            this.Name = "TelaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfissionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfissionais;
        private System.Windows.Forms.MaskedTextBox maskedTxtValorMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbProcurarPeloBairro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.MaskedTextBox maskedTxtValorMax;
        private System.Windows.Forms.Label label6;
    }
}
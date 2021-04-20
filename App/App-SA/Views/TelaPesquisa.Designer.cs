
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisa));
            this.gridProfissionais = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValorMin = new System.Windows.Forms.Label();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorMax = new System.Windows.Forms.Label();
            this.btnMinhaConta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.maskedTxtValorMin = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtValorMax = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvisoValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfissionais
            // 
            this.gridProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nome,
            this.Profissao,
            this.formacao,
            this.estado,
            this.cidade,
            this.valorHora,
            this.telefone});
            this.gridProfissionais.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            resources.ApplyResources(this.gridProfissionais, "gridProfissionais");
            this.gridProfissionais.MultiSelect = false;
            this.gridProfissionais.Name = "gridProfissionais";
            this.gridProfissionais.ReadOnly = true;
            this.gridProfissionais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfissionais_CellDoubleClick);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            resources.ApplyResources(this.idUsuario, "idUsuario");
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            resources.ApplyResources(this.nome, "nome");
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // Profissao
            // 
            this.Profissao.DataPropertyName = "profissao";
            resources.ApplyResources(this.Profissao, "Profissao");
            this.Profissao.Name = "Profissao";
            this.Profissao.ReadOnly = true;
            // 
            // formacao
            // 
            this.formacao.DataPropertyName = "formacao";
            resources.ApplyResources(this.formacao, "formacao");
            this.formacao.Name = "formacao";
            this.formacao.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            resources.ApplyResources(this.estado, "estado");
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            resources.ApplyResources(this.cidade, "cidade");
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // valorHora
            // 
            this.valorHora.DataPropertyName = "valorHora";
            resources.ApplyResources(this.valorHora, "valorHora");
            this.valorHora.Name = "valorHora";
            this.valorHora.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            resources.ApplyResources(this.telefone, "telefone");
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // lblValorMin
            // 
            resources.ApplyResources(this.lblValorMin, "lblValorMin");
            this.lblValorMin.ForeColor = System.Drawing.Color.White;
            this.lblValorMin.Name = "lblValorMin";
            // 
            // cbcidade
            // 
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Items.AddRange(new object[] {
            resources.GetString("cbcidade.Items")});
            resources.ApplyResources(this.cbcidade, "cbcidade");
            this.cbcidade.Name = "cbcidade";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            resources.GetString("cbEstado.Items"),
            resources.GetString("cbEstado.Items1"),
            resources.GetString("cbEstado.Items2"),
            resources.GetString("cbEstado.Items3"),
            resources.GetString("cbEstado.Items4"),
            resources.GetString("cbEstado.Items5"),
            resources.GetString("cbEstado.Items6"),
            resources.GetString("cbEstado.Items7"),
            resources.GetString("cbEstado.Items8"),
            resources.GetString("cbEstado.Items9"),
            resources.GetString("cbEstado.Items10"),
            resources.GetString("cbEstado.Items11"),
            resources.GetString("cbEstado.Items12"),
            resources.GetString("cbEstado.Items13"),
            resources.GetString("cbEstado.Items14"),
            resources.GetString("cbEstado.Items15"),
            resources.GetString("cbEstado.Items16"),
            resources.GetString("cbEstado.Items17"),
            resources.GetString("cbEstado.Items18"),
            resources.GetString("cbEstado.Items19"),
            resources.GetString("cbEstado.Items20"),
            resources.GetString("cbEstado.Items21"),
            resources.GetString("cbEstado.Items22"),
            resources.GetString("cbEstado.Items23"),
            resources.GetString("cbEstado.Items24"),
            resources.GetString("cbEstado.Items25"),
            resources.GetString("cbEstado.Items26")});
            resources.ApplyResources(this.cbEstado, "cbEstado");
            this.cbEstado.Name = "cbEstado";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblProfissao
            // 
            resources.ApplyResources(this.lblProfissao, "lblProfissao");
            this.lblProfissao.ForeColor = System.Drawing.Color.White;
            this.lblProfissao.Name = "lblProfissao";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Name = "label5";
            // 
            // lblValorMax
            // 
            resources.ApplyResources(this.lblValorMax, "lblValorMax");
            this.lblValorMax.ForeColor = System.Drawing.Color.White;
            this.lblValorMax.Name = "lblValorMax";
            // 
            // btnMinhaConta
            // 
            this.btnMinhaConta.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnMinhaConta, "btnMinhaConta");
            this.btnMinhaConta.ForeColor = System.Drawing.Color.Black;
            this.btnMinhaConta.Name = "btnMinhaConta";
            this.btnMinhaConta.UseVisualStyleBackColor = false;
            this.btnMinhaConta.Click += new System.EventHandler(this.btnMinhaConta_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // maskedTxtValorMin
            // 
            resources.ApplyResources(this.maskedTxtValorMin, "maskedTxtValorMin");
            this.maskedTxtValorMin.Name = "maskedTxtValorMin";
            // 
            // maskedTxtValorMax
            // 
            resources.ApplyResources(this.maskedTxtValorMax, "maskedTxtValorMax");
            this.maskedTxtValorMax.Name = "maskedTxtValorMax";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // lblAvisoValor
            // 
            resources.ApplyResources(this.lblAvisoValor, "lblAvisoValor");
            this.lblAvisoValor.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoValor.Name = "lblAvisoValor";
            // 
            // TelaPesquisa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblAvisoValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMinhaConta);
            this.Controls.Add(this.lblValorMax);
            this.Controls.Add(this.maskedTxtValorMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTxtValorMin);
            this.Controls.Add(this.lblValorMin);
            this.Controls.Add(this.cbcidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.gridProfissionais);
            this.Name = "TelaPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfissionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfissionais;
        private System.Windows.Forms.Label lblValorMin;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorMax;
        private System.Windows.Forms.Button btnMinhaConta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn formacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.MaskedTextBox maskedTxtValorMin;
        private System.Windows.Forms.MaskedTextBox maskedTxtValorMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvisoValor;
    }
}
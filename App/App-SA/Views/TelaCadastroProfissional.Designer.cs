
namespace App_SA
{
    partial class TelaCadastroProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProfissional));
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbProfissao = new System.Windows.Forms.ComboBox();
            this.maskedTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.richTxtInformacoesAdicionais = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.maskedTxtValorHora = new System.Windows.Forms.MaskedTextBox();
            this.cbAreaFormacao = new System.Windows.Forms.ComboBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblAreaFormacao = new System.Windows.Forms.Label();
            this.cdFormacao = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.pictureBoxProfissional = new System.Windows.Forms.PictureBox();
            this.lblAtencao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfissional)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.BackColor = System.Drawing.Color.Yellow;
            this.btnCarregarFoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCarregarFoto.Location = new System.Drawing.Point(485, 611);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(189, 54);
            this.btnCarregarFoto.TabIndex = 3;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = false;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // lblFormacao
            // 
            this.lblFormacao.AutoSize = true;
            this.lblFormacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormacao.ForeColor = System.Drawing.Color.White;
            this.lblFormacao.Location = new System.Drawing.Point(374, 161);
            this.lblFormacao.Name = "lblFormacao";
            this.lblFormacao.Size = new System.Drawing.Size(75, 19);
            this.lblFormacao.TabIndex = 27;
            this.lblFormacao.Text = "Formação";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(372, 331);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(314, 20);
            this.txtBairro.TabIndex = 28;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(371, 309);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 19);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(369, 259);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 19);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbEstado.Location = new System.Drawing.Point(372, 236);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(314, 21);
            this.cbEstado.TabIndex = 24;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(372, 216);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 19);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(13, 611);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(205, 54);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 20);
            this.txtNome.TabIndex = 17;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(11, 161);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 19);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(9, 117);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 15);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "CPF";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblProfissao.ForeColor = System.Drawing.Color.White;
            this.lblProfissao.Location = new System.Drawing.Point(370, 69);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(71, 19);
            this.lblProfissao.TabIndex = 14;
            this.lblProfissao.Text = "Profissão";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(9, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // cbProfissao
            // 
            this.cbProfissao.FormattingEnabled = true;
            this.cbProfissao.Items.AddRange(new object[] {
            "Auditor",
            "Babá",
            "Barbeiro(a)",
            "Cabelereiro(a)",
            "Consultor",
            "Cozinheiro(a)",
            "Diarista",
            "Eletricista",
            "Empresário(a)",
            "Farmacêutico",
            "Gesseiro(a)",
            "Gestor(a) Financeiro",
            "Gestor(a) Marketing",
            "Historiador(a)",
            "Influenciador(a) Digital",
            "Motorista",
            "Pedreiro(a)",
            "Personal Trainer",
            "Pintor(a)",
            "Professor",
            "Programador",
            "Recursos Humanos",
            "Tatuador(a)",
            "Vendedor(a)",
            "Youtuber",
            "Outro"});
            this.cbProfissao.Location = new System.Drawing.Point(372, 88);
            this.cbProfissao.Name = "cbProfissao";
            this.cbProfissao.Size = new System.Drawing.Size(314, 21);
            this.cbProfissao.TabIndex = 30;
            // 
            // maskedTxtCpf
            // 
            this.maskedTxtCpf.Location = new System.Drawing.Point(12, 135);
            this.maskedTxtCpf.Mask = "000\\.000\\.000\\-00";
            this.maskedTxtCpf.Name = "maskedTxtCpf";
            this.maskedTxtCpf.Size = new System.Drawing.Size(310, 20);
            this.maskedTxtCpf.TabIndex = 31;
            // 
            // richTxtInformacoesAdicionais
            // 
            this.richTxtInformacoesAdicionais.Location = new System.Drawing.Point(13, 431);
            this.richTxtInformacoesAdicionais.Name = "richTxtInformacoesAdicionais";
            this.richTxtInformacoesAdicionais.Size = new System.Drawing.Size(312, 163);
            this.richTxtInformacoesAdicionais.TabIndex = 32;
            this.richTxtInformacoesAdicionais.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Informações Adicionais";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorHora.ForeColor = System.Drawing.Color.White;
            this.lblValorHora.Location = new System.Drawing.Point(368, 360);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(119, 19);
            this.lblValorHora.TabIndex = 34;
            this.lblValorHora.Text = "Preço/Hora (R$)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 20);
            this.txtEmail.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(15, 263);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "E-mail";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(14, 183);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(308, 21);
            this.cbSexo.TabIndex = 39;
            // 
            // maskedTxtValorHora
            // 
            this.maskedTxtValorHora.Location = new System.Drawing.Point(372, 382);
            this.maskedTxtValorHora.Mask = "000\\,00";
            this.maskedTxtValorHora.Name = "maskedTxtValorHora";
            this.maskedTxtValorHora.Size = new System.Drawing.Size(314, 20);
            this.maskedTxtValorHora.TabIndex = 40;
            // 
            // cbAreaFormacao
            // 
            this.cbAreaFormacao.FormattingEnabled = true;
            this.cbAreaFormacao.Items.AddRange(new object[] {
            "Nenhum",
            "Administração",
            "Agronomia",
            "Antropologia",
            "Arquitetura e Urbanismo",
            "Arquivologia",
            "Artes Cênicas",
            "Artes Plásticas",
            "Astronomia",
            "Biblioteconomia",
            "Biofísica",
            "Bioquímica",
            "Biotecnologia",
            "Ciência da Computação",
            "Ciência da Computação",
            "Ciência Política",
            "Ciências Biológicas",
            "Ciências Contábeis",
            "Cinema",
            "Dança",
            "Design de Interiores",
            "Design Gráfico",
            "Direito",
            "Ecologia",
            "Economia",
            "Educação Física",
            "Enfermagem",
            "Engenharia Agrícola",
            "Engenharia de Alimentos",
            "Engenharia de Pesca",
            "Engenharia Florestal",
            "Estatística",
            "Farmácia",
            "Filosofia",
            "Física",
            "Fisioterapia",
            "Fonoaudiologia",
            "Fotografia",
            "Geofísica",
            "Geofísica",
            "Geografia",
            "Geologia",
            "História",
            "Jornalismo",
            "Letras",
            "Linguística",
            "Matemática",
            "Medicina",
            "Medicina Veterinária",
            "Meteorologia",
            "Meteorologia",
            "Moda",
            "Museologia",
            "Música",
            "Oceanografia",
            "Odontologia",
            "Psicologia",
            "Publicidade e Propaganda",
            "Química",
            "Rádio e TV",
            "Relações Internacionais",
            "Relações Públicas",
            "Saúde Coletiva",
            "Serviço Social",
            "Sociologia",
            "Teatro",
            "Teologia",
            "Terapia Ocupacional",
            "Tradução e Interpretação",
            "Turismo",
            "Zootecnia",
            "Outro"});
            this.cbAreaFormacao.Location = new System.Drawing.Point(372, 135);
            this.cbAreaFormacao.Name = "cbAreaFormacao";
            this.cbAreaFormacao.Size = new System.Drawing.Size(314, 21);
            this.cbAreaFormacao.TabIndex = 42;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(11, 378);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(311, 20);
            this.txtConfirmarSenha.TabIndex = 52;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(11, 356);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(122, 19);
            this.lblConfirmarSenha.TabIndex = 51;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 331);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(310, 20);
            this.txtSenha.TabIndex = 50;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(15, 309);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 19);
            this.lblSenha.TabIndex = 49;
            this.lblSenha.Text = "Senha";
            // 
            // lblAreaFormacao
            // 
            this.lblAreaFormacao.AutoSize = true;
            this.lblAreaFormacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblAreaFormacao.ForeColor = System.Drawing.Color.White;
            this.lblAreaFormacao.Location = new System.Drawing.Point(374, 113);
            this.lblAreaFormacao.Name = "lblAreaFormacao";
            this.lblAreaFormacao.Size = new System.Drawing.Size(132, 19);
            this.lblAreaFormacao.TabIndex = 91;
            this.lblAreaFormacao.Text = "Área de Formação";
            // 
            // cdFormacao
            // 
            this.cdFormacao.FormattingEnabled = true;
            this.cdFormacao.Items.AddRange(new object[] {
            "Nenhum",
            "Ensino Fundamental Incompleto",
            "Ensino Fundamental Completo",
            "Ensino Médio Incompleto",
            "Ensino Médio Completo",
            "Ensino Superior Incompleto",
            "Ensino Superior completo",
            "Pós Graduação Incompleta",
            "Pós Graduação Completa",
            "Mestrado Incompleto",
            "Mestrado Completo",
            "Doutorado Incompleto",
            "Doutorado Completo",
            "Pós Doutorado Incompleto",
            "Pós Doutorado Completo",
            "Cusro Técnico Incompleto",
            "Curso Técnico Completo"});
            this.cdFormacao.Location = new System.Drawing.Point(372, 183);
            this.cdFormacao.Name = "cdFormacao";
            this.cdFormacao.Size = new System.Drawing.Size(314, 21);
            this.cdFormacao.TabIndex = 92;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(12, 214);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 19);
            this.lblTelefone.TabIndex = 94;
            this.lblTelefone.Text = "Telefone";
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.Location = new System.Drawing.Point(13, 236);
            this.maskedTelefone.Mask = "(00) 00000-0000";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(311, 20);
            this.maskedTelefone.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 54);
            this.button1.TabIndex = 97;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(372, 281);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(314, 20);
            this.txtCidade.TabIndex = 99;
            // 
            // pictureBoxProfissional
            // 
            this.pictureBoxProfissional.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfissional.Image")));
            this.pictureBoxProfissional.Location = new System.Drawing.Point(436, 431);
            this.pictureBoxProfissional.Name = "pictureBoxProfissional";
            this.pictureBoxProfissional.Size = new System.Drawing.Size(163, 163);
            this.pictureBoxProfissional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfissional.TabIndex = 100;
            this.pictureBoxProfissional.TabStop = false;
            // 
            // lblAtencao
            // 
            this.lblAtencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencao.Image = global::App_SA.Properties.Resources._2682803_32;
            this.lblAtencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtencao.Location = new System.Drawing.Point(13, 9);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(675, 26);
            this.lblAtencao.TabIndex = 41;
            this.lblAtencao.Text = "ATENÇÃO - Informe os campos obrigatórios.";
            this.lblAtencao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAtencao.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Yellow;
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(254, 611);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(195, 54);
            this.btnSalvar.TabIndex = 102;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // TelaCadastroProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(698, 677);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBoxProfissional);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTelefone);
            this.Controls.Add(this.cdFormacao);
            this.Controls.Add(this.lblAreaFormacao);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.cbAreaFormacao);
            this.Controls.Add(this.lblAtencao);
            this.Controls.Add(this.maskedTxtValorHora);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTxtInformacoesAdicionais);
            this.Controls.Add(this.maskedTxtCpf);
            this.Controls.Add(this.cbProfissao);
            this.Controls.Add(this.lblFormacao);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.lblTelefone);
            this.Name = "TelaCadastroProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfissional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.Label lblFormacao;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbProfissao;
        private System.Windows.Forms.MaskedTextBox maskedTxtCpf;
        private System.Windows.Forms.RichTextBox richTxtInformacoesAdicionais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox maskedTxtValorHora;
        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.ComboBox cbAreaFormacao;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblAreaFormacao;
        private System.Windows.Forms.ComboBox cdFormacao;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.PictureBox pictureBoxProfissional;
        private System.Windows.Forms.Button btnSalvar;
    }
}
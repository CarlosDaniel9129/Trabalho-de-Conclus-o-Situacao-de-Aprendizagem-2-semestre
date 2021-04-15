using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App_SA.Models;
using App_SA.Controller;
using System.IO; //para usar o memorystream
using System.Drawing.Imaging; //para usar o ImageFormat
using MySql.Data.MySqlClient;

namespace App_SA
{
    public partial class TelaCadastroProfissional : Form
    {


        public string caminhoFoto;

        public TelaCadastroProfissional()
        {
            InitializeComponent();
            ehLogado();
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            Visible = false;
        }

        private void btnSalvarProfissional_Click(object sender, EventArgs e)
        {            
            try
            {

                if (txtNome.Text == string.Empty || !maskedTxtCpf.MaskCompleted /*|| !maskedTxtValorHora.MaskCompleted*/
                    || !maskedTelefone.MaskCompleted || txtEmail.Text == string.Empty || txtSenha.Text == string.Empty 
                    || txtConfirmarSenha.Text == string.Empty || cbProfissao.Text == string.Empty || cbFormacao.Text == string.Empty
                    || cbEstado.Text == string.Empty || txtCidade.Text == string.Empty || txtBairro.Text == string.Empty)
                {
                    ControlarVisibilidade();
                }
                else if (ehLogado().Equals(true))
                {
                    //caso ele nao esteja logado, ele chama o metodo !!! Recadastra !!!
                    Usuario usuario = new Usuario()
                    {
                        Nome = txtNome.Text,
                        Cpf = maskedTxtCpf.Text,
                        Senha = txtSenha.Text,
                        ConfSenha = txtConfirmarSenha.Text,
                        Email = txtEmail.Text,
                        Telefone = maskedTelefone.Text,
                        Sexo = cbSexo.Text,
                        ValorHora = decimal.Parse(maskedTxtValorHora.Text),
                        Infos = richTxtInformacoesAdicionais.Text,
                        Profissao = cbProfissao.Text,
                        Formacao = comboBox1.Text,
                        Estado = cbEstado.Text,
                        Cidade = txtCidade.Text,
                        Bairro = txtBairro.Text,
                        Imagem = conversorImagem()
                    };

                    usuario.recadastraUsu();
                }
                else
                {
                    //caso ele nao esteja logado, ele chama o metodo !!! Cadastra !!!
                    Usuario usuario = new Usuario()
                    {
                        Nome = txtNome.Text,
                        Cpf = maskedTxtCpf.Text,
                        Senha = txtSenha.Text,
                        ConfSenha = txtConfirmarSenha.Text,
                        Email = txtEmail.Text,
                        Telefone = maskedTelefone.Text,
                        Sexo = cbSexo.Text,
                        ValorHora = decimal.Parse(maskedTxtValorHora.Text),
                        Infos = richTxtInformacoesAdicionais.Text,
                        Profissao = cbProfissao.Text,
                        Formacao = comboBox1.Text,
                        Estado = cbEstado.Text,
                        Cidade = txtCidade.Text,
                        Bairro = txtBairro.Text,
                        //Imagem = conversorImagem()
                    };

                    usuario.cadastraUsu();

                    MessageBox.Show("Cadastro realizado com Secesso");

                    new TelaLogin().Show();
                    Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro. {ex.Message}");
            }
        }

        private bool ehLogado()
        {
            bool ehlogado = Comandos.Logado;
            if (!ehlogado)//ja é cadastrado?
            {
                btnPesquisaProfissional.Visible = false;
                // mostrar botao pesquisar profissional
            }

            return ehlogado;
        }

        private void ControlarVisibilidade()
        {
            lblAtencao.Visible = true;

            if (txtNome.Text == string.Empty)
                lblNome.ForeColor = Color.Red;
            else
                lblNome.ForeColor = Color.White;

            if (!maskedTxtCpf.MaskCompleted)
                lblCpf.ForeColor = Color.Red;
            else
                lblCpf.ForeColor = Color.White;

            if (!maskedTelefone.MaskCompleted)
                lblTelefone.ForeColor = Color.Red;
            else
                lblTelefone.ForeColor = Color.White;

            if (!maskedTxtValorHora.MaskCompleted)
                lblValorHora.ForeColor = Color.Red;
            else
                lblValorHora.ForeColor = Color.White;

            if (txtEmail.Text == string.Empty)
                lblEmail.ForeColor = Color.Red;
            else
                lblEmail.ForeColor = Color.White;

            if (txtSenha.Text == string.Empty)
                lblSenha.ForeColor = Color.Red;
            else
                lblSenha.ForeColor = Color.White;

            if (txtConfirmarSenha.Text == string.Empty)
                lblConfirmarSenha.ForeColor = Color.Red;
            else
                lblConfirmarSenha.ForeColor = Color.White;

            if (cbProfissao.Text == string.Empty)
                lblProfissao.ForeColor = Color.Red;
            else
                lblProfissao.ForeColor = Color.White;

            if (cbFormacao.Text == string.Empty)
                lblFormacao.ForeColor = Color.Red;
            else
                lblFormacao.ForeColor = Color.White;

            if (cbEstado.Text == string.Empty)
                lblEstado.ForeColor = Color.Red;
            else
                lblEstado.ForeColor = Color.White;

            if (txtCidade.Text == string.Empty)
                lblCidade.ForeColor = Color.Red;
            else
                lblCidade.ForeColor = Color.White;

            if (txtBairro.Text == string.Empty)
                lblBairro.ForeColor = Color.Red;
            else
                lblBairro.ForeColor = Color.White;

            return;
        }

        private void btnPesquisaProfissional_Click(object sender, EventArgs e)
        {
            new TelaPesquisa().Show();
            Visible = false;
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            carregaImagem();
        }

        public void carregaImagem()
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*"; //filtra somente arquivos com esses tipos
                                                                                               //qualquer arquivo and nome

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = dialog.FileName.ToString();
                pictureBoxProfissional.ImageLocation = caminhoFoto; // o caminho da imagem sera igual ao caminhoFOto, para exibir na pictureBox
            }
        
        }


        public byte[] conversorImagem()
        {
            FileStream fstream = new FileStream(this.caminhoFoto, FileMode.Open, FileAccess.Read); //serve para inserir os bytes da imagem dentro do array de byte, contem o diretorio da imagem
            BinaryReader br = new BinaryReader(fstream); //leitor de dados binarios
            byte[] imagem_byte = br.ReadBytes((int)fstream.Length); //o imagem_byte vai ser igual a leitura do tamanho desses dados binarios

            return imagem_byte;
        }


    }
}

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
        Bitmap bmp; //para trabalharmos com os pixels

        private MySqlConnection myConn = new MySqlConnection("server=localhost;user id=root;database=worknow"); //para endereco do banco
        private MySqlCommand command; //para fazer os comandos

        public TelaCadastroProfissional()
        {
            InitializeComponent();
            bool ehlogado = Comandos.Logado;
            if (!ehlogado)//ja é cadastrado?
            {
                btnPesquisaProfissional.Visible = false;
               // mostrar botao pesquisar profissional
            }
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
                else
                {
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
                        Bairro = txtBairro.Text
                    };

                    usuario.cadastraUsu();
                    //salvaImagem();

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
            carregaImage();
        }

        public void carregaImage()
        {
            //quando estiver aqbertto e o result for OK, faz o if
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName; //guarda o nome vindo do open

                bmp = new Bitmap(nome); //passo o nome do arquivo para transformar em pixels a imagem

                pictureBoxProfissional.Image = bmp; //preenche a picture com o bmp 
            }
        }

        private void salvaImagem()
        {
            MemoryStream memory = new MemoryStream(); //classe que guarda dados na memoria

            bmp.Save(memory, ImageFormat.Bmp); //passo o local e o formato do arquivo 

            byte[] foto = memory.ToArray(); //gravo o conteudo em uma matriz de byte, foto é onde ira conter a imagem


            command = new MySqlCommand("insert into usuario (imagem) values(@imagem) where cpf = @cpf", myConn);
            command.Parameters.AddWithValue("@cpf", maskedTxtCpf.Text);

            MySqlParameter paramFoto = new MySqlParameter("@imagem", MySqlDbType.Binary);
            paramFoto.Value = foto;
            command.Parameters.Add(paramFoto);
            

            

            myConn.Open();
            command.ExecuteNonQuery(); 

            myConn.Close();
        }
    }
}

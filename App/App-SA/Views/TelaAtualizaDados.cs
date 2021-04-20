using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_SA.Views;
using App_SA.Models;
using App_SA.Controller;
using System.IO; //para usar o memorystream
using System.Drawing.Imaging; //para usar o ImageFormat
using MySql.Data.MySqlClient;

namespace App_SA.Views
{
    public partial class TelaAtualizaDados : Form
    {
        private MySqlConnection myConn = new MySqlConnection("server=localhost;user id=root;database=workers"); //para endereco do banco
        private MySqlCommand command; //para fazer os comandos
        private MySqlDataReader myReader; //para guardar algum dado vindo do banco


        private string caminhoFoto = string.Empty;

        public string nomeLogado = TelaLogin.usuarioLogado;
        public string id;
        byte[] imagem;
        

        public TelaAtualizaDados()
        {
            InitializeComponent();
            bool ehlogado = Comandos.Logado;
            if (ehlogado)//ja é cadastrado?
            {
                btnBackup.Visible = true;
                // mostrar botao pesquisar profissional
            }
            carregaDados();
        }

        private void carregaDados()
        {
            try
            {
                myConn.Open();

                command = new MySqlCommand("select idUsuario, nome, cpf, sexo, email, senha, telefone, valorHora, informacoes, profissao, formacao, areaFormacao, estado, cidade, bairro, valorHora, imagem from usuario where email = @email", myConn);

                command.Parameters.AddWithValue("@email", nomeLogado);

                myReader = command.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        id = myReader.GetString("idUsuario").ToString();
                        txtNome.Text = myReader.GetString("nome").ToString();
                        cbSexo.Text = myReader.GetString("sexo").ToString();
                        txtEmail.Text = myReader.GetString("email").ToString();
                        txtSenha.Text = myReader.GetString("senha").ToString();
                        txtConfirmarSenha.Text = txtSenha.Text;
                        maskedTelefone.Text = myReader.GetString("telefone").ToString();
                        richTxtInformacoesAdicionais.Text = myReader.GetString("informacoes").ToString();
                        cbProfissao.Text = myReader.GetString("profissao").ToString();
                        cdFormacao.Text = myReader.GetString("formacao").ToString();
                        cbAreaFormacao.Text = myReader.GetString("areaFormacao").ToString();
                        cbEstado.Text = myReader.GetString("estado").ToString();
                        txtCidade.Text = myReader.GetString("cidade").ToString();
                        txtBairro.Text = myReader.GetString("bairro").ToString();
                        maskedTxtValorHora.Text = myReader.GetString("valorHora").ToString();
                        maskedTxtCpf.Text = myReader.GetString("cpf").ToString();

                        imagem = (byte[])(myReader["imagem"]);
                        MemoryStream mstream = new MemoryStream(imagem); //guarda uma quantidade de byte referente a uma variavel de armazenagem na memoria
                        pictureBoxProfissional.Image = System.Drawing.Image.FromStream(mstream);
                    }

                }

            }
            finally
            {
                myConn.Close();
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

            if (cbAreaFormacao.Text == string.Empty)
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

        //private void btnCarregarFoto_Click(object sender, EventArgs e)
        //{
        //    carregaImagem();
            
        //}

        private void btnCarregarFoto_Click_1(object sender, EventArgs e)
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
            byte[] imagem_byte;

            if (caminhoFoto == string.Empty)
            {
                return imagem_byte = null;
            }
            else
            {
                FileStream fstream = new FileStream(this.caminhoFoto, FileMode.Open, FileAccess.Read); //serve para inserir os bytes da imagem dentro do array de byte, contem o diretorio da imagem
                BinaryReader br = new BinaryReader(fstream); //leitor de dados binarios

                imagem_byte = br.ReadBytes((int)fstream.Length);

                return imagem_byte;
            }
    
        }

        private void btnSalvarProfissional_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || !maskedTxtCpf.MaskCompleted || !maskedTxtValorHora.MaskCompleted
            || !maskedTelefone.MaskCompleted || txtEmail.Text == string.Empty || txtSenha.Text == string.Empty
            || txtConfirmarSenha.Text == string.Empty || cbProfissao.Text == string.Empty || cbAreaFormacao.Text == string.Empty
            || cbEstado.Text == string.Empty || txtCidade.Text == string.Empty || txtBairro.Text == string.Empty)
            {
                ControlarVisibilidade();
                lblAtencao.Visible = true;
            }
            else
            {
                recadastraDados();
            }            
        }

        private void recadastraDados()
        {

            try
            {
                conversorImagem();

                if (conversorImagem() == null)
                {
                    Comandos comandos = new Comandos();
                    comandos.recadastraUsu(int.Parse(id), txtNome.Text, maskedTxtCpf.Text, cbSexo.Text,
                    maskedTelefone.Text, txtEmail.Text, txtSenha.Text, richTxtInformacoesAdicionais.Text,
                    cbProfissao.Text, cbAreaFormacao.Text, cdFormacao.Text, cbEstado.Text, txtCidade.Text,
                    txtBairro.Text, decimal.Parse(maskedTxtValorHora.Text), imagem);
                }
                else
                {
                    Comandos comandos = new Comandos();
                    comandos.recadastraUsu(int.Parse(id), txtNome.Text, maskedTxtCpf.Text, cbSexo.Text,
                    maskedTelefone.Text, txtEmail.Text, txtSenha.Text, richTxtInformacoesAdicionais.Text,
                    cbProfissao.Text, cbAreaFormacao.Text, cdFormacao.Text, cbEstado.Text, txtCidade.Text,
                    txtBairro.Text, decimal.Parse(maskedTxtValorHora.Text), conversorImagem());
                }
                              

                MessageBox.Show("Dados Atualizados com Sucesso");

                new TelaPesquisa().Show();
                Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro. {ex.Message}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaPesquisa().Show();
            Visible = false;
        }


    }
}

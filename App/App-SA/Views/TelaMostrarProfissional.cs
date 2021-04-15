using App_SA.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_SA.Controller;
using System.IO;

namespace App_SA.Views
{
    public partial class TelaMostrarProfissional : Form
    {
        private MySqlConnection myConn = new MySqlConnection("server=localhost;user id=root;database=workers"); //para endereco do banco
        private MySqlCommand command; //para fazer os comandos
        private MySqlDataReader myReader; //para guardar algum dado vindo do banco


        public TelaMostrarProfissional(int id)
        {
            InitializeComponent();
            viewProfissional(id);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();   
        }

        public void viewProfissional(int id)
        {
            try
            {
                myConn.Open();

                command = new MySqlCommand("select nome, sexo, email, telefone, valorHora, informacoes, profissao, formacao, areaFormacao, estado, cidade, bairro, valorHora, imagem from usuario where idUsuario = @id", myConn);

                command.Parameters.AddWithValue("@id", id);

                myReader = command.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        txtNome.Text = myReader.GetString("nome").ToString();
                        txtSexo.Text = myReader.GetString("sexo").ToString();
                        txtEmail.Text = myReader.GetString("email").ToString();
                        txtTelefone.Text = myReader.GetString("telefone").ToString();
                        richTxtInformacoesAdicionais.Text = myReader.GetString("informacoes").ToString();
                        txtProfissao.Text = myReader.GetString("profissao").ToString();
                        txtFormacao.Text = myReader.GetString("formacao").ToString();
                        txtAreaFormacao.Text = myReader.GetString("areaFormacao");
                        txtEstado.Text = myReader.GetString("estado").ToString();
                        txtCidade.Text = myReader.GetString("cidade").ToString();
                        txtBairro.Text = myReader.GetString("bairro").ToString();
                        txtValorHora.Text = myReader.GetString("valorHora").ToString();

                        byte[] imagem = (byte[])(myReader["imagem"]);
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
    }
}

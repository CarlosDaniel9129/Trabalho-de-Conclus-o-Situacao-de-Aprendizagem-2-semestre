﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_SA.Models;
using App_SA.Views;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace App_SA.Controller
{
    class Comandos
    {
        public bool tem = false;

      
        private static bool logado;
        public static bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }

        private MySqlConnection myConn = new MySqlConnection("server=localhost;user id=root;database=workers"); //para endereco do banco
        private MySqlCommand command; //para fazer os comandos
        private MySqlDataReader myReader; //para guardar algum dado vindo do banco

        public bool verificaLogin(string email, string senha)
        {
            try
            {
                myConn.Open();

                command = new MySqlCommand("select * from usuario where email = @email and senha = @senha", myConn);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@senha", senha);

                myReader = command.ExecuteReader();

                if (myReader.HasRows)
                {
                    if (myReader.Read())
                    {
                        
                        tem = true;
                        Comandos.Logado = true;
                    }
                }

            }
            finally
            {
                myConn.Close();
            }

            return tem;
        }

        public bool verificaEmailCpf(string email, string cpf)
        {
            try
            {
                myConn.Open();

                command = new MySqlCommand("select * from usuario where email = @email and cpf = @cpf", myConn);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@cpf", cpf);

                myReader = command.ExecuteReader();

                if (myReader.HasRows)
                {
                    tem = true;
                    logado = true;
                }
            }
            finally
            {
                myConn.Close();
            }

            return tem;
        }

        public void recuperaSenha(string senha, string confsenha, string cpf)
        {
            try
            {
                if (senha.Equals(confsenha))
                {
                    myConn.Open();

                    command = new MySqlCommand("update usuario set senha = @senha where cpf = @cpf", myConn);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.Parameters.AddWithValue("@cpf", cpf);

                    myReader = command.ExecuteReader();
                }
                else
                {
                    throw new Exception("As senhas devem ser iguais");
                }

            }
            finally
            {
                myConn.Close();
            }
        }

        public void cadastraUsu(string nome, string cpf, string sexo, string telefone, string email, string senha, string informacoes, string profissao, string areaFormacao, string formacao, string estado, string cidade, string bairro, decimal valorHora, byte[] imagem)
        {
            try
            {
                myConn.Open();
                                
                command = new MySqlCommand("insert into usuario(nome, cpf, sexo, telefone, email, senha, informacoes, profissao, areaFormacao, formacao, estado, cidade, bairro, valorHora, imagem) values(@nome, @cpf, @sexo, @telefone, @email, @senha, @informacoes, @profissao, @areaFormacao, @formacao, @estado, @cidade, @bairro, @valorHora, @imagem)", myConn);

                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@cpf", cpf);
                command.Parameters.AddWithValue("@sexo", sexo);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@senha", senha);
                command.Parameters.AddWithValue("@informacoes", informacoes);
                command.Parameters.AddWithValue("@profissao", profissao);
                command.Parameters.AddWithValue("@areaFormacao", areaFormacao);
                command.Parameters.AddWithValue("@formacao", formacao);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@bairro", bairro);
                command.Parameters.AddWithValue("@valorHora", valorHora);
                command.Parameters.AddWithValue("@imagem", imagem);

                command.ExecuteNonQuery();
                myConn.Close();

            }
            catch (Exception)
            {

                throw new Exception("Erro com Banco de Dados");
            }

        }

        public void recadastraUsu(int id, string nome, string cpf, string sexo, string telefone, string email, string senha, string informacoes, string profissao, string areaFormacao, string formacao, string estado, string cidade, string bairro, decimal valorHora, byte[] imagem)
        {
            try
            {
                myConn.Open();

                                          
                command = new MySqlCommand("update usuario set nome = @nome, cpf = @cpf, sexo = @sexo, telefone = @telefone, email = @email, senha = @senha, informacoes = @informacoes, profissao = @profissao, areaFormacao = @areaFormacao, formacao = @formacao, estado = @estado, cidade = @cidade, bairro = @bairro, valorHora = @valorHora, imagem = @imagem where idUsuario = @id", myConn);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@cpf", cpf);
                command.Parameters.AddWithValue("@sexo", sexo);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@senha", senha);
                command.Parameters.AddWithValue("@informacoes", informacoes);
                command.Parameters.AddWithValue("@profissao", profissao);
                command.Parameters.AddWithValue("@areaFormacao", areaFormacao);
                command.Parameters.AddWithValue("@formacao", formacao);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@bairro", bairro);
                command.Parameters.AddWithValue("@valorHora", valorHora);
                command.Parameters.AddWithValue("@imagem", imagem);
                             
                command.ExecuteNonQuery();

                myConn.Close();

            }
            catch (Exception)
            {

                throw new Exception("Erro com Banco de Dados");
            }

        }

        public void backup()
        {
            myConn.Open();

            // usa-se a hora, min, seg, pois Workbenchs desatualizados nao permite usar o comando "OR Replace"
            // Certo seriastring sql = "CREATE OR REPLACE TABLE BKP" + hj + " AS SELECT * FROM livros";

            string hj = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
            string sql = "CREATE TABLE BKP" + hj + " AS SELECT * FROM usuario";
            MySqlCommand command = new MySqlCommand(sql, myConn);
            int a = command.ExecuteNonQuery(); //pega o retorno da excecussão do banco, no caso o valor 1 de "1 row"

            myConn.Close();
            if (a > 0)
                MessageBox.Show("backup criado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

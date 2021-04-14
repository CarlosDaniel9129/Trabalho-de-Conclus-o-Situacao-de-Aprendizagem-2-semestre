using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_SA.Models;
using App_SA.Views;
using MySql.Data.MySqlClient;

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
                if(senha.Equals(confsenha))
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

        public void cadastraUsu(string nome, string cpf, string sexo, string email, string telefone, string senha, string estado, string cidade, string bairro, decimal valorHora, string infos, string profissao, string formacao)
        {
            try
            {
                myConn.Open();


                command = new MySqlCommand("INSERT INTO usuario(cpf, nome, email, telefone, senha, sexo, estado, cidade, bairro, valorHora, informacoes, profissao, formacao) VALUES(@cpf, @nome, @email, @telefone, @senha, @sexo, @estado, @cidade, @bairro, @valorHora, @informacoes, @profissao, @formacao)", myConn);
                // myComm.CommandText = "insert into usuario(cpf, nome, email, telefone, senha, sexo, estado, cidade, bairro, valorHora, informacoes, profissao, formacao) values(@cpf, @nome, @email, @telefone, @senha, @sexo, @estado, @cidade, @bairro, @valoHora, @informacoes, @profissao, @formacao)" ;
                command.Parameters.AddWithValue("@cpf", cpf);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@senha", senha);
                command.Parameters.AddWithValue("@sexo", sexo);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@bairro", bairro);
                command.Parameters.AddWithValue("@valorHora", valorHora);
                command.Parameters.AddWithValue("@informacoes", infos);
                command.Parameters.AddWithValue("@profissao", profissao);
                command.Parameters.AddWithValue("@formacao", formacao);


                command.ExecuteNonQuery();
                myConn.Close();

            }
            catch (Exception)
            {

                throw new Exception("Erro com Banco de Dados");
            }          
          
        }
    }
}

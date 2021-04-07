using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App_SA.Controller
{
    class Comandos
    {
        public bool tem = false;

        private MySqlConnection myConn = new MySqlConnection("server = localhost; user id = root; database = trabalho"); //para endereco do banco
        private MySqlCommand myCommand; //para fazer os comandos
        private MySqlDataReader myReader; //para guardar algum dado vindo do banco




        public bool verificaLogin(string email, string senha)
        {
            
            myConn.Open();

            myCommand = new MySqlCommand("select * from clientes where email = @email and senha = @senha", myConn);
            myCommand.Parameters.AddWithValue("@email", email);
            myCommand.Parameters.AddWithValue("@senha", senha);

            try
            {
                myReader = myCommand.ExecuteReader();

                if (myReader.HasRows)
                {
                    tem = true;
                }
            }
            finally
            {
                myConn.Close();
            }

            return tem;
        }

        public void cadastraClien(string nome, string cpf, string sexo, string email, string senha, string estado, string cidade, string bairro)
        {
            try
            {
                myConn.Open();

                myCommand = new MySqlCommand("insert into clientes (cpf, nome, email, senha, sexo, estado, cidade, bairro) values(@cpf, @nome, @email, @senha, @sexo, @estado, @cidade, @bairro)", myConn);
                myCommand.Parameters.AddWithValue("@cpf", cpf);
                myCommand.Parameters.AddWithValue("@nome", nome);
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@senha", senha);
                myCommand.Parameters.AddWithValue("@sexo", sexo);
                myCommand.Parameters.AddWithValue("@estado", estado);
                myCommand.Parameters.AddWithValue("@cidade", cidade);
                myCommand.Parameters.AddWithValue("@bairro", bairro);

                myCommand.ExecuteNonQuery();

                myConn.Close();
            }
            catch (Exception)
            {
 
                throw new Exception("Erro com Banco de Dados");
            }
        }

        public void cadastraProf(string nome, string cpf, string sexo, string email, string senha, string estado, string cidade, string bairro, decimal valorHora, string infos, string profissao, string formacao)
        {
            try
            {
                myConn.Open();

                myCommand = new MySqlCommand("insert into profissionais (cpf, nome, email, senha, sexo, estado, cidade, bairro, valorHora, infos, profissao, formacao) values(@cpf, @nome, @email, @senha, @sexo, @estado, @cidade, @bairro, @valoHora, @infos, @profissao, @formacao)", myConn);
                myCommand.Parameters.AddWithValue("@cpf", cpf);                                                                                                             
                myCommand.Parameters.AddWithValue("@nome", nome);
                //myCommand.Parameters.AddWithValue("@telefone", nome); //ATENCAO FALTA ADD CAMPO TELEFONE
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@senha", senha);
                myCommand.Parameters.AddWithValue("@sexo", sexo);
                myCommand.Parameters.AddWithValue("@estado", estado);
                myCommand.Parameters.AddWithValue("@cidade", cidade);
                myCommand.Parameters.AddWithValue("@bairro", bairro);
                myCommand.Parameters.AddWithValue("@valorHora", valorHora);
                myCommand.Parameters.AddWithValue("@infos", infos);
                myCommand.Parameters.AddWithValue("@profissao", profissao);
                myCommand.Parameters.AddWithValue("@formacao", formacao);

                myCommand.ExecuteNonQuery();

                myConn.Close();
            }
            catch (Exception)
            {

                throw new Exception("Erro com Banco de Dados");
            }
        }
    }
}

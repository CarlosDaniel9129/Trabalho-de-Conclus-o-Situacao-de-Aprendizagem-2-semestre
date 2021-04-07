using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_SA.Controller;

namespace App_SA.Models
{
    class Cliente
    {

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string confSenha;

        public string ConfSenha
        {
            get { return confSenha; }
            set { if (value == senha) { confSenha = value; } else{ throw new Exception("As senhas devem ser Iguais"); } }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public void cadastraClien()
        {
            Controle controle = new Controle();

            //controle.verificaLogin(Nome, Senha);

            //if (controle.tem.Equals(false))
            //{
                controle.cadastraDados(Nome, Cpf, Sexo, Email, Senha, Estado, Cidade, Bairro);
            //}
            //else
            //{
            //    throw new Exception("Este Usuário ja possui cadastro");
            //}
            
        }
    }
}

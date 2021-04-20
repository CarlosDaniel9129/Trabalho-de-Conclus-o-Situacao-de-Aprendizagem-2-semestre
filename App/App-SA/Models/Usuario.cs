using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_SA.Controller;

namespace App_SA.Models
{
    class Usuario
    {
        Comandos comando;

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

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
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
            set { if (value == senha) { confSenha = value; } else { throw new Exception("As senhas devem ser Iguais"); } }
        }

        private string infos;

        public string Infos
        {
            get { return infos; }
            set { infos = value; }
        }

        private string profissao;

        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

        private string areaFormacao;

        public string AreaFormacao
        {
            get { return areaFormacao; }
            set { areaFormacao = value; }
        }

        private string formacao;

        public string Formacao
        {
            get { return formacao; }
            set { formacao = value; }
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

        private decimal valorhora;

        public decimal ValorHora
        {
            get { return valorhora; }
            set { valorhora = value; }
        }

        private byte[] imagem;

        public byte[] Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }


        public void cadastraUsu()
        {
            comando = new Comandos();
            comando.cadastraUsu(Nome, Cpf, Sexo, Telefone, Email, Senha, Infos, Profissao, AreaFormacao, Formacao, Estado, Cidade, Bairro, ValorHora, Imagem);
        }

        //public void recadastraUsu(int id)
        //{
        //    comando = new Comandos();
        //    comando.recadastraUsu(id, Nome, Cpf, Sexo, Telefone, Email, Senha, Infos, Profissao, AreaFormacao, Formacao, Estado, Cidade, Bairro, ValorHora, Imagem);
        //}
    }
}

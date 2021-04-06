using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_SA.Controller;

namespace App_SA.Models
{
    class Profissional : Pessoa
    {
        private double valorhora;

        public double ValorHora
        {
            get { return valorhora; }
            set { valorhora = value; }
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

        private string formacao;

        public string Formacao
        {
            get { return formacao; }
            set { formacao = value; }
        }


        public override void cadastraDados()
        {
            base.cadastraDados();

            Controle controle = new Controle();

            controle.acessar(Nome, Senha);

            if (controle.tem.Equals(false))
            {
                controle.cadastraDados(Nome, Cpf, Sexo, Email, Senha, Estado, Cidade, Bairro, ValorHora, Infos, Profissao, Formacao);
            }
            else
            {
                throw new Exception("Este Usuário ja possui cadastro");
            }
        }
    }
}

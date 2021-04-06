using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SA.Controller
{
    class Controle
    {
        public bool tem = true;

        public bool acessar(string login, string senha)
        {
            Comandos comandos = new Comandos();
            comandos.verificaLogin(login, senha);

            if (comandos.tem.Equals(false))
            {
                tem = false;
                throw new Exception("Verifique Login e Senha e tente Novamente");
            }
            else
            {
                MessageBox.Show("Bem Vindo");
            }
            return tem;
        }

        public virtual void cadastraDados(string nome, string cpf, string sexo, string email, string senha, string estado, string cidade, string bairro)
        {
            Comandos comandos = new Comandos();
            comandos.cadastraClien(nome, cpf, sexo, email, senha, estado, cidade, bairro);
        }

        public virtual void cadastraDados(string nome, string cpf, string sexo, string email, string senha, string estado, string cidade, string bairro, double valor, string infos, string profissao, string formacao)
        {
            Comandos comandos = new Comandos();
            comandos.cadastraProf(nome, cpf, sexo, email, senha, estado, cidade, bairro, valor, infos, profissao, formacao);
        }

    }
}

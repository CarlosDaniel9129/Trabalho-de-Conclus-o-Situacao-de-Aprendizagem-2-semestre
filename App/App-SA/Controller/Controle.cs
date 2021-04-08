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

        public bool acessar(string email, string senha)
        {
            Comandos comandos = new Comandos();
            comandos.verificaLogin(email, senha);

            if (comandos.tem.Equals(false)) //da erro na tela de cadastro cliente
            {
                throw new Exception("Verifique Login e Senha e tente Novamente");
            }
            else
            {
                MessageBox.Show("Bem Vindo");
            }
            return tem;
        }

        public bool verificaLogin(string login, string senha)
        {
            Comandos comandos = new Comandos();
            comandos.verificaLogin(login, senha);

            if (comandos.tem.Equals(false)) //da erro na tela de cadastro cliente
            {
                tem = false;
            }

            return tem;
        }

        public void cadastraUsu(string nome, string cpf, string sexo, string email, string telefone, string senha, string estado, string cidade, string bairro, decimal valorHora, string infos, string profissao, string formacao)
        {
            Comandos comandos = new Comandos();
            comandos.cadastraUsu(nome, cpf, sexo, email, telefone, senha, estado, cidade, bairro, valorHora, infos, profissao, formacao);
        }

    }
}

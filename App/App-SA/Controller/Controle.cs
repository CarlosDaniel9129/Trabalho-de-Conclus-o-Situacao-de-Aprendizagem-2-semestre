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
        public void acessar(string login, string senha)
        {
            Comandos comandos = new Comandos();
            comandos.verificaLogin(login, senha);

            if (comandos.tem.Equals(false))
            {
                throw new Exception("Verifique Login e Senha e tente Novamente");
            }
            else
            {
                MessageBox.Show("Bem Vindo");
            }
        }
    }
}

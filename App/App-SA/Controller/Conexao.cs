using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App_SA.Controller
{

    class Conexao
    {
        private MySqlConnection myConn;

        public Conexao(){
            myConn = new MySqlConnection("server=localhost;user id=root;database=visualstudiomysql");
        }

        public void conectar()
        {
            myConn = new MySqlConnection("server=localhost;user id=root;database=visualstudiomysql");

            if (myConn.State == System.Data.ConnectionState.Closed)
            {
                myConn.Open();
            }
        }

        public void desconectar()
        {
            myConn = new MySqlConnection("server=localhost;user id=root;database=visualstudiomysql");

            if (myConn.State == System.Data.ConnectionState.Open)
            {
                myConn.Close();
            }
        }
    }
}

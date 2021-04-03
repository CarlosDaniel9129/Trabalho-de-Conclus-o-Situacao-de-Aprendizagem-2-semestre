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

        private MySqlConnection myConn = new MySqlConnection("server = localhost; user id = root; database = visualstudiomysql");
        private MySqlCommand myComand;
        private MySqlDataReader myReader;

        public bool verificaLogin(string login, string senha)
        {
            
            myConn.Open();

            myComand = new MySqlCommand("select * from teste where login = @login and senha = @senha", myConn);
            myComand.Parameters.AddWithValue("@login", login);
            myComand.Parameters.AddWithValue("@login", senha);

            try
            {
                myReader = myComand.ExecuteReader();

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
    }
}

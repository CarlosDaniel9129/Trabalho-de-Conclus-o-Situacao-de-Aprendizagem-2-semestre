using App_SA.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_SA.Controller;
using System.IO;

namespace App_SA.Views
{
    public partial class TelaMostrarProfissional : Form
    {
        private MySqlConnection myConn = new MySqlConnection("server=localhost;user id=root;database=worknow"); //para endereco do banco
        private MySqlCommand command; //para fazer os comandos
        private MySqlDataReader myReader; //para guardar algum dado vindo do banco


        public TelaMostrarProfissional(int id)
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}

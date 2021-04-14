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

namespace App_SA.Views
{
    public partial class TelaMostrarProfissional : Form
    {
        public TelaMostrarProfissional()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaPesquisa().Show();
            Visible = false;
        }
    }
}

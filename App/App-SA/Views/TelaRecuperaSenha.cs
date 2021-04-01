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
    public partial class TelaRecuperaSenha : Form
    {
        public TelaRecuperaSenha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
            txtEmail.Visible = false;

            lblCpf.Visible = false;
            mkbCpf.Visible = false;

            lblNewSenha.Visible = true;
            txtNewSenha.Visible = true;

            lblConfSenha.Visible = true;
            txtConfSenha.Visible = true;


            btnConf1.Visible = false;
            btnConf2.Visible = true;


        }

        private void btnConfSenha_Click(object sender, EventArgs e)
        {
             new TelaLogin().Show();
             Visible = false;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SA
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnPesquisaProfissional_Click(object sender, EventArgs e)
        {
            new TelaPesquisa().Show();
            Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            Visible = false;
        }
    }
}

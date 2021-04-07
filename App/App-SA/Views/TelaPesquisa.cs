using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_SA
{
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();
        }

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            new TelaCadastroProfissional().Show();
            Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}

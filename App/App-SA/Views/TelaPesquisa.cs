using App_SA.Controller;
using App_SA.Models;
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
            Comandos conectado = new Comandos();

            if (conectado.verificaLogin("@login", "@senha"))
            {
                btnVoltar.Visible = false;
                btnMinhaConta.Visible = true;
            }
            else
            {
                btnVoltar.Visible = true;
                btnMinhaConta.Visible = false;
            }
        }

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            new TelaCadastroProfissional().Show();
            Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaInicial().Show();
            Visible = false;
        }
    }
}

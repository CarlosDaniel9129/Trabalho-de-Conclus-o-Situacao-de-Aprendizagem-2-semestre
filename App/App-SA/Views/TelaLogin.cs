using App_SA.Views;
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

namespace App_SA
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnAcessarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxLogin.Text == string.Empty || txtBoxLogin.Text == null || txtBoxSenha.Text == string.Empty || txtBoxSenha.Text == null)
                {
                    lblAtencao.Visible = true;
                    return;
                }
                else
                {
                    Controle controle = new Controle();
                    controle.acessar(txtBoxLogin.Text, txtBoxSenha.Text);

                    TelaPesquisa pesquisarProfissional = new TelaPesquisa();
                    pesquisarProfissional.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocorreu um erro. {ex.Message}");
            }

       
        }

        private void btnCadastroProfissional_Click(object sender, EventArgs e)
        {
            new TelaCadastroProfissional().Show();
            Visible = false;
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            new TelaCadastroCliente().Show();
            Visible = false;
        }

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TelaRecuperaSenha().Show();
            Visible = false;
        }
    }
}

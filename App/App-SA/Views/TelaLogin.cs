﻿using App_SA.Views;
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

        Comandos comando = new Comandos();

        private void btnAcessarConta_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == string.Empty || txtBoxLogin.Text == null || txtBoxSenha.Text == string.Empty || txtBoxSenha.Text == null)
            {
                ControlarVisibilidade();
            }

            try
            {
                comando.verificaLogin(txtBoxLogin.Text, txtBoxSenha.Text);
                

                if (comando.tem.Equals(true))
                {
                    MessageBox.Show("Bem Vindo");

                    lblAtencao.Visible = false;
                   
                    new TelaPesquisa().Show();
                    Visible = false;
                }
                else
                {
                    throw new Exception("Verifique Login e Senha e tente novamente");
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

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TelaRecuperaSenha().Show();
            Visible = false;
        }

        private void ControlarVisibilidade()
        {
            lblAtencao.Visible = true;

            if (txtBoxLogin.Text == string.Empty || txtBoxLogin.Text == null)
                lblLogin.ForeColor = Color.Red;
            else
                lblLogin.ForeColor = Color.White;

            if (txtBoxSenha.Text == string.Empty || txtBoxSenha.Text == null)
                lblSenha.ForeColor = Color.Red;
            else
                lblSenha.ForeColor = Color.White;

            return;
        }
    }
}

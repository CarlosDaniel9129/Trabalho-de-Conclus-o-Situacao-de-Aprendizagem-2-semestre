using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App_SA.Models;

namespace App_SA
{
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            Visible = false;
        }

        private void btnSalavarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty || txtNome.Text == null
                || maskedTxtCpf.Text == string.Empty || maskedTxtCpf.Text == null
                || cbEstado.Text == string.Empty || cbEstado.Text == null
                || cbCidade.Text == string.Empty || cbCidade.Text == null
                || txtEmail.Text == string.Empty || txtEmail.Text == null
                || txtSenha.Text == string.Empty || txtSenha.Text == null
                || txtConfirmarSenha.Text == string.Empty || txtConfirmarSenha == null)
                {
                    ControlarVisibilidade();
                }
                else
                {
                    Cliente cliente = new Cliente()
                    {
                        Nome = txtNome.Text,
                        Cpf = txtEmail.Text,
                        Senha = txtSenha.Text,
                        ConfSenha = txtConfirmarSenha.Text,
                        Email = txtEmail.Text,
                        Sexo = cbSexo.Text,
                        Estado = cbEstado.Text,
                        Cidade = cbCidade.Text,
                        Bairro = txtBairro.Text
                    };

                    cliente.cadastraClien();

                    MessageBox.Show("Cadastro realizado com Secesso");

                    new TelaLogin().Show();
                    Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro. {ex.Message}");
            }

        }

        private void ControlarVisibilidade()
        {
            lblAtencao.Visible = true;

            if (txtNome.Text == string.Empty || txtNome.Text == null)
                lblNome.ForeColor = Color.Red;
            else
                lblNome.ForeColor = Color.White;

            if (maskedTxtCpf.Text == string.Empty || maskedTxtCpf.Text == null)
                lblCpf.ForeColor = Color.Red;
            else
                lblCpf.ForeColor = Color.White;

            if (cbEstado.Text == string.Empty || cbEstado.Text == null)
                lblEstado.ForeColor = Color.Red;
            else
                lblEstado.ForeColor = Color.White;

            if (cbCidade.Text == string.Empty || cbCidade.Text == null)
                lblCidade.ForeColor = Color.Red;
            else
                lblCidade.ForeColor = Color.White;

            if (txtEmail.Text == string.Empty || txtEmail.Text == null)
                lblEmail.ForeColor = Color.Red;
            else
                lblEmail.ForeColor = Color.White;

            if (txtSenha.Text == string.Empty || txtSenha.Text == null)
                lblSenha.ForeColor = Color.Red;
            else
                lblSenha.ForeColor = Color.White;

            if (txtConfirmarSenha.Text == string.Empty || txtConfirmarSenha == null)
                lblConfirmarSenha.ForeColor = Color.Red;
            else
                lblConfirmarSenha.ForeColor = Color.White;

            return;
        }
    }
}

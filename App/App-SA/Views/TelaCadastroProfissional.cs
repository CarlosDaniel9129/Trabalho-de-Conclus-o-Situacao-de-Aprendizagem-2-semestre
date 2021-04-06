using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App_SA.Models;
using App_SA.Controller;

namespace App_SA
{
    public partial class TelaCadastroProfissional : Form
    {
        Controle controle = new Controle();

        public TelaCadastroProfissional()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            Visible = false;
        }

        private void btnSalvarProfissional_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtNome.Text == string.Empty || txtNome.Text == null || maskedTxtCpf.Text == string.Empty || maskedTxtCpf.Text == null
                    || maskedTxtValorHora.Text == string.Empty || maskedTxtValorHora.Text == null || txtEmail.Text == string.Empty || txtEmail.Text == null
                    || txtSenha.Text == string.Empty || txtSenha.Text == null || txtConfirmarSenha.Text == string.Empty || txtConfirmarSenha == null
                    || cbProfissao.Text == string.Empty || cbProfissao.Text == null || cbFormacao.Text == string.Empty || cbFormacao.Text == null
                    || cbEstado.Text == string.Empty || cbEstado.Text == null || cbCidade.Text == string.Empty || cbCidade.Text == null)
                {
                    ControlarVisibilidade();
                }
                else
                {
                    Profissional profissional = new Profissional()
                    {
                        Nome = txtNome.Text,
                        Cpf = txtEmail.Text,
                        Email = txtEmail.Text,
                        Sexo = cbSexo.Text,
                        ValorHora = double.Parse(maskedTxtValorHora.Text),
                        Info = richTxtInformacoesAdicionais.Text,
                        Profissao = cbProfissao.Text,
                        Formacao = cbFormacao.Text,
                        Estado = cbEstado.Text,
                        Cidade = cbCidade.Text,
                        Bairro = txtBairro.Text
                    };

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

            if (!maskedTxtCpf.MaskCompleted)
                lblCpf.ForeColor = Color.Red;
            else
                lblCpf.ForeColor = Color.White;

            if (maskedTxtValorHora.MaskCompleted)
                lblValorHora.ForeColor = Color.Red;
            else
                lblValorHora.ForeColor = Color.White;

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

            if (cbProfissao.Text == string.Empty || cbProfissao.Text == null)
                lblProfissao.ForeColor = Color.Red;
            else
                lblProfissao.ForeColor = Color.White;

            if (cbFormacao.Text == string.Empty || cbFormacao.Text == null)
                lblFormacao.ForeColor = Color.Red;
            else
                lblFormacao.ForeColor = Color.White;

            if (cbEstado.Text == string.Empty || cbEstado.Text == null)
                lblEstado.ForeColor = Color.Red;
            else
                lblEstado.ForeColor = Color.White;

            if (cbCidade.Text == string.Empty || cbCidade.Text == null)
                lblCidade.ForeColor = Color.Red;
            else
                lblCidade.ForeColor = Color.White;

            return;
        }
    }
}

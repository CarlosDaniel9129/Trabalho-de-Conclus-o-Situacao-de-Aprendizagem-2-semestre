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

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
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

                }

            }
            catch (Exception)
            {

                throw;
            }



            new TelaLogin().Show();
            Visible = false;
        }
    }
}

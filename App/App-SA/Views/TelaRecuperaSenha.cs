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

namespace App_SA.Views
{
    public partial class TelaRecuperaSenha : Form
    {
        Comandos comandos = new Comandos();

        public string email;

        public TelaRecuperaSenha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            Visible = false;
        }

                   //btnConf1
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            
                comandos.verificaEmailCpf(txtEmail.Text, mkbCpf.Text);
                email = txtEmail.Text;

                if (comandos.tem.Equals(true))
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

                    btnVoltar.Visible = false;
                }
                else
                {
                    throw new Exception("Verifique Email e Cpf");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro. {ex.Message}");
            }
            

        }
                   //btnConf2
        private void btnConfSenha_Click(object sender, EventArgs e)
        {
            try
            {
                comandos.recuperaSenha(txtNewSenha.Text, txtConfSenha.Text, mkbCpf.Text);
                MessageBox.Show("Senha cadastrada com sucesso");

                new TelaLogin().Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro. {ex.Message}");
            }

        }


    }
}

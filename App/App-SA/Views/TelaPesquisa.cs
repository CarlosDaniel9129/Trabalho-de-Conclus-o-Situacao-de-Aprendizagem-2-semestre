using App_SA.Controller;
using App_SA.Models;
using MySql.Data.MySqlClient;
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

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public TelaPesquisa()
        {
            InitializeComponent();
        }

        

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();

            if (login.logado) //aqui faz a verificacao se o profi esta logado 
            {
                new TelaCadastroProfissional().Show();
                Visible = false;

                /*mostra tela cadastraProfissional, aqui dentro sera mostrado a tela do profissional 
                quando estiver logado e ira buscar as info do propfissional logado;*/
            }
            else
            {
                new TelaLogin().Show();
                Visible = false;

                /*mostra tela loginSenha, porque o profissional nao esta logado entao ele precisa estar
                logado para mostra a tela de cadastraProfissional*/
            }



        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            apresentaDados();
        }

        private void apresentaDados()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("server=localhost;user id=root;database=visualstudiomysql");
            mConn.Open();

            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("select * from usuario order by id", mConn);

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "usuario");

            //atribui o resultado à propriedade DataSource da dataGridView
            gridProfissionais.DataSource = mDataSet;
            gridProfissionais.DataMember = "usuario";
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

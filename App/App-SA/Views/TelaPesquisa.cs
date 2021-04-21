using App_SA.Controller;
using App_SA.Models;
using App_SA.Views;
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

        public TelaPesquisa()//recebo por parametro um objeto do tipo FORM
        {
            bool ehlogado = Comandos.Logado;
            InitializeComponent();
            if (ehlogado)
            {
                btnVoltar.Visible = false;
                btnMinhaConta.Visible = true;
                btnDeslogar.Visible = true;
            }
            else
            {
                btnVoltar.Visible = true;
                btnMinhaConta.Visible = false;
            }
        }
        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            new TelaAtualizaDados().Show();
            Visible = false;
        }

        private void apresentaDados()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("server=localhost;user id=root;database=workers");
            mConn.Open();
            string sql = "select idUsuario, nome, profissao, estado, cidade, formacao, valorHora, telefone from usuario where 1 = 1";
            if (cbProfissao.Text != string.Empty)
            {
                sql = sql + " and profissao like '%" + cbProfissao.Text + "%'";
            }

            if (cbEstado.Text != string.Empty)
            {
                sql = sql + " and estado like '%" + cbEstado.Text + "%'";
            }

            if (txtCidade.Text != string.Empty)
            {
                sql = sql + " and cidade like '%" + txtCidade.Text + "%'";
            }

            if (maskedTxtValorMin.MaskCompleted)
            {
                sql = sql + " and valorHora >= '" + maskedTxtValorMin.Text + "'";
            }

            if (maskedTxtValorMax.MaskCompleted)
            {
                sql = sql + " and valorHora <= '" + maskedTxtValorMax.Text + "'";
            }

            if (maskedTxtValorMin.MaskCompleted && maskedTxtValorMax.MaskCompleted)
            {
                var valorMin = Convert.ToDecimal(maskedTxtValorMin.Text);
                var valoMax = Convert.ToDecimal(maskedTxtValorMax.Text);
                if (valorMin > valoMax)
                {
                    lblAvisoValor.Visible = true;
                    lblValorMin.ForeColor = Color.Red;
                    lblValorMax.ForeColor = Color.Red;
                }
                else
                {
                    lblAvisoValor.Visible = false;
                    lblValorMin.ForeColor = Color.White;
                    lblValorMax.ForeColor = Color.White;
                }
            }
            else
            {
                lblAvisoValor.Visible = false;
                lblValorMin.ForeColor = Color.White;
                lblValorMax.ForeColor = Color.White;
            }



            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter(sql, mConn);

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            apresentaDados();
        }

        private void gridProfissionais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gridProfissionais.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString());
            new TelaMostrarProfissional(id).Show();

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            new TelaInicial().Show();
            Visible = false;
        }
    }
}

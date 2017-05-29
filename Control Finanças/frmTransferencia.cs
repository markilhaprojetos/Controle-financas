using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BicDll;

namespace Control_Finanças
{
    public partial class frmTransferencia : Form
    {
        string sql = null;
        DataTable dt = new DataTable();
        int modo = 0;

        double saldosaida = 0;
        double saldoentrada = 0;

        public frmTransferencia()
        {
            InitializeComponent();
            carregaContas();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja Sair ?"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void carregaContas()
        {
            cmbEntrada.Items.Clear();
            cmbSaida.Items.Clear();

            try
            {
                sql = "SELECT  conta_nome  FROM tblconta ";
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbEntrada.Items.Add(dr["conta_nome"].ToString());
                    cmbSaida.Items.Add(dr["conta_nome"].ToString()); 

                }



            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void btTransferencia_Click(object sender, EventArgs e)
        {
            lblSaldoSaida.Text = "";
            lblSaldoEntrada.Text = "";

            saldosaida = (saldosaida - Convert.ToDouble(txtValor.Text));
            saldoentrada = (saldoentrada + Convert.ToDouble(txtValor.Text));

            lblSaldoSaida.Text = Convert.ToString(saldosaida );
            lblSaldoEntrada .Text  = Convert.ToString(saldoentrada);

            atualizaSado( );


        }

        private void atualizaSado()
        {
            try
            {

                //Atualiza campo saída
                sql = "UPDATE tblconta SET conta_saldoatual = " + lblSaldoSaida.Text.Replace (",",".")+ "   WHERE conta_nome ='" + cmbSaida.Text + "' ;";
                 bicComponentes.AtualizarRegistro (Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                //Atualiza campo entrada
                 sql = "UPDATE tblconta SET conta_saldoatual = " + lblSaldoEntrada.Text.Replace (",",".")+ "  WHERE conta_nome ='" + cmbEntrada.Text + "' ;";
                 bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);


                 MessageBox.Show("Contas Atualizada com Sucesso...");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void cmbSaida_SelectedIndexChanged(object sender, EventArgs e)
        {
            modo = 0;
            lblSaldoSaida.Text = "...";
            carregaSaldo(lblSaldoSaida,cmbSaida);
        }

        private void carregaSaldo(Label texto, ComboBox combo)
        {
          
            try
            {

                sql = "SELECT  conta_saldoatual FROM tblconta WHERE conta_nome ='" + combo.Text  + "' ;" ;
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    texto.Text = (dr["conta_saldoatual"].ToString());

                    if (modo == 0)
                    {
                        
                        saldosaida = Convert.ToDouble(dr["conta_saldoatual"].ToString());

                    }
                    else
                    {
                        saldoentrada = Convert.ToDouble(dr["conta_saldoatual"].ToString());
                        
                    
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            modo = 1;
            lblSaldoEntrada.Text = "...";           
            carregaSaldo(lblSaldoEntrada , cmbEntrada );
        }
    }
}

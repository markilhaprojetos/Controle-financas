using BicDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Npgsql;
using System.Threading;

namespace Control_Finanças
{
    public partial class frmLogin : Form
    {
        string sql = "";
        DataTable dt = null;
       
        public frmLogin()
        {
            InitializeComponent();
            cmbNomeBanco.Items.Clear();
            txtIp.Text = Properties.Settings.Default.BancoIp;
            txtPorta.Text = Properties.Settings.Default.BancoPorta;
            cmbNomeBanco.Text = Properties.Settings.Default.BancoNome;

            txtIp.Text = Properties.Settings.Default.BancoIp;
            cmbUsuario.Text = Properties.Settings.Default.Usuario;
            cmbNomeBanco.Text = Properties.Settings.Default.BancoNome;
            txtPorta.Text = Properties.Settings.Default.BancoPorta;
            carregarUsuario();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtIp.Text = Properties.Settings.Default.BancoIp;
            cmbUsuario.Text = Properties.Settings.Default.Usuario;
            cmbNomeBanco.Text = Properties.Settings.Default.BancoNome;
            txtPorta.Text = Properties.Settings.Default.BancoPorta;
            carregarUsuario();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Thread th;

            //logar();
            Properties.Settings.Default.BancoIp = txtIp.Text;
            Properties.Settings.Default.Usuario = cmbUsuario.Text;
            Properties.Settings.Default.BancoNome = cmbNomeBanco.Text;
            Properties.Settings.Default.BancoPorta = txtPorta.Text;
            Properties.Settings.Default.BancoUsuario = "postgres";
            Properties.Settings.Default.BancoSenha = "postgres";
            Properties.Settings.Default.Save();

            this.Close();

            th = new Thread(AbrirFormulario);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

          
        }

        private void AbrirFormulario()
        {
            Application.Run(new frmPrincipal());
        }

       

        private void logar()
        {
            if (verificaSenha(txtSenha.Text) == true)
            {
                Properties.Settings.Default.BancoIp = txtIp.Text;
                Properties.Settings.Default.Usuario = cmbUsuario.Text;
                Properties.Settings.Default.Save();
                frmPrincipal form = new frmPrincipal();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Senha inválida");
                txtSenha.Focus();
            }

        }
        private bool verificaSenha(string txt)
        {
            bool resultado = false;
            try
            {
                string sql = " SELECT usuario_senha FROM tblusuario WHERE usuario_nome = '" + cmbUsuario.Text + "'" ;
                DataTable dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                if( dt.Rows.Count > 0)
                {
                   if( dt.Rows[0]["usuario_senha"].ToString() == txt)
                    {
                        resultado = true;

                    } else
                    {
                        resultado = false;
                    }
                }

            } catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return resultado;
        }       

        private void carregarUsuario()
        {
            cmbUsuario.Items.Clear();
           string sql = " SELECT usuario_nome  FROM tblusuario ORDER BY usuario_nome";
           DataTable dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, "postgres", "postgres", cmbNomeBanco.Text, sql);

            foreach (DataRow dr in dt.Rows)
            {
                cmbUsuario.Items.Add(dr["usuario_nome"].ToString());
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13)
            {
                logar();
            }
        }

        private void btnCarregarBanco_Click(object sender, EventArgs e)
        {
            
            dt = TodosRegistros(txtIp.Text, txtPorta.Text, "postgres", "postgres", "postgres", "SELECT datname FROM pg_database;");


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbNomeBanco.Items.Add(dr["datname"].ToString());

                }
            }
        }

        private void cmbNomeBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarUsuario();
        }

        //Pega todos os registros
        //Pega todos os registros
        public DataTable TodosRegistros(string ip,string porta,string usuario, string senha, string nomeBanco,string sql)
        {

            DataTable dt = new DataTable();            
            NpgsqlConnection pgsqlConnection = null;

            string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                            ip, porta, usuario, senha, nomeBanco);
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();

                    string cmdSeleciona = sql;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }

    }
}

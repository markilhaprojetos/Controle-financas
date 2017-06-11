using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BicDll;
using Npgsql;
using System.Threading;

namespace Control_Finanças
{
    public partial class frmEntrada : Form
    {
        string sql = "";
        DataTable dt = null;

        public frmEntrada()
        {
            InitializeComponent();
            slidemenu.Width = 50;
            this.Size = new System.Drawing.Size(440, 386);
            cmbNomeBanco.Items.Clear();
            txtIp.Text = Properties.Settings.Default.BancoIp;
            txtPorta.Text = Properties.Settings.Default.BancoPorta;
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImgMenu_Click(object sender, EventArgs e)
        {
            AbrirMenu(slidemenu);              
        }

        private void AbrirMenu(Panel Painel)
        {
            //1 enconde logo
            // 2 slide no painel
            if (slidemenu.Width == 50)
            {
                slidemenu.Width = 180;
                this.Size = new System.Drawing.Size(570, 386);             

            }
            else
            {
                slidemenu.Width = 50;                
                this.Size = new System.Drawing.Size(440, 386);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        public DataTable TodosRegistros(string ip, string porta, string usuario, string senha, string nomeBanco, string sql)
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
                string sql = " SELECT usuario_senha FROM tblusuario WHERE usuario_nome = '" + cmbUsuario.Text + "'";
                DataTable dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["usuario_senha"].ToString() == txt)
                    {
                        resultado = true;

                    }
                    else
                    {
                        resultado = false;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return resultado;
        }

        private void carregarUsuario()
        {
            try
            {
                cmbUsuario.Items.Clear();
                string sql = " SELECT usuario_nome  FROM tblusuario ORDER BY usuario_nome";
                DataTable dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, "postgres", "postgres", cmbNomeBanco.Text, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbUsuario.Items.Add(dr["usuario_nome"].ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbNomeBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarUsuario();
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

        private void cmbNomeBanco_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            carregarUsuario();
        }
    }
}

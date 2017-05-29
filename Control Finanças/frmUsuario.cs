using BicDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Finanças
{
    public partial class frmUsuario : Form
    {
        int id = 0;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Novo")
            {
                btnNovo.Text = "Salvar";
                habtilitaCampos();
                txtNome.Focus();


            }
            else
            {
                btnNovo.Text = "Novo";

                string sql = "Insert Into tblusuario (usuario_nome,usuario_senha) values( '"
                 + txtNome.Text + "','"
                 + txtSenha.Text + "' ) ;";
                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                MessageBox.Show("Cadastro Inserido com Sucesso...");
                carregarUsuario();
                DesabilitarCampos();
               

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                btnEditar.Text = "Salvar";
                habtilitaCampos();


            }
            else
            {
                btnEditar.Text = "Editar";
                string sql = "UPDATE tblusuario SET usuario_nome = '" + txtNome.Text + "' , usuario_senha = '" + txtSenha.Text + "' WHERE usuario_id = " + id + " ;";

                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                MessageBox.Show(" Registros Atualizados com Sucesso...");
                DesabilitarCampos();
                carregarUsuario();
            }
        }

        private void habtilitaCampos()
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
        }
        private void carregarUsuario()
        {
            string sql = " SELECT usuario_nome  FROM tblusuario ORDER BY usuario_nome";
            DataTable dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

            foreach (DataRow dr in dt.Rows)
            {
                cmbPesquisar.Items.Add(dr["usuario_nome"].ToString());
            }
        }
        private void carregarCampos()
        {
            string sql = " SELECT *  FROM tblusuario WHERE usuario_nome = '" + cmbPesquisar.Text + "' ORDER BY usuario_nome";
            DataTable dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

            foreach (DataRow dr in dt.Rows)
            {
                txtNome.Text = (dr["usuario_nome"].ToString());
                txtSenha.Text = (dr["usuario_senha"].ToString());
                id = Convert.ToInt32(dr["usuario_id"].ToString());
            }
        }

        private void cmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCampos();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            carregarUsuario();
            DesabilitarCampos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                   string sql = "Delete FROM tblusuario WHERE usuario_id = " + id;

                    bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                    MessageBox.Show(" Registros Deletados com Sucesso...");

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

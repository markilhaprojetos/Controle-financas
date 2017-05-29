using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BicDll;

namespace Control_Finanças
{
    public partial class frmConta : Form
    {
        int modo = 0;
        string sql = "";
        int id = 0;
        DataTable dt = new DataTable();


        public frmConta()

        {
            InitializeComponent();
            modo = 0;
            desativaCampos();
            btnAtualizar.Enabled = false;
            btnDeletar .Enabled = false;
            carregarcombo();
        }

        private void formulario1_Load(object sender, EventArgs e)
        {

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                btnInserir.Image = ListaImagem.Images[1];
                modo = 1;
                habtilitaCampos();
                txtNome.Focus();
                txtSaldoAnterior.Text = "0";
                txtSaldoProjetado.Text = "0";
                txtSaldoAtual.Text = "0";
                
            }
            else
            {
                btnInserir.Image = ListaImagem.Images[0];
                modo = 0;
                sql = "Insert Into tblconta (conta_nome,conta_saldoanterior,conta_saldoprojetado,conta_saldoatual) values( '"
                 + txtNome.Text+ "',"
                 + txtSaldoAnterior.Text.Replace(",", ".") + ","
                 + txtSaldoProjetado.Text.Replace(",", ".") + ","
                 + txtSaldoAtual.Text.Replace(",", ".") + ") ;";
               
                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                MessageBox.Show("Cadastro Inserido com Sucesso...");
                btnAtualizar.Enabled = true;
                btnInserir.Enabled = false;
                desativaCampos();
                carregarcombo();
            }
        }
        private void limpaCampos()
        {

            txtNome.Text = "";
            txtSaldoAnterior.Text = "";
            txtSaldoAtual.Text = "";
            txtSaldoProjetado.Text = "";
        }
        private void desativaCampos()
        {
            txtNome.Enabled = false;
            txtSaldoAnterior.Enabled = false;
            txtSaldoAtual.Enabled = false;
            txtSaldoProjetado.Enabled = false;
        
        }
        private void habtilitaCampos()
        {
            txtNome.Enabled = true;
            txtSaldoAnterior.Enabled = true;
            txtSaldoAtual.Enabled = true;
            txtSaldoProjetado.Enabled = true;
        
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                btnAtualizar.Image = ListaImagem.Images[1];
                modo = 1;
                habtilitaCampos();
                txtNome.Focus();

            }
            else
            {
                btnAtualizar.Image = ListaImagem.Images[2];
                modo = 0;


                //codsql = (txtSetor.Text + "-" + txtQuadra.Text + "-" + txtLote.Text);

                sql = "UPDATE tblconta SET conta_nome = '" + txtNome.Text + "' , conta_saldoanterior = '" + txtSaldoAnterior.Text + "' ,conta_saldoprojetado  = '" + txtSaldoProjetado.Text + "', conta_saldoatual  = '" + txtSaldoAtual.Text + "' WHERE conta_id = " +id+ " ;";
                
                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                lblEstatus.Text = " Registros Atualizados com Sucesso...";

                btnAtualizar.Enabled = false;                
                desativaCampos();              
                carregarcombo();
            }
        }

        private void carregarcampos()
        {
            sql = "SELECT * FROM tblconta  WHERE conta_nome = '" + cmbPesquisar.Text  + "' ORDER BY conta_nome;";
            btnAtualizar.Enabled = true;
            btnDeletar .Enabled = true;

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    txtNome.Text = dr["conta_nome"].ToString();
                    txtSaldoAnterior.Text = dr["conta_saldoanterior"].ToString();
                    txtSaldoProjetado.Text = dr["conta_saldoprojetado"].ToString();
                    txtSaldoAtual.Text = dr["conta_saldoatual"].ToString();
                    id = Convert.ToInt32(dr["conta_id"].ToString());
                
                }

                lblEstatus.Text = " Campos Carregados com Sucesso...";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              

        }
        private void carregarcombo()
        {
            sql = "SELECT conta_nome FROM tblconta  ORDER BY conta_nome;";
            cmbPesquisar.Items.Clear();           

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbPesquisar.Items .Add ( dr["conta_nome"].ToString());

                }


                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarcampos();
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    sql = "Delete FROM tblconta WHERE conta_id = " + id;
                    bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                    lblEstatus.Text = " Registros Deletados com Sucesso...";
                    carregarcombo();
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
    }
}

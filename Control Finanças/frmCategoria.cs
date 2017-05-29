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
    public partial class frmCategoria : Form
    {

        int modo = 0;
        string sql = "";
        int id = 0;
        int subid = 0;
        string tipo = "";
        
        DataTable dt = new DataTable();

        public frmCategoria()
        {
            InitializeComponent();
            desativaCampos();

            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            carregarcombo();
            dgvCategoria.ForeColor = Color.Black;

            if (Properties.Settings.Default.LancamentoTipo == "Despesa")
            {
                rbTipo.Checked  = true;
                tipo = "Despesa";

            }
            else
            {
                rbTipo.Checked = false;
                tipo = "Receita";
            
            }
        }

        private void carregarcombo()
        {
            sql = "SELECT categoria_nome FROM tblcategoria  ORDER BY categoria_nome;";
            cmbPesquisar.Items.Clear();

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbPesquisar.Items.Add(dr["categoria_nome"].ToString());

                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desativaCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
        }

      










        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja Sair ?"), "Controle de Despesas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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

            }
            else
            {
                btnInserir.Image = ListaImagem.Images[0];
                modo = 0;
                
                sql = "Insert Into tblcategoria (categoria_nome,categoria_descricao,categoria_tipo) values( '"
                 + txtNome.Text + "','"
                 + txtDescricao.Text + "','"
                 + tipo + "' ) ;";

                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                MessageBox.Show("Cadastro Inserido com Sucesso...");
                btnAtualizar.Enabled = true;
                btnInserir.Enabled = false;
                desativaCampos();
                carregarcampos();
                carregarcombo();
            }
        }

        private void habtilitaCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            
        }

        private void cmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarcampos();
            carregadgv();
        }
        private void carregadgv()
        {
            dgvCategoria.Rows.Clear();

            sql = "SELECT * FROM tblsubCategoria WHERE subcategoria_categoria = " + id + " ORDER BY subcategoria_id;";
           

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    dgvCategoria.Rows.Add(dr["subcategoria_id"].ToString(), dr["subcategoria_nome"].ToString());

                }

                lblEstatus.Text = " Campos Carregados com Sucesso...";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregarcampos()
        {
            sql = "SELECT * FROM tblcategoria  WHERE categoria_nome = '" + cmbPesquisar.Text + "' ORDER BY categoria_nome;";
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["categoria_tipo"].ToString() == "Despesa")
                    {
                        rbTipo.Checked = true;
                    }
                    else
                    {

                        rbTipo.Checked = false;
                    }

                    txtNome.Text = dr["categoria_nome"].ToString();
                    txtDescricao.Text = dr["categoria_descricao"].ToString();
                    id = Convert.ToInt32(dr["categoria_id"].ToString());

                }

                lblEstatus.Text = " Campos Carregados com Sucesso...";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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

                if (rbTipo.Checked == true)
                {
                    tipo = "Despesa";
                }
                else
                { tipo = "Receita"; }

                sql = "UPDATE tblcategoria SET categoria_nome = '" + txtNome.Text + "' , categoria_descricao = '" + txtDescricao.Text + "', categoria_tipo = '" + tipo + "' WHERE categoria_id = " + id + " ;";

                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                lblEstatus.Text = " Registros Atualizados com Sucesso...";

                btnAtualizar.Enabled = false;
                desativaCampos();

                carregarcombo();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    sql = "Delete FROM tblcategoria WHERE categoria_id = " + id;
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

      

        private void dgvCategoria_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvCategoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 2)
            {
                return;
            }
            else
            {
                subid = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);
                carregaCamposSub();
            
            }

            

        }

        private void carregaCamposSub()
        {

            sql = "SELECT * FROM tblsubcategoria  WHERE subcategoria_id = " + subid  + " ;";
            btnAtualizarSub.Enabled = true;
            btnDeletarSub.Enabled = true;

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    txtNomeSub.Text = dr["subcategoria_nome"].ToString();
                    txtDescricaoSub.Text = dr["subcategoria_descricao"].ToString();                  

                }

              

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            carregadgv();
        }

        private void btnInserirSub_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                btnInserirSub.Image = ListaImagem.Images[1];
                modo = 1;
                
                txtDescricaoSub.Text = "";
                txtNomeSub.Text = "";
                txtDescricaoSub.Enabled = true;
                txtNomeSub.Enabled = true;
                txtNome.Focus();

            }
            else
            {
                btnInserirSub.Image = ListaImagem.Images[0];
                modo = 0;

                sql = "Insert Into tblsubcategoria (subcategoria_categoria, subcategoria_nome, subcategoria_descricao) values( "
                 + id + ",'"
                 + txtNomeSub.Text + "','"
                 + txtDescricaoSub.Text + "' ) ;";

                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                MessageBox.Show("Cadastro Inserido com Sucesso...");

                btnAtualizarSub.Enabled = true;               
                txtDescricaoSub.Enabled = false;
                txtNomeSub.Enabled = false;
                carregadgv();
            }
        }

        private void btnAtualizarSub_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                btnAtualizarSub.Image = ListaImagem.Images[1];
                modo = 1;
                txtDescricaoSub.Enabled = true;
                txtNomeSub.Enabled = true;
                txtNome.Focus();

            }
            else
            {
                btnAtualizarSub.Image = ListaImagem.Images[2];
                modo = 0;
                sql = "UPDATE tblsubcategoria SET subcategoria_nome = '" + txtNomeSub.Text + "' , subcategoria_descricao = '" + txtDescricaoSub.Text + "' WHERE subcategoria_id = " + subid + " ;";

                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                lblEstatus.Text = " Registros Atualizados com Sucesso...";

                btnAtualizarSub.Enabled = false;
                txtDescricaoSub.Enabled = false;
                txtNomeSub.Enabled = false;
                carregadgv();

            }
        }

        private void btnDeletarSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    sql = "Delete FROM tblsubcategoria WHERE subcategoria_id = " + subid ;
                    bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                    lblEstatus.Text = " Registros Deletados com Sucesso...";
                    carregadgv();
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

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                return;
            }
            else
            {
                string v = dgvCategoria.Rows[e.RowIndex].Cells[0].Value.ToString ();
                    //Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);
                MessageBox.Show(v);

            
            }
        }

        private void splitPrincipal_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

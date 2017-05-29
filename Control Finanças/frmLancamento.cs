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
    public partial class frmLancamento : Form
    {
        string sql = "";
        DataTable dt = new DataTable();
        
        int catId = 0;      
        int modo = 0;
        string tipo = "";
        string estatus = "";
        
        

        public frmLancamento()
        {
            InitializeComponent();
            carregarCategoria(0);                   
            desativaCampos();           
            carregarCampos();          
            txtValor.Focus();


            switch (Properties.Settings.Default.LancamentoModo)
            {
                // 0 para novo lancamento
                case 0:
                    btnInserir.Image = ListaImagem.Images[1];
                    modo = 1;
                    habtilitaCampos();
                    limpaCampos();               
                    txtDataLançamento.Text = Properties.Settings.Default.LancamentoData; 

                        if (Properties.Settings.Default.LancamentoTipo == "Despesa")
                        {
                            rbTipo.Checked = true;
                        }
                        if (Properties.Settings.Default.LancamentoEstatus == "Pago")
                        {
                            rbEstatus.Checked = true; 
                        }
                break;

                // 1 para editar lancamento
                case 1:
                    btnAtualizar.Image = ListaImagem.Images[1];
                    modo = 1;
                    carregarCampos();                      
                    habtilitaCampos();              
                    txtDataLançamento.Focus();                
                break;
            
            }

            

        }

        private void carregarSubCategoria()
        {
           
           cmbSubCategoria.Items.Clear();
                
           sql = "SELECT * FROM tblsubCategoria WHERE subcategoria_categoria = " + catId + " ORDER BY subcategoria_nome;";
                       
            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                        cmbSubCategoria.Items.Add(dr["subcategoria_nome"].ToString());

                }

                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregarCampos()
        {
            DataTable tblcampos = null;

            cmbSubCategoria.Items.Clear();

            sql = "SELECT * FROM tblLancamento WHERE lancamento_id = " + Properties.Settings.Default.LancamentoCodigo  ;

            try
            {
                tblcampos = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                               
                if(tblcampos.Rows.Count > 0)
                {
                    txtDataLançamento.Text = tblcampos.Rows[0]["lancamento_data"].ToString();
                    txtDescricacao.Text = tblcampos.Rows[0]["lancamento_descricao"].ToString();
                    txtValor.Text = tblcampos.Rows[0]["lancamento_valor"].ToString();
                    txtParcela.Text = tblcampos.Rows[0]["lancamento_parcela"].ToString();
                    cmbSubCategoria.Text = tblcampos.Rows[0]["lancamento_subcategoria"].ToString();
                    cmbCategoria.Text = tblcampos.Rows[0]["lancamento_categoria"].ToString();
                   

                        if (tblcampos.Rows[0]["lancamento_tipo"].ToString() == "Despesa")
                        {
                            rbTipo.Checked = true;
                        }
                        if (tblcampos.Rows[0]["lancamento_estatus"].ToString() == "Pago")
                        {
                            rbEstatus.Checked = true;
                        }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string getMesPorExtenso(int mes)
        {
            // Obtém o nome do mês por extenso
            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToLower();
            // retorna o nome do mês com a primeira letra em maiúscula
            return char.ToUpper(mesExtenso[0]) + mesExtenso.Substring(1);
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDataLançamento.Text = dateTimePicker1.Value.ToShortDateString();
        }
        private void carregarCategoria(int opt)
        {
            try
            {
                switch (opt)
                { 
                    case 0:
                        cmbCategoria.Items.Clear();

                        sql = "SELECT categoria_nome FROM tblcategoria WHERE categoria_tipo = '" + Properties.Settings.Default.LancamentoTipo + "' ORDER BY categoria_nome;";
                         dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                

                foreach (DataRow dr in dt.Rows)
                {
                    cmbCategoria.Items.Add(dr["categoria_nome"].ToString());

                }

                        break;
                    case 1:
                        sql = "SELECT categoria_id FROM tblcategoria  WHERE categoria_nome ='" + cmbCategoria.Text + "' ;";
                         dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                

                foreach (DataRow dr in dt.Rows)
                {
                    catId = Convert.ToInt32(dr["categoria_id"].ToString());

                }

                        break;
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCategoria(1);
            lblEstatus.Text = catId.ToString();
            carregarSubCategoria();
        }       
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                btnInserir.Image = ListaImagem.Images[1];
                modo = 1;
                habtilitaCampos();
                limpaCampos();

                if (Properties.Settings.Default.LancamentoTipo == "Despesa")
                {
                    rbTipo.Enabled = true;
                }
                if (Properties.Settings.Default.LancamentoEstatus == "Pago")
                {
                    rbEstatus.Enabled = true;
                }
            }
            else
            {
                btnInserir.Image = ListaImagem.Images[0];
                modo = 0;               

                int cod_parcela = UltimoRegistro() + 1;
                tipoestatus();
                

                DateTime data = new DateTime();
                string dt = "";
                double mdata = 0;
                double adata = 0;
                string DataFinal = "";
                string Descricao = "";
                string ano = "";

                var valores = txtDataLançamento.Text.Split('/');

                mdata = Convert.ToInt32((valores[1]));
                adata = Convert.ToInt32((valores[2]));
                ano = valores[2].ToString();

                //Percorre o numero de parcelas
                for (int i = 0 ; i < Convert.ToInt32(txtParcela.Text); i++)
                {
                    if(mdata <= 12)   //Parcelas no mesmo ano                     
                    {
                        //Concatena data                        
                        DataFinal = valores[0] + "/" + string.Format("{0:00}",mdata) + "/" + string.Format("{0:00}",adata);
                        //Soma um mes
                        mdata++;
                        //converte string em data
                        data = Convert.ToDateTime(DataFinal);
                        //Converte o mes por extenso
                        dt = getMesPorExtenso(data.Month);
                        //Coloca o numero de parcelas no string Descrição
                        Descricao = txtDescricacao.Text + " (Parcela: " + (i + 1).ToString() + " de " + txtParcela.Text + ")";
                    }
                    else //Parcelas virando o ano
                    {
                        //mes se inicia
                        mdata = 1;
                        //soma um ano
                        adata = adata++;
                        //concactena data
                        DataFinal = valores[0] + "/" + string.Format("{0:00}", mdata) + "/" + string.Format("{0:00}", adata);
                        //converte string em data
                        data = Convert.ToDateTime(DataFinal);
                        //mes por extenso
                        dt = getMesPorExtenso(data.Month);
                        //coloca o numero de parcelas na descrição
                        Descricao = txtDescricacao.Text + " (Parcela: " + (i + 1).ToString() + " de " + txtParcela.Text + ")";
                    }

                    //Inseri Campos
                    sql = "Insert Into tbllancamento (lancamento_id_parcela, lancamento_categoria, lancamento_data, lancamento_descricao, lancamento_valor,lancamento_tipo ,lancamento_mes, lancamento_parcela, lancamento_subcategoria,lancamento_usuario,lancamento_ano, lancamento_estatus) values("
                    + cod_parcela + ",'"
                    + cmbCategoria.Text + "','"
                    + DataFinal + "','"
                    + Descricao + "','"
                    + txtValor.Text + "','"
                    + tipo + "','"
                    + dt + "',"
                    + 1 + ",'"
                    + cmbSubCategoria.Text + "','"
                    + Properties.Settings.Default.Usuario + "','"
                    + ano + "','"
                    + estatus + "') ;";
                    bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                  
                }

               
                MessageBox.Show("Cadastro Inserido com Sucesso...");
                btnAtualizar.Enabled = true;
                btnInserir.Enabled = true;
                desativaCampos();
                //carregarcampos();
            }
        }
        private int UltimoRegistro()
        {
            //paradoaqui
            int cod = 0;
            sql = "SELECT MAX(lancamento_id_parcela) FROM tbllancamento ;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

           
                foreach (DataRow dr in dt.Rows)
                {
                    if(dr["max"].ToString() != null)
                    {
                     cod = Convert.ToInt32(dr["max"].ToString());                   
                    }

                }

            return cod;
        }
        private void btnteste_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UltimoRegistro().ToString());
        }
        private void tipoestatus()
        {
            if (rbTipo.Checked)
            {
                tipo = "Despesa";
            }
            else
            {
                tipo = "Receita";
            }

            if (rbEstatus.Checked)
            {
                estatus = "Pago";
            }
            else
            {
                estatus = "Agendado";
            }
        }
        private void desativaCampos()
        {
            txtDataLançamento.Enabled = false;
            txtDescricacao.Enabled = false;
            txtParcela.Enabled = false;
            txtValor.Enabled = false;
            cmbCategoria.Enabled = false;           
            cmbSubCategoria.Enabled = false;
        }
        private void limpaCampos()
        {
            txtDataLançamento.Text = "";
            txtDescricacao.Text = "";            
            txtValor.Text = "";
            cmbCategoria.Text = "";          
            cmbSubCategoria.Text = ""; 
        }
        private void habtilitaCampos()
        {
            txtDataLançamento.Enabled = true;
            txtDescricacao.Enabled = true;
            txtParcela.Enabled = true;
            txtValor.Enabled = true;
            cmbCategoria.Enabled = true;           
            cmbSubCategoria.Enabled = true;   
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                btnAtualizar.Image = ListaImagem.Images[1];
                modo = 1;
                habtilitaCampos();              
                txtDataLançamento.Focus();

            }
            else
            {
                btnAtualizar.Image = ListaImagem.Images[2];
                modo = 0;
                if(rbTipo.Checked)
                {
                    tipo = "Despesa";
                }else
                {
                    tipo = "Receita";
                }

                DateTime data = new DateTime();
                string dt = "";
                data = Convert.ToDateTime(txtDataLançamento.Text);
                dt = getMesPorExtenso(data.Month);
                tipoestatus();
                var valores = txtDataLançamento.Text.Split('/');
                string ano = valores[2].ToString();


                sql = "UPDATE tbllancamento SET lancamento_data = '" + txtDataLançamento.Text + "', lancamento_descricao = '" + txtDescricacao.Text + "', lancamento_valor = '" + txtValor.Text + "', lancamento_parcela = " + txtParcela.Text + ", lancamento_subcategoria = '" + cmbSubCategoria.Text + "', lancamento_mes = '" + dt + "', lancamento_categoria ='" + cmbCategoria.Text + "', lancamento_estatus = '" + estatus  + "', lancamento_tipo ='" + tipo + "' , lancamento_ano ='"+ ano + "', lancamento_usuario='" + Properties.Settings.Default.Usuario + "'  WHERE lancamento_id = " + Properties.Settings.Default.LancamentoCodigo + " ;";
                     

                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                lblEstatus.Text = " Registros Atualizados com Sucesso...";

                btnAtualizar.Enabled = false;
                desativaCampos();

               
            }
        }
        private void splitPrincipal_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria form = new frmCategoria();
            form.Show();
            
        }
        private void cmbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }       
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    sql = "Delete FROM tbllancamento WHERE lancamento_id = " + Properties.Settings.Default.LancamentoCodigo;

                    bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                    lblEstatus.Text = " Registros Deletados com Sucesso...";
                    
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
        private void frmLancamento_Activated(object sender, EventArgs e)
        {
            carregarCategoria(0);
            txtValor.Focus();

        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            
        }
        private void frmLancamento_Load(object sender, EventArgs e)
        {
           
        }
        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void borda_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

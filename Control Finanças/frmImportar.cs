using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Finanças
{
    public partial class frmImportar : Form
    {
        public frmImportar()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //// Create an OpenFileDialog to request a file to open.
            //OpenFileDialog openFile1 = new OpenFileDialog();

            //// Initialize the OpenFileDialog to look for RTF files.
            //openFile1.DefaultExt = "*.csv";
            //openFile1.Filter = "Arquivos csv|*.csv";
            ////openFile1.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            //   openFile1.FileName.Length > 0)
            //{
            //    txtCaminho.Text = openFile1.FileName;

            //    importarCsv();
            //}
        }


        private void dgvImportarCsv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgvImportarCsv.Rows[e.RowIndex].Cells[7].Value = "Deletar";
            //dgvImportarCsv.Rows[e.RowIndex].Cells[6].Value = "Pago";

            //if (Convert.ToString(dgvLancamento.Rows[e.RowIndex].Cells[5].Value) == "Despesa")
            //{
            //    e.CellStyle.BackColor = Color.Beige;
            //}
            //else
            //{
            //    e.CellStyle.BackColor = Color.Aqua;
            //}

        }

        private void dgvImportarCsv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = new DataTable();

            if (e.ColumnIndex == 7)
            {

                dgvImportarCsv.Rows.RemoveAt(e.RowIndex);
                dgvImportarCsv.Update();


            }
        }
        private void importarCsv()
        {
            int cont = 0;
            string tipo = "";
            dgvImportarCsv.Rows.Clear();
            try
            {
                var reader = new System.IO.StreamReader(File.OpenRead(txtCaminho.Text));


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    //if (cont > 0)
                    //{                      

                    dgvImportarCsv.Rows.Add(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);

                    //}
                    //cont++;



                }
                MessageBox.Show("Importado com sucesso....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            //DateTime data = new DateTime();
            //string dt = "";

            //if (dgvImportarCsv.Rows.Count > 1)
            //{
            //    for (int i = 0; i < dgvImportarCsv.Rows.Count - 1; i++)
            //    {
            //        data = Convert.ToDateTime(dgvImportarCsv.Rows[i].Cells[0].Value);
            //        dt = getMesPorExtenso(data.Month);


            //        //atualizaSaldo(dgvImportarCsv.Rows[i].Cells[3].Value.ToString(), dgvImportarCsv.Rows[i].Cells[4].Value.ToString(), dgvImportarCsv.Rows[i].Cells[0].Value.ToString());



            //        sql = "Insert Into tbllancamento (lancamento_data, lancamento_categoria, lancamento_subcategoria, lancamento_conta, lancamento_valor, lancamento_tipo, lancamento_estatus,lancamento_parcela, lancamento_mes) values('"
            //   + dgvImportarCsv.Rows[i].Cells[0].Value + "','"
            //   + dgvImportarCsv.Rows[i].Cells[1].Value + "','"
            //   + dgvImportarCsv.Rows[i].Cells[2].Value + "','"
            //   + dgvImportarCsv.Rows[i].Cells[3].Value + "',"
            //   + Convert.ToString(dgvImportarCsv.Rows[i].Cells[4].Value) + ",'"
            //   + dgvImportarCsv.Rows[i].Cells[5].Value + "','"
            //   + dgvImportarCsv.Rows[i].Cells[6].Value + "',"
            //   + 1 + ",'"
            //   + dt + "') ;";

            //        bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            //    }

            //}


            //atualizar();

            //MessageBox.Show("Cadastro Inserido com Sucesso...");
        }
    }
}

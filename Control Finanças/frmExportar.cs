using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BicDll;
using System.IO;
using System.Reflection;

namespace Control_Finanças
{
    public partial class frmExportar : Form
    {
        string sql = "";
        DataTable dt = new DataTable();
        string caminho = "";
        public frmExportar()
        {
            InitializeComponent();
        }

        private void txtDataFinal_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            sql = "SELECT * from tbllancamento where cast(lancamento_data as date) between cast('"+txtDataInicial.Text+"' as date) and cast('"+txtDataFinal.Text+"' as date) order by cast(lancamento_data as date) ;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            if (dt.Rows.Count > 0)
            {
               
                dgvExportar.DataSource = dt;
                dgvExportar.Update();
            }
        }

        private void dtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            txtDataInicial.Text = dtDataInicial.Text;
        }

        private void dtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            txtDataFinal.Text = dtDataFinal.Text;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog openFile1 = new SaveFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.csv";
            openFile1.Filter = "Arquivos csv|*.csv";
            openFile1.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            openFile1.FileName = txtDataInicial.Text.Replace("/", "-") + "_" + txtDataFinal.Text.Replace("/", "-");

            if (openFile1.ShowDialog() == DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                caminho = openFile1.FileName;
                ExportarCsv();
                MessageBox.Show("Exportado com sucesso....");
            }
        }

        private void ExportarCsv()
        {
            string strExport = "";

            foreach (DataGridViewColumn dc in dgvExportar.Columns)
            {
                strExport += dc.Name + ";";
            }

            strExport = strExport.Substring(0, strExport.Length - 3) + Environment.NewLine.ToString();

            foreach (DataGridViewRow dr in dgvExportar.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if (dc.Value != null)
                    {
                        strExport += dc.Value.ToString() + ";";
                    }
                }
                strExport += Environment.NewLine.ToString();
            }

            Encoding unicode = Encoding.Unicode;

            strExport = strExport.Substring(0, strExport.Length - 3) + Environment.NewLine.ToString();
            TextWriter tw = new StreamWriter(caminho,false, Encoding.UTF8);
            

            tw.Write(strExport);
            tw.Close();
        }
        private void importarCsv()
        {
            int cont = 0;
            DataTable dt = new DataTable();

            //dgvExportar.Rows.Clear();
            try
            {
                var reader = new System.IO.StreamReader(File.OpenRead(caminho));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (cont == 0)
                    {
                        //Adicionar colunas
                        for (int i = 1; i < values.Count(); i++)
                        {
                            dt.Columns.Add(values[i], typeof(string));                            
                        }
                        
                    }
                    else
                    {
                        dt.Rows.Add(values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11], values[12], values[13]);

                    }
                    cont++;

                    dgvExportar.DataSource = dt;
                    dgvExportar.Update();
                }
                MessageBox.Show("Importado com sucesso....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public class EncodingStringWriter : StringWriter
        {
            private readonly Encoding _encoding;

            public EncodingStringWriter(StringBuilder builder, Encoding encoding) : base(builder)
            {
                _encoding = encoding;
            }

            public override Encoding Encoding
            {
                get { return _encoding; }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.csv";
            openFile1.Filter = "Arquivos csv|*.csv";
            openFile1.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
           

            if (openFile1.ShowDialog() == DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                caminho = openFile1.FileName;
                importarCsv();
                MessageBox.Show("Importado com sucesso....");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvExportar.Rows.Count > 0)
            {
                for (int i = 0; i < dgvExportar.Rows.Count ; i++)
                {
                 sql = "Insert Into tbllancamento (lancamento_data, lancamento_descricao, lancamento_valor, lancamento_parcela, lancamento_subcategoria, lancamento_categoria, lancamento_estatus, lancamento_tipo, lancamento_usuario, lancamento_mes, lancamento_id_parcela, lancamento_totalparcelas, lancamento_ano) values('"
                + dgvExportar.Rows[i].Cells[0].Value + "','"
                + dgvExportar.Rows[i].Cells[1].Value + "','"
                + dgvExportar.Rows[i].Cells[2].Value + "','"
                + dgvExportar.Rows[i].Cells[3].Value + "','"
                + dgvExportar.Rows[i].Cells[4].Value + "','"
                + dgvExportar.Rows[i].Cells[5].Value + "','"
                + dgvExportar.Rows[i].Cells[6].Value + "','"
                + dgvExportar.Rows[i].Cells[7].Value + "','"
                + dgvExportar.Rows[i].Cells[8].Value + "','"
                + dgvExportar.Rows[i].Cells[9].Value + "',"
                + dgvExportar.Rows[i].Cells[10].Value + ","
                + 1 + ",'"                              
                + dgvExportar.Rows[i].Cells[12].Value + "') ;";
                bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                }
                MessageBox.Show("Gravado com sucesso....");
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

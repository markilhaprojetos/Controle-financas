using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BicDll;
using System.IO;
using System.Reflection;
using System.Management;
using System.Linq;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace Control_Finanças
{
    public partial class frmPrincipal : Form
    {
        int mesatual = 0;
        double totalReceita= 0;
        double totalDespesa = 0;
        double totalReceitaAgendada = 0;
        double totalDespesaAgendada = 0;
        double resultado = 0;
        double resultadoFinal = 0;
        DataTable dt = new DataTable();
        DataTable dtGrafico = new DataTable();       
        string sql = "";
        CultureInfo formato = null;      
       

        public frmPrincipal()
        {
            InitializeComponent();

            formato = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            formato.NumberFormat.NumberDecimalSeparator = ",";
            formato.NumberFormat.NumberGroupSeparator = ".";

            mesatual = DateTime.Now.Month;

            dgvLancamento.ForeColor = Color.Black;            
            dgvContasPagar.ForeColor = Color.Blue;
           
            txtMes.Text = getMesPorExtenso(mesatual);
            txtGraficoMes.Text = getMesPorExtenso(mesatual);
            atualizar();             

            if (cmbCategoria.Items.Count != 0)
            {
                cmbCategoria.SelectedIndex = 0;
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'controle_financeiroDataSet.tbllancamento' table. You can move, or remove it, as needed.
            verificaVencida(dgvContasPagar, "Há Contas a Pagar Vencidas...");
            verificaVencida(dgvContasReceber, "Há Contas a Receber Vencidas...");
            lblUsuario.Text = "Usuário: " + Properties.Settings.Default.Usuario;
            cmbUsuario.Text = Properties.Settings.Default.Usuario;
            dgvLancamento.Columns["ValorLA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContasPagar.Columns["ValorCA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContasReceber.Columns["ValorCR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtGraficoAno.Text = DateTime.Now.Year.ToString();
            txtAno.Text = DateTime.Now.Year.ToString();
          
        }

        //Menu

        private void menuPrincipalSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Botoes

        private void btnFechar_Click(object sender, EventArgs e)
        {
          
        }

      

        private void MenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuPrincipalCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria Child = new frmCategoria();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      

        private void scprincipal_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            mesatual--;
            if (mesatual == 0)
            {
                mesatual = 12;
            }

            txtMes.Text = getMesPorExtenso(mesatual);


            atualizar();
            
        }

        private void btnProximoMes_Click(object sender, EventArgs e)
        {
            mesatual++;

            if (mesatual > 12)
            {
                mesatual = 1;
            }

            txtMes.Text = getMesPorExtenso(mesatual);
            atualizar();
        }

        private string getMesPorExtenso(int mes)
        {
            // Obtém o nome do mês por extenso
            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToLower();
            // retorna o nome do mês com a primeira letra em maiúscula
            return char.ToUpper(mesExtenso[0]) + mesExtenso.Substring(1);
        }
        private string getAnoPorExtenso()
        {
            // Obtém o nome do mês por extenso
            string anoExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.YearMonthPattern.ToLower();
            // retorna o nome do mês com a primeira letra em maiúscula
            return char.ToUpper(anoExtenso[0]) + anoExtenso.Substring(1);
        }

        //paradoaqui
        private void Grafico(Chart grafico)
        {
           
                double EstilodeVida = 0;
                double DespesaBasicas = 0;
                double Receitas = 0;
                double Restou = 0;


                dtGrafico.Columns.Clear();
                dtGrafico.Columns.Add("Valores", typeof(double));
                dtGrafico.Columns.Add("Titulo", typeof(string));

                //Soma as Despesa Basicas
                dt.Rows.Clear();
                sql = "SELECT  lancamento_categoria, lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = 'Despesas Básicas' ORDER BY lancamento_categoria;";
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                foreach (DataRow dr in dt.Rows)
                {
                    DespesaBasicas += bicComponentes.ConverterDouble(dr["lancamento_valor"].ToString());
                }

                //Soma as Estilo de Vida
                dt.Rows.Clear();
                sql = "SELECT  lancamento_categoria, lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = 'Estilo de Vida' ORDER BY lancamento_categoria;";
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                foreach (DataRow dr in dt.Rows)
                {
                    EstilodeVida += bicComponentes.ConverterDouble(dr["lancamento_valor"].ToString());
                }

                //Soma as Receitas
                dt.Rows.Clear();
                sql = "SELECT  lancamento_categoria, lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = 'Proventos' ORDER BY lancamento_categoria;";
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Receitas += bicComponentes.ConverterDouble(dr["lancamento_valor"].ToString());
                }

            if (Receitas > 0)
            {
                EstilodeVida = bicComponentes.ConverterDouble(string.Format("{0:0,0.00}", (EstilodeVida * 100) / Receitas));
                DespesaBasicas = bicComponentes.ConverterDouble(string.Format("{0:0,0.00}", (DespesaBasicas * 100) / Receitas));
                Restou = (100 - (EstilodeVida + DespesaBasicas));
                dtGrafico.Rows.Add(DespesaBasicas, "Despesas Básicas");
                dtGrafico.Rows.Add(EstilodeVida, "Estilo de Vida");
                dtGrafico.Rows.Add(Restou, "Investimento");

                grafico.Series.Clear();
                grafico.Titles.Clear();
                grafico.Palette = ChartColorPalette.Pastel;
                grafico.Titles.Add("Despesas Básica X Estilo de Vida X Investimento (%)");
                grafico.Series.Add("Categoria");
                grafico.ChartAreas[0].Area3DStyle.Enable3D = true;

                grafico.DataSource = dtGrafico;

                grafico.Series["Categoria"].XValueMember = "Titulo";
                grafico.Series["Categoria"].YValueMembers = "Valores";

                grafico.Series["Categoria"].XValueType = ChartValueType.Double;
                grafico.Series["Categoria"].IsValueShownAsLabel = true;
                //grafico.Series["Categoria"].Label = "Valores" + "#PERCENT{P1}";

                grafico.Series["Categoria"].ChartType = SeriesChartType.Pie;
                grafico.Update();
            }
            else
            {
                grafico.Series.Clear();
                grafico.Update();
                return;
            }
               

               
          
        }
        private void GraficoUsuario(Chart grafico)
        { 
            //paradoaqui
            double EstilodeVida = 0;
            double DespesaBasicas = 0;
            double Receitas = 0;
            double Restou = 0;


            dtGrafico.Columns.Clear();
            dtGrafico.Columns.Add("Valores", typeof(double));
            dtGrafico.Columns.Add("Titulo", typeof(string));

            //Soma as Despesa Basicas
            dt.Rows.Clear();
            sql = "SELECT  lancamento_categoria, lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = 'Despesas Básicas' AND lancamento_usuario = '" + cmbUsuario.Text + "' ORDER BY lancamento_categoria;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            foreach (DataRow dr in dt.Rows)
            {
                DespesaBasicas += bicComponentes.ConverterDouble(dr["lancamento_valor"].ToString());
            }

            //Soma as Estilo de Vida
            dt.Rows.Clear();
            sql = "SELECT  lancamento_categoria, lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = 'Estilo de Vida' AND lancamento_usuario = '" + cmbUsuario.Text + "' ORDER BY lancamento_categoria;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            foreach (DataRow dr in dt.Rows)
            {
                EstilodeVida +=  bicComponentes.ConverterDouble(dr["lancamento_valor"].ToString());
            }

            //Soma as Receitas
            dt.Rows.Clear();
            sql = "SELECT  lancamento_categoria, lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = 'Proventos' AND lancamento_usuario = '" + cmbUsuario.Text + "' ORDER BY lancamento_categoria;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            foreach (DataRow dr in dt.Rows)
            {
                Receitas += bicComponentes.ConverterDouble(dr["lancamento_valor"].ToString());
            }

            if(Receitas <= 0)
            {
                MessageBox.Show("Nenhuma receita lançada....");
                return;
            }

            
            EstilodeVida = Math.Round((EstilodeVida * 100) / Receitas,2);
            DespesaBasicas = Math.Round((DespesaBasicas * 100) / Receitas, 2);
            Restou = Math.Round(100 - (EstilodeVida + DespesaBasicas),2);

            dtGrafico.Rows.Add(DespesaBasicas, "Despesas Básicas");
            dtGrafico.Rows.Add(EstilodeVida, "Estilo de Vida");
            dtGrafico.Rows.Add(Restou, "Investimento");

            grafico.Series.Clear();
            grafico.Titles.Clear();
            grafico.Palette = ChartColorPalette.Pastel;
            grafico.Titles.Add("Despesas Básica X Estilo de Vida X Investimento (%)");
            grafico.Series.Add("Categoria");
            grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            grafico.DataSource = dtGrafico;

            grafico.Series["Categoria"].XValueMember = "Titulo";
            grafico.Series["Categoria"].YValueMembers = "Valores";

            grafico.Series["Categoria"].XValueType = ChartValueType.Double;
            grafico.Series["Categoria"].IsValueShownAsLabel = true;
            //grafico.Series["Categoria"].Label = "Valores" + "#PERCENT{P1}";

            grafico.Series["Categoria"].ChartType = SeriesChartType.Pie;
            grafico.Update();
        }
        private void GraficoCategoria(Chart grafico)
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Clear();


            double soma = 0;
            dtGrafico.Columns.Clear();
            dtGrafico.Columns.Add("Valores", typeof(double));
            dtGrafico.Columns.Add("Titulo", typeof(string));

            //Soma as Despesa Basicas
            
            dt.Rows.Clear();
            sql = "SELECT  DISTINCT lancamento_subcategoria FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_categoria = '" + cmbCategoria.Text + "' ORDER BY lancamento_subcategoria;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

            foreach (DataRow dr in dt.Rows)
            {
                dt2.Rows.Clear();
                sql = "SELECT  lancamento_valor FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_subcategoria = '" + dr["lancamento_subcategoria"].ToString() + "' ORDER BY lancamento_subcategoria;";
                dt2 = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    soma += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                }

                dtGrafico.Rows.Add(soma, dr["lancamento_subcategoria"].ToString());
                soma = 0;             
            }
            grafico.Series.Clear();
            grafico.Titles.Clear();
            grafico.Palette = ChartColorPalette.Pastel;
            grafico.Titles.Add("Categorias (%)");
            grafico.Series.Add("Categoria");
            grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            grafico.DataSource = dtGrafico;

            grafico.Series["Categoria"].XValueMember = "Titulo";
            grafico.Series["Categoria"].YValueMembers = "Valores";

            grafico.Series["Categoria"].XValueType = ChartValueType.Double;
            grafico.Series["Categoria"].IsValueShownAsLabel = true;
            //grafico.Series["Categoria"].Label = "Valores" + "#PERCENT{P1}";
            grafico.Series["Categoria"].ChartType = SeriesChartType.Pie;
            grafico.Update();
        }        
        private void carregarGrafico(string camponome,string campovalor, Chart grafico, string opt)
        {
            DataTable dt = new DataTable();
            string sql = "";
            double total = 0;

            grafico.Series.Clear();
            grafico.Titles.Clear();
            


            grafico.Palette = ChartColorPalette.Pastel;

            dt.Rows.Clear();
            switch (opt)
            {                 
                case "despesa":
                    sql = "SELECT  lancamento_categoria, sum(lancamento_valor) FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_tipo = 'Despesa' AND lancamento_estatus = 'Pago' GROUP BY lancamento_categoria ORDER BY lancamento_categoria;";
                    break;
                case "subcategoria":
                    sql = "SELECT  lancamento_subcategoria, sum(lancamento_valor) FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "'  AND lancamento_estatus = 'Pago' AND lancamento_categoria ='" + cmbCategoria.Text + "' GROUP BY lancamento_subcategoria ORDER BY lancamento_subcategoria;";

                    break;
            }
           

            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome,
               sql);

            foreach (DataRow dr in dt.Rows)
            {
                total = total + bicComponentes.ConverterDouble(dr["sum"].ToString());
            }

            string moeda = String.Format("{0:C}", total);
            //lblTotalDespesas.Text = moeda;
           
            grafico.Titles.Add("Despesas por Categoria ( Total = " + moeda + " )" );
            grafico.Series.Add("Categoria");
            grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            grafico.DataSource = dt;

            grafico.Series["Categoria"].XValueMember = camponome;
            grafico.Series["Categoria"].YValueMembers = "sum";
            grafico.Series["Categoria"].IsValueShownAsLabel = true;
            grafico.Series["Categoria"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            grafico.Update();
        }
        private void carregarGraficoBarra(Chart grafico)
        {
            Series serie;
            DataTable dtgraf = new DataTable();
            grafico.Series.Clear();
            grafico.Titles.Clear();
            //graficoBarra.Palette = ChartColorPalette.Pastel;
            grafico.Titles.Add("Resumo Ano");

            string itens = "Janeiro;Fevereiro;Março;Abril;Junho;Julho;Agosto;Setembro;Novembro;Dezembro";
            var valores = itens.Split(';');

                foreach (var dr in valores)
                {
                    dtgraf.Rows.Clear();
                    dtgraf = calculaValordoMes(Properties.Settings.Default.Usuario, dr.ToString(), txtGraficoAno.Text);
                    serie = grafico.Series.Add(dr.ToString());

                    foreach (DataRow dr2 in dtgraf.Rows)
                    {
                    serie.Points.Add(bicComponentes.ConverterDouble(dr2["Valor"].ToString()));
                    serie.LabelAngle = 0;
                    serie.IsValueShownAsLabel = false;
                    serie.Label = dr2["Mes"].ToString().Substring(0,3);
                    serie.ChartType = SeriesChartType.Column;
                    }

                    grafico.Update();
                }
        }
        private DataTable calculaValordoMes(string usuario, string mes, string ano)
        {
            DataTable dtsoma = new DataTable();
            DataTable dtds = new DataTable();
            double somaDespesaBasica = 0;
            double somaEstiloVida = 0;
            double somaProventos = 0;
                        
            dtds.Columns.Add("Mes", typeof(string));
            dtds.Columns.Add("Valor", typeof(string));
            dtds.Rows.Clear();

            sql = "SELECT lancamento_categoria, lancamento_valor,lancamento_data FROM tbllancamento WHERE lancamento_mes = '" + mes + "' AND lancamento_ano ='" + txtGraficoAno.Text + "' ;";
            dtsoma = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            if (dtsoma.Rows.Count > 0)
            {
                foreach (DataRow dr2 in dtsoma.Rows)
                {
                        if (dr2["lancamento_categoria"].ToString() == "Despesas Básicas")
                        {
                            somaDespesaBasica += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                        }
                        if (dr2["lancamento_categoria"].ToString() == "Estilo de Vida")
                        {
                            somaEstiloVida += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                        }
                        if (dr2["lancamento_categoria"].ToString() == "Proventos")
                        {
                            somaProventos += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                        }
                }

                dtds.Rows.Add(mes, (somaProventos - (somaDespesaBasica + somaEstiloVida)).ToString("0.00"));               

                //zera 
                somaDespesaBasica = 0;
                somaEstiloVida = 0;
                somaProventos = 0;
            }
            
            return dtds;

        }
        private void carregarGraficoReceitaDespesa(string  grafEstatus, Chart grafico, string Titulo)
        {
            DataTable dt = new DataTable();
            string sql = "";
            DataTable dt2 = new DataTable();
            dt2.Rows.Clear();

            grafico .Series.Clear();
            grafico .Titles.Clear();            
            grafico .Titles.Add(Titulo);
            dt.Rows.Clear();
            Series serie;



            //Serie Receita
            sql = "SELECT  lancamento_tipo, sum(lancamento_valor) FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_tipo = 'Receita' AND lancamento_estatus = '" + grafEstatus + "' GROUP BY lancamento_tipo ORDER BY lancamento_tipo;";
                dt2 = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome,
                   sql);

                foreach (DataRow dr2 in dt2.Rows)
                {
                    serie = grafico.Series.Add(dr2["lancamento_tipo"].ToString());
                    serie.Points.AddXY(dr2["lancamento_tipo"].ToString(), dr2["sum"].ToString());
                    serie.Color = Color.Blue;
                    
                    serie.IsValueShownAsLabel = true;
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                }


            //Serie Despesa
                sql = "SELECT  lancamento_tipo, sum(lancamento_valor) FROM tbllancamento   WHERE lancamento_mes = '" + txtGraficoMes.Text + "' AND lancamento_tipo = 'Despesa' AND lancamento_estatus = '" + grafEstatus + "' GROUP BY lancamento_tipo ORDER BY lancamento_tipo;";
                dt2 = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome,
                   sql);

                foreach (DataRow dr2 in dt2.Rows)
                {
                    serie = grafico.Series.Add(dr2["lancamento_tipo"].ToString());
                    serie.Points.AddXY(dr2["lancamento_tipo"].ToString(), dr2["sum"].ToString());
                    serie.Color = Color.Red;                   
                    serie.IsValueShownAsLabel = true;
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                }
             grafico .Update();
        }
        private void carregarLancamento(string opt)
        {
            switch (opt)
            { 
                case "Geral":
                    sql = "SELECT * FROM tbllancamento WHERE lancamento_mes = '" + txtMes.Text + "'  ORDER BY lancamento_data;";
                    break;

                case "Categoria":
                    sql = "SELECT * FROM tbllancamento WHERE lancamento_mes = '" + txtMes.Text + "' AND lancamento_categoria = '" +cmbFiltroCategoria.Text + "'  ORDER BY lancamento_data;";
                    break;
                case "Tipo":
                    sql = "SELECT * FROM tbllancamento WHERE lancamento_mes = '" + txtMes.Text + "' AND lancamento_tipo = '" + cmbTipo.Text  + "'  ORDER BY lancamento_data;";
                    break;

                case "Usuario":
                    sql = "SELECT * FROM tbllancamento WHERE lancamento_mes = '" + txtMes.Text + "' AND lancamento_usuario = '" + cmbConsultaUsuario.Text + "'  ORDER BY lancamento_data;";
                    break;
                case "Usuario2":
                    sql = "SELECT * FROM tbllancamento WHERE lancamento_mes = '" + txtMes.Text + "' AND lancamento_usuario = '" + Properties.Settings.Default.Usuario + "'  ORDER BY lancamento_data;";
                    break;

            }
           
            dgvLancamento.Rows.Clear();
           

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    string moeda = String.Format("{0:C}", dr["lancamento_valor"].ToString());
                    string _data = String.Format("{0:d}", dr["lancamento_data"].ToString()); //.Remove(10));                   

                    dgvLancamento.Rows.Add(dr["lancamento_id"].ToString(), _data, dr["lancamento_categoria"].ToString(), dr["lancamento_subcategoria"].ToString(), dr["lancamento_usuario"].ToString(), moeda, dr["lancamento_tipo"].ToString(), dr["lancamento_estatus"].ToString(), dr["lancamento_descricao"].ToString());

                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void totalDespesaReceita()
        {
           
            totalReceita = 0;
            totalDespesa = 0;
            totalReceitaAgendada = 0;
            totalDespesaAgendada = 0;
            resultado = 0;
            resultadoFinal = 0;
            lblResultado.Text  = "";
            lblTotalDespesas.Text  = "";
            DataTable dtl = new DataTable();
            dtl.Rows.Clear();
            try
            {
                if (dgvLancamento.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvLancamento.Rows.Count;i++ )
                    {
                       
                         //Calcula despesas 
                        if (Convert.ToString(dgvLancamento.Rows[i].Cells["Tipo"].Value) == "Despesa" && Convert.ToString(dgvLancamento.Rows[i].Cells["Estatus"].Value) == "Pago")
                        {
                            totalDespesa = totalDespesa + bicComponentes.ConverterDouble(dgvLancamento.Rows[i].Cells[5].Value.ToString());

                        }
                        //Calcula Receita
                        if (Convert.ToString(dgvLancamento.Rows[i].Cells["Tipo"].Value) == "Receita" && Convert.ToString(dgvLancamento.Rows[i].Cells["Estatus"].Value) == "Pago")
                        {
                            totalReceita = totalReceita + bicComponentes.ConverterDouble(dgvLancamento.Rows[i].Cells[5].Value.ToString());

                        }

                        //Calcula Receita Agendada
                        if (Convert.ToString(dgvLancamento.Rows[i].Cells["Tipo"].Value) == "Receita" && Convert.ToString(dgvLancamento.Rows[i].Cells["Estatus"].Value) == "Agendado")
                        {
                            totalReceitaAgendada += bicComponentes.ConverterDouble(dgvLancamento.Rows[i].Cells[5].Value.ToString());
                        }
                        //Calcula Despesa Agendada
                        if (Convert.ToString(dgvLancamento.Rows[i].Cells["Tipo"].Value) == "Despesa" && Convert.ToString(dgvLancamento.Rows[i].Cells["Estatus"].Value) == "Agendado")
                        {
                            totalDespesaAgendada += bicComponentes.ConverterDouble(dgvLancamento.Rows[i].Cells[5].Value.ToString());
                        }


                    }
                    //Calculo da soma
                    resultado = totalReceita - totalDespesa;
                    resultadoFinal = (totalReceita + totalReceitaAgendada) - (totalDespesa + totalDespesaAgendada);

                    lblTotalDespesas.Text = String.Format("{0:C}", totalDespesa);
                    lblTotalReceitas.Text = String.Format("{0:C}", totalReceita);
                    lblDespesasAgendadas.Text = String.Format("{0:C}", totalDespesaAgendada);
                    lblReceitasAgendadas.Text = String.Format("{0:C}", totalReceitaAgendada);
                    

                    lblResultado.Text = String.Format("{0:C}", resultado);
                    lblSaldoFuturo.Text = String.Format("{0:C}", resultadoFinal);


                    if (resultado < 0)
                    {
                        lblResultado.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Green;
                    }

                    if (resultadoFinal < 0)
                    {
                        lblSaldoFuturo.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblSaldoFuturo.ForeColor = Color.Green;
                    }


                }



               
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
           
        }
       
        private void btnAtualizarGrafico_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void atualizar()
        {
           
            carregarLancamento("Usuario2");            
            carregaCategoria();                       
            totalDespesaReceita();
            carregaContasPagar("Pagar",dgvContasPagar);
            carregaContasPagar("Receber", dgvContasReceber);
            carregaGraficos();
            verificaLancamento(dgvLancamento, 7, 5);
            carregarUsuario();

        }
        private void carregarUsuario()
        {
            cmbUsuario.Items.Clear();
            cmbConsultaUsuario.Items.Clear();
            cmbReportUsuarios.Items.Clear();

            sql = " SELECT usuario_nome  FROM tblusuario ORDER BY usuario_nome";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

            foreach (DataRow dr in dt.Rows)
            {
                cmbUsuario.Items.Add(dr["usuario_nome"].ToString());
                cmbConsultaUsuario.Items.Add(dr["usuario_nome"].ToString());
                cmbReportUsuarios.Items.Add(dr["usuario_nome"].ToString());
            }
            cmbConsultaUsuario.Items.Add("Geral");
        }
        private void carregaContasPagar( string opt,DataGridView grid)
        {

            switch (opt)
            { 
            
                case "Pagar":
                    sql = "SELECT lancamento_id, lancamento_id_parcela, lancamento_data, lancamento_categoria, lancamento_subcategoria,lancamento_usuario, lancamento_valor FROM tbllancamento WHERE lancamento_estatus = 'Agendado' AND lancamento_tipo = 'Despesa' AND lancamento_mes = '" + txtMes.Text + "'  ORDER BY lancamento_data;";
                    break;

                case "Receber":
                    sql = "SELECT lancamento_id, lancamento_id_parcela, lancamento_data, lancamento_categoria, lancamento_subcategoria,lancamento_usuario, lancamento_valor FROM tbllancamento WHERE lancamento_estatus = 'Agendado' AND lancamento_tipo = 'Receita' AND lancamento_mes = '" + txtMes.Text + "' ORDER BY lancamento_data;";
                    break;
            }
            grid.Rows.Clear();

            try
            {
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {
                    string valor = String.Format("{0:C}", dr["lancamento_valor"].ToString());

                    string _data = String.Format("{0:d}", dr["lancamento_data"].ToString()); //.Remove(10));

                    grid.Rows.Add(dr["lancamento_id"].ToString(), dr["lancamento_id_parcela"].ToString(), _data, dr["lancamento_categoria"].ToString(), dr["lancamento_subcategoria"].ToString(),dr["lancamento_usuario"].ToString(), valor);

                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LancamentoTipo = "Despesa";
            Properties.Settings.Default.Save();

            frmLancamento Child = new frmLancamento();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal .Panel1 .Height + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LancamentoTipo = "Receita";
            Properties.Settings.Default.Save();

            frmLancamento Child = new frmLancamento();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y +scprincipal .Panel1 .Height + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }


        private void carregaCategoria()
        {
            cmbCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Clear();
            try {
                sql = " SELECT DISTINCT lancamento_categoria FROM tbllancamento ";
                dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);

                foreach (DataRow dr in dt.Rows)
                {                
                cmbCategoria.Items.Add(dr["lancamento_categoria"].ToString());
                cmbFiltroCategoria.Items.Add(dr["lancamento_categoria"].ToString());
                
                }

            
            
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        
        }


        private void dgvLancamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                try
                {
                    Properties.Settings.Default.LancamentoCodigo = Convert.ToInt32(dgvLancamento.CurrentRow.Cells[0].Value);
                    //Properties.Settings.Default.LancamentoTipo = dgvLancamento.CurrentRow.Cells[3].Value.ToString();
                    Properties.Settings.Default.LancamentoModo = 1;
                    Properties.Settings.Default.Save();



                    frmLancamento Child = new frmLancamento();
                    Child.Show();
                        
                                      
                    //Child.StartPosition = FormStartPosition.Manual;
                    //Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
                    //Child.Show(this);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if(e.ColumnIndex == 10)
            {
                double saldoatual = 0;
                string conta = null;
                


                try
                {
                    conta = dgvLancamento.CurrentRow.Cells[4].Value.ToString();
                    double despesa = bicComponentes.ConverterDouble(dgvLancamento.CurrentRow.Cells[5].Value.ToString());
                    int codigo = Convert.ToInt32(dgvLancamento.CurrentRow.Cells[0].Value);


                    if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        //Resgada o saldo atual
                        sql = "SELECT conta_saldoatual FROM tblconta WHERE conta_nome = '" + conta + "';";
                        dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                        foreach (DataRow dr in dt.Rows)
                        {
                            saldoatual = bicComponentes.ConverterDouble(dr["conta_saldoatual"].ToString()) + despesa;

                        }
                        //Atualiza as contas
                        sql = "UPDATE tblconta SET conta_saldoatual = " + saldoatual + " WHERE conta_nome = '" + conta + "';";
                        bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                        

                        //Deleta o registro atual
                        sql = "Delete FROM tbllancamento WHERE lancamento_id = " + codigo;
                        bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                        MessageBox.Show("Registro deletado com sucesso...");

                        

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
            atualizar();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void cmbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar();
        }

       

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {           

            //LocalizaSerialUsb("1C6F6530298EEF90793C585B");

            atualizar();
        }

        private void dgvLancamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLancamento.Rows[e.RowIndex].Cells[9].Value = "Editar";
            dgvLancamento.Rows[e.RowIndex].Cells[9].Style.BackColor = Color.Yellow;

            dgvLancamento.Rows[e.RowIndex].Cells[10].Value = "Deletar";
            dgvLancamento.Rows[e.RowIndex].Cells[10].Style.BackColor = Color.Red ;

            dgvLancamento.Columns["ValorLA"].DefaultCellStyle.Format = "c2";
            dgvLancamento.Columns["ValorLA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (Convert.ToString(dgvLancamento.Rows[e.RowIndex].Cells[6].Value) == "Despesa")
            {
                e.CellStyle.BackColor = Color.Beige;
            }
            else
            {
                e.CellStyle.BackColor = Color.Aqua;
            }

        }

       

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria Child = new frmCategoria();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }


        ////////////////////////////////////////////////Página Graficos\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void carregaGraficos()
        {
            //paradoaqui
            //carregarGrafico("lancamento_categoria", "lancamento_valor",graficoDespesaCategoria , "despesa");
            //carregarGrafico("lancamento_subcategoria", "lancamento_valor", graficoSubcategoria, "subcategoria");
            //carregarGraficoBarra();
            //carregarGraficoReceitaDespesa("Pago", graficoReceitaDespesa, "Receita X Despesas(Mês Atual)");
            //carregarGraficoReceitaDespesa("Agendado", graficoAgendado , "Receita X Despesas(Agendado)");
            Grafico(graficoDespesaCategoria);
            carregarGraficoBarra(graficoBarras);


        }
       

        private void btnGraficoMesAnterior_Click(object sender, EventArgs e)
        {
            mesatual--;
            if (mesatual == 0)
            {
                mesatual = 12;
            }

            txtGraficoMes.Text = getMesPorExtenso(mesatual);
            carregaGraficos();
        }

        private void btnGraficoMesProximo_Click(object sender, EventArgs e)
        {
            mesatual++;

            if (mesatual > 12)
            {
                mesatual = 1;
            }

            txtGraficoMes.Text  = getMesPorExtenso(mesatual);
            carregaGraficos();
        }

        private void txtGraficoMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void cmbGraficoSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carregarGrafico("lancamento_subcategoria", "lancamento_valor", graficoSubcategoria , "subcategoria");
            GraficoCategoria(graficoSubcategoria);
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConta Child = new frmConta();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferencia Child = new frmTransferencia();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConta Child = new frmConta();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void lançamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTransferencia Child = new frmTransferencia();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarLancamento("Categoria");   
        }

        private void dgvContasPagar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                try
                {
                    Properties.Settings.Default.LancamentoCodigo = Convert.ToInt32(dgvContasPagar.CurrentRow.Cells[0].Value);
                    Properties.Settings.Default.LancamentoTipo = dgvContasPagar.CurrentRow.Cells[3].Value.ToString();                   
                    Properties.Settings.Default.LancamentoModo = 1;
                    Properties.Settings.Default.Save();

                    frmLancamento Child = new frmLancamento(); 
                    Child.StartPosition = FormStartPosition.Manual;
                    Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
                    Child.Show(this);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.ColumnIndex == 8)
            {
                double saldoatual = 0;
                string conta = null;

                 

                try
                {
                   
                   int codigo = Convert.ToInt32(dgvContasPagar.CurrentRow.Cells[1].Value);

                  
                    if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Deleta o registro atual
                        sql = "Delete FROM tbllancamento WHERE lancamento_id_parcela = " + codigo;
                        bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                        MessageBox.Show("Registro deletado com sucesso...");
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
            atualizar();
        }

        private void dgvContasPagar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvContasPagar.Rows[e.RowIndex].Cells[7].Value = "Editar";
            dgvContasPagar.Rows[e.RowIndex].Cells[7].Style.BackColor = Color.Yellow;
            dgvContasPagar.Rows[e.RowIndex].Cells[8].Value = "Deletar";
            dgvContasPagar.Rows[e.RowIndex].Cells[8].Style.BackColor = Color.Red;

           
                e.CellStyle.BackColor = Color.Beige;
          
        }


       

       

      

     

        private void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            carregarLancamento("Tipo");   
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LancamentoTipo = "Despesa";
            Properties.Settings.Default.LancamentoEstatus = "Pago";
            Properties.Settings.Default.LancamentoModo = 0;  
            Properties.Settings.Default.LancamentoData = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            Properties.Settings.Default.Save();
         

            frmLancamento Child = new frmLancamento();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void agendadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LancamentoTipo = "Despesa";
            Properties.Settings.Default.LancamentoEstatus = "Agendado";
            Properties.Settings.Default.LancamentoModo = 0;
            Properties.Settings.Default.LancamentoData = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            Properties.Settings.Default.Save();
           

            frmLancamento Child = new frmLancamento();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void pagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LancamentoTipo = "Receita";
            Properties.Settings.Default.LancamentoEstatus = "Pago";
            Properties.Settings.Default.LancamentoModo = 0;
            Properties.Settings.Default.LancamentoData = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);

            Properties.Settings.Default.Save();

            frmLancamento Child = new frmLancamento();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void agendadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
             Properties.Settings.Default.LancamentoTipo = "Receita";
            Properties.Settings.Default.LancamentoEstatus = "Receita";
            Properties.Settings.Default.LancamentoModo = 0;
            Properties.Settings.Default.LancamentoData = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            Properties.Settings.Default.Save();



            frmLancamento Child = new frmLancamento();
            Child.StartPosition = FormStartPosition.Manual;
            Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
            Child.Show(this);
        }

        private void dgvContasReceber_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvContasReceber.Rows[e.RowIndex].Cells[7].Value = "Editar";
            dgvContasReceber.Rows[e.RowIndex].Cells[7].Style.BackColor = Color.Yellow;
            dgvContasReceber.Rows[e.RowIndex].Cells[8].Value = "Deletar";
            dgvContasReceber.Rows[e.RowIndex].Cells[8].Style.BackColor = Color.Red;
            dgvContasReceber.ForeColor = Color.Black;

                e.CellStyle.BackColor = Color.Aqua;
          
        }

        private void dgvContasReceber_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex ==7)
            {
                try
                {
                    
                    Properties.Settings.Default.LancamentoCodigo = Convert.ToInt32(dgvContasReceber.CurrentRow.Cells[0].Value);
                    //Properties.Settings.Default.LancamentoTipo = dgvContasReceber.CurrentRow.Cells[3].Value.ToString();
                    Properties.Settings.Default.LancamentoModo = 1;
                    Properties.Settings.Default.Save();
                    frmLancamento Child = new frmLancamento();

                    Child.StartPosition = FormStartPosition.Manual;
                    Child.Location = new Point(Location.X + (scprincipal.Panel2.Width - Child.Width) / 2, Location.Y + scprincipal.Panel1.Height + (scprincipal.Panel2.Height - Child.Height) / 2);
                    Child.Show(this);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.ColumnIndex == 8)
            {
               try
                {
                   
                    int codigo = Convert.ToInt32(dgvContasReceber.CurrentRow.Cells[1].Value);


                    if (MessageBox.Show(("Deseja Excluir Registro Atual"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Deleta o registro atual
                        sql = "Delete FROM tbllancamento WHERE  lancamento_id_parcela = " + codigo;
                        bicComponentes.AtualizarRegistro(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                        MessageBox.Show("Registro deletado com sucesso...");

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
            atualizar();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".csv";
            savefile.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                gerarArquivoCSV(dgvLancamento, savefile.FileName);

            }
        }//


        private void gerarArquivoCSV(DataGridView gdvMovimento, string nomeArquivo)
        {
            //define as variáveis usadas no projeto
            string valorCelula = "";
            string linha = "";
            StreamWriter objWriter = null;

            //verifica se o arquivo existe e exclui o arquivo ja existente
            //não vou usar esta rotina 
            //try
            //{
            //    if (File.Exists(nomeArquivo) == true)
            //    {
            //        File.Delete(nomeArquivo);
            //        MessageBox.Show("Arquivo " + nomeArquivo + " excluido...");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
            if (nomeArquivo == string.Empty)
                nomeArquivo = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.Millisecond + ".csv";

            //define um objeto do tipo StreamWriter
            try
            {
                objWriter = new StreamWriter(nomeArquivo, true);
                //percorre o datagridview obtendo o valor de cada célula e montando a linha 
                //percorre o grid e salva cada célula
                for (int i = 0; i < gdvMovimento.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = gdvMovimento.Rows[i];
                    for (int j = 0; j < row.Cells.Count - 2; j++)
                    {
                        valorCelula = row.Cells[j].Value.ToString();
                        linha = linha + valorCelula + ";";
                    }
                    //escreve a linha no arquivo 
                    objWriter.WriteLine(linha);
                    linha = "";
                }
                //fecha o arquivo texto
                objWriter.Close();
                MessageBox.Show("Arquivo Texto gerado com sucesso: " + nomeArquivo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro durante a escrita no arquivo.  " + e.ToString());
            }
        }
        private void exportaDadosTexto(DataGridView gdvMovimento, string nomeArquivo,int coluna)
        {
            StreamWriter sWriter;
            if (nomeArquivo == string.Empty)
                nomeArquivo = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.Millisecond + ".txt";

            sWriter = new StreamWriter(nomeArquivo);
            string Str;

            string cabecalho = "Código,Categora,SubCategoria,Conta,Valor,Tipo,Estatus";

            sWriter.WriteLine(cabecalho);

            //percorre o grid e salva cada célula
            for (int i = 0; i < gdvMovimento.Rows.Count - 1; i++)
            {
                DataGridViewRow row = gdvMovimento.Rows[i];
                for (int j = 0; j < coluna; j++)
                {
                    Str = row.Cells[j].Value.ToString();
                    if (Str == "&nbsp;")
                        Str = "";
                    Str = (Str + ";");
                    try
                    {
                        sWriter.Write(Str);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show("Erro ao gravar no arquivo Texto..." + excep.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            try
            {
                sWriter.Close();
                MessageBox.Show("Arquivo Texto gerado com sucesso: " + nomeArquivo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception excep)
            {
                MessageBox.Show("Erro ao salvar no arquivo Texto..." + excep.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//

       

        private void menuStripLancamento_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cSVToolStripMenuItem1_Click(object sender, EventArgs e)
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


        private void verificaVencida(DataGridView gdv,string mensagem)
        {
            DateTime data = new DateTime();
            bool resultado = false;

            try
            {
                
                //percorre o grid e salva cada célula
                for (int i = 0; i < gdv.Rows.Count - 1; i++)
                {
                   DataGridViewRow row = gdv.Rows[i];
                   data = Convert.ToDateTime (row.Cells[2].Value.ToString ());

                   if (DateTime.Now >= data)
                   {
                        resultado = true;
                   } 
                }

                if(resultado == true)
                {
                   
                    AutoClosingMessageBox.Show(mensagem, "Aviso", 5000);
                }
               
              
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro durante a escrita no arquivo.  " + e.ToString());
            }
        
        }
        private void verificaLancamento(DataGridView gdv, int quantidadeColuna, int coluna)
        {
            

            try
            {

                //percorre o grid e salva cada célula
                for (int i = 0; i < gdv.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = gdv.Rows[i];

                    for (int j = 0; j < quantidadeColuna; j++)
                    {
                        if (row.Cells[j].Value.ToString() == "Despesa")
                        {
                            row.Cells[coluna].Style.ForeColor = Color.Red;

                        }
                        else
                        {
                            row.Cells[coluna].Style.ForeColor = Color.Green;
                        }
                    
                    
                    }

                    
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro durante a escrita no arquivo.  " + e.ToString());
            }

        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                exportaDadosTexto(dgvLancamento, savefile.FileName,7);

            }

        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //// Create an OpenFileDialog to request a file to open.
            //OpenFileDialog openFile1 = new OpenFileDialog();

            //// Initialize the OpenFileDialog to look for RTF files.
            //openFile1.DefaultExt = "*.txt";
            //openFile1.Filter = "Arquivos texto|*.txt";
            ////openFile1.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            //   openFile1.FileName.Length > 0)
            //{
            //    txtCaminho.Text = openFile1.FileName;

            //    importarCsv();
            //}
        }

       

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //string modelNo = identifier("Win32_DiskDrive", "Model");
            //string manufatureID = identifier("Win32_DiskDrive", "Manufacturer");
            //string signature = identifier("Win32_DiskDrive", "Signature");
            string totalHeads = identifier("Win32_DiskDrive", "SerialNumber");

            //MessageBox.Show(modelNo + "\n" +
            //    manufatureID + "\n" +
            //    signature + "\n" +
            //    totalHeads);

        }

        private string identifier(string wmiClass, string wmiProperty)            
                             
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Só pegue o primeiro
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }



        private void LocalizaSerialUsb(string chave)
        {
            string serial = "";
            var allDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);
            foreach (var d in allDrives)
            {
                if (d.IsReady)
                {
                    USBSerialNumber usb = new USBSerialNumber();
                    serial = usb.getSerialNumberFromDriveLetter(d.RootDirectory.Name.ToString().Replace(@"\", ""));
                    if (serial == chave)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("Favor entrar em contato pelo e-mail: markilha@gmail.com ", "Hardlook não encontrado");
            Application.Exit();

        }

        private void menuPrincipalUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario form = new frmUsuario();
            form.ShowDialog();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            GraficoUsuario(graficoDespesaCategoria);
        }

        private void cmbConsultaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbConsultaUsuario.Text =="Geral")
            {
                carregarLancamento("Geral");
                totalDespesaReceita();
                return;
            }
            carregarLancamento("Usuario");
            totalDespesaReceita();

        }

        private void cmbReportUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //paradoaqui
            DataTable dtsoma = new DataTable();
            DataTable dtds = new DataTable();
            double somaDespesaBasica = 0;
            double somaEstiloVida = 0;
            double somaProventos = 0;
                    
            dtds.Columns.Add("lancamento_mes", typeof(string));
            dtds.Columns.Add("lancamento_categoria", typeof(string));
            dtds.Columns.Add("lancamento_valor", typeof(string));
            dtds.Rows.Clear();
            
            string itens = "Janeiro;Fevereiro;Março;Abril;Junho;Julho;Agosto;Setembro;Novembro;Dezembro";
            var valores = itens.Split(';');

            foreach (var dr in valores)
            {
            sql = "SELECT lancamento_categoria, lancamento_valor,lancamento_data FROM tbllancamento WHERE lancamento_mes = '" + dr.ToString() + "' AND lancamento_ano ='" + txtAno.Text + "' AND lancamento_usuario ='" + cmbReportUsuarios.Text + "' ;";
            dtsoma = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            if (dtsoma.Rows.Count > 0)
            {
                foreach (DataRow dr2 in dtsoma.Rows)
                {
                    if (dr2["lancamento_categoria"].ToString() == "Despesas Básicas")
                    {
                        somaDespesaBasica += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                    }
                    if (dr2["lancamento_categoria"].ToString() == "Estilo de Vida")
                    {
                        somaEstiloVida += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                    }
                    if (dr2["lancamento_categoria"].ToString() == "Proventos")
                    {
                        somaProventos += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                    }
                }
            double total = somaProventos - (somaDespesaBasica + somaEstiloVida);

            dtds.Rows.Add(dr.ToString(), "Despesas Básicas", somaDespesaBasica.ToString("0.00"));
            dtds.Rows.Add("", "Estilo de Vida", somaEstiloVida.ToString("0.00"));
            dtds.Rows.Add("", "Proventos", somaProventos.ToString("0.00"));
            dtds.Rows.Add("", "TOTAL = ", total.ToString("0.00"));
            dtds.Rows.Add("#####", "#####", "#####");
            //zera 
            somaDespesaBasica = 0;
            somaEstiloVida = 0;
            somaProventos = 0;

            }

        }
        carregaReport(dtds, "dsds", "//rpds.rdlc");
        }

        private void carregaReport(DataTable ds, string data, string rdlc)
        {
            //Carrega Relatórios
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource(data, ds);
            reportViewer1.LocalReport.DataSources.Add(rpts);
            reportViewer1.LocalReport.ReportPath = Directory.GetCurrentDirectory() + rdlc;
            reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 110;
            
        }

        private void tblRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txtGraficoAno_TextChanged(object sender, EventArgs e)
        {
            carregaGraficos();
        }

        private void cmbMesGeral_SelectedIndexChanged(object sender, EventArgs e)
        {
            //paradoaqui
            DataTable dtgeral = new DataTable();
            DataTable dtresultado = new DataTable();
            double somaEstiloVida = 0;
            double somaDespesa = 0;
            double proventos = 0;

            dtresultado.Columns.Add("lancamento_data", typeof(string));
            dtresultado.Columns.Add("lancamento_categoria", typeof(string));
            dtresultado.Columns.Add("lancamento_subcategoria", typeof(string));
            dtresultado.Columns.Add("lancamento_descricao", typeof(string));
            dtresultado.Columns.Add("lancamento_valor", typeof(string));
            dtgeral.Rows.Clear();

            sql = "SELECT DISTINCT lancamento_categoria FROM tbllancamento WHERE lancamento_mes = '" + cmbMesGeral.Text + "' AND lancamento_ano ='" + txtAno.Text + "' AND lancamento_usuario ='" + Properties.Settings.Default.Usuario + "' ;";
            dt = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
            int cont = 0;
            string tipo = "";
            string categoria = "";
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    sql = "SELECT * FROM tbllancamento WHERE lancamento_mes = '" + cmbMesGeral.Text + "' AND lancamento_ano ='" + txtAno.Text + "' AND lancamento_usuario ='" + Properties.Settings.Default.Usuario + "' AND lancamento_categoria ='"+ dr["lancamento_categoria"].ToString() +"' ORDER BY lancamento_data ;";
                    dtgeral = bicComponentes.Registros(Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario, Properties.Settings.Default.BancoSenha, Properties.Settings.Default.BancoNome, sql);
                    foreach(DataRow dr2 in dtgeral.Rows)
                    {
                        if (cont > 0)
                        {
                            if(dr2["lancamento_categoria"].ToString() == tipo)
                            {
                                categoria = "";

                            }else
                            {
                                categoria = dr2["lancamento_categoria"].ToString();
                            }

                            dtresultado.Rows.Add(dr2["lancamento_data"].ToString(), categoria, dr2["lancamento_subcategoria"].ToString(), dr2["lancamento_descricao"].ToString(), dr2["lancamento_valor"].ToString());

                            tipo = dr2["lancamento_categoria"].ToString();
                            if (dr2["lancamento_categoria"].ToString() == "Estilo de Vida")
                            {
                                somaEstiloVida += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());

                            }
                            if (dr2["lancamento_categoria"].ToString() == "Despesas Básicas")
                            {
                                somaDespesa += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());

                            }
                            if (dr2["lancamento_categoria"].ToString() == "Proventos")
                            {
                                proventos += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());

                            }

                        }
                        else
                        {
                           
                            tipo = dr2["lancamento_categoria"].ToString();

                            if(dr2["lancamento_categoria"].ToString() == "Estilo de Vida")
                            {
                                somaEstiloVida += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());                               

                            }
                            if (dr2["lancamento_categoria"].ToString() == "Despesas Básicas")
                            {
                                somaDespesa += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());

                            }
                            if (dr2["lancamento_categoria"].ToString() == "Proventos")
                            {
                                proventos += bicComponentes.ConverterDouble(dr2["lancamento_valor"].ToString());
                                

                            }

                            dtresultado.Rows.Add(dr2["lancamento_data"].ToString(), dr2["lancamento_categoria"].ToString(), dr2["lancamento_subcategoria"].ToString(), dr2["lancamento_descricao"].ToString(), dr2["lancamento_valor"].ToString());
                        }
                        cont++;

                    }
                }

                double total = 0;
                total = proventos - (somaDespesa + somaEstiloVida);
                dtresultado.Rows.Add("----------------", "----------------","----------------","----------------", "----------------");
                dtresultado.Rows.Add("", "","", "Total Estilo de Vida: ", String.Format("{0:C}", somaEstiloVida)); 
                dtresultado.Rows.Add("", "","", "Total Despesas Básicas: ", String.Format("{0:C}", somaDespesa));
                dtresultado.Rows.Add("", "","", "Total Proventos: ", String.Format("{0:C}", proventos));
                dtresultado.Rows.Add("", "","", "","___________");
                dtresultado.Rows.Add("", "","", "Resultado: ", String.Format("{0:C}", total));
            }
           
            //Carrega Relatórios
            carregaReport(dtresultado, "ds_rol", "//reportRol.rdlc");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportar form = new frmExportar();
            form.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            bicComponentes.backupBanco(Properties.Settings.Default.BancoNome, Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja Sair ?"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void cmbCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario form = new frmUsuario();
            form.ShowDialog();
        }

        private void btnMenuBackup_Click(object sender, EventArgs e)
        {
            bicComponentes.backupBanco(Properties.Settings.Default.BancoNome, Properties.Settings.Default.BancoIp, Properties.Settings.Default.BancoPorta, Properties.Settings.Default.BancoUsuario);
        }

        private void btnMenuImportarExportar_Click(object sender, EventArgs e)
        {
            frmExportar form = new frmExportar();
            form.Show();
        }
    }
}

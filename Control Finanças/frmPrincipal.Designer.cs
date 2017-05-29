namespace Control_Finanças
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dt_dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Control_Finanças.ds();
            this.scprincipal = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.painel_geral = new System.Windows.Forms.Panel();
            this.tabGeral = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.PainelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PainelSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.gbProcedimentos = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbConsultaUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLancamento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbNavegador = new System.Windows.Forms.GroupBox();
            this.btnProximoMes = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnMesAnterior = new System.Windows.Forms.Button();
            this.PanelContasGeral = new System.Windows.Forms.TableLayoutPanel();
            this.PainelContasSaldo = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gruposalto = new System.Windows.Forms.GroupBox();
            this.lblSaldoFuturo = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.lblDespesasAgendadas = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lblReceitasAgendadas = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblTotalDespesas = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblTotalReceitas = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.painelContasPagarReceber = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dgvContasReceber = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTeste = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvContasPagar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodParc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabGrafico = new System.Windows.Forms.TabPage();
            this.painelGraficoPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.painelGraficoTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.gbMes = new System.Windows.Forms.GroupBox();
            this.btnGraficoMesProximo = new System.Windows.Forms.Button();
            this.txtGraficoMes = new System.Windows.Forms.TextBox();
            this.btnGraficoMesAnterior = new System.Windows.Forms.Button();
            this.tabGraficoSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.graficoSubcategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbDespesasCategoria = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.graficoDespesaCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtGraficoAno = new System.Windows.Forms.TextBox();
            this.graficoBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblRelatorio = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbMesGeral = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbReportUsuarios = new System.Windows.Forms.ComboBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripLancamento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lançamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCadastroUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuImportarExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dt_dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scprincipal)).BeginInit();
            this.scprincipal.Panel1.SuspendLayout();
            this.scprincipal.Panel2.SuspendLayout();
            this.scprincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painel_geral.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.PainelPrincipal.SuspendLayout();
            this.PainelSuperior.SuspendLayout();
            this.gbProcedimentos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamento)).BeginInit();
            this.gbNavegador.SuspendLayout();
            this.PanelContasGeral.SuspendLayout();
            this.PainelContasSaldo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gruposalto.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.painelContasPagarReceber.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceber)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).BeginInit();
            this.tabGrafico.SuspendLayout();
            this.painelGraficoPrincipal.SuspendLayout();
            this.painelGraficoTitulo.SuspendLayout();
            this.gbMes.SuspendLayout();
            this.tabGraficoSuperior.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoSubcategoria)).BeginInit();
            this.gbDespesasCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoDespesaCategoria)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBarras)).BeginInit();
            this.tblRelatorio.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStripLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_dsBindingSource
            // 
            this.dt_dsBindingSource.DataMember = "dt_ds";
            this.dt_dsBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scprincipal
            // 
            this.scprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scprincipal.Location = new System.Drawing.Point(0, 0);
            this.scprincipal.Name = "scprincipal";
            this.scprincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scprincipal.Panel1
            // 
            this.scprincipal.Panel1.Controls.Add(this.panel1);
            this.scprincipal.Panel1.Controls.Add(this.btnMinimizar);
            this.scprincipal.Panel1.Controls.Add(this.btnFechar);
            this.scprincipal.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.scprincipal_Panel1_Paint);
            // 
            // scprincipal.Panel2
            // 
            this.scprincipal.Panel2.Controls.Add(this.painel_geral);
            this.scprincipal.Size = new System.Drawing.Size(1370, 674);
            this.scprincipal.SplitterDistance = 33;
            this.scprincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 40);
            this.panel1.TabIndex = 116;
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1267, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.TabIndex = 42;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(47, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 21);
            this.label15.TabIndex = 40;
            this.label15.Text = "CONTROLE PESSOAL";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1323, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(1295, -7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 35);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1337, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 26);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painel_geral
            // 
            this.painel_geral.BackColor = System.Drawing.Color.White;
            this.painel_geral.Controls.Add(this.tabGeral);
            this.painel_geral.Controls.Add(this.statusStrip1);
            this.painel_geral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_geral.Location = new System.Drawing.Point(0, 0);
            this.painel_geral.Name = "painel_geral";
            this.painel_geral.Size = new System.Drawing.Size(1370, 637);
            this.painel_geral.TabIndex = 1;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.tabPrincipal);
            this.tabGeral.Controls.Add(this.tabGrafico);
            this.tabGeral.Controls.Add(this.tblRelatorio);
            this.tabGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGeral.ItemSize = new System.Drawing.Size(96, 30);
            this.tabGeral.Location = new System.Drawing.Point(0, 0);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.SelectedIndex = 0;
            this.tabGeral.Size = new System.Drawing.Size(1370, 615);
            this.tabGeral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGeral.TabIndex = 6;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.PainelPrincipal);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 34);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(1362, 577);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Geral";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.ColumnCount = 1;
            this.PainelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PainelPrincipal.Controls.Add(this.PainelSuperior, 0, 0);
            this.PainelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.RowCount = 1;
            this.PainelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.16988F));
            this.PainelPrincipal.Size = new System.Drawing.Size(1356, 571);
            this.PainelPrincipal.TabIndex = 5;
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.ColumnCount = 2;
            this.PainelSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.549F));
            this.PainelSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.451F));
            this.PainelSuperior.Controls.Add(this.gbProcedimentos, 1, 0);
            this.PainelSuperior.Controls.Add(this.PanelContasGeral, 0, 0);
            this.PainelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelSuperior.Location = new System.Drawing.Point(3, 3);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.RowCount = 1;
            this.PainelSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 565F));
            this.PainelSuperior.Size = new System.Drawing.Size(1350, 565);
            this.PainelSuperior.TabIndex = 0;
            // 
            // gbProcedimentos
            // 
            this.gbProcedimentos.Controls.Add(this.btnBackup);
            this.gbProcedimentos.Controls.Add(this.btnExportar);
            this.gbProcedimentos.Controls.Add(this.groupBox1);
            this.gbProcedimentos.Controls.Add(this.groupBox9);
            this.gbProcedimentos.Controls.Add(this.groupBox5);
            this.gbProcedimentos.Controls.Add(this.groupBox4);
            this.gbProcedimentos.Controls.Add(this.gbNavegador);
            this.gbProcedimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProcedimentos.Location = new System.Drawing.Point(536, 3);
            this.gbProcedimentos.Name = "gbProcedimentos";
            this.gbProcedimentos.Size = new System.Drawing.Size(811, 559);
            this.gbProcedimentos.TabIndex = 3;
            this.gbProcedimentos.TabStop = false;
            this.gbProcedimentos.Text = "Procedimentos";
            // 
            // btnBackup
            // 
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.Location = new System.Drawing.Point(663, 44);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(103, 24);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(663, 16);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(103, 24);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar/Importar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbConsultaUsuario);
            this.groupBox1.Location = new System.Drawing.Point(518, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // cmbConsultaUsuario
            // 
            this.cmbConsultaUsuario.FormattingEnabled = true;
            this.cmbConsultaUsuario.Location = new System.Drawing.Point(6, 14);
            this.cmbConsultaUsuario.Name = "cmbConsultaUsuario";
            this.cmbConsultaUsuario.Size = new System.Drawing.Size(116, 21);
            this.cmbConsultaUsuario.TabIndex = 10;
            this.cmbConsultaUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbConsultaUsuario_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cmbTipo);
            this.groupBox9.Location = new System.Drawing.Point(377, 18);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(135, 44);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Despesa",
            "Receita"});
            this.cmbTipo.Location = new System.Drawing.Point(6, 14);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(116, 21);
            this.cmbTipo.TabIndex = 10;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbFiltroCategoria);
            this.groupBox5.Location = new System.Drawing.Point(236, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 44);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Categoria";
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(6, 14);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(116, 21);
            this.cmbFiltroCategoria.TabIndex = 10;
            this.cmbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCategoria_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvLancamento);
            this.groupBox4.Location = new System.Drawing.Point(6, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(797, 482);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lançamentos";
            // 
            // dgvLancamento
            // 
            this.dgvLancamento.AllowUserToAddRows = false;
            this.dgvLancamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLancamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Data,
            this.Categoria,
            this.SubCategoria,
            this.Usuario,
            this.ValorLA,
            this.Tipo,
            this.Estatus,
            this.Descricao,
            this.Editar,
            this.Deletar});
            this.dgvLancamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLancamento.Location = new System.Drawing.Point(3, 16);
            this.dgvLancamento.Name = "dgvLancamento";
            this.dgvLancamento.RowHeadersVisible = false;
            this.dgvLancamento.Size = new System.Drawing.Size(791, 463);
            this.dgvLancamento.TabIndex = 1;
            this.dgvLancamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLancamento_CellFormatting);
            this.dgvLancamento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLancamento_CellMouseClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Data
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 80;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // SubCategoria
            // 
            this.SubCategoria.HeaderText = "SubCategoria";
            this.SubCategoria.Name = "SubCategoria";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 50;
            // 
            // ValorLA
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorLA.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorLA.HeaderText = "Valor";
            this.ValorLA.Name = "ValorLA";
            this.ValorLA.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 60;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.Width = 70;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 150;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Width = 50;
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.Width = 50;
            // 
            // gbNavegador
            // 
            this.gbNavegador.Controls.Add(this.btnProximoMes);
            this.gbNavegador.Controls.Add(this.txtMes);
            this.gbNavegador.Controls.Add(this.btnMesAnterior);
            this.gbNavegador.Location = new System.Drawing.Point(9, 18);
            this.gbNavegador.Name = "gbNavegador";
            this.gbNavegador.Size = new System.Drawing.Size(217, 44);
            this.gbNavegador.TabIndex = 0;
            this.gbNavegador.TabStop = false;
            this.gbNavegador.Text = "Navegador";
            // 
            // btnProximoMes
            // 
            this.btnProximoMes.BackColor = System.Drawing.Color.Transparent;
            this.btnProximoMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximoMes.ForeColor = System.Drawing.Color.Black;
            this.btnProximoMes.Location = new System.Drawing.Point(171, 13);
            this.btnProximoMes.Name = "btnProximoMes";
            this.btnProximoMes.Size = new System.Drawing.Size(37, 23);
            this.btnProximoMes.TabIndex = 3;
            this.btnProximoMes.Text = ">>";
            this.btnProximoMes.UseVisualStyleBackColor = false;
            this.btnProximoMes.Click += new System.EventHandler(this.btnProximoMes_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(47, 13);
            this.txtMes.Multiline = true;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(118, 22);
            this.txtMes.TabIndex = 1;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            // 
            // btnMesAnterior
            // 
            this.btnMesAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnMesAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnMesAnterior.Location = new System.Drawing.Point(6, 13);
            this.btnMesAnterior.Name = "btnMesAnterior";
            this.btnMesAnterior.Size = new System.Drawing.Size(35, 23);
            this.btnMesAnterior.TabIndex = 2;
            this.btnMesAnterior.Text = "<<";
            this.btnMesAnterior.UseVisualStyleBackColor = false;
            this.btnMesAnterior.Click += new System.EventHandler(this.btnMesAnterior_Click);
            // 
            // PanelContasGeral
            // 
            this.PanelContasGeral.ColumnCount = 1;
            this.PanelContasGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelContasGeral.Controls.Add(this.PainelContasSaldo, 0, 0);
            this.PanelContasGeral.Controls.Add(this.painelContasPagarReceber, 0, 1);
            this.PanelContasGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContasGeral.Location = new System.Drawing.Point(3, 3);
            this.PanelContasGeral.Name = "PanelContasGeral";
            this.PanelContasGeral.RowCount = 2;
            this.PanelContasGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.PanelContasGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelContasGeral.Size = new System.Drawing.Size(527, 559);
            this.PanelContasGeral.TabIndex = 4;
            // 
            // PainelContasSaldo
            // 
            this.PainelContasSaldo.ColumnCount = 1;
            this.PainelContasSaldo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PainelContasSaldo.Controls.Add(this.groupBox2, 0, 0);
            this.PainelContasSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelContasSaldo.Location = new System.Drawing.Point(3, 3);
            this.PainelContasSaldo.Name = "PainelContasSaldo";
            this.PainelContasSaldo.RowCount = 1;
            this.PainelContasSaldo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PainelContasSaldo.Size = new System.Drawing.Size(521, 170);
            this.PainelContasSaldo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gruposalto);
            this.groupBox2.Controls.Add(this.groupBox16);
            this.groupBox2.Controls.Add(this.groupBox15);
            this.groupBox2.Controls.Add(this.groupBox12);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumo";
            // 
            // gruposalto
            // 
            this.gruposalto.Controls.Add(this.lblSaldoFuturo);
            this.gruposalto.Location = new System.Drawing.Point(237, 113);
            this.gruposalto.Name = "gruposalto";
            this.gruposalto.Size = new System.Drawing.Size(188, 45);
            this.gruposalto.TabIndex = 11;
            this.gruposalto.TabStop = false;
            this.gruposalto.Text = "Saldo (Futuro)";
            // 
            // lblSaldoFuturo
            // 
            this.lblSaldoFuturo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoFuturo.AutoSize = true;
            this.lblSaldoFuturo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoFuturo.ForeColor = System.Drawing.Color.Red;
            this.lblSaldoFuturo.Location = new System.Drawing.Point(72, 16);
            this.lblSaldoFuturo.Name = "lblSaldoFuturo";
            this.lblSaldoFuturo.Size = new System.Drawing.Size(20, 16);
            this.lblSaldoFuturo.TabIndex = 3;
            this.lblSaldoFuturo.Text = "...";
            this.lblSaldoFuturo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.lblDespesasAgendadas);
            this.groupBox16.Location = new System.Drawing.Point(237, 65);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(188, 45);
            this.groupBox16.TabIndex = 10;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Despesas (Agendada)";
            // 
            // lblDespesasAgendadas
            // 
            this.lblDespesasAgendadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDespesasAgendadas.AutoSize = true;
            this.lblDespesasAgendadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesasAgendadas.ForeColor = System.Drawing.Color.Red;
            this.lblDespesasAgendadas.Location = new System.Drawing.Point(72, 21);
            this.lblDespesasAgendadas.Name = "lblDespesasAgendadas";
            this.lblDespesasAgendadas.Size = new System.Drawing.Size(20, 16);
            this.lblDespesasAgendadas.TabIndex = 3;
            this.lblDespesasAgendadas.Text = "...";
            this.lblDespesasAgendadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.lblReceitasAgendadas);
            this.groupBox15.Location = new System.Drawing.Point(237, 19);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(188, 45);
            this.groupBox15.TabIndex = 9;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Receitas (Agendada)";
            // 
            // lblReceitasAgendadas
            // 
            this.lblReceitasAgendadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceitasAgendadas.AutoSize = true;
            this.lblReceitasAgendadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitasAgendadas.ForeColor = System.Drawing.Color.Black;
            this.lblReceitasAgendadas.Location = new System.Drawing.Point(72, 21);
            this.lblReceitasAgendadas.Name = "lblReceitasAgendadas";
            this.lblReceitasAgendadas.Size = new System.Drawing.Size(20, 16);
            this.lblReceitasAgendadas.TabIndex = 2;
            this.lblReceitasAgendadas.Text = "...";
            this.lblReceitasAgendadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblTotalDespesas);
            this.groupBox12.Location = new System.Drawing.Point(7, 65);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(188, 45);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Despesas (Paga)";
            // 
            // lblTotalDespesas
            // 
            this.lblTotalDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDespesas.AutoSize = true;
            this.lblTotalDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDespesas.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDespesas.Location = new System.Drawing.Point(72, 21);
            this.lblTotalDespesas.Name = "lblTotalDespesas";
            this.lblTotalDespesas.Size = new System.Drawing.Size(20, 16);
            this.lblTotalDespesas.TabIndex = 3;
            this.lblTotalDespesas.Text = "...";
            this.lblTotalDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblTotalReceitas);
            this.groupBox11.Location = new System.Drawing.Point(7, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(188, 45);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Receitas (Paga)";
            // 
            // lblTotalReceitas
            // 
            this.lblTotalReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalReceitas.AutoSize = true;
            this.lblTotalReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceitas.ForeColor = System.Drawing.Color.Black;
            this.lblTotalReceitas.Location = new System.Drawing.Point(72, 21);
            this.lblTotalReceitas.Name = "lblTotalReceitas";
            this.lblTotalReceitas.Size = new System.Drawing.Size(20, 16);
            this.lblTotalReceitas.TabIndex = 2;
            this.lblTotalReceitas.Text = "...";
            this.lblTotalReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblResultado);
            this.groupBox10.Location = new System.Drawing.Point(7, 111);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(188, 45);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Saldo Atual";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(72, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(20, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelContasPagarReceber
            // 
            this.painelContasPagarReceber.ColumnCount = 1;
            this.painelContasPagarReceber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelContasPagarReceber.Controls.Add(this.groupBox13, 0, 1);
            this.painelContasPagarReceber.Controls.Add(this.groupBox3, 0, 0);
            this.painelContasPagarReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelContasPagarReceber.Location = new System.Drawing.Point(3, 179);
            this.painelContasPagarReceber.Name = "painelContasPagarReceber";
            this.painelContasPagarReceber.RowCount = 2;
            this.painelContasPagarReceber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.04774F));
            this.painelContasPagarReceber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.95226F));
            this.painelContasPagarReceber.Size = new System.Drawing.Size(521, 377);
            this.painelContasPagarReceber.TabIndex = 1;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.dgvContasReceber);
            this.groupBox13.Controls.Add(this.btnTeste);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(3, 251);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(515, 123);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Contas a Receber";
            // 
            // dgvContasReceber
            // 
            this.dgvContasReceber.AllowUserToAddRows = false;
            this.dgvContasReceber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContasReceber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.ParcCod,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.UsuarioCR,
            this.ValorCR,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn5});
            this.dgvContasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContasReceber.Location = new System.Drawing.Point(3, 16);
            this.dgvContasReceber.Name = "dgvContasReceber";
            this.dgvContasReceber.RowHeadersVisible = false;
            this.dgvContasReceber.Size = new System.Drawing.Size(509, 104);
            this.dgvContasReceber.TabIndex = 2;
            this.dgvContasReceber.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContasReceber_CellFormatting);
            this.dgvContasReceber.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContasReceber_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // ParcCod
            // 
            this.ParcCod.HeaderText = "ParcCod";
            this.ParcCod.Name = "ParcCod";
            this.ParcCod.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn10.HeaderText = "Data";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "SubCategoria";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // UsuarioCR
            // 
            this.UsuarioCR.HeaderText = "Usuario";
            this.UsuarioCR.Name = "UsuarioCR";
            this.UsuarioCR.Width = 80;
            // 
            // ValorCR
            // 
            this.ValorCR.HeaderText = "Valor";
            this.ValorCR.Name = "ValorCR";
            this.ValorCR.Width = 65;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Width = 45;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.Width = 45;
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(312, -3);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(110, 20);
            this.btnTeste.TabIndex = 6;
            this.btnTeste.Text = "button1";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Visible = false;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvContasPagar);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 242);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contas a Pagar";
            // 
            // dgvContasPagar
            // 
            this.dgvContasPagar.AllowUserToAddRows = false;
            this.dgvContasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CodParc,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.UsuarioCP,
            this.ValorCA,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvContasPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContasPagar.Location = new System.Drawing.Point(3, 16);
            this.dgvContasPagar.Name = "dgvContasPagar";
            this.dgvContasPagar.RowHeadersVisible = false;
            this.dgvContasPagar.Size = new System.Drawing.Size(509, 223);
            this.dgvContasPagar.TabIndex = 2;
            this.dgvContasPagar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContasPagar_CellFormatting);
            this.dgvContasPagar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContasPagar_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // CodParc
            // 
            this.CodParc.HeaderText = "CodParc";
            this.CodParc.Name = "CodParc";
            this.CodParc.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "SubCategoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // UsuarioCP
            // 
            this.UsuarioCP.HeaderText = "Usuario";
            this.UsuarioCP.Name = "UsuarioCP";
            this.UsuarioCP.Width = 80;
            // 
            // ValorCA
            // 
            this.ValorCA.HeaderText = "Valor";
            this.ValorCA.Name = "ValorCA";
            this.ValorCA.Width = 65;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 45;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 45;
            // 
            // tabGrafico
            // 
            this.tabGrafico.Controls.Add(this.painelGraficoPrincipal);
            this.tabGrafico.Location = new System.Drawing.Point(4, 34);
            this.tabGrafico.Name = "tabGrafico";
            this.tabGrafico.Size = new System.Drawing.Size(1362, 577);
            this.tabGrafico.TabIndex = 1;
            this.tabGrafico.Text = "Gráficos";
            this.tabGrafico.UseVisualStyleBackColor = true;
            // 
            // painelGraficoPrincipal
            // 
            this.painelGraficoPrincipal.ColumnCount = 2;
            this.painelGraficoPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.painelGraficoPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.painelGraficoPrincipal.Controls.Add(this.painelGraficoTitulo, 0, 0);
            this.painelGraficoPrincipal.Controls.Add(this.tabGraficoSuperior, 0, 1);
            this.painelGraficoPrincipal.Controls.Add(this.groupBox17, 0, 2);
            this.painelGraficoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelGraficoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelGraficoPrincipal.Name = "painelGraficoPrincipal";
            this.painelGraficoPrincipal.RowCount = 3;
            this.painelGraficoPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.318891F));
            this.painelGraficoPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.54073F));
            this.painelGraficoPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.painelGraficoPrincipal.Size = new System.Drawing.Size(1362, 577);
            this.painelGraficoPrincipal.TabIndex = 0;
            // 
            // painelGraficoTitulo
            // 
            this.painelGraficoTitulo.ColumnCount = 3;
            this.painelGraficoTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.06433F));
            this.painelGraficoTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33011F));
            this.painelGraficoTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68832F));
            this.painelGraficoTitulo.Controls.Add(this.gbMes, 1, 0);
            this.painelGraficoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelGraficoTitulo.Location = new System.Drawing.Point(3, 3);
            this.painelGraficoTitulo.Name = "painelGraficoTitulo";
            this.painelGraficoTitulo.RowCount = 1;
            this.painelGraficoTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.painelGraficoTitulo.Size = new System.Drawing.Size(1336, 42);
            this.painelGraficoTitulo.TabIndex = 1;
            // 
            // gbMes
            // 
            this.gbMes.Controls.Add(this.btnGraficoMesProximo);
            this.gbMes.Controls.Add(this.txtGraficoMes);
            this.gbMes.Controls.Add(this.btnGraficoMesAnterior);
            this.gbMes.Location = new System.Drawing.Point(524, 3);
            this.gbMes.Name = "gbMes";
            this.gbMes.Size = new System.Drawing.Size(177, 34);
            this.gbMes.TabIndex = 1;
            this.gbMes.TabStop = false;
            // 
            // btnGraficoMesProximo
            // 
            this.btnGraficoMesProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficoMesProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficoMesProximo.ForeColor = System.Drawing.Color.Black;
            this.btnGraficoMesProximo.Location = new System.Drawing.Point(136, 8);
            this.btnGraficoMesProximo.Name = "btnGraficoMesProximo";
            this.btnGraficoMesProximo.Size = new System.Drawing.Size(37, 23);
            this.btnGraficoMesProximo.TabIndex = 3;
            this.btnGraficoMesProximo.Text = ">>";
            this.btnGraficoMesProximo.UseVisualStyleBackColor = false;
            this.btnGraficoMesProximo.Click += new System.EventHandler(this.btnGraficoMesProximo_Click);
            // 
            // txtGraficoMes
            // 
            this.txtGraficoMes.Location = new System.Drawing.Point(47, 8);
            this.txtGraficoMes.Multiline = true;
            this.txtGraficoMes.Name = "txtGraficoMes";
            this.txtGraficoMes.Size = new System.Drawing.Size(83, 22);
            this.txtGraficoMes.TabIndex = 1;
            this.txtGraficoMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGraficoMes.TextChanged += new System.EventHandler(this.txtGraficoMes_TextChanged);
            // 
            // btnGraficoMesAnterior
            // 
            this.btnGraficoMesAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficoMesAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficoMesAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnGraficoMesAnterior.Location = new System.Drawing.Point(6, 8);
            this.btnGraficoMesAnterior.Name = "btnGraficoMesAnterior";
            this.btnGraficoMesAnterior.Size = new System.Drawing.Size(35, 23);
            this.btnGraficoMesAnterior.TabIndex = 2;
            this.btnGraficoMesAnterior.Text = "<<";
            this.btnGraficoMesAnterior.UseVisualStyleBackColor = false;
            this.btnGraficoMesAnterior.Click += new System.EventHandler(this.btnGraficoMesAnterior_Click);
            // 
            // tabGraficoSuperior
            // 
            this.tabGraficoSuperior.ColumnCount = 2;
            this.tabGraficoSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabGraficoSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabGraficoSuperior.Controls.Add(this.groupBox6, 0, 0);
            this.tabGraficoSuperior.Controls.Add(this.gbDespesasCategoria, 0, 0);
            this.tabGraficoSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGraficoSuperior.Location = new System.Drawing.Point(3, 51);
            this.tabGraficoSuperior.Name = "tabGraficoSuperior";
            this.tabGraficoSuperior.RowCount = 1;
            this.tabGraficoSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabGraficoSuperior.Size = new System.Drawing.Size(1336, 251);
            this.tabGraficoSuperior.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbCategoria);
            this.groupBox6.Controls.Add(this.graficoSubcategoria);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(671, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(662, 245);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Categoria X SubCategoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(6, 19);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(146, 21);
            this.cmbCategoria.TabIndex = 9;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbGraficoSubCategoria_SelectedIndexChanged);
            // 
            // graficoSubcategoria
            // 
            this.graficoSubcategoria.BorderlineColor = System.Drawing.Color.Black;
            this.graficoSubcategoria.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.graficoSubcategoria.ChartAreas.Add(chartArea1);
            this.graficoSubcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.graficoSubcategoria.Legends.Add(legend1);
            this.graficoSubcategoria.Location = new System.Drawing.Point(3, 16);
            this.graficoSubcategoria.Name = "graficoSubcategoria";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoSubcategoria.Series.Add(series1);
            this.graficoSubcategoria.Size = new System.Drawing.Size(656, 226);
            this.graficoSubcategoria.TabIndex = 1;
            this.graficoSubcategoria.Text = "chart1";
            // 
            // gbDespesasCategoria
            // 
            this.gbDespesasCategoria.Controls.Add(this.cmbUsuario);
            this.gbDespesasCategoria.Controls.Add(this.graficoDespesaCategoria);
            this.gbDespesasCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDespesasCategoria.Location = new System.Drawing.Point(3, 3);
            this.gbDespesasCategoria.Name = "gbDespesasCategoria";
            this.gbDespesasCategoria.Size = new System.Drawing.Size(662, 245);
            this.gbDespesasCategoria.TabIndex = 0;
            this.gbDespesasCategoria.TabStop = false;
            this.gbDespesasCategoria.Text = "Despesas x Categoria";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(6, 19);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(152, 21);
            this.cmbUsuario.TabIndex = 10;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // graficoDespesaCategoria
            // 
            this.graficoDespesaCategoria.BorderlineColor = System.Drawing.Color.Black;
            this.graficoDespesaCategoria.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.graficoDespesaCategoria.ChartAreas.Add(chartArea2);
            this.graficoDespesaCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.graficoDespesaCategoria.Legends.Add(legend2);
            this.graficoDespesaCategoria.Location = new System.Drawing.Point(3, 16);
            this.graficoDespesaCategoria.Name = "graficoDespesaCategoria";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoDespesaCategoria.Series.Add(series2);
            this.graficoDespesaCategoria.Size = new System.Drawing.Size(656, 226);
            this.graficoDespesaCategoria.TabIndex = 1;
            this.graficoDespesaCategoria.Text = "chart1";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtGraficoAno);
            this.groupBox17.Controls.Add(this.graficoBarras);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(3, 308);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1336, 266);
            this.groupBox17.TabIndex = 4;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Projeção do ano";
            // 
            // txtGraficoAno
            // 
            this.txtGraficoAno.Location = new System.Drawing.Point(6, 16);
            this.txtGraficoAno.Multiline = true;
            this.txtGraficoAno.Name = "txtGraficoAno";
            this.txtGraficoAno.Size = new System.Drawing.Size(53, 22);
            this.txtGraficoAno.TabIndex = 3;
            this.txtGraficoAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGraficoAno.TextChanged += new System.EventHandler(this.txtGraficoAno_TextChanged);
            // 
            // graficoBarras
            // 
            this.graficoBarras.BorderlineColor = System.Drawing.Color.Black;
            this.graficoBarras.BorderlineWidth = 5;
            chartArea3.Name = "ChartArea1";
            this.graficoBarras.ChartAreas.Add(chartArea3);
            this.graficoBarras.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.graficoBarras.Legends.Add(legend3);
            this.graficoBarras.Location = new System.Drawing.Point(3, 16);
            this.graficoBarras.Name = "graficoBarras";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graficoBarras.Series.Add(series3);
            this.graficoBarras.Size = new System.Drawing.Size(1330, 247);
            this.graficoBarras.TabIndex = 2;
            this.graficoBarras.Text = "chart1";
            // 
            // tblRelatorio
            // 
            this.tblRelatorio.Controls.Add(this.groupBox8);
            this.tblRelatorio.Controls.Add(this.groupBox7);
            this.tblRelatorio.Controls.Add(this.groupBox14);
            this.tblRelatorio.Controls.Add(this.reportViewer1);
            this.tblRelatorio.Location = new System.Drawing.Point(4, 34);
            this.tblRelatorio.Name = "tblRelatorio";
            this.tblRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tblRelatorio.Size = new System.Drawing.Size(1362, 577);
            this.tblRelatorio.TabIndex = 2;
            this.tblRelatorio.Text = "Relatorios";
            this.tblRelatorio.UseVisualStyleBackColor = true;
            this.tblRelatorio.Click += new System.EventHandler(this.tblRelatorio_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmbMesGeral);
            this.groupBox8.Location = new System.Drawing.Point(360, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(144, 47);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Tag = "";
            this.groupBox8.Text = "Consulta Geral";
            // 
            // cmbMesGeral
            // 
            this.cmbMesGeral.FormattingEnabled = true;
            this.cmbMesGeral.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Abril",
            "Março",
            "Abril",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbMesGeral.Location = new System.Drawing.Point(6, 19);
            this.cmbMesGeral.Name = "cmbMesGeral";
            this.cmbMesGeral.Size = new System.Drawing.Size(121, 21);
            this.cmbMesGeral.TabIndex = 17;
            this.cmbMesGeral.SelectedIndexChanged += new System.EventHandler(this.cmbMesGeral_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbReportUsuarios);
            this.groupBox7.Location = new System.Drawing.Point(134, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(220, 47);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Tag = "";
            this.groupBox7.Text = "Usuário";
            // 
            // cmbReportUsuarios
            // 
            this.cmbReportUsuarios.FormattingEnabled = true;
            this.cmbReportUsuarios.Location = new System.Drawing.Point(6, 17);
            this.cmbReportUsuarios.Name = "cmbReportUsuarios";
            this.cmbReportUsuarios.Size = new System.Drawing.Size(198, 21);
            this.cmbReportUsuarios.TabIndex = 12;
            this.cmbReportUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbReportUsuarios_SelectedIndexChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtAno);
            this.groupBox14.Location = new System.Drawing.Point(14, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(114, 47);
            this.groupBox14.TabIndex = 15;
            this.groupBox14.TabStop = false;
            this.groupBox14.Tag = "";
            this.groupBox14.Text = "Ano";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(8, 17);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(79, 20);
            this.txtAno.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsds";
            reportDataSource1.Value = this.dt_dsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Finanças.rpds.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1149, 500);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.Text = "Usuário: ";
            // 
            // menuStripLancamento
            // 
            this.menuStripLancamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStripLancamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançamentoToolStripMenuItem1,
            this.contaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.cmbCadastroUsuario,
            this.btnMenuBackup,
            this.btnMenuImportarExportar});
            this.menuStripLancamento.Name = "contextMenuStrip1";
            this.menuStripLancamento.Size = new System.Drawing.Size(169, 136);
            this.menuStripLancamento.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripLancamento_Opening);
            // 
            // lançamentoToolStripMenuItem1
            // 
            this.lançamentoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debitoToolStripMenuItem,
            this.receitasToolStripMenuItem});
            this.lançamentoToolStripMenuItem1.Name = "lançamentoToolStripMenuItem1";
            this.lançamentoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.lançamentoToolStripMenuItem1.Text = "Lançamento";
            // 
            // debitoToolStripMenuItem
            // 
            this.debitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoToolStripMenuItem,
            this.agendadoToolStripMenuItem});
            this.debitoToolStripMenuItem.Name = "debitoToolStripMenuItem";
            this.debitoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.debitoToolStripMenuItem.Text = "Despesas";
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pagoToolStripMenuItem.Text = "Pago";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // agendadoToolStripMenuItem
            // 
            this.agendadoToolStripMenuItem.Name = "agendadoToolStripMenuItem";
            this.agendadoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.agendadoToolStripMenuItem.Text = "Agendado";
            this.agendadoToolStripMenuItem.Click += new System.EventHandler(this.agendadoToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoToolStripMenuItem1,
            this.agendadoToolStripMenuItem1});
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.receitasToolStripMenuItem.Text = "Receitas";
            // 
            // pagoToolStripMenuItem1
            // 
            this.pagoToolStripMenuItem1.Name = "pagoToolStripMenuItem1";
            this.pagoToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.pagoToolStripMenuItem1.Text = "Pago";
            this.pagoToolStripMenuItem1.Click += new System.EventHandler(this.pagoToolStripMenuItem1_Click);
            // 
            // agendadoToolStripMenuItem1
            // 
            this.agendadoToolStripMenuItem1.Name = "agendadoToolStripMenuItem1";
            this.agendadoToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.agendadoToolStripMenuItem1.Text = "Agendado";
            this.agendadoToolStripMenuItem1.Click += new System.EventHandler(this.agendadoToolStripMenuItem1_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.transferênciaToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // transferênciaToolStripMenuItem
            // 
            this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.transferênciaToolStripMenuItem.Text = "Transferência";
            this.transferênciaToolStripMenuItem.Click += new System.EventHandler(this.transferênciaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // cmbCadastroUsuario
            // 
            this.cmbCadastroUsuario.Name = "cmbCadastroUsuario";
            this.cmbCadastroUsuario.Size = new System.Drawing.Size(168, 22);
            this.cmbCadastroUsuario.Text = "Usuários";
            this.cmbCadastroUsuario.Click += new System.EventHandler(this.cmbCadastroUsuario_Click);
            // 
            // btnMenuBackup
            // 
            this.btnMenuBackup.Name = "btnMenuBackup";
            this.btnMenuBackup.Size = new System.Drawing.Size(168, 22);
            this.btnMenuBackup.Text = "Backup";
            this.btnMenuBackup.Click += new System.EventHandler(this.btnMenuBackup_Click);
            // 
            // btnMenuImportarExportar
            // 
            this.btnMenuImportarExportar.Name = "btnMenuImportarExportar";
            this.btnMenuImportarExportar.Size = new System.Drawing.Size(168, 22);
            this.btnMenuImportarExportar.Text = "Importar\\Exportar";
            this.btnMenuImportarExportar.Click += new System.EventHandler(this.btnMenuImportarExportar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1370, 674);
            this.ContextMenuStrip = this.menuStripLancamento;
            this.Controls.Add(this.scprincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.scprincipal.Panel1.ResumeLayout(false);
            this.scprincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scprincipal)).EndInit();
            this.scprincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painel_geral.ResumeLayout(false);
            this.painel_geral.PerformLayout();
            this.tabGeral.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.PainelPrincipal.ResumeLayout(false);
            this.PainelSuperior.ResumeLayout(false);
            this.gbProcedimentos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamento)).EndInit();
            this.gbNavegador.ResumeLayout(false);
            this.gbNavegador.PerformLayout();
            this.PanelContasGeral.ResumeLayout(false);
            this.PainelContasSaldo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gruposalto.ResumeLayout(false);
            this.gruposalto.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.painelContasPagarReceber.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).EndInit();
            this.tabGrafico.ResumeLayout(false);
            this.painelGraficoPrincipal.ResumeLayout(false);
            this.painelGraficoTitulo.ResumeLayout(false);
            this.gbMes.ResumeLayout(false);
            this.gbMes.PerformLayout();
            this.tabGraficoSuperior.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoSubcategoria)).EndInit();
            this.gbDespesasCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoDespesaCategoria)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBarras)).EndInit();
            this.tblRelatorio.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripLancamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scprincipal;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnProximoMes;
        private System.Windows.Forms.Button btnMesAnterior;
        private System.Windows.Forms.ContextMenuStrip menuStripLancamento;
        private System.Windows.Forms.ToolStripMenuItem lançamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.Panel painel_geral;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabGeral;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TableLayoutPanel PainelPrincipal;
        private System.Windows.Forms.TableLayoutPanel PainelSuperior;
        private System.Windows.Forms.GroupBox gbProcedimentos;
        private System.Windows.Forms.DataGridView dgvLancamento;
        private System.Windows.Forms.TableLayoutPanel PanelContasGeral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTotalDespesas;
        private System.Windows.Forms.Label lblTotalReceitas;
        private System.Windows.Forms.TabPage tabGrafico;
        private System.Windows.Forms.GroupBox gbNavegador;
        private System.Windows.Forms.TableLayoutPanel painelGraficoPrincipal;
        private System.Windows.Forms.GroupBox gbDespesasCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoDespesaCategoria;
        private System.Windows.Forms.TableLayoutPanel painelGraficoTitulo;
        private System.Windows.Forms.TableLayoutPanel tabGraficoSuperior;
        private System.Windows.Forms.GroupBox gbMes;
        private System.Windows.Forms.Button btnGraficoMesProximo;
        private System.Windows.Forms.TextBox txtGraficoMes;
        private System.Windows.Forms.Button btnGraficoMesAnterior;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.TableLayoutPanel PainelContasSaldo;
        private System.Windows.Forms.DataGridView dgvContasPagar;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendadoToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel painelContasPagarReceber;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DataGridView dgvContasReceber;
        private System.Windows.Forms.GroupBox gruposalto;
        private System.Windows.Forms.Label lblSaldoFuturo;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label lblDespesasAgendadas;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label lblReceitasAgendadas;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbConsultaUsuario;
        private System.Windows.Forms.TabPage tblRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodParc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCA;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Deletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCR;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.BindingSource dt_dsBindingSource;
        private ds ds;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox txtGraficoAno;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoBarras;
        private System.Windows.Forms.ComboBox cmbReportUsuarios;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cmbMesGeral;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoSubcategoria;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem cmbCadastroUsuario;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.ToolStripMenuItem btnMenuBackup;
        private System.Windows.Forms.ToolStripMenuItem btnMenuImportarExportar;
    }
}
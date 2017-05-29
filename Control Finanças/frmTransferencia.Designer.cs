namespace Control_Finanças
{
    partial class frmTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferencia));
            this.cmbSaida = new System.Windows.Forms.ComboBox();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbValor = new System.Windows.Forms.GroupBox();
            this.gbContas = new System.Windows.Forms.GroupBox();
            this.btTransferencia = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblSaldoSaida = new System.Windows.Forms.Label();
            this.lblSaldoEntrada = new System.Windows.Forms.Label();
            this.gbValor.SuspendLayout();
            this.gbContas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSaida
            // 
            this.cmbSaida.FormattingEnabled = true;
            this.cmbSaida.Location = new System.Drawing.Point(17, 21);
            this.cmbSaida.Name = "cmbSaida";
            this.cmbSaida.Size = new System.Drawing.Size(122, 21);
            this.cmbSaida.TabIndex = 8;
            this.cmbSaida.SelectedIndexChanged += new System.EventHandler(this.cmbSaida_SelectedIndexChanged);
            // 
            // cmbEntrada
            // 
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Location = new System.Drawing.Point(184, 21);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(122, 21);
            this.cmbEntrada.TabIndex = 10;
            this.cmbEntrada.SelectedIndexChanged += new System.EventHandler(this.cmbEntrada_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 15);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 20);
            this.txtValor.TabIndex = 11;
            // 
            // gbValor
            // 
            this.gbValor.BackColor = System.Drawing.Color.Transparent;
            this.gbValor.Controls.Add(this.txtValor);
            this.gbValor.Location = new System.Drawing.Point(12, 10);
            this.gbValor.Name = "gbValor";
            this.gbValor.Size = new System.Drawing.Size(159, 43);
            this.gbValor.TabIndex = 12;
            this.gbValor.TabStop = false;
            this.gbValor.Text = "Valor";
            // 
            // gbContas
            // 
            this.gbContas.BackColor = System.Drawing.Color.Transparent;
            this.gbContas.Controls.Add(this.lblSaldoEntrada);
            this.gbContas.Controls.Add(this.lblSaldoSaida);
            this.gbContas.Controls.Add(this.btTransferencia);
            this.gbContas.Controls.Add(this.cmbSaida);
            this.gbContas.Controls.Add(this.cmbEntrada);
            this.gbContas.Location = new System.Drawing.Point(10, 55);
            this.gbContas.Name = "gbContas";
            this.gbContas.Size = new System.Drawing.Size(324, 72);
            this.gbContas.TabIndex = 13;
            this.gbContas.TabStop = false;
            this.gbContas.Text = "Contas";
            // 
            // btTransferencia
            // 
            this.btTransferencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTransferencia.BackgroundImage")));
            this.btTransferencia.FlatAppearance.BorderSize = 0;
            this.btTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransferencia.Location = new System.Drawing.Point(145, 16);
            this.btTransferencia.Name = "btTransferencia";
            this.btTransferencia.Size = new System.Drawing.Size(33, 29);
            this.btTransferencia.TabIndex = 11;
            this.btTransferencia.UseVisualStyleBackColor = true;
            this.btTransferencia.Click += new System.EventHandler(this.btTransferencia_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(322, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 26);
            this.btnFechar.TabIndex = 43;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblSaldoSaida
            // 
            this.lblSaldoSaida.AutoSize = true;
            this.lblSaldoSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoSaida.ForeColor = System.Drawing.Color.White;
            this.lblSaldoSaida.Location = new System.Drawing.Point(17, 45);
            this.lblSaldoSaida.Name = "lblSaldoSaida";
            this.lblSaldoSaida.Size = new System.Drawing.Size(16, 13);
            this.lblSaldoSaida.TabIndex = 44;
            this.lblSaldoSaida.Text = "...";
            // 
            // lblSaldoEntrada
            // 
            this.lblSaldoEntrada.AutoSize = true;
            this.lblSaldoEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoEntrada.ForeColor = System.Drawing.Color.White;
            this.lblSaldoEntrada.Location = new System.Drawing.Point(186, 45);
            this.lblSaldoEntrada.Name = "lblSaldoEntrada";
            this.lblSaldoEntrada.Size = new System.Drawing.Size(16, 13);
            this.lblSaldoEntrada.TabIndex = 45;
            this.lblSaldoEntrada.Text = "...";
            // 
            // frmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 152);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbContas);
            this.Controls.Add(this.gbValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferencia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferencia";
            this.gbValor.ResumeLayout(false);
            this.gbValor.PerformLayout();
            this.gbContas.ResumeLayout(false);
            this.gbContas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContas;
        private System.Windows.Forms.Button btTransferencia;
        private System.Windows.Forms.ComboBox cmbSaida;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.GroupBox gbValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSaldoEntrada;
        private System.Windows.Forms.Label lblSaldoSaida;
    }
}
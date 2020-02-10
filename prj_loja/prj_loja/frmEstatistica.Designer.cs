namespace prj_loja
{
    partial class frmEstatistica
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvFaturamento = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo_UN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_UN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tc_faturamento = new System.Windows.Forms.TabPage();
            this.despesas = new System.Windows.Forms.TabPage();
            this.vendas = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tc_faturamento.SuspendLayout();
            this.despesas.SuspendLayout();
            this.vendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.Location = new System.Drawing.Point(474, 367);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(134, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dgvFaturamento
            // 
            this.dgvFaturamento.AllowUserToAddRows = false;
            this.dgvFaturamento.AllowUserToDeleteRows = false;
            this.dgvFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.caixaFinal,
            this.credito,
            this.debito});
            this.dgvFaturamento.Location = new System.Drawing.Point(6, 5);
            this.dgvFaturamento.Name = "dgvFaturamento";
            this.dgvFaturamento.ReadOnly = true;
            this.dgvFaturamento.Size = new System.Drawing.Size(586, 260);
            this.dgvFaturamento.TabIndex = 2;
            // 
            // dia
            // 
            this.dia.HeaderText = "dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Width = 110;
            // 
            // caixaFinal
            // 
            this.caixaFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caixaFinal.HeaderText = "caixa final";
            this.caixaFinal.Name = "caixaFinal";
            this.caixaFinal.ReadOnly = true;
            // 
            // credito
            // 
            this.credito.HeaderText = "credito";
            this.credito.Name = "credito";
            this.credito.ReadOnly = true;
            this.credito.Width = 110;
            // 
            // debito
            // 
            this.debito.HeaderText = "debito";
            this.debito.Name = "debito";
            this.debito.ReadOnly = true;
            this.debito.Width = 110;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(474, 315);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpInicial.Size = new System.Drawing.Size(134, 20);
            this.dtpInicial.TabIndex = 3;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(474, 341);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFinal.Size = new System.Drawing.Size(134, 20);
            this.dtpFinal.TabIndex = 4;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AllowUserToAddRows = false;
            this.dgvDespesa.AllowUserToDeleteRows = false;
            this.dgvDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.motivo,
            this.cl_valor});
            this.dgvDespesa.Location = new System.Drawing.Point(6, 6);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.Size = new System.Drawing.Size(586, 259);
            this.dgvDespesa.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // motivo
            // 
            this.motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.motivo.HeaderText = "motivo";
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            // 
            // cl_valor
            // 
            this.cl_valor.HeaderText = "valor";
            this.cl_valor.Name = "cl_valor";
            this.cl_valor.ReadOnly = true;
            this.cl_valor.Width = 120;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(230, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total caixa";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(295, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(295, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total credito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(295, 373);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total debito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "inicial";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "final";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.custo_UN,
            this.preco_UN,
            this.vendido,
            this.faturamento});
            this.dgvVendas.Location = new System.Drawing.Point(7, 3);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(588, 265);
            this.dgvVendas.TabIndex = 6;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 90;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // custo_UN
            // 
            this.custo_UN.FillWeight = 80F;
            this.custo_UN.HeaderText = "custo UN";
            this.custo_UN.Name = "custo_UN";
            this.custo_UN.ReadOnly = true;
            this.custo_UN.Width = 80;
            // 
            // preco_UN
            // 
            this.preco_UN.FillWeight = 80F;
            this.preco_UN.HeaderText = "preco UN";
            this.preco_UN.Name = "preco_UN";
            this.preco_UN.ReadOnly = true;
            this.preco_UN.Width = 80;
            // 
            // vendido
            // 
            this.vendido.HeaderText = "vendido";
            this.vendido.Name = "vendido";
            this.vendido.ReadOnly = true;
            this.vendido.Width = 80;
            // 
            // faturamento
            // 
            this.faturamento.HeaderText = "faturamento";
            this.faturamento.Name = "faturamento";
            this.faturamento.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tc_faturamento);
            this.tabControl1.Controls.Add(this.despesas);
            this.tabControl1.Controls.Add(this.vendas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 297);
            this.tabControl1.TabIndex = 15;
            // 
            // tc_faturamento
            // 
            this.tc_faturamento.Controls.Add(this.dgvFaturamento);
            this.tc_faturamento.Location = new System.Drawing.Point(4, 22);
            this.tc_faturamento.Name = "tc_faturamento";
            this.tc_faturamento.Padding = new System.Windows.Forms.Padding(3);
            this.tc_faturamento.Size = new System.Drawing.Size(598, 271);
            this.tc_faturamento.TabIndex = 0;
            this.tc_faturamento.Text = "faturamento";
            this.tc_faturamento.UseVisualStyleBackColor = true;
            // 
            // despesas
            // 
            this.despesas.Controls.Add(this.dgvDespesa);
            this.despesas.Location = new System.Drawing.Point(4, 22);
            this.despesas.Name = "despesas";
            this.despesas.Padding = new System.Windows.Forms.Padding(3);
            this.despesas.Size = new System.Drawing.Size(598, 271);
            this.despesas.TabIndex = 1;
            this.despesas.Text = "despesas";
            this.despesas.UseVisualStyleBackColor = true;
            // 
            // vendas
            // 
            this.vendas.Controls.Add(this.dgvVendas);
            this.vendas.Location = new System.Drawing.Point(4, 22);
            this.vendas.Name = "vendas";
            this.vendas.Size = new System.Drawing.Size(598, 271);
            this.vendas.TabIndex = 2;
            this.vendas.Text = "vendas";
            this.vendas.UseVisualStyleBackColor = true;
            // 
            // frmEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 403);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.btnGerar);
            this.Name = "frmEstatistica";
            this.Text = "estatistica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tc_faturamento.ResumeLayout(false);
            this.despesas.ResumeLayout(false);
            this.vendas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridView dgvFaturamento;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo_UN;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_UN;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturamento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tc_faturamento;
        private System.Windows.Forms.TabPage despesas;
        private System.Windows.Forms.TabPage vendas;
    }
}
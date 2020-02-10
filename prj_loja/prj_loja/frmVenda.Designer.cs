namespace prj_loja
{
    partial class frmVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpPagamento = new System.Windows.Forms.TabPage();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tpProdutos = new System.Windows.Forms.TabPage();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.qtItens = new System.Windows.Forms.NumericUpDown();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.clCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbcPainel = new System.Windows.Forms.TabControl();
            this.tpPagamento.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tbcPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpPagamento
            // 
            this.tpPagamento.Controls.Add(this.cbxTipoPago);
            this.tpPagamento.Controls.Add(this.label6);
            this.tpPagamento.Controls.Add(this.txtTotal);
            this.tpPagamento.Controls.Add(this.txtTroco);
            this.tpPagamento.Controls.Add(this.txtPago);
            this.tpPagamento.Controls.Add(this.label3);
            this.tpPagamento.Controls.Add(this.label5);
            this.tpPagamento.Controls.Add(this.btnFechar);
            this.tpPagamento.Controls.Add(this.label4);
            this.tpPagamento.Location = new System.Drawing.Point(4, 22);
            this.tpPagamento.Name = "tpPagamento";
            this.tpPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpPagamento.Size = new System.Drawing.Size(562, 312);
            this.tpPagamento.TabIndex = 1;
            this.tpPagamento.Text = "pagamento";
            this.tpPagamento.UseVisualStyleBackColor = true;
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxTipoPago.FormattingEnabled = true;
            this.cbxTipoPago.Location = new System.Drawing.Point(183, 76);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(157, 21);
            this.cbxTipoPago.TabIndex = 15;
            this.cbxTipoPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxTipoPago_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(183, 155);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(157, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(183, 129);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(157, 20);
            this.txtTroco.TabIndex = 11;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(183, 103);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(157, 20);
            this.txtPago.TabIndex = 9;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPago_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "tipoPagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "troco";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(430, 283);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(121, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "fechar conta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "pago";
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.btnPagar);
            this.tpProdutos.Controls.Add(this.label1);
            this.tpProdutos.Controls.Add(this.btnExcluir);
            this.tpProdutos.Controls.Add(this.qtItens);
            this.tpProdutos.Controls.Add(this.dgvItens);
            this.tpProdutos.Controls.Add(this.txtCodigo);
            this.tpProdutos.Controls.Add(this.label2);
            this.tpProdutos.Controls.Add(this.btnAdicionar);
            this.tpProdutos.Location = new System.Drawing.Point(4, 22);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdutos.Size = new System.Drawing.Size(562, 312);
            this.tpProdutos.TabIndex = 0;
            this.tpProdutos.Text = "produtos";
            this.tpProdutos.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(438, 277);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(111, 23);
            this.btnPagar.TabIndex = 20;
            this.btnPagar.Text = "pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "código";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(438, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // qtItens
            // 
            this.qtItens.Location = new System.Drawing.Point(371, 12);
            this.qtItens.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtItens.Name = "qtItens";
            this.qtItens.Size = new System.Drawing.Size(61, 20);
            this.qtItens.TabIndex = 19;
            this.qtItens.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCod,
            this.produto,
            this.quantidade,
            this.preco,
            this.total});
            this.dgvItens.Location = new System.Drawing.Point(14, 38);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(535, 204);
            this.dgvItens.TabIndex = 0;
            // 
            // clCod
            // 
            this.clCod.HeaderText = "Codigos";
            this.clCod.Name = "clCod";
            this.clCod.ReadOnly = true;
            this.clCod.Width = 80;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.HeaderText = "produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 70;
            // 
            // preco
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.preco.DefaultCellStyle = dataGridViewCellStyle3;
            this.preco.HeaderText = "preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 70;
            // 
            // total
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle4;
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 70;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(68, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(231, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "quantidade";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(438, 9);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbcPainel
            // 
            this.tbcPainel.Controls.Add(this.tpProdutos);
            this.tbcPainel.Controls.Add(this.tpPagamento);
            this.tbcPainel.Location = new System.Drawing.Point(12, 12);
            this.tbcPainel.Name = "tbcPainel";
            this.tbcPainel.SelectedIndex = 0;
            this.tbcPainel.Size = new System.Drawing.Size(570, 338);
            this.tbcPainel.TabIndex = 20;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 363);
            this.Controls.Add(this.tbcPainel);
            this.Name = "frmVenda";
            this.Text = "venda";
            this.Load += new System.EventHandler(this.venda_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmVenda_KeyUp);
            this.tpPagamento.ResumeLayout(false);
            this.tpPagamento.PerformLayout();
            this.tpProdutos.ResumeLayout(false);
            this.tpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tbcPainel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpPagamento;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpProdutos;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.NumericUpDown qtItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TabControl tbcPainel;
    }
}
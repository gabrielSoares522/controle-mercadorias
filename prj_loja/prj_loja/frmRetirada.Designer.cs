namespace prj_loja
{
    partial class frmRetirada
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
            this.gpbAdDivida = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dgvMotivo = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdRetirada = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.gpbAdMotivo = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo2 = new System.Windows.Forms.Label();
            this.btnAdMotivo = new System.Windows.Forms.Button();
            this.gpbAdDivida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivo)).BeginInit();
            this.gpbAdMotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAdDivida
            // 
            this.gpbAdDivida.Controls.Add(this.lblCodigo);
            this.gpbAdDivida.Controls.Add(this.lblMotivo);
            this.gpbAdDivida.Controls.Add(this.dgvMotivo);
            this.gpbAdDivida.Controls.Add(this.btnAdRetirada);
            this.gpbAdDivida.Controls.Add(this.txtValor);
            this.gpbAdDivida.Controls.Add(this.lblValor);
            this.gpbAdDivida.Location = new System.Drawing.Point(12, 6);
            this.gpbAdDivida.Name = "gpbAdDivida";
            this.gpbAdDivida.Size = new System.Drawing.Size(384, 235);
            this.gpbAdDivida.TabIndex = 8;
            this.gpbAdDivida.TabStop = false;
            this.gpbAdDivida.Text = "Realizar retirada";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 178);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(6, 206);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 6;
            this.lblMotivo.Text = "Motivo:";
            // 
            // dgvMotivo
            // 
            this.dgvMotivo.AllowUserToAddRows = false;
            this.dgvMotivo.AllowUserToDeleteRows = false;
            this.dgvMotivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome});
            this.dgvMotivo.Location = new System.Drawing.Point(6, 19);
            this.dgvMotivo.MultiSelect = false;
            this.dgvMotivo.Name = "dgvMotivo";
            this.dgvMotivo.ReadOnly = true;
            this.dgvMotivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMotivo.Size = new System.Drawing.Size(367, 150);
            this.dgvMotivo.TabIndex = 3;
            this.dgvMotivo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMotivo_CellMouseClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "motivo";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // btnAdRetirada
            // 
            this.btnAdRetirada.Location = new System.Drawing.Point(263, 201);
            this.btnAdRetirada.Name = "btnAdRetirada";
            this.btnAdRetirada.Size = new System.Drawing.Size(110, 23);
            this.btnAdRetirada.TabIndex = 0;
            this.btnAdRetirada.Text = "realizar retirada";
            this.btnAdRetirada.UseVisualStyleBackColor = true;
            this.btnAdRetirada.Click += new System.EventHandler(this.btnAdRetirada_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(263, 175);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(218, 178);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(30, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "valor";
            // 
            // gpbAdMotivo
            // 
            this.gpbAdMotivo.Controls.Add(this.txtMotivo);
            this.gpbAdMotivo.Controls.Add(this.lblMotivo2);
            this.gpbAdMotivo.Controls.Add(this.btnAdMotivo);
            this.gpbAdMotivo.Location = new System.Drawing.Point(12, 259);
            this.gpbAdMotivo.Name = "gpbAdMotivo";
            this.gpbAdMotivo.Size = new System.Drawing.Size(384, 77);
            this.gpbAdMotivo.TabIndex = 7;
            this.gpbAdMotivo.TabStop = false;
            this.gpbAdMotivo.Text = "Adicionar motivo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(68, 33);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(180, 20);
            this.txtMotivo.TabIndex = 6;
            // 
            // lblMotivo2
            // 
            this.lblMotivo2.AutoSize = true;
            this.lblMotivo2.Location = new System.Drawing.Point(27, 36);
            this.lblMotivo2.Name = "lblMotivo2";
            this.lblMotivo2.Size = new System.Drawing.Size(35, 13);
            this.lblMotivo2.TabIndex = 5;
            this.lblMotivo2.Text = "Nome";
            // 
            // btnAdMotivo
            // 
            this.btnAdMotivo.Location = new System.Drawing.Point(263, 31);
            this.btnAdMotivo.Name = "btnAdMotivo";
            this.btnAdMotivo.Size = new System.Drawing.Size(110, 23);
            this.btnAdMotivo.TabIndex = 4;
            this.btnAdMotivo.Text = "Adicionar motivo";
            this.btnAdMotivo.UseVisualStyleBackColor = true;
            this.btnAdMotivo.Click += new System.EventHandler(this.btnAdMotivo_Click);
            // 
            // frmRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 351);
            this.Controls.Add(this.gpbAdDivida);
            this.Controls.Add(this.gpbAdMotivo);
            this.Name = "frmRetirada";
            this.Text = "retirada";
            this.Load += new System.EventHandler(this.retirada_Load);
            this.gpbAdDivida.ResumeLayout(false);
            this.gpbAdDivida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivo)).EndInit();
            this.gpbAdMotivo.ResumeLayout(false);
            this.gpbAdMotivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAdDivida;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.DataGridView dgvMotivo;
        private System.Windows.Forms.Button btnAdRetirada;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gpbAdMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo2;
        private System.Windows.Forms.Button btnAdMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.Label lblCodigo;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using prj_loja.Properties;

namespace prj_loja
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        #region variaveis
        string local = "SERVER=localhost;UID=root;PASSWORD=;DATABASE=lojabanco;";
        List<clsProduto> produtos = new List<clsProduto>();
        List<clsFormaPagar> formasPagar = new List<clsFormaPagar>();

        //List<string> codigos = new List<string>();
        //List<string> descricoes = new List<string>();
        //List<string> valores = new List<string>();

        //List<string> cd_pagamento = new List<string>();
        //List<string> nm_pagamento = new List<string>();

        //List<string> cd_fiador = new List<string>();
        //List<string> nm_fiador = new List<string>();

        double totalPagar = 0;
        double pago = 0;
        #endregion
        
        #region carregar dados
        private void venda_Load(object sender, EventArgs e)
        {
            #region conectar
            MySqlConnection conexao = new MySqlConnection(local);
            MySqlCommand requerimento = new MySqlCommand();
            MySqlDataReader dados;

            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("erro de conexão");
                conexao.Close();
                return;
            }
            #endregion

            #region carrregar produtos
            requerimento = new MySqlCommand("select cd_produto,ds_produto,vl_venda from produto", conexao);
            dados = requerimento.ExecuteReader();

            if (dados.HasRows){
                while (dados.Read()){
                    clsProduto pr = new clsProduto(dados[0].ToString(),dados[1].ToString(),dados[2].ToString());
                    produtos.Add(pr);
                    //codigos.Add(dados[0].ToString());
                    //descricoes.Add(dados[1].ToString());
                    //valores.Add(dados[2].ToString());
                }
            }
            dados.Close();
            #endregion

            #region carregar tipos pagamentos
            requerimento = new MySqlCommand("select cd_tipoPagamento,nm_tipoPagamento from tipoPagamento", conexao);
            dados = requerimento.ExecuteReader();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    clsFormaPagar fp = new clsFormaPagar(dados[0].ToString(), dados[1].ToString());
                    formasPagar.Add(fp);
                    //cd_pagamento.Add(dados[0].ToString());
                    //nm_pagamento.Add(dados[1].ToString());
                    cbxTipoPago.Items.Add(dados[1].ToString());
                }
            }
            dados.Close();
            conexao.Close();
            cbxTipoPago.SelectedIndex = 0;
            #endregion
            
            dados.Close();
            txtCodigo.Select();
        }
        #endregion

        #region adicionar item
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarItem();
        }
        private void adicionarItem()
        {
            #region variaveis
            string codSele = txtCodigo.Text;
            string codItem = "";
            int linhaItem = 0;
            int indexSele = -1;
            bool achou = false;
            #endregion

            #region checar se existe produto
            //for(int i = 0; i < codigos.Count; i++)
            for (int i = 0; i < produtos.Count; i++)
            {
                //if(codSele == codigos[i])
                if (codSele == produtos[i].Codigo)
                {
                    indexSele = i;
                    break;
                }
            }
            if(indexSele== -1)
            {
                MessageBox.Show("codigo invalido!");
                return;
            }
            #endregion

            #region checar se ja tem na conta
            for (int i = 0;i < dgvItens.Rows.Count;i++)
            {
                codItem = dgvItens.Rows[i].Cells[0].Value.ToString();
                //if (codItem == codigos[indexSele])
                if (codItem == produtos[indexSele].Codigo)
                {
                    linhaItem = i;
                    achou = true;
                    break;
                }
            }
            #endregion

            #region adicionar a conta
            if (!achou) {
                int novaLinha = dgvItens.Rows.Add();

                //dgvItens.Rows[novaLinha].Cells[0].Value = codigos[indexSele];
                dgvItens.Rows[novaLinha].Cells[0].Value = produtos[indexSele].Codigo;
                //dgvItens.Rows[novaLinha].Cells[1].Value = descricoes[indexSele];
                dgvItens.Rows[novaLinha].Cells[1].Value = produtos[indexSele].Descricao;
                dgvItens.Rows[novaLinha].Cells[2].Value = 0;
                //dgvItens.Rows[novaLinha].Cells[3].Value = valores[indexSele];
                dgvItens.Rows[novaLinha].Cells[3].Value = produtos[indexSele].Valor;
                dgvItens.Rows[novaLinha].Cells[4].Value = 0;

                atualizarTotalItem(novaLinha, int.Parse(qtItens.Value.ToString()));
            }
            else {
                atualizarTotalItem(linhaItem, int.Parse(qtItens.Value.ToString()));
            }
            qtItens.Value = 1;
            #endregion

            txtCodigo.Text = "";
        }
        #endregion

        #region Excluir item
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int selecionado = dgvItens.SelectedCells[0].RowIndex;
            int qtItens = int.Parse(dgvItens.Rows[selecionado].Cells[2].Value.ToString());

            atualizarTotalItem(selecionado, -1);

            if(qtItens == 1)
            {
                dgvItens.Rows.RemoveAt(selecionado);
            }
        }
        #endregion

        #region fechar conta
        private void btnFechar_Click(object sender, EventArgs e)
        {
            fecharConta();
        }
        private void fecharConta()
        {
            #region conectar
            MySqlConnection conexao = new MySqlConnection(local);
            MySqlCommand registro;
            MySqlDataReader dados;
            string comando = "";
            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("erro de conexão");
                conexao.Close();
                return;
            }
            #endregion

            #region pegar codigo venda
            string cd_venda = "";
            comando = "select max(cd_venda)+1 from venda";
            registro = new MySqlCommand(comando, conexao);
            dados = registro.ExecuteReader();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    cd_venda = dados[0].ToString();
                }
            }
            dados.Close();
            #endregion

            #region pegar data
            DateTime data = DateTime.Now;
            string dia = data.Year + "-" + data.Month +"-"+data.Day;
            string hora = data.ToLongTimeString();
            #endregion

            #region pegar tipo pagamento
            int selePagar = cbxTipoPago.SelectedIndex;
            string pagamento = formasPagar[selePagar].Codigo;
            //string pagamento = cd_pagamento[selePagar];
            #endregion
            
            #region registrar venda  /nao esta registrando o funcionario que realizou a venda/
            comando = "insert into venda(cd_venda,dt_venda,hr_venda,cd_tipoPagamento,cd_login,vl_pagamento) values("+cd_venda+",'"+dia+"','"+hora+"',"+pagamento+","+global.cod_login+","+ totalPagar + ")";
            
            registro = new MySqlCommand(comando, conexao);

            try
            {
                registro.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("erro registrar venda!");
                conexao.Close();
                return;
            }
            #endregion

            #region registrar produtos vendidos
            comando = "insert into itemVenda(cd_produto,cd_venda,qt_unidades) values ";
            
            for(int i = 0; i < dgvItens.Rows.Count; i++)
            {
                string produto = dgvItens.Rows[i].Cells[0].Value.ToString();
                string quantidade = dgvItens.Rows[i].Cells[2].Value.ToString();

                comando += "("+produto+","+cd_venda+","+ quantidade + ")";
                if(i< dgvItens.Rows.Count - 1) {
                    comando += ",";
                }
            }
            registro = new MySqlCommand(comando, conexao);

            try
            {
                registro.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("erro registrar produtos vendidos!");
                conexao.Close();
                return;
            }
            #endregion

            #region atualizar estoque
            comando = "update produto as p inner join itemVenda i on(p.cd_produto = i.cd_produto) set p.qt_total_unidades = p.qt_total_unidades - i.qt_unidades where i.cd_venda = " + cd_venda;
            registro = new MySqlCommand(comando, conexao);

            try
            {
                registro.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("erro para atualizar estoque!");
                conexao.Close();
                return;
            }
            #endregion

            #region limpar
            conexao.Close();
            MessageBox.Show("venda finalizada com sucesso!");
            dgvItens.Rows.Clear();
            txtCodigo.Text = "";
            txtPago.Text   = "";
            txtTroco.Text  = "";
            txtTotal.Text  = "";
            qtItens.Value = 1;
            cbxTipoPago.SelectedIndex = 0;
            txtCodigo.Select();
            tbcPainel.SelectedIndex = 0;
            #endregion
        }
        #endregion

        #region atualizar total item
        private void atualizarTotalItem(int linhaItem,int qtAddItem)
        {
            double valorUni = double.Parse(dgvItens.Rows[linhaItem].Cells[3].Value.ToString());
            int qtUniAtual = int.Parse(dgvItens.Rows[linhaItem].Cells[2].Value.ToString());
            double valorAlterar = valorUni * qtAddItem;

            dgvItens.Rows[linhaItem].Cells[2].Value = qtUniAtual+qtAddItem;
            dgvItens.Rows[linhaItem].Cells[4].Value = double.Parse(dgvItens.Rows[linhaItem].Cells[4].Value.ToString())+valorAlterar;
            totalPagar += valorAlterar;
            txtTotal.Text = totalPagar.ToString();
        }
        #endregion

        #region atualizar troco
        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            pago = 0;

            try {
                pago = double.Parse(txtPago.Text);
            }
            catch {
                txtPago.Text = "";
                txtTroco.Text = "";
                return;
            }
            txtTroco.Text = (pago - totalPagar).ToString();

        }
        #endregion

        #region mudar tela
        private void btnPagar_Click(object sender, EventArgs e)
        {
            tbcPainel.SelectedIndex = 1;
        }
        #endregion

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                adicionarItem();
            }
            if (e.KeyCode == Keys.Right)
            {
                tbcPainel.SelectedIndex = 1;
                cbxTipoPago.Focus();
            }
        }

        private void frmVenda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbcPainel.SelectedIndex = 1;
                txtPago.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                tbcPainel.SelectedIndex = 0;
                txtCodigo.Focus();
            }
        }

        private void cbxTipoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                tbcPainel.SelectedIndex = 0;
                txtCodigo.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtPago.Focus();
            }
        }

        private void txtPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                tbcPainel.SelectedIndex = 0;
                txtCodigo.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                fecharConta();
            }
        }
    }
}

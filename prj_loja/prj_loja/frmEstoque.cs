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

namespace prj_loja
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }
        string local = "SERVER=localhost;UID=root;PASSWORD=;DATABASE=lojabanco;";

        #region produtos
        List<string> codigos = new List<string>();
        List<string> descricao = new List<string>();
        List<int> qtEstoque = new List<int>();
        List<int> qtSobrando = new List<int>();
        List<string> vlCompra = new List<string>();
        List<string> vlVenda = new List<string>();
        #endregion

        #region carregar estoque
        private void estoque_Load(object sender, EventArgs e)
        {
            atualizarEstoque();
        }
        private void atualizarEstoque()
        {
            codigos = new List<string>();
            descricao = new List<string>();
            qtEstoque = new List<int>();
            qtSobrando = new List<int>();
            vlCompra = new List<string>();
            vlVenda = new List<string>();

            #region conectar
            MySqlConnection conexao = new MySqlConnection(local);
            MySqlCommand executar;
            MySqlDataReader dados;
            string comando = "";

            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("erro de conexao");
                conexao.Close();
                return;
            }
            #endregion

            #region pegar produtos
            comando = "select cd_produto,ds_produto,qt_total_unidades,vl_compra,vl_venda from produto order by cd_produto asc;";
            executar = new MySqlCommand(comando, conexao);
            dados = executar.ExecuteReader();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    codigos.Add(dados[0].ToString());
                    descricao.Add(dados[1].ToString());
                    qtEstoque.Add(int.Parse(dados[2].ToString()));
                    qtSobrando.Add(int.Parse(dados[2].ToString()));
                    vlCompra.Add(dados[3].ToString());
                    vlVenda.Add(dados[4].ToString());
                }
            }
            dados.Close();
            #endregion

            #region pegar itens comprados
            comando = "select cd_produto,qt_unidades,dt_validade from itemcompra order by cd_produto asc,dt_validade desc,cd_compra desc;";
            executar = new MySqlCommand(comando, conexao);
            dados = executar.ExecuteReader();

            if (dados.HasRows)
            {
                int i = 0;
                while (dados.Read())
                {
                    for (i = 0; i < codigos.Count; i++)
                    {
                        if (dados[0].ToString() == codigos[i])
                        { break; }
                    }
                    if (qtSobrando[i] > 0)
                    {
                        int linha = dgvEstoque.Rows.Add();
                        dgvEstoque.Rows[linha].Cells[0].Value = dados[0].ToString();
                        dgvEstoque.Rows[linha].Cells[1].Value = descricao[i];
                        dgvEstoque.Rows[linha].Cells[2].Value = DateTime.Parse(dados[2].ToString()).ToShortDateString();
                        dgvEstoque.Rows[linha].Cells[3].Value = vlCompra[i];
                        dgvEstoque.Rows[linha].Cells[4].Value = vlVenda[i];

                        if (qtSobrando[i] >= int.Parse(dados[1].ToString()))
                        {
                            dgvEstoque.Rows[linha].Cells[5].Value = dados[1].ToString();
                            qtSobrando[i] -= int.Parse(dados[1].ToString());
                        }
                        else
                        {
                            dgvEstoque.Rows[linha].Cells[5].Value = qtSobrando[i];
                            qtSobrando[i] = 0;
                        }
                    }

                }
            }
            dados.Close();
            #endregion

            #region exibir esgotados
            for (int i = 0; i < codigos.Count; i++)
            {
                if (qtEstoque[i] == 0)
                {
                    int linha = dgvEstoque.Rows.Add();
                    dgvEstoque.Rows[linha].Cells[0].Value = codigos[i];
                    dgvEstoque.Rows[linha].Cells[1].Value = descricao[i];
                    dgvEstoque.Rows[linha].Cells[2].Value = "--/--/----";
                    dgvEstoque.Rows[linha].Cells[3].Value = vlCompra[i];
                    dgvEstoque.Rows[linha].Cells[4].Value = vlVenda[i];
                    dgvEstoque.Rows[linha].Cells[5].Value = 0;
                }
            }
            #endregion
            conexao.Close();
        }
        #endregion

        #region filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region novo produto
        private void btnAdProduto_Click(object sender, EventArgs e)
        {
            #region variaveis
            string local = "SERVER=localhost;UID=root;PASSWORD=;DATABASE=lojabanco;";
            string codigo = txtProduto.Text;
            string descricao = txtDescricao.Text;
            string custo = "";
            string preco = txtPreco.Text;
            string quantidade = txtQuantidade.Text;
            string validade = dtpValiNovoProd.Value.ToString("yyyy-MM-dd");
            #endregion

            #region checar custo
            string[] vl = new string[2];
            int n = 0;
            for (int i = 0; i < txtCusto.Text.Length; i++)
            {
                if (txtCusto.Text.Substring(i, 1) != "/")
                {
                    vl[n] += txtCusto.Text.Substring(i, 1);
                }
                else n = 1;
            }

            if (n == 0) custo = vl[0];
            else custo = (float.Parse(vl[0]) / float.Parse(vl[1])).ToString();
            #endregion

            #region conectar
            MySqlConnection conexao = new MySqlConnection(local);

            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("erro de conexao");
                conexao.Close();
                return;
            }
            #endregion

            #region registrar novo produto
            string cmdNovo = "insert into produto(cd_produto,ds_produto,vl_compra,vl_venda,qt_total_unidades)";
            cmdNovo += " values(" + codigo + ",'" + descricao + "'," + custo + "," + preco + ",0)";

            MySqlCommand executar = new MySqlCommand(cmdNovo, conexao);
            try
            {
                executar.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("falha em registrar novo produto");
                conexao.Close();
                return;
            }

            MessageBox.Show("produto cadastrado com sucesso");
            conexao.Close();
            #endregion
            string valorCompra = (float.Parse(custo) * float.Parse(quantidade)).ToString();
            valorCompra = valorCompra.Replace(",",".");
            addEstoque(codigo,quantidade,validade,valorCompra);
        }
        #endregion

        #region adicionar ao estoque
        private void btnAdEstoque_Click(object sender, EventArgs e){
            #region variaveis
            string codigoProduto = txtCdAddEstoque.Text;
            string quantidade = txtQtAddEstoque.Text;
            string validade = dtpValiAddEstoque.Value.ToString("yyyy-MM-dd");
            string valorCompra = txtVlAddEstoque.Text.Replace(",",".");
            #endregion

            addEstoque(codigoProduto,quantidade,validade,valorCompra);
        }

        private void addEstoque(string cdProduto,string qtProduto,string validade,string vlCusto) {
            string codigoCompra = "";
            string data = DateTime.Today.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm:ss");
            MySqlDataReader dados;

            #region comandos
            string cmdPegaCodigo = "select Max(cd_compra)+1 from itemCompra";
            string cmdAddEstoque = "insert into itemCompra(cd_compra,cd_produto,dt_compra,hr_compra,qt_unidades,dt_validade,vl_compra)";
            string cmdAtuEstoque = "update produto set qt_total_unidades=qt_total_unidades+" + qtProduto + " where cd_produto ="+cdProduto;
            #endregion

            #region conectar
            MySqlConnection conexao = new MySqlConnection(local);

            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("erro de conexao");
                conexao.Close();
                return;
            }
            #endregion

            #region registrar no estoque
            MySqlCommand executar = new MySqlCommand(cmdPegaCodigo, conexao);
            try
            {
                dados = executar.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("falha em pegar novo codigo");
                conexao.Close();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    codigoCompra = dados[0].ToString();
                }
            }
            dados.Close();

            cmdAddEstoque += " values(" + codigoCompra + "," + cdProduto + ",'" + data + "','" + hora + "'," + qtProduto + ",'";
            cmdAddEstoque += validade + "'," + vlCusto + ")";

            executar = new MySqlCommand(cmdAddEstoque, conexao);
            try
            {
                executar.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("falha em registrar compra estoque");
                MessageBox.Show(cmdAddEstoque);
                conexao.Close();
                return;
            }

            executar = new MySqlCommand(cmdAtuEstoque, conexao);
            try
            {
                executar.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("falha em atualizar estoque");
                conexao.Close();
                return;
            }

            conexao.Close();
            MessageBox.Show("produto cadastrado com sucesso");
            #endregion

            atualizarEstoque();
        }
        #endregion

        #region selecionar linha
        private void dgvEstoque_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCdAddEstoque.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString();
            txtDsAddEstoque.Text = dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[1].Value.ToString();
            exibirVlCompra();
        }
        #endregion

        #region digitar quantidade a colocar no estoque
        private void txtQtAddEstoque_TextChanged(object sender, EventArgs e)
        {
            exibirVlCompra();
        }
        private void exibirVlCompra()
        {
            int qtAdd = 0;
            if (txtQtAddEstoque.Text != "" && dgvEstoque.CurrentRow.Index>-1) {
                try {
                    qtAdd = int.Parse(txtQtAddEstoque.Text);
                }
                catch {
                    txtQtAddEstoque.Text = "";
                    txtVlAddEstoque.Text = "";
                    return;
                }
                float valor = float.Parse(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[3].Value.ToString());
                txtVlAddEstoque.Text = (qtAdd * valor).ToString();
            }
            else {
                txtVlAddEstoque.Text = "";
            }
        }
        #endregion
    
    }
}

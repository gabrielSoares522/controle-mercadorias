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
            #region conectar
            MySqlConnection conexao = new MySqlConnection(local);
            MySqlCommand executar;
            MySqlDataReader dados;
            string comando = "";

            try{
                conexao.Open();
            }
            catch{
                MessageBox.Show("erro de conexao");
                conexao.Close();
                return;
            }
            #endregion

            #region pegar produtos
            comando = "select cd_produto,ds_produto,qt_total_unidades,vl_compra,vl_venda from produto order by cd_produto asc;";
            executar = new MySqlCommand(comando, conexao);
            dados = executar.ExecuteReader();

            if(dados.HasRows) {
                while (dados.Read()) {
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
                    for(i=0;i < codigos.Count; i++)
                    {
                        if(dados[0].ToString() == codigos[i])
                        { break; }
                    }
                    if (qtSobrando[i] >0) {
                        int linha = dgvEstoque.Rows.Add();
                        dgvEstoque.Rows[linha].Cells[0].Value = dados[0].ToString();
                        dgvEstoque.Rows[linha].Cells[1].Value = descricao[i];
                        dgvEstoque.Rows[linha].Cells[2].Value = DateTime.Parse(dados[2].ToString()).ToShortDateString();
                        dgvEstoque.Rows[linha].Cells[3].Value = vlCompra[i];
                        dgvEstoque.Rows[linha].Cells[4].Value = vlVenda[i];

                        if (qtSobrando[i] >= int.Parse(dados[1].ToString())) {
                            dgvEstoque.Rows[linha].Cells[5].Value = dados[1].ToString();
                            qtSobrando[i] -= int.Parse(dados[1].ToString());
                        }
                        else {
                            dgvEstoque.Rows[linha].Cells[5].Value = qtSobrando[i];
                            qtSobrando[i] = 0;
                        }
                    }

                }
            }
            dados.Close();
            #endregion

            #region exibir esgotados
            for(int i =0;i<codigos.Count;i++)
            {
                if (qtEstoque[i] == 0){
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
            frmNovoProduto telaCriarProduto = new frmNovoProduto(this);
            telaCriarProduto.Show();
        }
        #endregion

        #region adicionar ao estoque
        private void btnAdEstoque_Click(object sender, EventArgs e){
            
            /*
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
            string comando = "insert into itemCompra(cd_produto,cd_compra,qt_unidades,dt_validade,vl_compra)";
            //comando += " values(" + codigo + ",'" + descricao + "'," + custo + "," + preco + "," + quantidade + ")";

            MySqlCommand executar = new MySqlCommand(comando, conexao);
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

            conexao.Close();
            MessageBox.Show("produto cadastrado com sucesso");
            #endregion*/
        }
        #endregion
    }
}

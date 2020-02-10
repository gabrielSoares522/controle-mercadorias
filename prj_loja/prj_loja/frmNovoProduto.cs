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
    public partial class frmNovoProduto : Form
    {
        frmEstoque telaPai;
        public frmNovoProduto(frmEstoque pai)
        {
            InitializeComponent();
            telaPai = pai;
        }

        private void btnAdProduto_Click(object sender, EventArgs e)
        {
            #region variaveis
            string local = "SERVER=localhost;UID=root;PASSWORD=;DATABASE=lojabanco;";
            string codigo = txtProduto.Text;
            string descricao = txtDescricao.Text;
            string custo = "";
            string preco = txtPreco.Text;
            string quantidade = txtQuantidade.Text;
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
            string comando = "insert into produto(cd_produto,ds_produto,vl_compra,vl_venda,qt_total_unidades)";
            comando += " values(" + codigo + ",'" + descricao + "'," + custo + "," + preco + "," + quantidade + ")";

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

            MessageBox.Show("produto cadastrado com sucesso");
            conexao.Close();
            #endregion
        }
    }
}

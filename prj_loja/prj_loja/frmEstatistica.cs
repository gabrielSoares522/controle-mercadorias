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
    public partial class frmEstatistica : Form
    {
        public frmEstatistica()
        {
            InitializeComponent();
        }
        
    
        private void btnGerar_Click(object sender, EventArgs e)
        {
            #region conectar
            MySqlConnection conexao = new MySqlConnection(global.Local);

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

            #region variaveis
            string inicial = dtpInicial.Value.ToString("yyyy-MM-dd");
            string final = dtpFinal.Value.ToString("yyyy-MM-dd");
            
            string comandoFaturamento = "select v.dt_venda,v.cd_tipoPagamento,t.nm_tipoPagamento,sum(v.vl_pagamento) from venda v inner join tipoPagamento t on(v.cd_tipoPagamento = t.cd_tipoPagamento)  where (v.dt_venda between '" + inicial + "' AND'" + final + "') group by v.dt_venda,v.cd_tipoPagamento";// add coluna vl_pago em vendas
            string comandoDespesas = "select mr.cd_motivoRetirada,mr.nm_motivoRetirada,sum(r.vl_retirada) from retirada as r inner join motivoretirada as mr on(r.cd_motivoretirada = mr.cd_motivoretirada) where (r.dt_retirada between '" + inicial + "' AND'" + final + "') group by mr.cd_motivoRetirada";
            string comandoVendas = "select p.cd_produto, p.ds_produto, p.vl_compra, p.vl_venda,sum(i.qt_unidades) ,sum(i.qt_unidades)*p.vl_venda ";
            comandoVendas += "from produto as p inner join itemVenda as i on(p.cd_produto = i.cd_produto) inner join venda as v on (i.cd_venda = v.cd_venda)";
            comandoVendas += " where (v.dt_venda between '" + inicial + "' AND'" + final + "') group by p.cd_produto";

            MySqlCommand executar = new MySqlCommand("",conexao);
            MySqlDataReader dados;
            #endregion


            executar.CommandText = comandoDespesas;
            dados = executar.ExecuteReader();
            prencherTabela(ref dgvDespesa, ref dados);

            executar.CommandText = comandoVendas;
            dados = executar.ExecuteReader();
            prencherTabela(ref dgvVendas,ref dados);

            conexao.Close();
        }
        
        private void prencherTabela(ref DataGridView tabela,ref MySqlDataReader dados)
        {
            int qtColunas = tabela.ColumnCount;

            tabela.Rows.Clear();
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    int linha = tabela.Rows.Add();
                    for (int i = 0; i < qtColunas; i++){
                        tabela.Rows[linha].Cells[i].Value = dados[i].ToString();
                    }
                }
            }
            dados.Close();
        }
    }
}

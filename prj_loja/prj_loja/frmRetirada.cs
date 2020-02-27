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
    public partial class frmRetirada : Form
    {
        public frmRetirada()
        {
            InitializeComponent();
        }

        private void retirada_Load(object sender, EventArgs e)
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

            #region buscar dados
            MySqlCommand executar = new MySqlCommand("select * from motivoRetirada;", conexao);
            MySqlDataReader dado = executar.ExecuteReader();
            if (dado.HasRows)
            {
                while (dado.Read())
                {
                    int linha = dgvMotivo.Rows.Add();

                    dgvMotivo.Rows[linha].Cells[0].Value = dado[0].ToString();
                    dgvMotivo.Rows[linha].Cells[1].Value = dado[1].ToString();

                }
            }
            conexao.Close();
            #endregion
        }

        #region registrar retirada
        private void btnAdRetirada_Click(object sender, EventArgs e)
        {
            #region variaveis
            MySqlConnection conexao = new MySqlConnection(global.Local);
            string dia = DateTime.Now.Date.ToString("yyyy-MM-dd");
            string horario = DateTime.Now.ToShortTimeString();


            string codigo = dgvMotivo.Rows[dgvMotivo.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            double valor = 0;
            string comando = "select dt_operacao from diaOperacao where ic_fechado = false";
            #endregion

            #region conectar
            try
            {
                conexao.Open();
            }
            catch{
                MessageBox.Show("erro de conexão");
                conexao.Close();
                return;
            }
            #endregion

            #region checar valor
            try
            {
                valor = double.Parse(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("valor invalido");
                conexao.Close();
                return;
            }
            #endregion

            #region enviar pro banco
            comando = "insert into retirada values('"+ dia + "','" + horario + "',"+ valor.ToString()+","+codigo+","+global.cod_login+");";
            MySqlCommand executar = new MySqlCommand(comando, conexao);

            try
            {
                executar.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("erro de envio! "+comando);
                conexao.Close();
                return;
            }
            conexao.Close();

            MessageBox.Show("despesa registrada com sucesso!");
            #endregion
        }
        #endregion

        #region adicionar novo motivo
        private void btnAdMotivo_Click(object sender, EventArgs e)
        {
            if(txtMotivo.Text ==""){
                MessageBox.Show("preencha o campo");
                return;
            }

            #region conectar
            MySqlConnection conexao = new MySqlConnection(global.Local);
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

            int codigo = 0;

            codigo = int.Parse(dgvMotivo.Rows[dgvMotivo.Rows.Count - 1].Cells[0].Value.ToString())+1;

            string comando = "insert into motivoRetirada(cd_motivoRetirada,nm_motivoRetirada) values("+codigo.ToString()+",'"+txtMotivo.Text+"');";
            MySqlCommand executar = new MySqlCommand(comando, conexao);
            try{
                executar.ExecuteNonQuery();
            }
            catch{
                MessageBox.Show("erro");
                return;
            }

            int novaLinha = dgvMotivo.Rows.Add();
            dgvMotivo.Rows[novaLinha].Cells[0].Value = codigo.ToString();
            dgvMotivo.Rows[novaLinha].Cells[1].Value = txtMotivo.Text;

            conexao.Close();
        
            txtMotivo.Text = "";
        }
        #endregion
        

        private void dgvMotivo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblCodigo.Text = "Codigo: "+dgvMotivo.Rows[dgvMotivo.CurrentRow.Index].Cells[0].Value.ToString();
            lblMotivo.Text = "Motivo: " + dgvMotivo.Rows[dgvMotivo.CurrentRow.Index].Cells[1].Value.ToString();

        }
    }
}

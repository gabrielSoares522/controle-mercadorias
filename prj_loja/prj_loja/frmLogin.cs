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
    public partial class frmLogin : Form
    {
        frmPrincipal telaPrincipal;
        bool fechaPrograma = true;

        public frmLogin(frmPrincipal tlPrinc)
        {
            telaPrincipal = tlPrinc;
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            entrar();
        }
        
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fechaPrograma) {
                telaPrincipal.Close();
            }
        }

        #region navegacao
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Select();
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                entrar();
            }
        }
        #endregion

        #region Entrar
        public void entrar()
        {
            #region variaveis
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            
            MySqlConnection conexao;
            #endregion

            #region checa se esta vazio
            if (login == "")
            {
                MessageBox.Show("digite o login!");
                return;
            }
            if (senha == "")
            {
                MessageBox.Show("digite o senha!");
                return;
            }
            #endregion

            #region checa no banco
            conexao = new MySqlConnection(global.Local);
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
            MySqlCommand executar = new MySqlCommand("select cd_login from usuario where nm_login = '" + login + "' and nm_senha= md5('" + senha + "')", conexao);
            MySqlDataReader dado = executar.ExecuteReader();
            if (dado.HasRows)
            {
                while (dado.Read())
                {
                    global.cod_login = dado[0].ToString();
                }
            }
            else
            {
                MessageBox.Show("login ou senha incorretos!");
                dado.Close();
                conexao.Close();
                return;
            }
            dado.Close();
            conexao.Close();
            #endregion

            #region fechando login
            telaPrincipal.Show();
            fechaPrograma = false;
            this.Close();
            #endregion
        }
        #endregion
    }
}

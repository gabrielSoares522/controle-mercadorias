using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_loja
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {

            InitializeComponent();
        }

        private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFechamento frm_fechamento = new frmFechamento();
            frm_fechamento.MdiParent = this;
            frm_fechamento.Show();
        }

        private void retiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetirada frm_retirada = new frmRetirada();
            frm_retirada.MdiParent = this;
            frm_retirada.Show();
        }

        private void estatisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstatistica frm_estatistica = new frmEstatistica();
            frm_estatistica.MdiParent = this;
            frm_estatistica.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque frm_estoque = new frmEstoque();
            frm_estoque.MdiParent = this;
            frm_estoque.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frm_venda = new frmVenda();
            frm_venda.MdiParent = this;
            frm_venda.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin telainicial = new frmLogin(this);
            telainicial.Show();
        }
    }
    static class global {
        private static string cd_login;

        public static string cod_login
        {
            get { return cd_login;  }
            set { cd_login = value; }
        }
    }
}

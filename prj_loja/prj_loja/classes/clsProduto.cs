using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_loja.Properties
{
    public class clsProduto
    {
        private string codigo;
        private string descricao;
        private string valor;

        public clsProduto(string cd,string ds,string vl) {
            codigo = cd;
            descricao = ds;
            valor = vl;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Valor { get => valor; set => valor = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_loja
{
    class clsFormaPagar
    {
        private string codigo;
        private string nome;

        public clsFormaPagar(string cd,string nm){
            codigo = cd;
            nome = nm;
        }
        public string Codigo {
            get => codigo;
            set => codigo = value;
        }

        public string Nome {
            get => nome;
            set => nome = value;
        }

    }
}

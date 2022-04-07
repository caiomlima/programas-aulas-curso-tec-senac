using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Polimorfismo {
    class ClassParar : Carro {

        public override bool acao() {
            MessageBox.Show("Parando o carro", "Parando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

    }
}

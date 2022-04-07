using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Polimorfismo {
    class ClassAcelera : Carro {

        public override bool acao() {
            MessageBox.Show("Acelerando o carro", "Acelerando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

    }
}

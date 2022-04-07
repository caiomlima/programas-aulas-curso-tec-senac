using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Polimorfismo {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void click_btn_Click(object sender, EventArgs e) {
            if(this.corre_option.Checked) {
                movimento(new ClassAcelera());
            } else {
                movimento(new ClassParar());
            }
        }

        private void sair_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        public bool movimento(Carro veiculo) {
            return veiculo.acao();
        }
    }
}

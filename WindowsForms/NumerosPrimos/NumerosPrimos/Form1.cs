using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimos {
    public partial class Primos_Form : Form {
        public Primos_Form() {
            InitializeComponent();
        }

        private void confirmar_button_Click(object sender, EventArgs e) {

            int i, cont = 0, num = int.Parse(num_textBox.Text);

            for (i = 1; i < num; i++) {
                if (num % i == 0) {
                    cont++;
                }
            }

            if (cont == 2) {
                res_label.Text = "O número " + num.ToString() + " é primo";
            } else {
                res_label.Text = "O número " + num.ToString() + " não é primo";
            }

        }

        private void limpar_button_Click(object sender, EventArgs e) {
            num_textBox.Clear();
            res_label.Text = "";
            num_textBox.Focus();
        }

        private void sair_button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

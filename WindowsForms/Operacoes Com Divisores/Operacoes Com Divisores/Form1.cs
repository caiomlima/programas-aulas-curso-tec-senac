using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operacoes_Com_Divisores {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void div_button_Click(object sender, EventArgs e) {
            int num;

            num = int.Parse(num_textBox.Text);

            for(int i = 1; i <= num; i++) {
                if(num % i == 0) {
                    res_label.Text = i.ToString();
                }
            }
        }

        private void primo_button_Click(object sender, EventArgs e) {
            int num, cont = 0;

            num = int.Parse(num_textBox.Text);

            //for (int i = num; i > 0; i--) {
            //    if (num % i == 0) {
            //        cont++;
            //    }
            //}

            for (int i = 1; i <= num; i++) {
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

        private void perf_button_Click(object sender, EventArgs e) {
            int num, soma = 0;

            num = int.Parse(num_textBox.Text);

            for (int i = 1; i < num; i++) {
                if(num % 1 == 0) {
                    soma += 1;
                }
            }

            if(soma == num) {
                res_label.Text = "O número " + num.ToString() + " é perfeito";
            } else {
                res_label.Text = "O número " + num.ToString() + " não é perfeito";
            }
        }

        private void sair_button_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}

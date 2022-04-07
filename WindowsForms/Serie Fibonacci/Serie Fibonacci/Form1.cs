using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serie_Fibonacci {
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e) {
            int num, ant = 0, atual = 1, prox;

            num = int.Parse(termos_textBox.Text);

            for(int i = 1; i <= num; i++) {
                res_listBox.Items.Add(atual);
                prox = ant + atual;
                ant = atual;
                atual = prox;
            }
        }

        private void limpar_button_Click(object sender, EventArgs e) {
            termos_textBox.Clear();
            res_listBox.Text = "";
        }

        private void sair_button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

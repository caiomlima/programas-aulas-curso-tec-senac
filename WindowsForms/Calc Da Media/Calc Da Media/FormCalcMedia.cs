using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Da_Media {
    public partial class FormCalcMedia : Form {
        public FormCalcMedia() {
            InitializeComponent();
        }

        private void calc_button_Click(object sender, EventArgs e) {

            ClassCalculo valores = new ClassCalculo();
            double a = new double();
            double b = new double();
            double c = new double();
            double d = new double();
            double valor = new double();

            try {

                string v1 = n1_textBox.Text;
                v1 = v1.Replace('.', ',');
                a = double.Parse(v1);

                string v2 = n2_textBox.Text;
                v2 = v2.Replace('.', ',');
                b = double.Parse(v2);

                string v3 = n3_textBox.Text;
                v3 = v3.Replace('.', ',');
                c = double.Parse(v3);

                string v4 = n4_textBox.Text;
                v4 = v4.Replace('.', ',');
                d = double.Parse(v4);

                if(a < 0 || a > 10 || b < 0 || b > 10 || c < 0 || c > 10 || d < 0 || d > 10) {
                    MessageBox.Show("Entrada de notas inválidas\nDigite as notas novamentes", "NOTAS INVÁLIDAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpar();
                } else {
                    valor = valores.Processar(a, b, c, d);
                    res_media_label.Text = "A média das notas é " + valor.ToString();
                }

            } catch(FormatException erro) {
                string mens = erro.Message;
                MessageBox.Show(mens + "\nA entrada dos dados não está em um formato correto!\nTente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }

        }

        public void limpar() {
            n1_textBox.Clear();
            n2_textBox.Clear();
            n3_textBox.Clear();
            n4_textBox.Clear();
            res_media_label.Text = "";
            n1_textBox.Focus();
        }

        private void limpar_button_Click(object sender, EventArgs e) {
            limpar();
        }

        private void sair_button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificarNumeros {
    public partial class FrmVerifica : Form {
        public FrmVerifica() {
            InitializeComponent();
        }

        private void verifica_button_Click(object sender, EventArgs e) {

            try {
                int n = int.Parse(num_textBox.Text);

                if (n % 2 == 0) {
                    res_label.Text = "O número " + n.ToString() + " é par";
                } else {
                    res_label.Text = "O número " + n.ToString() + " é ímpar";
                }
            } catch(FormatException error) {
                string msg = error.Message + "\nA entrada está em um formato incorreto";
                MessageBox.Show(msg + "\nPor favor, tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } finally {
                num_textBox.Clear();
                res_label.Text = "";
                num_textBox.Focus();
            }

        }
        private void limpa_button_Click(object sender, EventArgs e) {
            num_textBox.Clear();
            res_label.Text = "";
            num_textBox.Focus();
        }

        private void sair_button_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Deseja sair do verificador ?", "Finalizando",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                this.Close();
            } else {
                num_textBox.Clear();
                res_label.Text = "";
                num_textBox.Focus();
            }
        }

    }
}

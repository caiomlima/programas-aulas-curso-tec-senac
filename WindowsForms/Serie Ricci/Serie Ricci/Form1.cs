using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serie_Ricci {
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e) {
            try {
                int i, termo1, termo2, nTermos, prox = 0;
                termo1 = int.Parse(termo1_textBox.Text);
                termo2 = int.Parse(termo2_textBox.Text);
                nTermos = int.Parse(n_termos_textBox.Text);

                res_listBox.Items.Add(termo1);
                res_listBox.Items.Add(termo2);

                for (i = 0; i <= nTermos; i--) {
                    prox = termo1 + termo2;
                    termo1 = termo2;
                    termo2 = prox;
                    res_listBox.Items.Add(prox);
                }
            } catch(FormatException error) {
                string mensagem = "Sequência de entradas está em um formato incorreto";
                string recado = "AVISO";
                MessageBox.Show(recado, mensagem,MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void limpar_button_Click(object sender, EventArgs e) {
            termo1_textBox.Clear();
            termo2_textBox.Clear();
            n_termos_textBox.Clear();
            res_listBox.Items.Clear();
        }

        private void sair_button_Click(object sender, EventArgs e) {
            this.Close();

            string mensagem = "Deseja sair do programa ?";
            string recado = "AVISO";
            if(MessageBox.Show(recado, mensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                this.Close();
            } else {
                termo1_textBox.Clear();
                termo2_textBox.Clear();
                n_termos_textBox.Clear();
                res_listBox.Items.Clear();
            }
        }

    }
}

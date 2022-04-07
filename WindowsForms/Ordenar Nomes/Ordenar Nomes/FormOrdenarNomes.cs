using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenar_Nomes {
    public partial class FormOrdenarNomes : Form {
        public FormOrdenarNomes() {
            InitializeComponent();
        }

        private void classificar_btn_Click(object sender, EventArgs e) {
            string[] nomes = new string[5];
            string aux;

            nomes[0] = nome1_textBox.Text;
            nomes[1] = nome2_textBox.Text;
            nomes[2] = nome3_textBox.Text;
            nomes[3] = nome4_textBox.Text;
            nomes[4] = nome5_textBox.Text;

            for(int j = 0; j <= 4; j++) {
                if(nomes[j].Length >= 15) {
                    // Se o tamanho da palavra for maior que 15 char, diminui a fonte
                    exibir_nomes_label.Font = new Font("Arial Narrow", 10, System.Drawing.FontStyle.Bold);
                }
            }

            // Ordenar a lista
            for(int i = 0; i <= 4; i++) {
                for(int j = i+ 1; j <= 4; j++) {
                    // Verifica se o nome é menor, em ordem alfábetica, que o outro
                    // e realiza a troca dos elementos da string (vetor)
                    if(String.CompareOrdinal(nomes[i],nomes[j]) > 0) {
                        aux = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;
                    }
                }
            }

            // Exibir a lista ordenada na label de saída
            groupBox2.Visible = true;
            for(int x = 0; x <= 4; x++) {
                exibir_nomes_label.Text += "\n" + nomes[x] + "\n";
            }
        }

        public void Cancelar() {
            nome1_textBox.Clear();
            nome2_textBox.Clear();
            nome3_textBox.Clear();
            nome4_textBox.Clear();
            nome5_textBox.Clear();
            exibir_nomes_label.Text = "";
            groupBox2.Visible = false;
            exibir_nomes_label.Font = new Font("Verdana", 9, System.Drawing.FontStyle.Bold);
            nome1_textBox.Focus();
        }

        private void limpar_btn_Click(object sender, EventArgs e) {
            Cancelar();
        }

        private void btn_fechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void nome1_textBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Return) {
                nome2_textBox.Focus();
            }
        }

        private void nome2_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                nome3_textBox.Focus();
            }
        }

        private void nome3_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                nome4_textBox.Focus();
            }
        }

        private void nome4_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                nome5_textBox.Focus();
            }
        }

        private void nome5_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                classificar_btn.Focus();
            }
        }
    }
}

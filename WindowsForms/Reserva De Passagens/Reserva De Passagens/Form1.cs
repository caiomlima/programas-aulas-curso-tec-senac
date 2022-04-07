using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_De_Passagens {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void sair_button_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void limpar_button_Click(object sender, EventArgs e) {
            //nome_textBox.Text = "";
            nome_textBox.Clear();
            aviao_radioButton.Checked = false;
            onibus_radioButton.Checked = false;
        }

        private void calc_button_Click(object sender, EventArgs e) {
            Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void confirmar_button_Click(object sender, EventArgs e) {
            if(nome_textBox.Text.Length == 0) {
                MessageBox.Show("Digite o nome do passageiro");
                nome_textBox.Focus();
            }
            if(destino_comboBox.Text == "") {
                MessageBox.Show("Escolha um destino");
                destino_comboBox.Focus();
            }
            if(aviao_radioButton.Checked == false && onibus_radioButton.Checked == false) {
                MessageBox.Show("Escolha um meio de transporte");
                aviao_radioButton.Focus();
            }
        }

        private void calc_final_button_Click(object sender, EventArgs e) {
            float gasto_destino, gasto_transporte, gasto_total;

            switch(destino_comboBox.Text.ToUpper()) {
                case "SP": gasto_destino = 1000f; // rj, bh, am, rs, rm, pr
                    break;
                case "RJ": gasto_destino = 1200f;
                    break;
                case "SC": gasto_destino = 1900f;
                    break;
                default: gasto_destino = 0;
                    break;
            }

            if(aviao_radioButton.Checked == true) {
                gasto_transporte = 100f;
            } else {
                gasto_transporte = 30f;
            }

            gasto_total = gasto_destino + gasto_transporte;

            valores_groupBox.Visible = true;

            res_gasto_dest_label.Text = gasto_destino.ToString("C2");
            res_gasto_transp_label.Text = gasto_transporte.ToString("C2");
            res_valor_total_textBox.Text = gasto_total.ToString("C2");
        }
    }
}

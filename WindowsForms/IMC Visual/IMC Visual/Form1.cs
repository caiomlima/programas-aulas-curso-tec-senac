using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Visual {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void imc_res_label_Click(object sender, EventArgs e) {
            double peso, altura, imc;

            altura = double.Parse(altura_textBox.Text);
            peso = double.Parse(peso_textBox.Text);
            imc = peso / Math.Pow(altura, 2);

            imc_res_label.Text = imc.ToString();

            if(imc < 20) {
                situacao_res_label.Text = "Abaixo do peso";
            } else if(imc <= 25) {
                situacao_res_label.Text = "Peso normal";
            } else if(imc <= 30) {
                situacao_res_label.Text = "Acima do peso";
            } else if(imc <= 40) {
                situacao_res_label.Text = "Obeso";
            } else {
                situacao_res_label.Text = "Obesidade mórbida";
            }
        }

        private void sair_button_Click(object sender, EventArgs e) {
            //this.Close(); // Fecha a janela atual
            Application.Exit(); // Fecha totalmente o app
        }
    }
}

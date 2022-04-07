using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criacao_De_Menus_2.Forms {
    public partial class FormOpcao2 : Form {
        public FormOpcao2() {
            InitializeComponent();
        }

        private void mult_btn_Click(object sender, EventArgs e) {
            int resultado;
            Classes.ClassOpcao2 opcao2 = new Classes.ClassOpcao2();
            resultado = opcao2.Multiplicar(Convert.ToInt32(num1_textBox.Text), Convert.ToInt32(num2_textBox.Text));
            result_textBox.Text = resultado.ToString();
        }
    }
}

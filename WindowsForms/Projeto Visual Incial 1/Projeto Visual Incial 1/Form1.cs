using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Visual_Incial_1 {
    public partial class Form_saudacao : Form {
        public Form_saudacao() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button_nome_Click(object sender, EventArgs e) {
            MessageBox.Show("Bom dia," + textBox_nome.Text, "Caixa de texto sem nada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        }
    }
}

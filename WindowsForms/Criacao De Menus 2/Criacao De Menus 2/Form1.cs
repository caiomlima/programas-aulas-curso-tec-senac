using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criacao_De_Menus_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void opcao1ToolStripMenuItem_Click(object sender, EventArgs e) {
            Forms.FormOpcao1 formOpcao1 = new Forms.FormOpcao1();
            formOpcao1.Show();
        }

        private void opcao2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Forms.FormOpcao2 formOpcao2 = new Forms.FormOpcao2();
            formOpcao2.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

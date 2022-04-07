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
    public partial class FormOpcao1 : Form {
        public FormOpcao1() {
            InitializeComponent();
        }

        private void saudacoes_btn_Click(object sender, EventArgs e) {
            Classes.ClassOpcao1 opcao1 = new Classes.ClassOpcao1();
            string minhaSaudaco = opcao1.Saudar(nome_textBox.Text);
            MessageBox.Show(minhaSaudaco);
        }
    }
}

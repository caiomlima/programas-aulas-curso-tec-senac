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
    public partial class Acesso : Form {
        public Acesso() {
            InitializeComponent();
        }

        private void acessar_btn_Click(object sender, EventArgs e) {
            if(senha_textBox.Text == "") {
                MessageBox.Show("Você deve digitar a sua senha !!");
            } else {
                if(senha_textBox.Text == "123") {
                    Form1 formPrincipal = new Form1();
                    formPrincipal.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Senha inválida!!");
                    senha_textBox.Clear();
                }
            }
        }
    }
}

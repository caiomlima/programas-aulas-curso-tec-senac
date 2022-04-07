using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_De_Nomes {
    public partial class form_lista_nomes : Form {
        public form_lista_nomes() {
            InitializeComponent();
        }

        private void adc_btn_Click(object sender, EventArgs e) {
            string nome = nome_textBox.Text;
            nome_listBox.Items.Add(nome.ToUpper());
            nome_textBox.Clear();
            nome_textBox.Focus();
        }

        private void remov_btn_Click(object sender, EventArgs e) {
            int valor = nome_listBox.SelectedIndex;
            if(valor == -1) {
                MessageBox.Show("Para excluir um item, é necessário selecionar alguma coisa", "Excluindo item da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                remov_btn.Enabled = false;
                nome_textBox.Focus();
            } else {
                nome_listBox.Items.RemoveAt(valor);
            }
        }

        private void remov_tudo_btn_Click(object sender, EventArgs e) {
            if(nome_listBox.Items.Count == 0) {
                MessageBox.Show("A lista está vazia\n", "Não é possivel remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome_textBox.Focus();
            } else {
                remov_btn.Enabled = true;
                nome_listBox.Items.Clear();
                nome_textBox.Focus();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            nome_textBox.Clear();
            nome_textBox.Focus();
        }

        private void sair_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

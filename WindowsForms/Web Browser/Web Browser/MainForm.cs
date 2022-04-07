using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            novaAbaToolStripMenuItem_Click(null, null);
        }

        private string pagInicial = "http://www.google.com.br";

        private void novaAbaToolStripMenuItem_Click(object sender, EventArgs e) {
            abas_tabControl.TabPages.Add("nova", pagInicial);

            endereco_textBox.Text = pagInicial;

            WebBrowser webBrowser = new WebBrowser();

            webBrowser.Dock = DockStyle.Fill;

            Uri uri = new Uri(pagInicial);
            webBrowser.Url = uri;

            abas_tabControl.TabPages[abas_tabControl.TabCount - 1].Controls.Add(webBrowser);

            abas_tabControl.SelectedIndex = abas_tabControl.TabCount - 1;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void voltar_btn_Click(object sender, EventArgs e) {
            foreach(Control control in abas_tabControl.SelectedTab.Controls) {
                (control as WebBrowser).GoBack();
                endereco_textBox.Text = (control as WebBrowser).Url.AbsoluteUri;
            }
        }

        private void avancar_btn_Click(object sender, EventArgs e) {
            foreach(Control control in abas_tabControl.SelectedTab.Controls) {
                (control as WebBrowser).GoForward();
            }
        }

        private void atualizar_btn_Click(object sender, EventArgs e) {
            foreach(Control control in abas_tabControl.SelectedTab.Controls) {
                (control as WebBrowser).Refresh();
            }
        }

        private void parar_btn_Click(object sender, EventArgs e) {
            foreach (Control control in abas_tabControl.SelectedTab.Controls) {
                (control as WebBrowser).Stop();
            }
        }

        private void inicial_btn_Click(object sender, EventArgs e) {
            Uri uri = new Uri(pagInicial);
            endereco_textBox.Text = pagInicial;
            foreach(Control control in abas_tabControl.SelectedTab.Controls) {
                (control as WebBrowser).Url = uri;
            }
        }

        private void endereco_textBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter) {
                Uri uri = (endereco_textBox.Text.ToLower().StartsWith("http://")) ?
                    new Uri(endereco_textBox.Text.ToLower()) :
                    new Uri("http://" + endereco_textBox.Text.ToLower());
                foreach(Control control in abas_tabControl.SelectedTab.Controls) {
                    (control as WebBrowser).Url = uri;
                }
            }
        }

        private void pagInicialToolStripMenuItem_Click(object sender, EventArgs e) {
            FormInitialPage form = new FormInitialPage();
            form.paginaInicial_textBox.Text = pagInicial;
            if(form.ShowDialog() == DialogResult.OK) {
                pagInicial = form.paginaInicial_textBox.Text;
            }
        }
    }
}

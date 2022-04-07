using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Visual {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void processar_btn_Click(object sender, EventArgs e) {
            Pessoa.Pessoa p = new Pessoa.Pessoa();
            p.setNome(nome_textBox.Text);

            try {
                p.setIdade(int.Parse(idade_textBox.Text));
                string xnome = p.getNome();
                int xidade = p.getIdade();
                string strsaida = "Nome: " + xnome.ToUpper() + "\n\n" + "Idade: " + xidade.ToString();
                MessageBox.Show(strsaida, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception error) {
                MessageBox.Show(error.Message + "\n\nTente novamente", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e) {
            nome_textBox.Clear();
            idade_textBox.Clear();
            nome_textBox.Focus();
        }

        private void sair_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

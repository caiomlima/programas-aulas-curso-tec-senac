using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca_Visual {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private void confirmar_btn_Click(object sender, EventArgs e) {
            ConsoleHeranca.Funcionario f = new ConsoleHeranca.Funcionario();
            f.setNome(nome_textBox.Text);
            f.setEndereco(endereco_textBox.Text);
            f.setCidade(cidade_textBox.Text);
            f.setTelefone(telefone_maskedTextBox.Text);
            f.setFuncao(funcao_textBox.Text);
            try {
                f.setSalario(double.Parse(salario_maskedTextBox.Text));
                string saida = "Nome: " + f.getNome().ToUpper() + "\n" +
                    "Endereço: " + f.getEndereco().ToUpper() + "\n" +
                    "Cidade: " + f.getCidade().ToUpper() + "\n" +
                    "Telefone: " + f.getFone().ToUpper() + "\n" +
                    "Função: " + f.getFuncao().ToUpper() + "\n" +
                    "Salário: " + f.getSalario().ToString();
                MessageBox.Show(saida, "Saída dos dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
             } catch(Exception error) {
                MessageBox.Show(error.Message, "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpar_btn_Click(object sender, EventArgs e) {
            nome_textBox.Clear();
            endereco_textBox.Clear();
            cidade_textBox.Clear();
            telefone_maskedTextBox.Clear();
            funcao_textBox.Clear();
            salario_maskedTextBox.Clear();
            nome_textBox.Focus();
        }

        private void sair_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_String {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            string texto = "Estudo de Classes em C# no Visual Studio 2019";
            int tamanho = texto.Length;
            label4.Text = texto;
            label5.Text = tamanho.ToString();
            label6.Text = texto.Substring(10, 1).ToUpper() + texto.Substring(11,12);
        }
    }
}

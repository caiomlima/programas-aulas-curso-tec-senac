using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualiza_Imagem {
    public partial class form_imagem : Form {
        public form_imagem() {
            InitializeComponent();
        }

        private void abrir_btn_Click(object sender, EventArgs e) {
            try {
                openFileDialog.ShowDialog();
                if(openFileDialog.FileName != "") {
                    img_pictureBox.Load(openFileDialog.FileName);
                }
            } catch(Exception error) {
                MessageBox.Show(error.Message + "\nO arquivo selecionado não é um arquivo de imagem", "ERRO DE ARQUIVO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sair_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

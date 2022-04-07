using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimenta_Teclas {
    public partial class FormMoviTeclas : Form {
        public FormMoviTeclas() {
            InitializeComponent();
        }

        private void FormMoviTeclas_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Left) {
                if(logo_pictureBox.Location.X > -99) {
                    logo_pictureBox.Left -= 10;
                } else {
                    logo_pictureBox.Left = 615;
                }
            }

            if (e.KeyCode == Keys.Up) {
                if (logo_pictureBox.Location.Y > -94) {
                    logo_pictureBox.Top -= 10;
                } else {
                    logo_pictureBox.Top = 514;
                }
            }

            if (e.KeyCode == Keys.Right) {
                if (logo_pictureBox.Location.X < 615) {
                    logo_pictureBox.Left += 10;
                } else {
                    logo_pictureBox.Left = -99;
                }
            }

            if (e.KeyCode == Keys.Down) {
                if (logo_pictureBox.Location.Y < 514) {
                    logo_pictureBox.Top += 10;
                } else {
                    logo_pictureBox.Top = -99 ;
                }
            }
        }
    }
}

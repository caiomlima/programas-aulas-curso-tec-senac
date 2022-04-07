using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeADS {
    public partial class Form1 : Form {

        Graphics g;
        Fila cabeca;
        public Form1() {
            InitializeComponent();
            cabeca = new Fila(10, 10);
            Graphics g = canvas.CreateGraphics();
        }

        private void loop_Tick(object sender, EventArgs e) {
            g.Clear(Color.White);
            cabeca.desenhar(g);
        }
    }
}

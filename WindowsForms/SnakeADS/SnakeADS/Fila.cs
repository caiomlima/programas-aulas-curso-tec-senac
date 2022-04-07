using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeADS {
    class Fila : Objeto {

        public Fila(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void desenhar(Graphics g) {
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.largura, this.largura);
        }

    }
}

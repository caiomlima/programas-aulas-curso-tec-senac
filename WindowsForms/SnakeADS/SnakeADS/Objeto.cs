using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeADS {
    class Objeto {

        protected int x, y, largura;
        public Objeto() {
            largura = 10;
        }

        public Boolean interseccao(Objeto o) {
            int difx = Math.Abs(this.x - o.x);
            int dify = Math.Abs(this.y - o.y);
            if(difx >= 0 && difx < largura && difx >= 0 && difx < largura) {
                return true;
            } else {
                return false;
            }
        }

    }
}

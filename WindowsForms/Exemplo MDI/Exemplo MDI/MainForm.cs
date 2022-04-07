using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_MDI {

    public partial class MainForm : Form {

        private int formContador = 1;

        public MainForm() {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            FormFilho meuForm = new FormFilho();
            meuForm.MdiParent = this;
            meuForm.Text = "Fomulário Filho N°" + formContador.ToString();
            meuForm.Show();
            formContador++;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            foreach(Form c in this.MdiChildren) {
                c.Close();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

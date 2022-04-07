using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio {
    public partial class form_relogio : Form {
        public form_relogio() {
            InitializeComponent();
        }

        private void label_relogio_Click(object sender, EventArgs e) {
            label_data.Text = DateTime.Now.ToLongDateString();
        }

        private void timer_counter_Tick(object sender, EventArgs e) {
            label_relogio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

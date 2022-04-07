using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Menus {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void calculoDaMediatoolStripMenuItem_Click(object sender, EventArgs e) {
            Calc_Da_Media.FormCalcMedia item1 = new Calc_Da_Media.FormCalcMedia();
            item1.MdiParent = this;
            item1.Show();
        }

        private void classfNomesToolStripMenuItem_Click(object sender, EventArgs e) {
            Ordenar_Nomes.FormOrdenarNomes item2 = new Ordenar_Nomes.FormOrdenarNomes();
            item2.MdiParent = this;
            item2.Show();
        }

        private void listaDeNomesToolStripMenuItem_Click(object sender, EventArgs e) {
            Lista_De_Nomes.form_lista_nomes item3 = new Lista_De_Nomes.form_lista_nomes();
            item3.MdiParent = this;
            item3.Show();
        }

        private void movimentarImagemToolStripMenuItem_Click(object sender, EventArgs e) {
            Movimenta_Teclas.FormMoviTeclas item4 = new Movimenta_Teclas.FormMoviTeclas();
            item4.MdiParent = this;
            item4.Show();
        }

        private void visualizarImagemToolStripMenuItem_Click(object sender, EventArgs e) {
            Visualiza_Imagem.form_imagem item5 = new Visualiza_Imagem.form_imagem();
            item5.MdiParent = this;
            item5.Show();
        }

        private void relogioToolStripMenuItem_Click(object sender, EventArgs e) {
            Relogio.form_relogio item6 = new Relogio.form_relogio();
            item6.MdiParent = this;
            item6.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }






        private void calcMediaPopMenuItem_Click(object sender, EventArgs e) {
            Calc_Da_Media.FormCalcMedia itemPop1 = new Calc_Da_Media.FormCalcMedia();
            itemPop1.MdiParent = this;
            itemPop1.Show();
        }

        private void classNomesPopMenuItem_Click(object sender, EventArgs e) {
            Ordenar_Nomes.FormOrdenarNomes itemPop2 = new Ordenar_Nomes.FormOrdenarNomes();
            itemPop2.MdiParent = this;
            itemPop2.Show();
        }

        private void listaNomesPopMenuItem_Click(object sender, EventArgs e) {
            Ordenar_Nomes.FormOrdenarNomes itemPop3 = new Ordenar_Nomes.FormOrdenarNomes();
            itemPop3.MdiParent = this;
            itemPop3.Show();
        }

        private void visualizarImagemPopMenuItem_Click(object sender, EventArgs e) {
            Visualiza_Imagem.form_imagem itemPop4 = new Visualiza_Imagem.form_imagem();
            itemPop4.MdiParent = this;
            itemPop4.Show();
        }

        private void relogioToolStripPopMenuItem_Click(object sender, EventArgs e) {
            Relogio.form_relogio itemPop5 = new Relogio.form_relogio();
            itemPop5.MdiParent = this;
            itemPop5.Show();
        }

        private void sairPopMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }





        private void MainForm_Load(object sender, EventArgs e) {
            string dataCompleta = DateTime.Now.ToLongDateString();
            string semana = dataCompleta.Substring(0, 1).ToUpper() + dataCompleta.Substring(1, dataCompleta.Length - 1);
            dataStatusLabel.Text = semana;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            horaStatusLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

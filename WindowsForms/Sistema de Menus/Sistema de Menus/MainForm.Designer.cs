
namespace Sistema_de_Menus {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDaMediatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classfNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calcMediaPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classNomesPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNomesPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogioToolStripPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.horaStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.popMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDaMediatoolStripMenuItem,
            this.classfNomesToolStripMenuItem,
            this.listaDeNomesToolStripMenuItem,
            this.movimentarImagemToolStripMenuItem,
            this.visualizarImagemToolStripMenuItem,
            this.relogioToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // calculoDaMediatoolStripMenuItem
            // 
            this.calculoDaMediatoolStripMenuItem.Name = "calculoDaMediatoolStripMenuItem";
            this.calculoDaMediatoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculoDaMediatoolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.calculoDaMediatoolStripMenuItem.Text = "Cálculo da Média";
            this.calculoDaMediatoolStripMenuItem.Click += new System.EventHandler(this.calculoDaMediatoolStripMenuItem_Click);
            // 
            // classfNomesToolStripMenuItem
            // 
            this.classfNomesToolStripMenuItem.Name = "classfNomesToolStripMenuItem";
            this.classfNomesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.classfNomesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.classfNomesToolStripMenuItem.Text = "Classificar Nomes";
            this.classfNomesToolStripMenuItem.Click += new System.EventHandler(this.classfNomesToolStripMenuItem_Click);
            // 
            // listaDeNomesToolStripMenuItem
            // 
            this.listaDeNomesToolStripMenuItem.Name = "listaDeNomesToolStripMenuItem";
            this.listaDeNomesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listaDeNomesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listaDeNomesToolStripMenuItem.Text = "Lista de Nomes";
            this.listaDeNomesToolStripMenuItem.Click += new System.EventHandler(this.listaDeNomesToolStripMenuItem_Click);
            // 
            // movimentarImagemToolStripMenuItem
            // 
            this.movimentarImagemToolStripMenuItem.Name = "movimentarImagemToolStripMenuItem";
            this.movimentarImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.movimentarImagemToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.movimentarImagemToolStripMenuItem.Text = "Movimentar Imagem";
            this.movimentarImagemToolStripMenuItem.Click += new System.EventHandler(this.movimentarImagemToolStripMenuItem_Click);
            // 
            // visualizarImagemToolStripMenuItem
            // 
            this.visualizarImagemToolStripMenuItem.Name = "visualizarImagemToolStripMenuItem";
            this.visualizarImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.visualizarImagemToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.visualizarImagemToolStripMenuItem.Text = "Visualizar Imagem";
            this.visualizarImagemToolStripMenuItem.Click += new System.EventHandler(this.visualizarImagemToolStripMenuItem_Click);
            // 
            // relogioToolStripMenuItem
            // 
            this.relogioToolStripMenuItem.Name = "relogioToolStripMenuItem";
            this.relogioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relogioToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.relogioToolStripMenuItem.Text = "Relógio";
            this.relogioToolStripMenuItem.Click += new System.EventHandler(this.relogioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sairToolStripMenuItem.Text = "Sair do Programa";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // popMenu
            // 
            this.popMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcMediaPopMenuItem,
            this.classNomesPopMenuItem,
            this.listaNomesPopMenuItem,
            this.visualizarImagemPopMenuItem,
            this.relogioToolStripPopMenuItem,
            this.toolStripSeparator2,
            this.sairPopMenuItem});
            this.popMenu.Name = "popMenu";
            this.popMenu.Size = new System.Drawing.Size(171, 142);
            // 
            // calcMediaPopMenuItem
            // 
            this.calcMediaPopMenuItem.Name = "calcMediaPopMenuItem";
            this.calcMediaPopMenuItem.Size = new System.Drawing.Size(170, 22);
            this.calcMediaPopMenuItem.Text = "Cálculo da Média";
            this.calcMediaPopMenuItem.Click += new System.EventHandler(this.calcMediaPopMenuItem_Click);
            // 
            // classNomesPopMenuItem
            // 
            this.classNomesPopMenuItem.Name = "classNomesPopMenuItem";
            this.classNomesPopMenuItem.Size = new System.Drawing.Size(170, 22);
            this.classNomesPopMenuItem.Text = "Classificar Nomes";
            this.classNomesPopMenuItem.Click += new System.EventHandler(this.classNomesPopMenuItem_Click);
            // 
            // listaNomesPopMenuItem
            // 
            this.listaNomesPopMenuItem.Name = "listaNomesPopMenuItem";
            this.listaNomesPopMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listaNomesPopMenuItem.Text = "Lista de Nomes";
            this.listaNomesPopMenuItem.Click += new System.EventHandler(this.listaNomesPopMenuItem_Click);
            // 
            // visualizarImagemPopMenuItem
            // 
            this.visualizarImagemPopMenuItem.Name = "visualizarImagemPopMenuItem";
            this.visualizarImagemPopMenuItem.Size = new System.Drawing.Size(170, 22);
            this.visualizarImagemPopMenuItem.Text = "Visualizar Imagem";
            this.visualizarImagemPopMenuItem.Click += new System.EventHandler(this.visualizarImagemPopMenuItem_Click);
            // 
            // relogioToolStripPopMenuItem
            // 
            this.relogioToolStripPopMenuItem.Name = "relogioToolStripPopMenuItem";
            this.relogioToolStripPopMenuItem.Size = new System.Drawing.Size(170, 22);
            this.relogioToolStripPopMenuItem.Text = "Relogio";
            this.relogioToolStripPopMenuItem.Click += new System.EventHandler(this.relogioToolStripPopMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // sairPopMenuItem
            // 
            this.sairPopMenuItem.Name = "sairPopMenuItem";
            this.sairPopMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairPopMenuItem.Text = "Sair do Programa";
            this.sairPopMenuItem.Click += new System.EventHandler(this.sairPopMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataStatusLabel,
            this.horaStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataStatusLabel
            // 
            this.dataStatusLabel.AutoSize = false;
            this.dataStatusLabel.Name = "dataStatusLabel";
            this.dataStatusLabel.Size = new System.Drawing.Size(218, 17);
            this.dataStatusLabel.Text = "Data";
            // 
            // horaStatusLabel
            // 
            this.horaStatusLabel.AutoSize = false;
            this.horaStatusLabel.Name = "horaStatusLabel";
            this.horaStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.horaStatusLabel.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(700, 521);
            this.ContextMenuStrip = this.popMenu;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Menus em C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.popMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDaMediatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classfNomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentarImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relogioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip popMenu;
        private System.Windows.Forms.ToolStripMenuItem calcMediaPopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classNomesPopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNomesPopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImagemPopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relogioToolStripPopMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairPopMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dataStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel horaStatusLabel;
        private System.Windows.Forms.Timer timer1;
    }
}


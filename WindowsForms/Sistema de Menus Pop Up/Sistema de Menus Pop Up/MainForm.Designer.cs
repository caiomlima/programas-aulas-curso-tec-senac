
namespace Sistema_de_Menus_Pop_Up {
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
            this.popMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.caclMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificarNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // popMenu
            // 
            this.popMenu.AutoSize = false;
            this.popMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caclMediaToolStripMenuItem,
            this.classificarNomesToolStripMenuItem,
            this.listaDeNomesToolStripMenuItem,
            this.visualizarImagemToolStripMenuItem,
            this.relogioToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem1});
            this.popMenu.Name = "contextMenuStrip";
            this.popMenu.Size = new System.Drawing.Size(187, 186);
            // 
            // caclMediaToolStripMenuItem
            // 
            this.caclMediaToolStripMenuItem.Name = "caclMediaToolStripMenuItem";
            this.caclMediaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caclMediaToolStripMenuItem.Text = "Cálculo da Média";
            this.caclMediaToolStripMenuItem.Click += new System.EventHandler(this.caclMediaToolStripMenuItem_Click);
            // 
            // classificarNomesToolStripMenuItem
            // 
            this.classificarNomesToolStripMenuItem.Name = "classificarNomesToolStripMenuItem";
            this.classificarNomesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classificarNomesToolStripMenuItem.Text = "Classificar Nomes";
            this.classificarNomesToolStripMenuItem.Click += new System.EventHandler(this.classificarNomesToolStripMenuItem_Click);
            // 
            // listaDeNomesToolStripMenuItem
            // 
            this.listaDeNomesToolStripMenuItem.Name = "listaDeNomesToolStripMenuItem";
            this.listaDeNomesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeNomesToolStripMenuItem.Text = "Lista de Nomes";
            this.listaDeNomesToolStripMenuItem.Click += new System.EventHandler(this.listaDeNomesToolStripMenuItem_Click);
            // 
            // visualizarImagemToolStripMenuItem
            // 
            this.visualizarImagemToolStripMenuItem.Name = "visualizarImagemToolStripMenuItem";
            this.visualizarImagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarImagemToolStripMenuItem.Text = "Visualizar Imagem";
            this.visualizarImagemToolStripMenuItem.Click += new System.EventHandler(this.visualizarImagemToolStripMenuItem_Click);
            // 
            // relogioToolStripMenuItem
            // 
            this.relogioToolStripMenuItem.Name = "relogioToolStripMenuItem";
            this.relogioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relogioToolStripMenuItem.Text = "Relogio";
            this.relogioToolStripMenuItem.Click += new System.EventHandler(this.relogioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Menus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.popMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip popMenu;
        private System.Windows.Forms.ToolStripMenuItem caclMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificarNomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relogioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}



namespace Web_Browser {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.voltar_btn = new System.Windows.Forms.Button();
            this.avancar_btn = new System.Windows.Forms.Button();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.parar_btn = new System.Windows.Forms.Button();
            this.inicial_btn = new System.Windows.Forms.Button();
            this.endereco_textBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.abas_tabControl = new System.Windows.Forms.TabControl();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 426);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaAbaToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novaAbaToolStripMenuItem
            // 
            this.novaAbaToolStripMenuItem.Name = "novaAbaToolStripMenuItem";
            this.novaAbaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.novaAbaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaAbaToolStripMenuItem.Text = "Nova Aba";
            this.novaAbaToolStripMenuItem.Click += new System.EventHandler(this.novaAbaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagInicialToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configToolStripMenuItem.Text = "&Configurações";
            // 
            // pagInicialToolStripMenuItem
            // 
            this.pagInicialToolStripMenuItem.Name = "pagInicialToolStripMenuItem";
            this.pagInicialToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.pagInicialToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pagInicialToolStripMenuItem.Text = "Página Inicial";
            this.pagInicialToolStripMenuItem.Click += new System.EventHandler(this.pagInicialToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.abas_tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.voltar_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.avancar_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.atualizar_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.parar_btn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.inicial_btn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.endereco_textBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // voltar_btn
            // 
            this.voltar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voltar_btn.ImageIndex = 1;
            this.voltar_btn.ImageList = this.imageList1;
            this.voltar_btn.Location = new System.Drawing.Point(3, 3);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(75, 93);
            this.voltar_btn.TabIndex = 0;
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // avancar_btn
            // 
            this.avancar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avancar_btn.ImageIndex = 0;
            this.avancar_btn.ImageList = this.imageList1;
            this.avancar_btn.Location = new System.Drawing.Point(84, 3);
            this.avancar_btn.Name = "avancar_btn";
            this.avancar_btn.Size = new System.Drawing.Size(75, 93);
            this.avancar_btn.TabIndex = 1;
            this.avancar_btn.UseVisualStyleBackColor = true;
            this.avancar_btn.Click += new System.EventHandler(this.avancar_btn_Click);
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atualizar_btn.ImageIndex = 2;
            this.atualizar_btn.ImageList = this.imageList1;
            this.atualizar_btn.Location = new System.Drawing.Point(560, 3);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(75, 93);
            this.atualizar_btn.TabIndex = 2;
            this.atualizar_btn.UseVisualStyleBackColor = true;
            this.atualizar_btn.Click += new System.EventHandler(this.atualizar_btn_Click);
            // 
            // parar_btn
            // 
            this.parar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parar_btn.ImageIndex = 3;
            this.parar_btn.ImageList = this.imageList1;
            this.parar_btn.Location = new System.Drawing.Point(641, 3);
            this.parar_btn.Name = "parar_btn";
            this.parar_btn.Size = new System.Drawing.Size(75, 93);
            this.parar_btn.TabIndex = 3;
            this.parar_btn.UseVisualStyleBackColor = true;
            this.parar_btn.Click += new System.EventHandler(this.parar_btn_Click);
            // 
            // inicial_btn
            // 
            this.inicial_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicial_btn.ImageIndex = 5;
            this.inicial_btn.ImageList = this.imageList1;
            this.inicial_btn.Location = new System.Drawing.Point(722, 3);
            this.inicial_btn.Name = "inicial_btn";
            this.inicial_btn.Size = new System.Drawing.Size(75, 93);
            this.inicial_btn.TabIndex = 4;
            this.inicial_btn.UseVisualStyleBackColor = true;
            this.inicial_btn.Click += new System.EventHandler(this.inicial_btn_Click);
            // 
            // endereco_textBox
            // 
            this.endereco_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endereco_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_textBox.Location = new System.Drawing.Point(165, 3);
            this.endereco_textBox.Name = "endereco_textBox";
            this.endereco_textBox.Size = new System.Drawing.Size(389, 30);
            this.endereco_textBox.TabIndex = 5;
            this.endereco_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endereco_textBox_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "83919.png");
            this.imageList1.Images.SetKeyName(1, "93634.png");
            this.imageList1.Images.SetKeyName(2, "159612.png");
            this.imageList1.Images.SetKeyName(3, "189640.png");
            this.imageList1.Images.SetKeyName(4, "images.png");
            this.imageList1.Images.SetKeyName(5, "start-131964753309942507.png");
            // 
            // abas_tabControl
            // 
            this.abas_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abas_tabControl.Location = new System.Drawing.Point(0, 0);
            this.abas_tabControl.Name = "abas_tabControl";
            this.abas_tabControl.SelectedIndex = 0;
            this.abas_tabControl.Size = new System.Drawing.Size(800, 323);
            this.abas_tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button avancar_btn;
        private System.Windows.Forms.Button atualizar_btn;
        private System.Windows.Forms.Button parar_btn;
        private System.Windows.Forms.Button inicial_btn;
        private System.Windows.Forms.TextBox endereco_textBox;
        private System.Windows.Forms.TabControl abas_tabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaAbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagInicialToolStripMenuItem;
    }
}
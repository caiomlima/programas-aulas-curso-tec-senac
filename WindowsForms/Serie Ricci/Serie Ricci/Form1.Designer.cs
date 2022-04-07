
namespace Serie_Ricci {
    partial class Form {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.termo1_label = new System.Windows.Forms.Label();
            this.termo2_label = new System.Windows.Forms.Label();
            this.n_termos_label = new System.Windows.Forms.Label();
            this.termo1_textBox = new System.Windows.Forms.TextBox();
            this.termo2_textBox = new System.Windows.Forms.TextBox();
            this.n_termos_textBox = new System.Windows.Forms.TextBox();
            this.res_listBox = new System.Windows.Forms.ListBox();
            this.res_button = new System.Windows.Forms.Button();
            this.limpar_button = new System.Windows.Forms.Button();
            this.sair_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Série de Ricci";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Serie_Ricci.Properties.Resources.logica;
            this.pictureBox1.Location = new System.Drawing.Point(367, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // termo1_label
            // 
            this.termo1_label.AutoSize = true;
            this.termo1_label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termo1_label.Location = new System.Drawing.Point(28, 101);
            this.termo1_label.Name = "termo1_label";
            this.termo1_label.Size = new System.Drawing.Size(207, 18);
            this.termo1_label.TabIndex = 2;
            this.termo1_label.Text = "Digite o primeiro Termo:";
            // 
            // termo2_label
            // 
            this.termo2_label.AutoSize = true;
            this.termo2_label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termo2_label.Location = new System.Drawing.Point(28, 145);
            this.termo2_label.Name = "termo2_label";
            this.termo2_label.Size = new System.Drawing.Size(208, 18);
            this.termo2_label.TabIndex = 3;
            this.termo2_label.Text = "Digite o segundo Termo:";
            // 
            // n_termos_label
            // 
            this.n_termos_label.AutoSize = true;
            this.n_termos_label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_termos_label.Location = new System.Drawing.Point(28, 186);
            this.n_termos_label.Name = "n_termos_label";
            this.n_termos_label.Size = new System.Drawing.Size(236, 18);
            this.n_termos_label.TabIndex = 4;
            this.n_termos_label.Text = "Digite o número de Termos:";
            // 
            // termo1_textBox
            // 
            this.termo1_textBox.Location = new System.Drawing.Point(253, 101);
            this.termo1_textBox.Name = "termo1_textBox";
            this.termo1_textBox.Size = new System.Drawing.Size(88, 22);
            this.termo1_textBox.TabIndex = 5;
            // 
            // termo2_textBox
            // 
            this.termo2_textBox.Location = new System.Drawing.Point(253, 145);
            this.termo2_textBox.Name = "termo2_textBox";
            this.termo2_textBox.Size = new System.Drawing.Size(88, 22);
            this.termo2_textBox.TabIndex = 6;
            // 
            // n_termos_textBox
            // 
            this.n_termos_textBox.Location = new System.Drawing.Point(274, 186);
            this.n_termos_textBox.Name = "n_termos_textBox";
            this.n_termos_textBox.Size = new System.Drawing.Size(67, 22);
            this.n_termos_textBox.TabIndex = 7;
            // 
            // res_listBox
            // 
            this.res_listBox.FormattingEnabled = true;
            this.res_listBox.ItemHeight = 14;
            this.res_listBox.Location = new System.Drawing.Point(31, 233);
            this.res_listBox.Name = "res_listBox";
            this.res_listBox.Size = new System.Drawing.Size(310, 130);
            this.res_listBox.TabIndex = 8;
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_button.Location = new System.Drawing.Point(396, 233);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(84, 33);
            this.res_button.TabIndex = 9;
            this.res_button.Text = "Mostrar";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // limpar_button
            // 
            this.limpar_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar_button.Location = new System.Drawing.Point(396, 281);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(84, 33);
            this.limpar_button.TabIndex = 10;
            this.limpar_button.Text = "Limpar";
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.limpar_button_Click);
            // 
            // sair_button
            // 
            this.sair_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair_button.Location = new System.Drawing.Point(396, 330);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(84, 33);
            this.sair_button.TabIndex = 11;
            this.sair_button.Text = "Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 400);
            this.Controls.Add(this.sair_button);
            this.Controls.Add(this.limpar_button);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.res_listBox);
            this.Controls.Add(this.n_termos_textBox);
            this.Controls.Add(this.termo2_textBox);
            this.Controls.Add(this.termo1_textBox);
            this.Controls.Add(this.n_termos_label);
            this.Controls.Add(this.termo2_label);
            this.Controls.Add(this.termo1_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Série de Ricci";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label termo1_label;
        private System.Windows.Forms.Label termo2_label;
        private System.Windows.Forms.Label n_termos_label;
        private System.Windows.Forms.TextBox termo1_textBox;
        private System.Windows.Forms.TextBox termo2_textBox;
        private System.Windows.Forms.TextBox n_termos_textBox;
        private System.Windows.Forms.ListBox res_listBox;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Button limpar_button;
        private System.Windows.Forms.Button sair_button;
    }
}


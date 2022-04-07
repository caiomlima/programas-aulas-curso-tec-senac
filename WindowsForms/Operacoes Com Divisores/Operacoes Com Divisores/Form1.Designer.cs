
namespace Operacoes_Com_Divisores {
    partial class Form1 {
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
            this.titulo_label = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.res_label = new System.Windows.Forms.Label();
            this.div_button = new System.Windows.Forms.Button();
            this.primo_button = new System.Windows.Forms.Button();
            this.perf_button = new System.Windows.Forms.Button();
            this.sair_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(7, 38);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(300, 28);
            this.titulo_label.TabIndex = 0;
            this.titulo_label.Text = "Operações com Inteiros";
            this.titulo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_label
            // 
            this.num_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.Location = new System.Drawing.Point(12, 101);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(195, 19);
            this.num_label.TabIndex = 1;
            this.num_label.Text = "Digite um número inteiro:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Operacoes_Com_Divisores.Properties.Resources._58ffb0b95ebc89_8888466458ffb0b94b07b3_82105425;
            this.pictureBox1.Location = new System.Drawing.Point(313, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(210, 99);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(90, 22);
            this.num_textBox.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.sair_button);
            this.groupBox.Controls.Add(this.perf_button);
            this.groupBox.Controls.Add(this.primo_button);
            this.groupBox.Controls.Add(this.div_button);
            this.groupBox.Location = new System.Drawing.Point(12, 213);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(485, 73);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // res_label
            // 
            this.res_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_label.Location = new System.Drawing.Point(12, 170);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(485, 31);
            this.res_label.TabIndex = 5;
            this.res_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // div_button
            // 
            this.div_button.Location = new System.Drawing.Point(35, 21);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(90, 35);
            this.div_button.TabIndex = 0;
            this.div_button.Text = "Exibir Divs.";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // primo_button
            // 
            this.primo_button.Location = new System.Drawing.Point(146, 21);
            this.primo_button.Name = "primo_button";
            this.primo_button.Size = new System.Drawing.Size(90, 35);
            this.primo_button.TabIndex = 1;
            this.primo_button.Text = "Ver. Primo";
            this.primo_button.UseVisualStyleBackColor = true;
            this.primo_button.Click += new System.EventHandler(this.primo_button_Click);
            // 
            // perf_button
            // 
            this.perf_button.Location = new System.Drawing.Point(254, 21);
            this.perf_button.Name = "perf_button";
            this.perf_button.Size = new System.Drawing.Size(90, 35);
            this.perf_button.TabIndex = 2;
            this.perf_button.Text = "É Perfeito?";
            this.perf_button.UseVisualStyleBackColor = true;
            this.perf_button.Click += new System.EventHandler(this.perf_button_Click);
            // 
            // sair_button
            // 
            this.sair_button.Location = new System.Drawing.Point(366, 21);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(90, 35);
            this.sair_button.TabIndex = 3;
            this.sair_button.Text = "Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(509, 298);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.num_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.num_label);
            this.Controls.Add(this.titulo_label);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operações com Número Inteiros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button sair_button;
        private System.Windows.Forms.Button perf_button;
        private System.Windows.Forms.Button primo_button;
        private System.Windows.Forms.Button div_button;
        private System.Windows.Forms.Label res_label;
    }
}


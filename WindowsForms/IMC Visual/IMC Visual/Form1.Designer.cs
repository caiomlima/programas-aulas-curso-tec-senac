
namespace IMC_Visual {
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
            this.altura_label = new System.Windows.Forms.Label();
            this.peso_label = new System.Windows.Forms.Label();
            this.situacao_label = new System.Windows.Forms.Label();
            this.peso_textBox = new System.Windows.Forms.TextBox();
            this.altura_textBox = new System.Windows.Forms.TextBox();
            this.situacao_res_label = new System.Windows.Forms.Label();
            this.imc_res_label = new System.Windows.Forms.Label();
            this.imc_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sair_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(229, 30);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(238, 31);
            this.titulo_label.TabIndex = 0;
            this.titulo_label.Text = "Calculador de IMC";
            // 
            // altura_label
            // 
            this.altura_label.AutoSize = true;
            this.altura_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura_label.Location = new System.Drawing.Point(76, 157);
            this.altura_label.Name = "altura_label";
            this.altura_label.Size = new System.Drawing.Size(69, 25);
            this.altura_label.TabIndex = 1;
            this.altura_label.Text = "Altura:";
            // 
            // peso_label
            // 
            this.peso_label.AutoSize = true;
            this.peso_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso_label.Location = new System.Drawing.Point(82, 112);
            this.peso_label.Name = "peso_label";
            this.peso_label.Size = new System.Drawing.Size(63, 25);
            this.peso_label.TabIndex = 2;
            this.peso_label.Text = "Peso:";
            // 
            // situacao_label
            // 
            this.situacao_label.AutoSize = true;
            this.situacao_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacao_label.Location = new System.Drawing.Point(61, 239);
            this.situacao_label.Name = "situacao_label";
            this.situacao_label.Size = new System.Drawing.Size(95, 25);
            this.situacao_label.TabIndex = 4;
            this.situacao_label.Text = "Situação:";
            // 
            // peso_textBox
            // 
            this.peso_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso_textBox.Location = new System.Drawing.Point(162, 112);
            this.peso_textBox.Multiline = true;
            this.peso_textBox.Name = "peso_textBox";
            this.peso_textBox.Size = new System.Drawing.Size(127, 30);
            this.peso_textBox.TabIndex = 5;
            // 
            // altura_textBox
            // 
            this.altura_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura_textBox.Location = new System.Drawing.Point(162, 157);
            this.altura_textBox.Multiline = true;
            this.altura_textBox.Name = "altura_textBox";
            this.altura_textBox.Size = new System.Drawing.Size(127, 30);
            this.altura_textBox.TabIndex = 7;
            // 
            // situacao_res_label
            // 
            this.situacao_res_label.AutoSize = true;
            this.situacao_res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacao_res_label.Location = new System.Drawing.Point(157, 239);
            this.situacao_res_label.Name = "situacao_res_label";
            this.situacao_res_label.Size = new System.Drawing.Size(128, 25);
            this.situacao_res_label.TabIndex = 8;
            this.situacao_res_label.Text = "Res Situação";
            // 
            // imc_res_label
            // 
            this.imc_res_label.AutoSize = true;
            this.imc_res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imc_res_label.Location = new System.Drawing.Point(157, 198);
            this.imc_res_label.Name = "imc_res_label";
            this.imc_res_label.Size = new System.Drawing.Size(124, 25);
            this.imc_res_label.TabIndex = 10;
            this.imc_res_label.Text = "Clique Aqui !";
            this.imc_res_label.Click += new System.EventHandler(this.imc_res_label_Click);
            // 
            // imc_label
            // 
            this.imc_label.AutoSize = true;
            this.imc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imc_label.Location = new System.Drawing.Point(82, 198);
            this.imc_label.Name = "imc_label";
            this.imc_label.Size = new System.Drawing.Size(55, 25);
            this.imc_label.TabIndex = 9;
            this.imc_label.Text = "IMC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMC_Visual.Properties.Resources.imc1;
            this.pictureBox1.Location = new System.Drawing.Point(322, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // sair_button
            // 
            this.sair_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair_button.Location = new System.Drawing.Point(295, 307);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(87, 37);
            this.sair_button.TabIndex = 12;
            this.sair_button.Text = "Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(670, 371);
            this.Controls.Add(this.sair_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imc_res_label);
            this.Controls.Add(this.imc_label);
            this.Controls.Add(this.situacao_res_label);
            this.Controls.Add(this.altura_textBox);
            this.Controls.Add(this.peso_textBox);
            this.Controls.Add(this.situacao_label);
            this.Controls.Add(this.peso_label);
            this.Controls.Add(this.altura_label);
            this.Controls.Add(this.titulo_label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label altura_label;
        private System.Windows.Forms.Label peso_label;
        private System.Windows.Forms.Label situacao_label;
        private System.Windows.Forms.TextBox peso_textBox;
        private System.Windows.Forms.TextBox altura_textBox;
        private System.Windows.Forms.Label situacao_res_label;
        private System.Windows.Forms.Label imc_res_label;
        private System.Windows.Forms.Label imc_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sair_button;
    }
}


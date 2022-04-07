
namespace Serie_Fibonacci {
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
            this.titulo_label = new System.Windows.Forms.Label();
            this.termos_label = new System.Windows.Forms.Label();
            this.termos_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.res_listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.res_button = new System.Windows.Forms.Button();
            this.limpar_button = new System.Windows.Forms.Button();
            this.sair_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(49, 40);
            this.titulo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(293, 35);
            this.titulo_label.TabIndex = 0;
            this.titulo_label.Text = "Série de Fibonacci";
            this.titulo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termos_label
            // 
            this.termos_label.AutoSize = true;
            this.termos_label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termos_label.Location = new System.Drawing.Point(12, 126);
            this.termos_label.Name = "termos_label";
            this.termos_label.Size = new System.Drawing.Size(236, 18);
            this.termos_label.TabIndex = 1;
            this.termos_label.Text = "Digite o número de Termos:";
            this.termos_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termos_textBox
            // 
            this.termos_textBox.Location = new System.Drawing.Point(254, 126);
            this.termos_textBox.Name = "termos_textBox";
            this.termos_textBox.Size = new System.Drawing.Size(74, 22);
            this.termos_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Série com Termos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res_listBox
            // 
            this.res_listBox.FormattingEnabled = true;
            this.res_listBox.ItemHeight = 14;
            this.res_listBox.Location = new System.Drawing.Point(12, 248);
            this.res_listBox.Name = "res_listBox";
            this.res_listBox.Size = new System.Drawing.Size(313, 186);
            this.res_listBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Serie_Fibonacci.Properties.Resources._513f755d9827683068000278fibonacci_spiral_geogebra_svg;
            this.pictureBox1.Location = new System.Drawing.Point(359, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_button.Location = new System.Drawing.Point(429, 248);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(103, 43);
            this.res_button.TabIndex = 6;
            this.res_button.Text = "Mostrar";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // limpar_button
            // 
            this.limpar_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar_button.Location = new System.Drawing.Point(429, 321);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(103, 43);
            this.limpar_button.TabIndex = 7;
            this.limpar_button.Text = "Limpar";
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.limpar_button_Click);
            // 
            // sair_button
            // 
            this.sair_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair_button.Location = new System.Drawing.Point(429, 391);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(103, 43);
            this.sair_button.TabIndex = 8;
            this.sair_button.Text = "Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 446);
            this.Controls.Add(this.sair_button);
            this.Controls.Add(this.limpar_button);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res_listBox);
            this.Controls.Add(this.termos_textBox);
            this.Controls.Add(this.termos_label);
            this.Controls.Add(this.titulo_label);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ShowInTaskbar = false;
            this.Text = "Série de Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label termos_label;
        private System.Windows.Forms.TextBox termos_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox res_listBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Button limpar_button;
        private System.Windows.Forms.Button sair_button;
    }
}


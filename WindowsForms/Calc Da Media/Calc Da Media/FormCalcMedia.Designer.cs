
namespace Calc_Da_Media {
    partial class FormCalcMedia {
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.n1_label = new System.Windows.Forms.Label();
            this.n2_label = new System.Windows.Forms.Label();
            this.n4_label = new System.Windows.Forms.Label();
            this.n3_label = new System.Windows.Forms.Label();
            this.n1_textBox = new System.Windows.Forms.TextBox();
            this.n4_textBox = new System.Windows.Forms.TextBox();
            this.n3_textBox = new System.Windows.Forms.TextBox();
            this.n2_textBox = new System.Windows.Forms.TextBox();
            this.res_media_label = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.limpar_button = new System.Windows.Forms.Button();
            this.sair_button = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo da Média";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.sair_button);
            this.groupBox.Controls.Add(this.limpar_button);
            this.groupBox.Controls.Add(this.calc_button);
            this.groupBox.Controls.Add(this.res_media_label);
            this.groupBox.Controls.Add(this.n2_textBox);
            this.groupBox.Controls.Add(this.n3_textBox);
            this.groupBox.Controls.Add(this.n4_textBox);
            this.groupBox.Controls.Add(this.n1_textBox);
            this.groupBox.Controls.Add(this.n3_label);
            this.groupBox.Controls.Add(this.n4_label);
            this.groupBox.Controls.Add(this.n2_label);
            this.groupBox.Controls.Add(this.n1_label);
            this.groupBox.Location = new System.Drawing.Point(38, 101);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(461, 202);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // n1_label
            // 
            this.n1_label.AutoSize = true;
            this.n1_label.Location = new System.Drawing.Point(15, 25);
            this.n1_label.Name = "n1_label";
            this.n1_label.Size = new System.Drawing.Size(67, 16);
            this.n1_label.TabIndex = 0;
            this.n1_label.Text = "1° Nota:";
            // 
            // n2_label
            // 
            this.n2_label.AutoSize = true;
            this.n2_label.Location = new System.Drawing.Point(15, 65);
            this.n2_label.Name = "n2_label";
            this.n2_label.Size = new System.Drawing.Size(67, 16);
            this.n2_label.TabIndex = 1;
            this.n2_label.Text = "2° Nota:";
            // 
            // n4_label
            // 
            this.n4_label.AutoSize = true;
            this.n4_label.Location = new System.Drawing.Point(234, 62);
            this.n4_label.Name = "n4_label";
            this.n4_label.Size = new System.Drawing.Size(67, 16);
            this.n4_label.TabIndex = 2;
            this.n4_label.Text = "4° Nota:";
            // 
            // n3_label
            // 
            this.n3_label.AutoSize = true;
            this.n3_label.Location = new System.Drawing.Point(234, 21);
            this.n3_label.Name = "n3_label";
            this.n3_label.Size = new System.Drawing.Size(67, 16);
            this.n3_label.TabIndex = 3;
            this.n3_label.Text = "3° Nota:";
            // 
            // n1_textBox
            // 
            this.n1_textBox.Location = new System.Drawing.Point(88, 21);
            this.n1_textBox.Name = "n1_textBox";
            this.n1_textBox.Size = new System.Drawing.Size(100, 23);
            this.n1_textBox.TabIndex = 4;
            // 
            // n4_textBox
            // 
            this.n4_textBox.Location = new System.Drawing.Point(307, 62);
            this.n4_textBox.Name = "n4_textBox";
            this.n4_textBox.Size = new System.Drawing.Size(100, 23);
            this.n4_textBox.TabIndex = 5;
            // 
            // n3_textBox
            // 
            this.n3_textBox.Location = new System.Drawing.Point(307, 21);
            this.n3_textBox.Name = "n3_textBox";
            this.n3_textBox.Size = new System.Drawing.Size(100, 23);
            this.n3_textBox.TabIndex = 6;
            // 
            // n2_textBox
            // 
            this.n2_textBox.Location = new System.Drawing.Point(88, 62);
            this.n2_textBox.Name = "n2_textBox";
            this.n2_textBox.Size = new System.Drawing.Size(100, 23);
            this.n2_textBox.TabIndex = 7;
            // 
            // res_media_label
            // 
            this.res_media_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res_media_label.Location = new System.Drawing.Point(48, 107);
            this.res_media_label.Name = "res_media_label";
            this.res_media_label.Size = new System.Drawing.Size(370, 26);
            this.res_media_label.TabIndex = 8;
            this.res_media_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(30, 150);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(109, 32);
            this.calc_button.TabIndex = 9;
            this.calc_button.Text = "&Calcular";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // limpar_button
            // 
            this.limpar_button.Location = new System.Drawing.Point(176, 150);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(109, 32);
            this.limpar_button.TabIndex = 10;
            this.limpar_button.Text = "&Limpar";
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.limpar_button_Click);
            // 
            // sair_button
            // 
            this.sair_button.Location = new System.Drawing.Point(318, 150);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(109, 32);
            this.sair_button.TabIndex = 11;
            this.sair_button.Text = "&Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // FormCalcMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(527, 320);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormCalcMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo da Média";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label n4_label;
        private System.Windows.Forms.Label n2_label;
        private System.Windows.Forms.Label n1_label;
        private System.Windows.Forms.TextBox n1_textBox;
        private System.Windows.Forms.Label n3_label;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Label res_media_label;
        private System.Windows.Forms.TextBox n2_textBox;
        private System.Windows.Forms.TextBox n3_textBox;
        private System.Windows.Forms.TextBox n4_textBox;
        private System.Windows.Forms.Button sair_button;
        private System.Windows.Forms.Button limpar_button;
    }
}


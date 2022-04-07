
namespace Ordenar_Nomes {
    partial class FormOrdenarNomes {
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
            this.title_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nome5_textBox = new System.Windows.Forms.TextBox();
            this.nome4_textBox = new System.Windows.Forms.TextBox();
            this.nome3_textBox = new System.Windows.Forms.TextBox();
            this.nome2_textBox = new System.Windows.Forms.TextBox();
            this.nome1_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exibir_nomes_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.limpar_btn = new System.Windows.Forms.Button();
            this.classificar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_label.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(71, 19);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(442, 38);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Lista de Nomes";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nome5_textBox);
            this.groupBox1.Controls.Add(this.nome4_textBox);
            this.groupBox1.Controls.Add(this.nome3_textBox);
            this.groupBox1.Controls.Add(this.nome2_textBox);
            this.groupBox1.Controls.Add(this.nome1_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // nome5_textBox
            // 
            this.nome5_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome5_textBox.Location = new System.Drawing.Point(83, 161);
            this.nome5_textBox.Name = "nome5_textBox";
            this.nome5_textBox.Size = new System.Drawing.Size(232, 23);
            this.nome5_textBox.TabIndex = 9;
            this.nome5_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome5_textBox_KeyDown);
            // 
            // nome4_textBox
            // 
            this.nome4_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome4_textBox.Location = new System.Drawing.Point(83, 132);
            this.nome4_textBox.Name = "nome4_textBox";
            this.nome4_textBox.Size = new System.Drawing.Size(232, 23);
            this.nome4_textBox.TabIndex = 8;
            this.nome4_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome4_textBox_KeyDown);
            // 
            // nome3_textBox
            // 
            this.nome3_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome3_textBox.Location = new System.Drawing.Point(84, 101);
            this.nome3_textBox.Name = "nome3_textBox";
            this.nome3_textBox.Size = new System.Drawing.Size(232, 23);
            this.nome3_textBox.TabIndex = 7;
            this.nome3_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome3_textBox_KeyDown);
            // 
            // nome2_textBox
            // 
            this.nome2_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome2_textBox.Location = new System.Drawing.Point(84, 71);
            this.nome2_textBox.Name = "nome2_textBox";
            this.nome2_textBox.Size = new System.Drawing.Size(232, 23);
            this.nome2_textBox.TabIndex = 6;
            this.nome2_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome2_textBox_KeyDown);
            // 
            // nome1_textBox
            // 
            this.nome1_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome1_textBox.Location = new System.Drawing.Point(84, 38);
            this.nome1_textBox.Name = "nome1_textBox";
            this.nome1_textBox.Size = new System.Drawing.Size(232, 23);
            this.nome1_textBox.TabIndex = 5;
            this.nome1_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome1_textBox_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "5° Nome";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "4° Nome";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "3° Nome";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2° Nome";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1° Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exibir_nomes_label);
            this.groupBox2.Location = new System.Drawing.Point(353, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // exibir_nomes_label
            // 
            this.exibir_nomes_label.Location = new System.Drawing.Point(17, 25);
            this.exibir_nomes_label.Name = "exibir_nomes_label";
            this.exibir_nomes_label.Size = new System.Drawing.Size(178, 170);
            this.exibir_nomes_label.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_fechar);
            this.groupBox3.Controls.Add(this.limpar_btn);
            this.groupBox3.Controls.Add(this.classificar_btn);
            this.groupBox3.Location = new System.Drawing.Point(14, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(395, 23);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(127, 35);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // limpar_btn
            // 
            this.limpar_btn.Location = new System.Drawing.Point(215, 23);
            this.limpar_btn.Name = "limpar_btn";
            this.limpar_btn.Size = new System.Drawing.Size(127, 35);
            this.limpar_btn.TabIndex = 1;
            this.limpar_btn.Text = "&Limpar";
            this.limpar_btn.UseVisualStyleBackColor = true;
            this.limpar_btn.Click += new System.EventHandler(this.limpar_btn_Click);
            // 
            // classificar_btn
            // 
            this.classificar_btn.Location = new System.Drawing.Point(30, 23);
            this.classificar_btn.Name = "classificar_btn";
            this.classificar_btn.Size = new System.Drawing.Size(127, 35);
            this.classificar_btn.TabIndex = 0;
            this.classificar_btn.Text = "&Classificar";
            this.classificar_btn.UseVisualStyleBackColor = true;
            this.classificar_btn.Click += new System.EventHandler(this.classificar_btn_Click);
            // 
            // FormOrdenarNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormOrdenarNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificar Nomes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nome5_textBox;
        private System.Windows.Forms.TextBox nome4_textBox;
        private System.Windows.Forms.TextBox nome3_textBox;
        private System.Windows.Forms.TextBox nome2_textBox;
        private System.Windows.Forms.TextBox nome1_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label exibir_nomes_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button limpar_btn;
        private System.Windows.Forms.Button classificar_btn;
    }
}


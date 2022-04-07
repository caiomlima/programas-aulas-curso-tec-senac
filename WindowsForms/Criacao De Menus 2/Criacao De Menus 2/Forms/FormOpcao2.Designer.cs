
namespace Criacao_De_Menus_2.Forms {
    partial class FormOpcao2 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num1_textBox = new System.Windows.Forms.TextBox();
            this.num2_textBox = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.mult_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulário da Opção 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resultado:";
            // 
            // num1_textBox
            // 
            this.num1_textBox.Location = new System.Drawing.Point(181, 84);
            this.num1_textBox.Name = "num1_textBox";
            this.num1_textBox.Size = new System.Drawing.Size(125, 20);
            this.num1_textBox.TabIndex = 5;
            // 
            // num2_textBox
            // 
            this.num2_textBox.Location = new System.Drawing.Point(181, 134);
            this.num2_textBox.Name = "num2_textBox";
            this.num2_textBox.Size = new System.Drawing.Size(125, 20);
            this.num2_textBox.TabIndex = 6;
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(181, 189);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(125, 20);
            this.result_textBox.TabIndex = 7;
            // 
            // mult_btn
            // 
            this.mult_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_btn.Location = new System.Drawing.Point(444, 120);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(111, 46);
            this.mult_btn.TabIndex = 8;
            this.mult_btn.Text = "Multiplicar";
            this.mult_btn.UseVisualStyleBackColor = true;
            this.mult_btn.Click += new System.EventHandler(this.mult_btn_Click);
            // 
            // FormOpcao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 250);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.num2_textBox);
            this.Controls.Add(this.num1_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOpcao2";
            this.Text = "FormOpcao2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num1_textBox;
        private System.Windows.Forms.TextBox num2_textBox;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button mult_btn;
    }
}
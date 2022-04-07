
namespace Visual_Polimorfismo {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.corre_option = new System.Windows.Forms.RadioButton();
            this.para_option = new System.Windows.Forms.RadioButton();
            this.click_btn = new System.Windows.Forms.Button();
            this.sair_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.para_option);
            this.groupBox1.Controls.Add(this.corre_option);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções para o carro";
            // 
            // corre_option
            // 
            this.corre_option.Location = new System.Drawing.Point(14, 38);
            this.corre_option.Name = "corre_option";
            this.corre_option.Size = new System.Drawing.Size(93, 20);
            this.corre_option.TabIndex = 0;
            this.corre_option.TabStop = true;
            this.corre_option.Text = "Correndo";
            this.corre_option.UseVisualStyleBackColor = true;
            // 
            // para_option
            // 
            this.para_option.Location = new System.Drawing.Point(14, 70);
            this.para_option.Name = "para_option";
            this.para_option.Size = new System.Drawing.Size(86, 20);
            this.para_option.TabIndex = 1;
            this.para_option.TabStop = true;
            this.para_option.Text = "Parar";
            this.para_option.UseVisualStyleBackColor = true;
            // 
            // click_btn
            // 
            this.click_btn.Location = new System.Drawing.Point(12, 127);
            this.click_btn.Name = "click_btn";
            this.click_btn.Size = new System.Drawing.Size(83, 36);
            this.click_btn.TabIndex = 1;
            this.click_btn.Text = "&Clique";
            this.click_btn.UseVisualStyleBackColor = true;
            this.click_btn.Click += new System.EventHandler(this.click_btn_Click);
            // 
            // sair_btn
            // 
            this.sair_btn.Location = new System.Drawing.Point(129, 127);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.Size = new System.Drawing.Size(83, 36);
            this.sair_btn.TabIndex = 2;
            this.sair_btn.Text = "&Sair";
            this.sair_btn.UseVisualStyleBackColor = true;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 178);
            this.Controls.Add(this.sair_btn);
            this.Controls.Add(this.click_btn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polimorfismo em C#";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton para_option;
        private System.Windows.Forms.RadioButton corre_option;
        private System.Windows.Forms.Button click_btn;
        private System.Windows.Forms.Button sair_btn;
    }
}


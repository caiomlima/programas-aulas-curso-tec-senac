
namespace Criacao_De_Menus_2 {
    partial class Acesso {
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
            this.senha_textBox = new System.Windows.Forms.TextBox();
            this.acessar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senha_textBox
            // 
            this.senha_textBox.Location = new System.Drawing.Point(65, 45);
            this.senha_textBox.Name = "senha_textBox";
            this.senha_textBox.Size = new System.Drawing.Size(115, 20);
            this.senha_textBox.TabIndex = 0;
            // 
            // acessar_btn
            // 
            this.acessar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessar_btn.Location = new System.Drawing.Point(65, 103);
            this.acessar_btn.Name = "acessar_btn";
            this.acessar_btn.Size = new System.Drawing.Size(115, 55);
            this.acessar_btn.TabIndex = 1;
            this.acessar_btn.Text = "Acessar";
            this.acessar_btn.UseVisualStyleBackColor = true;
            this.acessar_btn.Click += new System.EventHandler(this.acessar_btn_Click);
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 201);
            this.Controls.Add(this.acessar_btn);
            this.Controls.Add(this.senha_textBox);
            this.Name = "Acesso";
            this.Text = "Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senha_textBox;
        private System.Windows.Forms.Button acessar_btn;
    }
}
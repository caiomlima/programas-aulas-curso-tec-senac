
namespace Classe_Visual {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.idade_textBox = new System.Windows.Forms.TextBox();
            this.processar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.sair_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua idade:";
            // 
            // nome_textBox
            // 
            this.nome_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_textBox.Location = new System.Drawing.Point(178, 21);
            this.nome_textBox.MaxLength = 35;
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(223, 23);
            this.nome_textBox.TabIndex = 2;
            // 
            // idade_textBox
            // 
            this.idade_textBox.Location = new System.Drawing.Point(177, 62);
            this.idade_textBox.Name = "idade_textBox";
            this.idade_textBox.Size = new System.Drawing.Size(224, 23);
            this.idade_textBox.TabIndex = 3;
            // 
            // processar_btn
            // 
            this.processar_btn.Location = new System.Drawing.Point(65, 101);
            this.processar_btn.Name = "processar_btn";
            this.processar_btn.Size = new System.Drawing.Size(100, 29);
            this.processar_btn.TabIndex = 4;
            this.processar_btn.Text = "Processar";
            this.processar_btn.UseVisualStyleBackColor = true;
            this.processar_btn.Click += new System.EventHandler(this.processar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(183, 101);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(100, 29);
            this.cancelar_btn.TabIndex = 5;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // sair_btn
            // 
            this.sair_btn.Location = new System.Drawing.Point(301, 101);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.Size = new System.Drawing.Size(100, 29);
            this.sair_btn.TabIndex = 6;
            this.sair_btn.Text = "Sair";
            this.sair_btn.UseVisualStyleBackColor = true;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 142);
            this.Controls.Add(this.sair_btn);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.processar_btn);
            this.Controls.Add(this.idade_textBox);
            this.Controls.Add(this.nome_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes Modo Visual C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.TextBox idade_textBox;
        private System.Windows.Forms.Button processar_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button sair_btn;
    }
}


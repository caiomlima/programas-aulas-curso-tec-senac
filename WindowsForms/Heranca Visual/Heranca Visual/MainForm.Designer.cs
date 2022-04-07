
namespace Heranca_Visual {
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.endereco_textBox = new System.Windows.Forms.TextBox();
            this.cidade_textBox = new System.Windows.Forms.TextBox();
            this.funcao_textBox = new System.Windows.Forms.TextBox();
            this.telefone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.salario_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.confirmar_btn = new System.Windows.Forms.Button();
            this.sair_btn = new System.Windows.Forms.Button();
            this.limpar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Função:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salário:";
            // 
            // nome_textBox
            // 
            this.nome_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_textBox.Location = new System.Drawing.Point(132, 6);
            this.nome_textBox.MaxLength = 50;
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(376, 26);
            this.nome_textBox.TabIndex = 6;
            // 
            // endereco_textBox
            // 
            this.endereco_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.endereco_textBox.Location = new System.Drawing.Point(132, 49);
            this.endereco_textBox.MaxLength = 100;
            this.endereco_textBox.Name = "endereco_textBox";
            this.endereco_textBox.Size = new System.Drawing.Size(376, 26);
            this.endereco_textBox.TabIndex = 7;
            // 
            // cidade_textBox
            // 
            this.cidade_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cidade_textBox.Location = new System.Drawing.Point(132, 95);
            this.cidade_textBox.MaxLength = 50;
            this.cidade_textBox.Name = "cidade_textBox";
            this.cidade_textBox.Size = new System.Drawing.Size(376, 26);
            this.cidade_textBox.TabIndex = 8;
            // 
            // funcao_textBox
            // 
            this.funcao_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.funcao_textBox.Location = new System.Drawing.Point(132, 182);
            this.funcao_textBox.MaxLength = 50;
            this.funcao_textBox.Name = "funcao_textBox";
            this.funcao_textBox.Size = new System.Drawing.Size(376, 26);
            this.funcao_textBox.TabIndex = 10;
            // 
            // telefone_maskedTextBox
            // 
            this.telefone_maskedTextBox.Location = new System.Drawing.Point(132, 139);
            this.telefone_maskedTextBox.Mask = "(99)99999-9999";
            this.telefone_maskedTextBox.Name = "telefone_maskedTextBox";
            this.telefone_maskedTextBox.Size = new System.Drawing.Size(138, 26);
            this.telefone_maskedTextBox.TabIndex = 11;
            // 
            // salario_maskedTextBox
            // 
            this.salario_maskedTextBox.Location = new System.Drawing.Point(132, 224);
            this.salario_maskedTextBox.Mask = "999,999.99";
            this.salario_maskedTextBox.Name = "salario_maskedTextBox";
            this.salario_maskedTextBox.Size = new System.Drawing.Size(138, 26);
            this.salario_maskedTextBox.TabIndex = 12;
            // 
            // confirmar_btn
            // 
            this.confirmar_btn.Location = new System.Drawing.Point(60, 279);
            this.confirmar_btn.Name = "confirmar_btn";
            this.confirmar_btn.Size = new System.Drawing.Size(98, 37);
            this.confirmar_btn.TabIndex = 13;
            this.confirmar_btn.Text = "&Confirmar";
            this.confirmar_btn.UseVisualStyleBackColor = true;
            this.confirmar_btn.Click += new System.EventHandler(this.confirmar_btn_Click);
            // 
            // sair_btn
            // 
            this.sair_btn.Location = new System.Drawing.Point(366, 279);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.Size = new System.Drawing.Size(98, 37);
            this.sair_btn.TabIndex = 14;
            this.sair_btn.Text = "&Sair";
            this.sair_btn.UseVisualStyleBackColor = true;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // limpar_btn
            // 
            this.limpar_btn.Location = new System.Drawing.Point(211, 279);
            this.limpar_btn.Name = "limpar_btn";
            this.limpar_btn.Size = new System.Drawing.Size(98, 37);
            this.limpar_btn.TabIndex = 15;
            this.limpar_btn.Text = "&Limpar";
            this.limpar_btn.UseVisualStyleBackColor = true;
            this.limpar_btn.Click += new System.EventHandler(this.limpar_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 328);
            this.Controls.Add(this.limpar_btn);
            this.Controls.Add(this.sair_btn);
            this.Controls.Add(this.confirmar_btn);
            this.Controls.Add(this.salario_maskedTextBox);
            this.Controls.Add(this.telefone_maskedTextBox);
            this.Controls.Add(this.funcao_textBox);
            this.Controls.Add(this.cidade_textBox);
            this.Controls.Add(this.endereco_textBox);
            this.Controls.Add(this.nome_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herança em C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.TextBox endereco_textBox;
        private System.Windows.Forms.TextBox cidade_textBox;
        private System.Windows.Forms.TextBox funcao_textBox;
        private System.Windows.Forms.MaskedTextBox telefone_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox salario_maskedTextBox;
        private System.Windows.Forms.Button confirmar_btn;
        private System.Windows.Forms.Button sair_btn;
        private System.Windows.Forms.Button limpar_btn;
    }
}


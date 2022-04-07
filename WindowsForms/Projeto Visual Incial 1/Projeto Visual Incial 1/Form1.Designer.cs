
namespace Projeto_Visual_Incial_1 {
    partial class Form_saudacao {
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
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_nome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(37, 75);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(601, 31);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Eae mano, escreve seu nome na caixinha abaixo";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(177, 151);
            this.textBox_nome.Multiline = true;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(309, 39);
            this.textBox_nome.TabIndex = 1;
            // 
            // button_nome
            // 
            this.button_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nome.Location = new System.Drawing.Point(274, 212);
            this.button_nome.Name = "button_nome";
            this.button_nome.Size = new System.Drawing.Size(114, 39);
            this.button_nome.TabIndex = 2;
            this.button_nome.Text = "Clique Aqui";
            this.button_nome.UseVisualStyleBackColor = true;
            this.button_nome.Click += new System.EventHandler(this.button_nome_Click);
            // 
            // Form_saudacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(674, 287);
            this.Controls.Add(this.button_nome);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_saudacao";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa que dá Bom Dia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_nome;
    }
}


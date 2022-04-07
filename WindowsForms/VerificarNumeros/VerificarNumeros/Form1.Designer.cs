
namespace VerificarNumeros {
    partial class FrmVerifica {
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
            this.num_label = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.res_label = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.sair_button = new System.Windows.Forms.Button();
            this.limpa_button = new System.Windows.Forms.Button();
            this.verifica_button = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_label
            // 
            this.num_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.Location = new System.Drawing.Point(12, 38);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(133, 18);
            this.num_label.TabIndex = 0;
            this.num_label.Text = "Digite um número:";
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(155, 35);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(151, 22);
            this.num_textBox.TabIndex = 1;
            this.num_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // res_label
            // 
            this.res_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_label.Location = new System.Drawing.Point(12, 83);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(335, 24);
            this.res_label.TabIndex = 2;
            this.res_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.sair_button);
            this.groupBox.Controls.Add(this.limpa_button);
            this.groupBox.Controls.Add(this.verifica_button);
            this.groupBox.Location = new System.Drawing.Point(8, 150);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(339, 59);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // sair_button
            // 
            this.sair_button.Location = new System.Drawing.Point(240, 21);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(75, 23);
            this.sair_button.TabIndex = 2;
            this.sair_button.Text = "&Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // limpa_button
            // 
            this.limpa_button.Location = new System.Drawing.Point(134, 21);
            this.limpa_button.Name = "limpa_button";
            this.limpa_button.Size = new System.Drawing.Size(75, 23);
            this.limpa_button.TabIndex = 1;
            this.limpa_button.Text = "&Limpar";
            this.limpa_button.UseVisualStyleBackColor = true;
            this.limpa_button.Click += new System.EventHandler(this.limpa_button_Click);
            // 
            // verifica_button
            // 
            this.verifica_button.Location = new System.Drawing.Point(25, 21);
            this.verifica_button.Name = "verifica_button";
            this.verifica_button.Size = new System.Drawing.Size(75, 23);
            this.verifica_button.TabIndex = 0;
            this.verifica_button.Text = "&Verifica";
            this.verifica_button.UseVisualStyleBackColor = true;
            this.verifica_button.Click += new System.EventHandler(this.verifica_button_Click);
            // 
            // FrmVerifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(359, 233);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.num_textBox);
            this.Controls.Add(this.num_label);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Números - Pares ou Ímpares";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button sair_button;
        private System.Windows.Forms.Button limpa_button;
        private System.Windows.Forms.Button verifica_button;
    }
}


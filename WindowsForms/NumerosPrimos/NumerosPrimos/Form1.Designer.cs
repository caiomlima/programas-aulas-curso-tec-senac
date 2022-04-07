
namespace NumerosPrimos {
    partial class Primos_Form {
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.sair_button = new System.Windows.Forms.Button();
            this.limpar_button = new System.Windows.Forms.Button();
            this.confirmar_button = new System.Windows.Forms.Button();
            this.res_label = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_label
            // 
            this.num_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.Location = new System.Drawing.Point(30, 36);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(130, 18);
            this.num_label.TabIndex = 0;
            this.num_label.Text = "Digite um número:";
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(170, 33);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(176, 22);
            this.num_textBox.TabIndex = 2;
            this.num_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.sair_button);
            this.groupBox.Controls.Add(this.limpar_button);
            this.groupBox.Controls.Add(this.confirmar_button);
            this.groupBox.Location = new System.Drawing.Point(12, 134);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(354, 82);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // sair_button
            // 
            this.sair_button.Location = new System.Drawing.Point(252, 32);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(82, 23);
            this.sair_button.TabIndex = 2;
            this.sair_button.Text = "&Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // limpar_button
            // 
            this.limpar_button.Location = new System.Drawing.Point(136, 32);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(82, 23);
            this.limpar_button.TabIndex = 1;
            this.limpar_button.Text = "&Limpar";
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.limpar_button_Click);
            // 
            // confirmar_button
            // 
            this.confirmar_button.Location = new System.Drawing.Point(21, 32);
            this.confirmar_button.Name = "confirmar_button";
            this.confirmar_button.Size = new System.Drawing.Size(82, 23);
            this.confirmar_button.TabIndex = 0;
            this.confirmar_button.Text = "&Confirmar";
            this.confirmar_button.UseVisualStyleBackColor = true;
            this.confirmar_button.Click += new System.EventHandler(this.confirmar_button_Click);
            // 
            // res_label
            // 
            this.res_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res_label.Location = new System.Drawing.Point(33, 84);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(313, 26);
            this.res_label.TabIndex = 4;
            this.res_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Primos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(378, 228);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.num_textBox);
            this.Controls.Add(this.num_label);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Primos_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador de Números Primos";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button sair_button;
        private System.Windows.Forms.Button limpar_button;
        private System.Windows.Forms.Button confirmar_button;
        private System.Windows.Forms.Label res_label;
    }
}



namespace Lista_De_Nomes {
    partial class form_lista_nomes {
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
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.nome_listBox = new System.Windows.Forms.ListBox();
            this.adc_btn = new System.Windows.Forms.Button();
            this.remov_btn = new System.Windows.Forms.Button();
            this.remov_tudo_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.sair_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item para a Lista";
            // 
            // nome_textBox
            // 
            this.nome_textBox.Location = new System.Drawing.Point(146, 28);
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(226, 23);
            this.nome_textBox.TabIndex = 1;
            this.nome_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nome_listBox
            // 
            this.nome_listBox.FormattingEnabled = true;
            this.nome_listBox.ItemHeight = 16;
            this.nome_listBox.Location = new System.Drawing.Point(14, 73);
            this.nome_listBox.Name = "nome_listBox";
            this.nome_listBox.Size = new System.Drawing.Size(213, 276);
            this.nome_listBox.Sorted = true;
            this.nome_listBox.TabIndex = 2;
            // 
            // adc_btn
            // 
            this.adc_btn.Location = new System.Drawing.Point(246, 97);
            this.adc_btn.Name = "adc_btn";
            this.adc_btn.Size = new System.Drawing.Size(126, 32);
            this.adc_btn.TabIndex = 3;
            this.adc_btn.Text = "&Adicionar";
            this.adc_btn.UseVisualStyleBackColor = true;
            this.adc_btn.Click += new System.EventHandler(this.adc_btn_Click);
            // 
            // remov_btn
            // 
            this.remov_btn.Location = new System.Drawing.Point(246, 146);
            this.remov_btn.Name = "remov_btn";
            this.remov_btn.Size = new System.Drawing.Size(126, 32);
            this.remov_btn.TabIndex = 4;
            this.remov_btn.Text = "&Remover";
            this.remov_btn.UseVisualStyleBackColor = true;
            this.remov_btn.Click += new System.EventHandler(this.remov_btn_Click);
            // 
            // remov_tudo_btn
            // 
            this.remov_tudo_btn.Location = new System.Drawing.Point(246, 194);
            this.remov_tudo_btn.Name = "remov_tudo_btn";
            this.remov_tudo_btn.Size = new System.Drawing.Size(126, 32);
            this.remov_tudo_btn.TabIndex = 5;
            this.remov_tudo_btn.Text = "&Remover Tudo";
            this.remov_tudo_btn.UseVisualStyleBackColor = true;
            this.remov_tudo_btn.Click += new System.EventHandler(this.remov_tudo_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(246, 241);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(126, 32);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "&Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // sair_btn
            // 
            this.sair_btn.Location = new System.Drawing.Point(246, 289);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.Size = new System.Drawing.Size(126, 32);
            this.sair_btn.TabIndex = 7;
            this.sair_btn.Text = "&Sair";
            this.sair_btn.UseVisualStyleBackColor = true;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // form_lista_nomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.sair_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.remov_tudo_btn);
            this.Controls.Add(this.remov_btn);
            this.Controls.Add(this.adc_btn);
            this.Controls.Add(this.nome_listBox);
            this.Controls.Add(this.nome_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_lista_nomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.ListBox nome_listBox;
        private System.Windows.Forms.Button adc_btn;
        private System.Windows.Forms.Button remov_btn;
        private System.Windows.Forms.Button remov_tudo_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button sair_btn;
    }
}


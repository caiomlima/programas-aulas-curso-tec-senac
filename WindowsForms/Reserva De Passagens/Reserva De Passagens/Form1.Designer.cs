
namespace Reserva_De_Passagens {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titulo_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.destino_label = new System.Windows.Forms.Label();
            this.data_emb_label = new System.Windows.Forms.Label();
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.destino_comboBox = new System.Windows.Forms.ComboBox();
            this.embarque_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transporte_groupBox = new System.Windows.Forms.GroupBox();
            this.onibus_radioButton = new System.Windows.Forms.RadioButton();
            this.aviao_radioButton = new System.Windows.Forms.RadioButton();
            this.valores_groupBox = new System.Windows.Forms.GroupBox();
            this.res_gasto_dest_label = new System.Windows.Forms.Label();
            this.res_gasto_transp_label = new System.Windows.Forms.Label();
            this.valor_total_label = new System.Windows.Forms.Label();
            this.gasto_dest_label = new System.Windows.Forms.Label();
            this.gasto_transp_label = new System.Windows.Forms.Label();
            this.sair_button = new System.Windows.Forms.Button();
            this.confirmar_button = new System.Windows.Forms.Button();
            this.limpar_button = new System.Windows.Forms.Button();
            this.calc_button = new System.Windows.Forms.Button();
            this.calc_final_button = new System.Windows.Forms.Button();
            this.res_valor_total_textBox = new System.Windows.Forms.TextBox();
            this.transporte_groupBox.SuspendLayout();
            this.valores_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(12, 9);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(776, 41);
            this.titulo_label.TabIndex = 0;
            this.titulo_label.Text = "Reserva de Passagem";
            this.titulo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(61, 87);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(55, 20);
            this.nome_label.TabIndex = 1;
            this.nome_label.Text = "Nome:";
            // 
            // destino_label
            // 
            this.destino_label.AutoSize = true;
            this.destino_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino_label.Location = new System.Drawing.Point(61, 130);
            this.destino_label.Name = "destino_label";
            this.destino_label.Size = new System.Drawing.Size(68, 20);
            this.destino_label.TabIndex = 2;
            this.destino_label.Text = "Destino:";
            // 
            // data_emb_label
            // 
            this.data_emb_label.AutoSize = true;
            this.data_emb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_emb_label.Location = new System.Drawing.Point(61, 172);
            this.data_emb_label.Name = "data_emb_label";
            this.data_emb_label.Size = new System.Drawing.Size(124, 20);
            this.data_emb_label.TabIndex = 3;
            this.data_emb_label.Text = "Data embarque:";
            // 
            // nome_textBox
            // 
            this.nome_textBox.Location = new System.Drawing.Point(145, 87);
            this.nome_textBox.Multiline = true;
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(150, 20);
            this.nome_textBox.TabIndex = 4;
            // 
            // destino_comboBox
            // 
            this.destino_comboBox.FormattingEnabled = true;
            this.destino_comboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.destino_comboBox.Location = new System.Drawing.Point(145, 129);
            this.destino_comboBox.Name = "destino_comboBox";
            this.destino_comboBox.Size = new System.Drawing.Size(150, 21);
            this.destino_comboBox.TabIndex = 5;
            // 
            // embarque_dateTimePicker
            // 
            this.embarque_dateTimePicker.Location = new System.Drawing.Point(200, 172);
            this.embarque_dateTimePicker.Name = "embarque_dateTimePicker";
            this.embarque_dateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.embarque_dateTimePicker.TabIndex = 6;
            // 
            // transporte_groupBox
            // 
            this.transporte_groupBox.Controls.Add(this.onibus_radioButton);
            this.transporte_groupBox.Controls.Add(this.aviao_radioButton);
            this.transporte_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transporte_groupBox.Location = new System.Drawing.Point(65, 219);
            this.transporte_groupBox.Name = "transporte_groupBox";
            this.transporte_groupBox.Size = new System.Drawing.Size(174, 60);
            this.transporte_groupBox.TabIndex = 7;
            this.transporte_groupBox.TabStop = false;
            this.transporte_groupBox.Text = "Meio de transporte";
            // 
            // onibus_radioButton
            // 
            this.onibus_radioButton.AutoSize = true;
            this.onibus_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onibus_radioButton.Location = new System.Drawing.Point(92, 30);
            this.onibus_radioButton.Name = "onibus_radioButton";
            this.onibus_radioButton.Size = new System.Drawing.Size(77, 24);
            this.onibus_radioButton.TabIndex = 1;
            this.onibus_radioButton.TabStop = true;
            this.onibus_radioButton.Text = "Ônibus";
            this.onibus_radioButton.UseVisualStyleBackColor = true;
            // 
            // aviao_radioButton
            // 
            this.aviao_radioButton.AutoSize = true;
            this.aviao_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviao_radioButton.Location = new System.Drawing.Point(6, 30);
            this.aviao_radioButton.Name = "aviao_radioButton";
            this.aviao_radioButton.Size = new System.Drawing.Size(66, 24);
            this.aviao_radioButton.TabIndex = 0;
            this.aviao_radioButton.TabStop = true;
            this.aviao_radioButton.Text = "Avião";
            this.aviao_radioButton.UseVisualStyleBackColor = true;
            // 
            // valores_groupBox
            // 
            this.valores_groupBox.Controls.Add(this.res_valor_total_textBox);
            this.valores_groupBox.Controls.Add(this.res_gasto_dest_label);
            this.valores_groupBox.Controls.Add(this.res_gasto_transp_label);
            this.valores_groupBox.Controls.Add(this.valor_total_label);
            this.valores_groupBox.Controls.Add(this.gasto_dest_label);
            this.valores_groupBox.Controls.Add(this.gasto_transp_label);
            this.valores_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valores_groupBox.Location = new System.Drawing.Point(65, 304);
            this.valores_groupBox.Name = "valores_groupBox";
            this.valores_groupBox.Size = new System.Drawing.Size(368, 137);
            this.valores_groupBox.TabIndex = 8;
            this.valores_groupBox.TabStop = false;
            this.valores_groupBox.Text = "Valores do Pacote";
            this.valores_groupBox.Visible = false;
            // 
            // res_gasto_dest_label
            // 
            this.res_gasto_dest_label.AutoSize = true;
            this.res_gasto_dest_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_gasto_dest_label.Location = new System.Drawing.Point(176, 68);
            this.res_gasto_dest_label.Name = "res_gasto_dest_label";
            this.res_gasto_dest_label.Size = new System.Drawing.Size(0, 18);
            this.res_gasto_dest_label.TabIndex = 4;
            // 
            // res_gasto_transp_label
            // 
            this.res_gasto_transp_label.AutoSize = true;
            this.res_gasto_transp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_gasto_transp_label.Location = new System.Drawing.Point(176, 36);
            this.res_gasto_transp_label.Name = "res_gasto_transp_label";
            this.res_gasto_transp_label.Size = new System.Drawing.Size(0, 18);
            this.res_gasto_transp_label.TabIndex = 3;
            // 
            // valor_total_label
            // 
            this.valor_total_label.AutoSize = true;
            this.valor_total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_total_label.Location = new System.Drawing.Point(7, 100);
            this.valor_total_label.Name = "valor_total_label";
            this.valor_total_label.Size = new System.Drawing.Size(83, 18);
            this.valor_total_label.TabIndex = 2;
            this.valor_total_label.Text = "Valor Total:";
            // 
            // gasto_dest_label
            // 
            this.gasto_dest_label.AutoSize = true;
            this.gasto_dest_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasto_dest_label.Location = new System.Drawing.Point(7, 68);
            this.gasto_dest_label.Name = "gasto_dest_label";
            this.gasto_dest_label.Size = new System.Drawing.Size(142, 18);
            this.gasto_dest_label.TabIndex = 1;
            this.gasto_dest_label.Text = "Gasto com Destino:";
            // 
            // gasto_transp_label
            // 
            this.gasto_transp_label.AutoSize = true;
            this.gasto_transp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasto_transp_label.Location = new System.Drawing.Point(7, 36);
            this.gasto_transp_label.Name = "gasto_transp_label";
            this.gasto_transp_label.Size = new System.Drawing.Size(150, 18);
            this.gasto_transp_label.TabIndex = 0;
            this.gasto_transp_label.Text = "Gasto do Transporte:";
            // 
            // sair_button
            // 
            this.sair_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair_button.Location = new System.Drawing.Point(698, 87);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(90, 34);
            this.sair_button.TabIndex = 13;
            this.sair_button.Text = "Sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // confirmar_button
            // 
            this.confirmar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar_button.Location = new System.Drawing.Point(698, 135);
            this.confirmar_button.Name = "confirmar_button";
            this.confirmar_button.Size = new System.Drawing.Size(90, 34);
            this.confirmar_button.TabIndex = 14;
            this.confirmar_button.Text = "Confirmar";
            this.confirmar_button.UseVisualStyleBackColor = true;
            this.confirmar_button.Click += new System.EventHandler(this.confirmar_button_Click);
            // 
            // limpar_button
            // 
            this.limpar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar_button.Location = new System.Drawing.Point(698, 184);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(90, 34);
            this.limpar_button.TabIndex = 15;
            this.limpar_button.Text = "Limpar";
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.limpar_button_Click);
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_button.Location = new System.Drawing.Point(698, 231);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(90, 34);
            this.calc_button.TabIndex = 16;
            this.calc_button.Text = "Calculadora";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // calc_final_button
            // 
            this.calc_final_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_final_button.Location = new System.Drawing.Point(698, 281);
            this.calc_final_button.Name = "calc_final_button";
            this.calc_final_button.Size = new System.Drawing.Size(90, 62);
            this.calc_final_button.TabIndex = 17;
            this.calc_final_button.Text = "Calcular Valor da Passagem";
            this.calc_final_button.UseVisualStyleBackColor = true;
            this.calc_final_button.Click += new System.EventHandler(this.calc_final_button_Click);
            // 
            // res_valor_total_textBox
            // 
            this.res_valor_total_textBox.Enabled = false;
            this.res_valor_total_textBox.Location = new System.Drawing.Point(179, 100);
            this.res_valor_total_textBox.Name = "res_valor_total_textBox";
            this.res_valor_total_textBox.Size = new System.Drawing.Size(118, 26);
            this.res_valor_total_textBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(842, 515);
            this.Controls.Add(this.calc_final_button);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.limpar_button);
            this.Controls.Add(this.confirmar_button);
            this.Controls.Add(this.sair_button);
            this.Controls.Add(this.valores_groupBox);
            this.Controls.Add(this.transporte_groupBox);
            this.Controls.Add(this.embarque_dateTimePicker);
            this.Controls.Add(this.destino_comboBox);
            this.Controls.Add(this.nome_textBox);
            this.Controls.Add(this.data_emb_label);
            this.Controls.Add(this.destino_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.titulo_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agência de Passagens";
            this.transporte_groupBox.ResumeLayout(false);
            this.transporte_groupBox.PerformLayout();
            this.valores_groupBox.ResumeLayout(false);
            this.valores_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label destino_label;
        private System.Windows.Forms.Label data_emb_label;
        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.ComboBox destino_comboBox;
        private System.Windows.Forms.DateTimePicker embarque_dateTimePicker;
        private System.Windows.Forms.GroupBox transporte_groupBox;
        private System.Windows.Forms.RadioButton onibus_radioButton;
        private System.Windows.Forms.RadioButton aviao_radioButton;
        private System.Windows.Forms.GroupBox valores_groupBox;
        private System.Windows.Forms.Label valor_total_label;
        private System.Windows.Forms.Label gasto_dest_label;
        private System.Windows.Forms.Label gasto_transp_label;
        private System.Windows.Forms.Button sair_button;
        private System.Windows.Forms.Button confirmar_button;
        private System.Windows.Forms.Label res_gasto_dest_label;
        private System.Windows.Forms.Label res_gasto_transp_label;
        private System.Windows.Forms.Button limpar_button;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Button calc_final_button;
        private System.Windows.Forms.TextBox res_valor_total_textBox;
    }
}



namespace Visualiza_Imagem {
    partial class form_imagem {
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
            this.img_pictureBox = new System.Windows.Forms.PictureBox();
            this.abrir_btn = new System.Windows.Forms.Button();
            this.sair_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.img_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // img_pictureBox
            // 
            this.img_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.img_pictureBox.Name = "img_pictureBox";
            this.img_pictureBox.Size = new System.Drawing.Size(516, 384);
            this.img_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_pictureBox.TabIndex = 0;
            this.img_pictureBox.TabStop = false;
            // 
            // abrir_btn
            // 
            this.abrir_btn.Location = new System.Drawing.Point(355, 415);
            this.abrir_btn.Name = "abrir_btn";
            this.abrir_btn.Size = new System.Drawing.Size(75, 47);
            this.abrir_btn.TabIndex = 1;
            this.abrir_btn.Text = "Abrir";
            this.abrir_btn.UseVisualStyleBackColor = true;
            this.abrir_btn.Click += new System.EventHandler(this.abrir_btn_Click);
            // 
            // sair_btn
            // 
            this.sair_btn.Location = new System.Drawing.Point(453, 415);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.Size = new System.Drawing.Size(75, 47);
            this.sair_btn.TabIndex = 2;
            this.sair_btn.Text = "Sair";
            this.sair_btn.UseVisualStyleBackColor = true;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Arquivos de Imagens | *.*";
            this.openFileDialog.InitialDirectory = "D:\\";
            // 
            // form_imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(540, 517);
            this.Controls.Add(this.sair_btn);
            this.Controls.Add(this.abrir_btn);
            this.Controls.Add(this.img_pictureBox);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_imagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.img_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_pictureBox;
        private System.Windows.Forms.Button abrir_btn;
        private System.Windows.Forms.Button sair_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


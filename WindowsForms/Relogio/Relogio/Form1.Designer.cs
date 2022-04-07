
namespace Relogio {
    partial class form_relogio {
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
            this.components = new System.ComponentModel.Container();
            this.label_relogio = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.StatusStrip();
            this.timer_counter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_relogio
            // 
            this.label_relogio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_relogio.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_relogio.Location = new System.Drawing.Point(130, 35);
            this.label_relogio.Name = "label_relogio";
            this.label_relogio.Size = new System.Drawing.Size(161, 50);
            this.label_relogio.TabIndex = 0;
            this.label_relogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_relogio.Click += new System.EventHandler(this.label_relogio_Click);
            // 
            // label_data
            // 
            this.label_data.Location = new System.Drawing.Point(0, 115);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(410, 22);
            this.label_data.TabIndex = 1;
            // 
            // timer_counter
            // 
            this.timer_counter.Enabled = true;
            this.timer_counter.Interval = 1000;
            this.timer_counter.Tick += new System.EventHandler(this.timer_counter_Tick);
            // 
            // form_relogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(410, 137);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_relogio);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_relogio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_relogio;
        private System.Windows.Forms.StatusStrip label_data;
        private System.Windows.Forms.Timer timer_counter;
    }
}


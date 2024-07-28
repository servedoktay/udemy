namespace _22.Pratik_Örnek___Öğrenci_Sınav_Durumu_Hesaplama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.Proje = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınav1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(129, 47);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(100, 26);
            this.txtSinav1.TabIndex = 1;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(129, 81);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(100, 26);
            this.txtSinav2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınav2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProje
            // 
            this.txtProje.Location = new System.Drawing.Point(129, 118);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(100, 26);
            this.txtProje.TabIndex = 5;
            this.txtProje.TextChanged += new System.EventHandler(this.txtSinav3_TextChanged);
            // 
            // Proje
            // 
            this.Proje.AutoSize = true;
            this.Proje.Location = new System.Drawing.Point(51, 118);
            this.Proje.Name = "Proje";
            this.Proje.Size = new System.Drawing.Size(44, 19);
            this.Proje.TabIndex = 4;
            this.Proje.Text = "Proje";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Enabled = false;
            this.txtOrtalama.Location = new System.Drawing.Point(129, 150);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 26);
            this.txtOrtalama.TabIndex = 7;
            this.txtOrtalama.TextChanged += new System.EventHandler(this.txtOrtalama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ortalama";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(154, 182);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "button1";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProje);
            this.Controls.Add(this.Proje);
            this.Controls.Add(this.txtSinav2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSinav1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.Label Proje;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
    }
}


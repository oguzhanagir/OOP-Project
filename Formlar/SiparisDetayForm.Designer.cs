
namespace Proje2
{
    partial class SiparisDetayi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblÖdemeBilgi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBitis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblÜrününFiyati = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKargoÜcreti = new System.Windows.Forms.Label();
            this.lblToplamAgirlik = new System.Windows.Forms.Label();
            this.lblVergiTutari = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblÜrünAd = new System.Windows.Forms.Label();
            this.lblKapıdaÖdeme = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 40);
            this.panel1.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(715, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(755, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblÖdemeBilgi
            // 
            this.lblÖdemeBilgi.AutoSize = true;
            this.lblÖdemeBilgi.Location = new System.Drawing.Point(94, 365);
            this.lblÖdemeBilgi.Name = "lblÖdemeBilgi";
            this.lblÖdemeBilgi.Size = new System.Drawing.Size(0, 17);
            this.lblÖdemeBilgi.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(92, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Ödeme Seçenekleri";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(97, 279);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.Text = "Havale";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(97, 205);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 21);
            this.checkBox2.TabIndex = 53;
            this.checkBox2.Text = "Kapıda Ödeme";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 21);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Kredi Kartı ile Ödeme";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnBitis
            // 
            this.btnBitis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBitis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitis.Location = new System.Drawing.Point(373, 427);
            this.btnBitis.Name = "btnBitis";
            this.btnBitis.Size = new System.Drawing.Size(224, 69);
            this.btnBitis.TabIndex = 51;
            this.btnBitis.Text = "Ödeme Ekranına Git";
            this.btnBitis.UseVisualStyleBackColor = true;
            this.btnBitis.Click += new System.EventHandler(this.btnBitis_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.lblÜrününFiyati);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lblToplamTutar);
            this.groupBox1.Controls.Add(this.lblKargoÜcreti);
            this.groupBox1.Controls.Add(this.lblToplamAgirlik);
            this.groupBox1.Controls.Add(this.lblVergiTutari);
            this.groupBox1.Controls.Add(this.lblAdet);
            this.groupBox1.Controls.Add(this.lblÜrünAd);
            this.groupBox1.Controls.Add(this.lblKapıdaÖdeme);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(373, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 274);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // lblÜrününFiyati
            // 
            this.lblÜrününFiyati.AutoSize = true;
            this.lblÜrününFiyati.Location = new System.Drawing.Point(201, 78);
            this.lblÜrününFiyati.Name = "lblÜrününFiyati";
            this.lblÜrününFiyati.Size = new System.Drawing.Size(54, 17);
            this.lblÜrününFiyati.TabIndex = 15;
            this.lblÜrününFiyati.Text = "label19";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 14;
            this.label19.Text = "Ürünün Fiyatı";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(201, 221);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(54, 17);
            this.lblToplamTutar.TabIndex = 13;
            this.lblToplamTutar.Text = "label19";
            // 
            // lblKargoÜcreti
            // 
            this.lblKargoÜcreti.AutoSize = true;
            this.lblKargoÜcreti.Location = new System.Drawing.Point(201, 152);
            this.lblKargoÜcreti.Name = "lblKargoÜcreti";
            this.lblKargoÜcreti.Size = new System.Drawing.Size(54, 17);
            this.lblKargoÜcreti.TabIndex = 12;
            this.lblKargoÜcreti.Text = "label19";
            // 
            // lblToplamAgirlik
            // 
            this.lblToplamAgirlik.AutoSize = true;
            this.lblToplamAgirlik.Location = new System.Drawing.Point(201, 125);
            this.lblToplamAgirlik.Name = "lblToplamAgirlik";
            this.lblToplamAgirlik.Size = new System.Drawing.Size(54, 17);
            this.lblToplamAgirlik.TabIndex = 11;
            this.lblToplamAgirlik.Text = "label19";
            // 
            // lblVergiTutari
            // 
            this.lblVergiTutari.AutoSize = true;
            this.lblVergiTutari.Location = new System.Drawing.Point(201, 97);
            this.lblVergiTutari.Name = "lblVergiTutari";
            this.lblVergiTutari.Size = new System.Drawing.Size(54, 17);
            this.lblVergiTutari.TabIndex = 10;
            this.lblVergiTutari.Text = "label19";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(201, 51);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(54, 17);
            this.lblAdet.TabIndex = 9;
            this.lblAdet.Text = "label19";
            // 
            // lblÜrünAd
            // 
            this.lblÜrünAd.AutoSize = true;
            this.lblÜrünAd.Location = new System.Drawing.Point(201, 22);
            this.lblÜrünAd.Name = "lblÜrünAd";
            this.lblÜrünAd.Size = new System.Drawing.Size(54, 17);
            this.lblÜrünAd.TabIndex = 8;
            this.lblÜrünAd.Text = "label19";
            // 
            // lblKapıdaÖdeme
            // 
            this.lblKapıdaÖdeme.AutoSize = true;
            this.lblKapıdaÖdeme.Location = new System.Drawing.Point(201, 188);
            this.lblKapıdaÖdeme.Name = "lblKapıdaÖdeme";
            this.lblKapıdaÖdeme.Size = new System.Drawing.Size(0, 17);
            this.lblKapıdaÖdeme.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Kapıda Ödeme Ücreti";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kargo Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Vergi Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Toplam Ağırlık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label9.Location = new System.Drawing.Point(368, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Sipariş Özeti";
            // 
            // SiparisDetayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(795, 553);
            this.Controls.Add(this.lblÖdemeBilgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnBitis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisDetayi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisDetayi";
            this.Load += new System.EventHandler(this.SiparisDetayi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblÖdemeBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBitis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblÜrününFiyati;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKargoÜcreti;
        private System.Windows.Forms.Label lblToplamAgirlik;
        private System.Windows.Forms.Label lblVergiTutari;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblÜrünAd;
        private System.Windows.Forms.Label lblKapıdaÖdeme;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}
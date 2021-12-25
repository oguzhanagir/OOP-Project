
namespace Proje2
{
    partial class AnaSayfa
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
            this.btnMüsteriGirisi = new System.Windows.Forms.Button();
            this.btnSirketSahibi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMüsteriGirisi
            // 
            this.btnMüsteriGirisi.AutoSize = true;
            this.btnMüsteriGirisi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüsteriGirisi.Location = new System.Drawing.Point(220, 300);
            this.btnMüsteriGirisi.Name = "btnMüsteriGirisi";
            this.btnMüsteriGirisi.Size = new System.Drawing.Size(220, 100);
            this.btnMüsteriGirisi.TabIndex = 0;
            this.btnMüsteriGirisi.Text = "Müşteri Girişi";
            this.btnMüsteriGirisi.UseVisualStyleBackColor = true;
            this.btnMüsteriGirisi.Click += new System.EventHandler(this.btnMüsteriGirisi_Click);
            // 
            // btnSirketSahibi
            // 
            this.btnSirketSahibi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketSahibi.Location = new System.Drawing.Point(660, 300);
            this.btnSirketSahibi.Name = "btnSirketSahibi";
            this.btnSirketSahibi.Size = new System.Drawing.Size(220, 100);
            this.btnSirketSahibi.TabIndex = 1;
            this.btnSirketSahibi.Text = "Şirket Sahibi Girişi";
            this.btnSirketSahibi.UseVisualStyleBackColor = true;
            this.btnSirketSahibi.Click += new System.EventHandler(this.btnSirketSahibi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(201, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satış Otosmasyonuna Hoş Geldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(375, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(354, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lütfen Giriş Şeklini Seçiniz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSirketSahibi);
            this.Controls.Add(this.btnMüsteriGirisi);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMüsteriGirisi;
        private System.Windows.Forms.Button btnSirketSahibi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


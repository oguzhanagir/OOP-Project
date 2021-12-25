
namespace Proje2
{
    partial class MüsteriGirisi
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
            this.lblePosta = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txbePosta = new System.Windows.Forms.TextBox();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.lblMGirisi = new System.Windows.Forms.Label();
            this.btbGiris = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.lblGirisYap = new System.Windows.Forms.Label();
            this.lblUyeOl = new System.Windows.Forms.Label();
            this.lblMemnuniyet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblePosta
            // 
            this.lblePosta.AutoSize = true;
            this.lblePosta.Location = new System.Drawing.Point(88, 134);
            this.lblePosta.Name = "lblePosta";
            this.lblePosta.Size = new System.Drawing.Size(61, 17);
            this.lblePosta.TabIndex = 0;
            this.lblePosta.Text = "E-posta:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(88, 165);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 17);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            this.lblSifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbePosta
            // 
            this.txbePosta.Location = new System.Drawing.Point(159, 134);
            this.txbePosta.Name = "txbePosta";
            this.txbePosta.Size = new System.Drawing.Size(208, 22);
            this.txbePosta.TabIndex = 2;
            // 
            // txbSifre
            // 
            this.txbSifre.Location = new System.Drawing.Point(159, 162);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(151, 22);
            this.txbSifre.TabIndex = 3;
            // 
            // lblMGirisi
            // 
            this.lblMGirisi.AutoSize = true;
            this.lblMGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMGirisi.Location = new System.Drawing.Point(56, 40);
            this.lblMGirisi.Name = "lblMGirisi";
            this.lblMGirisi.Size = new System.Drawing.Size(551, 32);
            this.lblMGirisi.TabIndex = 4;
            this.lblMGirisi.Text = "Merhaba, giriş yapınız veya üye olunuz!";
            // 
            // btbGiris
            // 
            this.btbGiris.Location = new System.Drawing.Point(91, 202);
            this.btbGiris.Name = "btbGiris";
            this.btbGiris.Size = new System.Drawing.Size(99, 38);
            this.btbGiris.TabIndex = 5;
            this.btbGiris.Text = "Giriş Yap";
            this.btbGiris.UseVisualStyleBackColor = true;
            this.btbGiris.Click += new System.EventHandler(this.btbGiris_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Location = new System.Drawing.Point(91, 316);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(99, 38);
            this.btnUyeOl.TabIndex = 6;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // lblGirisYap
            // 
            this.lblGirisYap.AutoSize = true;
            this.lblGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYap.Location = new System.Drawing.Point(66, 96);
            this.lblGirisYap.Name = "lblGirisYap";
            this.lblGirisYap.Size = new System.Drawing.Size(91, 25);
            this.lblGirisYap.TabIndex = 7;
            this.lblGirisYap.Text = "Giriş Yap";
            // 
            // lblUyeOl
            // 
            this.lblUyeOl.AutoSize = true;
            this.lblUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeOl.Location = new System.Drawing.Point(66, 272);
            this.lblUyeOl.Name = "lblUyeOl";
            this.lblUyeOl.Size = new System.Drawing.Size(301, 25);
            this.lblUyeOl.TabIndex = 8;
            this.lblUyeOl.Text = "Hesabınız yoksa, üye olabilirsiniz.";
            // 
            // lblMemnuniyet
            // 
            this.lblMemnuniyet.AutoSize = true;
            this.lblMemnuniyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemnuniyet.Location = new System.Drawing.Point(66, 381);
            this.lblMemnuniyet.Name = "lblMemnuniyet";
            this.lblMemnuniyet.Size = new System.Drawing.Size(221, 25);
            this.lblMemnuniyet.TabIndex = 9;
            this.lblMemnuniyet.Text = "Keyifli alışverişler dileriz!";
            // 
            // MüsteriGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.lblMemnuniyet);
            this.Controls.Add(this.lblUyeOl);
            this.Controls.Add(this.lblGirisYap);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btbGiris);
            this.Controls.Add(this.lblMGirisi);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.txbePosta);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblePosta);
            this.IsMdiContainer = true;
            this.Name = "MüsteriGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MüsteriGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblePosta;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txbePosta;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.Label lblMGirisi;
        private System.Windows.Forms.Button btbGiris;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label lblGirisYap;
        private System.Windows.Forms.Label lblUyeOl;
        private System.Windows.Forms.Label lblMemnuniyet;
    }
}
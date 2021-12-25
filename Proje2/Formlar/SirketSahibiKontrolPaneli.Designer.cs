
namespace Proje2
{
    partial class SirketSahibiKontrolPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SirketSahibiKontrolPaneli));
            this.btnmusteritakip = new System.Windows.Forms.Button();
            this.btnUrunlistele = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnmusteritakip
            // 
            this.btnmusteritakip.BackColor = System.Drawing.Color.Gold;
            this.btnmusteritakip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmusteritakip.BackgroundImage")));
            this.btnmusteritakip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmusteritakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteritakip.Location = new System.Drawing.Point(33, 21);
            this.btnmusteritakip.Name = "btnmusteritakip";
            this.btnmusteritakip.Size = new System.Drawing.Size(296, 342);
            this.btnmusteritakip.TabIndex = 0;
            this.btnmusteritakip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmusteritakip.UseVisualStyleBackColor = false;
            this.btnmusteritakip.Click += new System.EventHandler(this.btnmusteritakip_Click);
            // 
            // btnUrunlistele
            // 
            this.btnUrunlistele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUrunlistele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunlistele.BackgroundImage")));
            this.btnUrunlistele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunlistele.Location = new System.Drawing.Point(335, 21);
            this.btnUrunlistele.Name = "btnUrunlistele";
            this.btnUrunlistele.Size = new System.Drawing.Size(296, 342);
            this.btnUrunlistele.TabIndex = 0;
            this.btnUrunlistele.UseVisualStyleBackColor = false;
            this.btnUrunlistele.Click += new System.EventHandler(this.btnUrunlistele_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // SirketSahibiKontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(657, 381);
            this.Controls.Add(this.btnUrunlistele);
            this.Controls.Add(this.btnmusteritakip);
            this.Name = "SirketSahibiKontrolPaneli";
            this.Text = "SirketSahibiKontrolPaneli";
            this.Load += new System.EventHandler(this.SirketSahibiKontrolPaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmusteritakip;
        private System.Windows.Forms.Button btnUrunlistele;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
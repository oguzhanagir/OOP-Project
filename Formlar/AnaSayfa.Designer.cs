
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMüsteriGirisi
            // 
            this.btnMüsteriGirisi.AutoSize = true;
            this.btnMüsteriGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMüsteriGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMüsteriGirisi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüsteriGirisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMüsteriGirisi.Location = new System.Drawing.Point(12, 169);
            this.btnMüsteriGirisi.Name = "btnMüsteriGirisi";
            this.btnMüsteriGirisi.Size = new System.Drawing.Size(129, 33);
            this.btnMüsteriGirisi.TabIndex = 0;
            this.btnMüsteriGirisi.Text = "Müşteri Girişi";
            this.btnMüsteriGirisi.UseVisualStyleBackColor = false;
            this.btnMüsteriGirisi.Click += new System.EventHandler(this.btnMüsteriGirisi_Click);
            // 
            // btnSirketSahibi
            // 
            this.btnSirketSahibi.AutoEllipsis = true;
            this.btnSirketSahibi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSirketSahibi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSirketSahibi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketSahibi.Location = new System.Drawing.Point(12, 116);
            this.btnSirketSahibi.Name = "btnSirketSahibi";
            this.btnSirketSahibi.Size = new System.Drawing.Size(129, 36);
            this.btnSirketSahibi.TabIndex = 1;
            this.btnSirketSahibi.Text = "Firma Girişi";
            this.btnSirketSahibi.UseVisualStyleBackColor = false;
            this.btnSirketSahibi.Click += new System.EventHandler(this.btnSirketSahibi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Satış Otamasyonu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 40);
            this.panel2.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(406, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(453, 247);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSirketSahibi);
            this.Controls.Add(this.btnMüsteriGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMüsteriGirisi;
        private System.Windows.Forms.Button btnSirketSahibi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
    }
}


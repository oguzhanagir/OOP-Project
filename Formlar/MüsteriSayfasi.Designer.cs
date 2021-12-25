
namespace Proje2.Formlar
{
    partial class MüsteriSayfasi
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
            this.dgwMusteriSayfasi = new System.Windows.Forms.DataGridView();
            this.lblÜrünFiyat = new System.Windows.Forms.Label();
            this.lblÜrünAd = new System.Windows.Forms.Label();
            this.txtÜrünAdet = new System.Windows.Forms.TextBox();
            this.lblPAmount = new System.Windows.Forms.Label();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbnPName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriSayfasi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMusteriSayfasi
            // 
            this.dgwMusteriSayfasi.AllowUserToAddRows = false;
            this.dgwMusteriSayfasi.AllowUserToDeleteRows = false;
            this.dgwMusteriSayfasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteriSayfasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriSayfasi.Location = new System.Drawing.Point(9, 27);
            this.dgwMusteriSayfasi.Name = "dgwMusteriSayfasi";
            this.dgwMusteriSayfasi.ReadOnly = true;
            this.dgwMusteriSayfasi.RowHeadersWidth = 51;
            this.dgwMusteriSayfasi.RowTemplate.Height = 24;
            this.dgwMusteriSayfasi.Size = new System.Drawing.Size(912, 210);
            this.dgwMusteriSayfasi.TabIndex = 2;
            this.dgwMusteriSayfasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriSayfasi_CellClick);
            // 
            // lblÜrünFiyat
            // 
            this.lblÜrünFiyat.AutoSize = true;
            this.lblÜrünFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜrünFiyat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblÜrünFiyat.Location = new System.Drawing.Point(386, 366);
            this.lblÜrünFiyat.Name = "lblÜrünFiyat";
            this.lblÜrünFiyat.Size = new System.Drawing.Size(0, 20);
            this.lblÜrünFiyat.TabIndex = 16;
            // 
            // lblÜrünAd
            // 
            this.lblÜrünAd.AutoSize = true;
            this.lblÜrünAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜrünAd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblÜrünAd.Location = new System.Drawing.Point(386, 325);
            this.lblÜrünAd.Name = "lblÜrünAd";
            this.lblÜrünAd.Size = new System.Drawing.Size(0, 20);
            this.lblÜrünAd.TabIndex = 15;
            // 
            // txtÜrünAdet
            // 
            this.txtÜrünAdet.Location = new System.Drawing.Point(390, 405);
            this.txtÜrünAdet.Name = "txtÜrünAdet";
            this.txtÜrünAdet.Size = new System.Drawing.Size(96, 22);
            this.txtÜrünAdet.TabIndex = 14;
            // 
            // lblPAmount
            // 
            this.lblPAmount.AutoSize = true;
            this.lblPAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPAmount.Location = new System.Drawing.Point(293, 407);
            this.lblPAmount.Name = "lblPAmount";
            this.lblPAmount.Size = new System.Drawing.Size(53, 20);
            this.lblPAmount.TabIndex = 13;
            this.lblPAmount.Text = "Adet:";
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPPrice.Location = new System.Drawing.Point(293, 366);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(56, 20);
            this.lblPPrice.TabIndex = 12;
            this.lblPPrice.Text = "Fiyat:";
            // 
            // btnBuy
            // 
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuy.Location = new System.Drawing.Point(562, 366);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(111, 61);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Satın Al";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click_1);
            // 
            // lbnPName
            // 
            this.lbnPName.AutoSize = true;
            this.lbnPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbnPName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbnPName.Location = new System.Drawing.Point(293, 325);
            this.lbnPName.Name = "lbnPName";
            this.lbnPName.Size = new System.Drawing.Size(37, 20);
            this.lbnPName.TabIndex = 10;
            this.lbnPName.Text = "Ad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwMusteriSayfasi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Listesi";
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
            this.panel1.Size = new System.Drawing.Size(930, 40);
            this.panel1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(850, 0);
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
            this.button1.Location = new System.Drawing.Point(890, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MüsteriSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(930, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblÜrünFiyat);
            this.Controls.Add(this.lblÜrünAd);
            this.Controls.Add(this.txtÜrünAdet);
            this.Controls.Add(this.lblPAmount);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lbnPName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MüsteriSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Sayfası";
            this.Load += new System.EventHandler(this.MusteriSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriSayfasi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriSayfasi;
        private System.Windows.Forms.Label lblÜrünFiyat;
        private System.Windows.Forms.Label lblÜrünAd;
        private System.Windows.Forms.TextBox txtÜrünAdet;
        private System.Windows.Forms.Label lblPAmount;
        private System.Windows.Forms.Label lblPPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lbnPName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
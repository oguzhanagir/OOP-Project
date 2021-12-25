
namespace Proje2
{
    partial class KontrolPaneliUrun
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
            System.Windows.Forms.DataGridView dataGridView1;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUruncesid = new System.Windows.Forms.ComboBox();
            this.comboBoxurunad = new System.Windows.Forms.ComboBox();
            this.textBoxUrunadet = new System.Windows.Forms.TextBox();
            this.textBoxurunfiyat = new System.Windows.Forms.TextBox();
            this.textBoxUrunagirlik = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(36, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(736, 328);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürünün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürünün Adeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürünün Ağırlığı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürünün Çeşidi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürünün Adı ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUruncesid);
            this.groupBox1.Controls.Add(this.comboBoxurunad);
            this.groupBox1.Controls.Add(this.textBoxUrunadet);
            this.groupBox1.Controls.Add(this.textBoxurunfiyat);
            this.groupBox1.Controls.Add(this.textBoxUrunagirlik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN BİLGİLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxUruncesid
            // 
            this.comboBoxUruncesid.FormattingEnabled = true;
            this.comboBoxUruncesid.Location = new System.Drawing.Point(204, 103);
            this.comboBoxUruncesid.Name = "comboBoxUruncesid";
            this.comboBoxUruncesid.Size = new System.Drawing.Size(133, 24);
            this.comboBoxUruncesid.TabIndex = 2;
            // 
            // comboBoxurunad
            // 
            this.comboBoxurunad.FormattingEnabled = true;
            this.comboBoxurunad.Location = new System.Drawing.Point(204, 54);
            this.comboBoxurunad.Name = "comboBoxurunad";
            this.comboBoxurunad.Size = new System.Drawing.Size(133, 24);
            this.comboBoxurunad.TabIndex = 1;
            // 
            // textBoxUrunadet
            // 
            this.textBoxUrunadet.Location = new System.Drawing.Point(204, 179);
            this.textBoxUrunadet.Name = "textBoxUrunadet";
            this.textBoxUrunadet.Size = new System.Drawing.Size(133, 22);
            this.textBoxUrunadet.TabIndex = 4;
            // 
            // textBoxurunfiyat
            // 
            this.textBoxurunfiyat.Location = new System.Drawing.Point(204, 143);
            this.textBoxurunfiyat.Name = "textBoxurunfiyat";
            this.textBoxurunfiyat.Size = new System.Drawing.Size(133, 22);
            this.textBoxurunfiyat.TabIndex = 3;
            // 
            // textBoxUrunagirlik
            // 
            this.textBoxUrunagirlik.Location = new System.Drawing.Point(204, 214);
            this.textBoxUrunagirlik.Name = "textBoxUrunagirlik";
            this.textBoxUrunagirlik.Size = new System.Drawing.Size(133, 22);
            this.textBoxUrunagirlik.TabIndex = 5;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(554, 371);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(99, 92);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(449, 371);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(99, 92);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(659, 482);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(99, 92);
            this.btngeri.TabIndex = 3;
            this.btngeri.Text = "GERİ DÖN";
            this.btngeri.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(554, 482);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(99, 92);
            this.btniptal.TabIndex = 4;
            this.btniptal.Text = "İptal et";
            this.btniptal.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(659, 371);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(99, 92);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(449, 482);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(99, 92);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(62, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "gg.aa.yyyy.hh.mm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(498, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 35);
            this.panel1.TabIndex = 7;
            // 
            // KontrolPaneliUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(dataGridView1);
            this.Name = "KontrolPaneliUrun";
            this.Text = "KontrolPaneliUrun";
            this.Load += new System.EventHandler(this.KontrolPaneliUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxUrunadet;
        private System.Windows.Forms.TextBox textBoxurunfiyat;
        private System.Windows.Forms.TextBox textBoxUrunagirlik;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ComboBox comboBoxUruncesid;
        private System.Windows.Forms.ComboBox comboBoxurunad;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}
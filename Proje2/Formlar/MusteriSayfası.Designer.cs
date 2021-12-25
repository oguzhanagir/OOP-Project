
namespace Proje2.Formlar
{
    partial class MusteriSayfası
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
            this.lbnPName = new System.Windows.Forms.Label();
            this.txbPName = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.txbPPrice = new System.Windows.Forms.TextBox();
            this.lblPAmount = new System.Windows.Forms.Label();
            this.txbPAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriSayfasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusteriSayfasi
            // 
            this.dgwMusteriSayfasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriSayfasi.Location = new System.Drawing.Point(-8, 2);
            this.dgwMusteriSayfasi.Name = "dgwMusteriSayfasi";
            this.dgwMusteriSayfasi.RowHeadersWidth = 51;
            this.dgwMusteriSayfasi.RowTemplate.Height = 24;
            this.dgwMusteriSayfasi.Size = new System.Drawing.Size(806, 283);
            this.dgwMusteriSayfasi.TabIndex = 0;
            // 
            // lbnPName
            // 
            this.lbnPName.AutoSize = true;
            this.lbnPName.Location = new System.Drawing.Point(45, 317);
            this.lbnPName.Name = "lbnPName";
            this.lbnPName.Size = new System.Drawing.Size(29, 17);
            this.lbnPName.TabIndex = 1;
            this.lbnPName.Text = "Ad:";
            // 
            // txbPName
            // 
            this.txbPName.Location = new System.Drawing.Point(112, 317);
            this.txbPName.Name = "txbPName";
            this.txbPName.Size = new System.Drawing.Size(100, 22);
            this.txbPName.TabIndex = 2;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(275, 398);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 25);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Satın Al";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Location = new System.Drawing.Point(45, 358);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(42, 17);
            this.lblPPrice.TabIndex = 4;
            this.lblPPrice.Text = "Fiyat:";
            // 
            // txbPPrice
            // 
            this.txbPPrice.Location = new System.Drawing.Point(112, 358);
            this.txbPPrice.Name = "txbPPrice";
            this.txbPPrice.Size = new System.Drawing.Size(100, 22);
            this.txbPPrice.TabIndex = 5;
            this.txbPPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPAmount
            // 
            this.lblPAmount.AutoSize = true;
            this.lblPAmount.Location = new System.Drawing.Point(45, 399);
            this.lblPAmount.Name = "lblPAmount";
            this.lblPAmount.Size = new System.Drawing.Size(41, 17);
            this.lblPAmount.TabIndex = 6;
            this.lblPAmount.Text = "Adet:";
            // 
            // txbPAmount
            // 
            this.txbPAmount.Location = new System.Drawing.Point(112, 399);
            this.txbPAmount.Name = "txbPAmount";
            this.txbPAmount.Size = new System.Drawing.Size(100, 22);
            this.txbPAmount.TabIndex = 7;
            // 
            // MusteriSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.txbPAmount);
            this.Controls.Add(this.lblPAmount);
            this.Controls.Add(this.txbPPrice);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txbPName);
            this.Controls.Add(this.lbnPName);
            this.Controls.Add(this.dgwMusteriSayfasi);
            this.Name = "MusteriSayfası";
            this.Text = "Müşteri Sayfası";
            this.Load += new System.EventHandler(this.MusteriSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriSayfasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriSayfasi;
        private System.Windows.Forms.Label lbnPName;
        private System.Windows.Forms.TextBox txbPName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblPPrice;
        private System.Windows.Forms.TextBox txbPPrice;
        private System.Windows.Forms.Label lblPAmount;
        private System.Windows.Forms.TextBox txbPAmount;
    }
}
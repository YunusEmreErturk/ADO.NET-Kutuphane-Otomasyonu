namespace Kutuphane
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.cmb_raporlar = new System.Windows.Forms.ComboBox();
            this.dGvw_raporlar = new System.Windows.Forms.DataGridView();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGvw_raporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_raporlar
            // 
            this.cmb_raporlar.FormattingEnabled = true;
            this.cmb_raporlar.Items.AddRange(new object[] {
            "Dışarıda olan kitaplar",
            "Üyelerin kitaplarını öngörülen getirme tarihleri",
            "Üyenin Bugüne Kadar Ödediği Toplam Ceza Tutarı",
            "Bugüne kadar hangi kitaptan ne kadar para kazanılmış ceza tutarı olarak",
            "Teslim Tarih Yılına Göre O Yıl Ödenmiş Ceza Tutar Toplamı",
            "3 VEYA DAHA FAZLA CEZA ÖDEMİŞ KULLANICILAR",
            "En çok geç getirilen kitaplar",
            "En çok tercih edilen kitapları ve bu kitapların kac kere ödünc alındıgı"});
            this.cmb_raporlar.Location = new System.Drawing.Point(183, 68);
            this.cmb_raporlar.Name = "cmb_raporlar";
            this.cmb_raporlar.Size = new System.Drawing.Size(413, 21);
            this.cmb_raporlar.TabIndex = 0;
            this.cmb_raporlar.SelectedIndexChanged += new System.EventHandler(this.cmb_raporlar_SelectedIndexChanged);
            // 
            // dGvw_raporlar
            // 
            this.dGvw_raporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvw_raporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvw_raporlar.Location = new System.Drawing.Point(30, 114);
            this.dGvw_raporlar.Name = "dGvw_raporlar";
            this.dGvw_raporlar.Size = new System.Drawing.Size(566, 267);
            this.dGvw_raporlar.TabIndex = 1;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(282, 26);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(98, 20);
            this.txt_tarih.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yılı Seçiniz : ";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.dGvw_raporlar);
            this.Controls.Add(this.cmb_raporlar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dGvw_raporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_raporlar;
        private System.Windows.Forms.DataGridView dGvw_raporlar;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.Label label1;
    }
}
namespace Kutuphane
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.lbl_kitapAdi = new System.Windows.Forms.Label();
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.lbl_sayfaSayisi = new System.Windows.Forms.Label();
            this.lbl_kitapFiyati = new System.Windows.Forms.Label();
            this.lbl_basimTarihi = new System.Windows.Forms.Label();
            this.lbl_stokAdedi = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.lbl_yayinevi = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.lbl_kitapOzeti = new System.Windows.Forms.Label();
            this.txt_kitapAdi = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.txt_sayfaSayisi = new System.Windows.Forms.TextBox();
            this.txt_kitapFiyati = new System.Windows.Forms.TextBox();
            this.txt_basimTarihi = new System.Windows.Forms.TextBox();
            this.txt_stokAdedi = new System.Windows.Forms.TextBox();
            this.txt_kitapOzeti = new System.Windows.Forms.TextBox();
            this.cmb_yazar = new System.Windows.Forms.ComboBox();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.cmb_yayinevi = new System.Windows.Forms.ComboBox();
            this.btn_yazarEkle = new System.Windows.Forms.Button();
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            this.btn_yayineviEkle = new System.Windows.Forms.Button();
            this.btn_kitabiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kitapAdi
            // 
            this.lbl_kitapAdi.AutoSize = true;
            this.lbl_kitapAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kitapAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapAdi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_kitapAdi.Location = new System.Drawing.Point(103, 29);
            this.lbl_kitapAdi.Name = "lbl_kitapAdi";
            this.lbl_kitapAdi.Size = new System.Drawing.Size(76, 16);
            this.lbl_kitapAdi.TabIndex = 0;
            this.lbl_kitapAdi.Text = "Kitap Adı :";
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_barkod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_barkod.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_barkod.Location = new System.Drawing.Point(116, 83);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(63, 16);
            this.lbl_barkod.TabIndex = 1;
            this.lbl_barkod.Text = "Barkod :";
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_tur.Location = new System.Drawing.Point(144, 130);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(35, 16);
            this.lbl_tur.TabIndex = 2;
            this.lbl_tur.Text = "Tür :";
            // 
            // lbl_sayfaSayisi
            // 
            this.lbl_sayfaSayisi.AutoSize = true;
            this.lbl_sayfaSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sayfaSayisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayfaSayisi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_sayfaSayisi.Location = new System.Drawing.Point(86, 179);
            this.lbl_sayfaSayisi.Name = "lbl_sayfaSayisi";
            this.lbl_sayfaSayisi.Size = new System.Drawing.Size(93, 16);
            this.lbl_sayfaSayisi.TabIndex = 3;
            this.lbl_sayfaSayisi.Text = "Sayfa Sayısı :";
            // 
            // lbl_kitapFiyati
            // 
            this.lbl_kitapFiyati.AutoSize = true;
            this.lbl_kitapFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kitapFiyati.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapFiyati.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_kitapFiyati.Location = new System.Drawing.Point(91, 230);
            this.lbl_kitapFiyati.Name = "lbl_kitapFiyati";
            this.lbl_kitapFiyati.Size = new System.Drawing.Size(88, 16);
            this.lbl_kitapFiyati.TabIndex = 4;
            this.lbl_kitapFiyati.Text = "Kitap Fiyatı :";
            // 
            // lbl_basimTarihi
            // 
            this.lbl_basimTarihi.AutoSize = true;
            this.lbl_basimTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_basimTarihi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_basimTarihi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_basimTarihi.Location = new System.Drawing.Point(85, 279);
            this.lbl_basimTarihi.Name = "lbl_basimTarihi";
            this.lbl_basimTarihi.Size = new System.Drawing.Size(94, 16);
            this.lbl_basimTarihi.TabIndex = 5;
            this.lbl_basimTarihi.Text = "Basım Tarihi :";
            // 
            // lbl_stokAdedi
            // 
            this.lbl_stokAdedi.AutoSize = true;
            this.lbl_stokAdedi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stokAdedi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stokAdedi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_stokAdedi.Location = new System.Drawing.Point(422, 180);
            this.lbl_stokAdedi.Name = "lbl_stokAdedi";
            this.lbl_stokAdedi.Size = new System.Drawing.Size(78, 16);
            this.lbl_stokAdedi.TabIndex = 6;
            this.lbl_stokAdedi.Text = "Stok Adet :";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kategori.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_kategori.Location = new System.Drawing.Point(429, 80);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(71, 16);
            this.lbl_kategori.TabIndex = 7;
            this.lbl_kategori.Text = "Kategori :";
            // 
            // lbl_yayinevi
            // 
            this.lbl_yayinevi.AutoSize = true;
            this.lbl_yayinevi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yayinevi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yayinevi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_yayinevi.Location = new System.Drawing.Point(429, 130);
            this.lbl_yayinevi.Name = "lbl_yayinevi";
            this.lbl_yayinevi.Size = new System.Drawing.Size(71, 16);
            this.lbl_yayinevi.TabIndex = 8;
            this.lbl_yayinevi.Text = "Yayınevi :";
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_yazar.Location = new System.Drawing.Point(447, 30);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(53, 16);
            this.lbl_yazar.TabIndex = 9;
            this.lbl_yazar.Text = "Yazar :";
            // 
            // lbl_kitapOzeti
            // 
            this.lbl_kitapOzeti.AutoSize = true;
            this.lbl_kitapOzeti.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kitapOzeti.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapOzeti.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_kitapOzeti.Location = new System.Drawing.Point(413, 229);
            this.lbl_kitapOzeti.Name = "lbl_kitapOzeti";
            this.lbl_kitapOzeti.Size = new System.Drawing.Size(87, 16);
            this.lbl_kitapOzeti.TabIndex = 10;
            this.lbl_kitapOzeti.Text = "Kitap Özeti :";
            // 
            // txt_kitapAdi
            // 
            this.txt_kitapAdi.Location = new System.Drawing.Point(198, 29);
            this.txt_kitapAdi.Name = "txt_kitapAdi";
            this.txt_kitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapAdi.TabIndex = 11;
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(198, 79);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(100, 20);
            this.txt_barkod.TabIndex = 12;
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(198, 129);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(100, 20);
            this.txt_tur.TabIndex = 13;
            // 
            // txt_sayfaSayisi
            // 
            this.txt_sayfaSayisi.Location = new System.Drawing.Point(198, 179);
            this.txt_sayfaSayisi.Name = "txt_sayfaSayisi";
            this.txt_sayfaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_sayfaSayisi.TabIndex = 14;
            // 
            // txt_kitapFiyati
            // 
            this.txt_kitapFiyati.Location = new System.Drawing.Point(198, 229);
            this.txt_kitapFiyati.Name = "txt_kitapFiyati";
            this.txt_kitapFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapFiyati.TabIndex = 15;
            // 
            // txt_basimTarihi
            // 
            this.txt_basimTarihi.Location = new System.Drawing.Point(198, 279);
            this.txt_basimTarihi.Name = "txt_basimTarihi";
            this.txt_basimTarihi.Size = new System.Drawing.Size(100, 20);
            this.txt_basimTarihi.TabIndex = 16;
            // 
            // txt_stokAdedi
            // 
            this.txt_stokAdedi.Location = new System.Drawing.Point(520, 179);
            this.txt_stokAdedi.Name = "txt_stokAdedi";
            this.txt_stokAdedi.Size = new System.Drawing.Size(121, 20);
            this.txt_stokAdedi.TabIndex = 17;
            // 
            // txt_kitapOzeti
            // 
            this.txt_kitapOzeti.Location = new System.Drawing.Point(520, 229);
            this.txt_kitapOzeti.Name = "txt_kitapOzeti";
            this.txt_kitapOzeti.Size = new System.Drawing.Size(121, 20);
            this.txt_kitapOzeti.TabIndex = 18;
            // 
            // cmb_yazar
            // 
            this.cmb_yazar.FormattingEnabled = true;
            this.cmb_yazar.Location = new System.Drawing.Point(520, 29);
            this.cmb_yazar.Name = "cmb_yazar";
            this.cmb_yazar.Size = new System.Drawing.Size(121, 21);
            this.cmb_yazar.TabIndex = 19;
            this.cmb_yazar.SelectedIndexChanged += new System.EventHandler(this.cmb_yazar_SelectedIndexChanged);
            this.cmb_yazar.Click += new System.EventHandler(this.cmb_yazar_Click);
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Location = new System.Drawing.Point(520, 79);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(121, 21);
            this.cmb_kategori.TabIndex = 20;
            this.cmb_kategori.SelectedIndexChanged += new System.EventHandler(this.cmb_kategori_SelectedIndexChanged);
            this.cmb_kategori.Click += new System.EventHandler(this.cmb_kategori_Click);
            // 
            // cmb_yayinevi
            // 
            this.cmb_yayinevi.FormattingEnabled = true;
            this.cmb_yayinevi.Location = new System.Drawing.Point(520, 129);
            this.cmb_yayinevi.Name = "cmb_yayinevi";
            this.cmb_yayinevi.Size = new System.Drawing.Size(121, 21);
            this.cmb_yayinevi.TabIndex = 21;
            this.cmb_yayinevi.SelectedIndexChanged += new System.EventHandler(this.cmb_yayinevi_SelectedIndexChanged);
            this.cmb_yayinevi.Click += new System.EventHandler(this.cmb_yayinevi_Click);
            // 
            // btn_yazarEkle
            // 
            this.btn_yazarEkle.BackColor = System.Drawing.Color.DimGray;
            this.btn_yazarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yazarEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yazarEkle.Location = new System.Drawing.Point(670, 22);
            this.btn_yazarEkle.Name = "btn_yazarEkle";
            this.btn_yazarEkle.Size = new System.Drawing.Size(104, 33);
            this.btn_yazarEkle.TabIndex = 22;
            this.btn_yazarEkle.Text = "Yazar Ekle";
            this.btn_yazarEkle.UseVisualStyleBackColor = false;
            this.btn_yazarEkle.Click += new System.EventHandler(this.btn_yazarEkle_Click);
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.BackColor = System.Drawing.Color.DimGray;
            this.btn_kategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kategoriEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategoriEkle.Location = new System.Drawing.Point(670, 72);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(104, 33);
            this.btn_kategoriEkle.TabIndex = 23;
            this.btn_kategoriEkle.Text = "Kategori Ekle";
            this.btn_kategoriEkle.UseVisualStyleBackColor = false;
            this.btn_kategoriEkle.Click += new System.EventHandler(this.kategoriEkle_Click);
            // 
            // btn_yayineviEkle
            // 
            this.btn_yayineviEkle.BackColor = System.Drawing.Color.DimGray;
            this.btn_yayineviEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yayineviEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yayineviEkle.Location = new System.Drawing.Point(670, 122);
            this.btn_yayineviEkle.Name = "btn_yayineviEkle";
            this.btn_yayineviEkle.Size = new System.Drawing.Size(104, 33);
            this.btn_yayineviEkle.TabIndex = 24;
            this.btn_yayineviEkle.Text = "Yayınevi Ekle";
            this.btn_yayineviEkle.UseVisualStyleBackColor = false;
            this.btn_yayineviEkle.Click += new System.EventHandler(this.btn_yayineviEkle_Click);
            // 
            // btn_kitabiEkle
            // 
            this.btn_kitabiEkle.BackColor = System.Drawing.Color.DimGray;
            this.btn_kitabiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitabiEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitabiEkle.Location = new System.Drawing.Point(520, 279);
            this.btn_kitabiEkle.Name = "btn_kitabiEkle";
            this.btn_kitabiEkle.Size = new System.Drawing.Size(121, 49);
            this.btn_kitabiEkle.TabIndex = 25;
            this.btn_kitabiEkle.Text = "Kitabı Ekle";
            this.btn_kitabiEkle.UseVisualStyleBackColor = false;
            this.btn_kitabiEkle.Click += new System.EventHandler(this.btn_kitabiEkle_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.btn_kitabiEkle);
            this.Controls.Add(this.btn_yayineviEkle);
            this.Controls.Add(this.btn_kategoriEkle);
            this.Controls.Add(this.btn_yazarEkle);
            this.Controls.Add(this.cmb_yayinevi);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.cmb_yazar);
            this.Controls.Add(this.txt_kitapOzeti);
            this.Controls.Add(this.txt_stokAdedi);
            this.Controls.Add(this.txt_basimTarihi);
            this.Controls.Add(this.txt_kitapFiyati);
            this.Controls.Add(this.txt_sayfaSayisi);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.txt_kitapAdi);
            this.Controls.Add(this.lbl_kitapOzeti);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.lbl_yayinevi);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_stokAdedi);
            this.Controls.Add(this.lbl_basimTarihi);
            this.Controls.Add(this.lbl_kitapFiyati);
            this.Controls.Add(this.lbl_sayfaSayisi);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.lbl_barkod);
            this.Controls.Add(this.lbl_kitapAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitapEkle_FormClosing);
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kitapAdi;
        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.Label lbl_sayfaSayisi;
        private System.Windows.Forms.Label lbl_kitapFiyati;
        private System.Windows.Forms.Label lbl_basimTarihi;
        private System.Windows.Forms.Label lbl_stokAdedi;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label lbl_yayinevi;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.Label lbl_kitapOzeti;
        private System.Windows.Forms.TextBox txt_kitapAdi;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.TextBox txt_sayfaSayisi;
        private System.Windows.Forms.TextBox txt_kitapFiyati;
        private System.Windows.Forms.TextBox txt_basimTarihi;
        private System.Windows.Forms.TextBox txt_stokAdedi;
        private System.Windows.Forms.TextBox txt_kitapOzeti;
        private System.Windows.Forms.ComboBox cmb_yazar;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.ComboBox cmb_yayinevi;
        private System.Windows.Forms.Button btn_yazarEkle;
        private System.Windows.Forms.Button btn_kategoriEkle;
        private System.Windows.Forms.Button btn_yayineviEkle;
        private System.Windows.Forms.Button btn_kitabiEkle;
    }
}
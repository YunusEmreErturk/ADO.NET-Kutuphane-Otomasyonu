namespace Kutuphane
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kitapAl = new System.Windows.Forms.Button();
            this.btn_kitapVer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_uyeAra = new System.Windows.Forms.TextBox();
            this.btn_borcOde = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cmb_uyeKitaplar = new System.Windows.Forms.ComboBox();
            this.btn_raporlar = new System.Windows.Forms.Button();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.txt_kitapAra = new System.Windows.Forms.TextBox();
            this.btn_uyeEkle = new System.Windows.Forms.Button();
            this.btn_uyeSil = new System.Windows.Forms.Button();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kitapAl
            // 
            this.btn_kitapAl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapAl.Location = new System.Drawing.Point(623, 335);
            this.btn_kitapAl.Name = "btn_kitapAl";
            this.btn_kitapAl.Size = new System.Drawing.Size(93, 50);
            this.btn_kitapAl.TabIndex = 0;
            this.btn_kitapAl.Text = "KİTAP İADE";
            this.btn_kitapAl.UseVisualStyleBackColor = true;
            this.btn_kitapAl.Click += new System.EventHandler(this.btn_kitapAl_Click);
            // 
            // btn_kitapVer
            // 
            this.btn_kitapVer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapVer.Location = new System.Drawing.Point(623, 70);
            this.btn_kitapVer.Name = "btn_kitapVer";
            this.btn_kitapVer.Size = new System.Drawing.Size(93, 56);
            this.btn_kitapVer.TabIndex = 1;
            this.btn_kitapVer.Text = "KİTAP VER";
            this.btn_kitapVer.UseVisualStyleBackColor = true;
            this.btn_kitapVer.Click += new System.EventHandler(this.btn_kitapVer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 217);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 94);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(275, 341);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // txt_uyeAra
            // 
            this.txt_uyeAra.Location = new System.Drawing.Point(82, 58);
            this.txt_uyeAra.Name = "txt_uyeAra";
            this.txt_uyeAra.Size = new System.Drawing.Size(196, 20);
            this.txt_uyeAra.TabIndex = 7;
            this.txt_uyeAra.TextChanged += new System.EventHandler(this.txt_uyeAra_TextChanged);
            // 
            // btn_borcOde
            // 
            this.btn_borcOde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_borcOde.Location = new System.Drawing.Point(623, 391);
            this.btn_borcOde.Name = "btn_borcOde";
            this.btn_borcOde.Size = new System.Drawing.Size(93, 44);
            this.btn_borcOde.TabIndex = 8;
            this.btn_borcOde.Text = "BORÇ ÖDE";
            this.btn_borcOde.UseVisualStyleBackColor = true;
            this.btn_borcOde.Click += new System.EventHandler(this.btn_borcOde_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(310, 335);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(298, 100);
            this.dataGridView4.TabIndex = 9;
            this.dataGridView4.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_CellMouseClick);
            this.dataGridView4.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_CellMouseDoubleClick);
            // 
            // cmb_uyeKitaplar
            // 
            this.cmb_uyeKitaplar.FormattingEnabled = true;
            this.cmb_uyeKitaplar.Items.AddRange(new object[] {
            "Üyenin Üstünde Bulunan Kitaplar",
            "Borcu Olan Kitaplar"});
            this.cmb_uyeKitaplar.Location = new System.Drawing.Point(310, 290);
            this.cmb_uyeKitaplar.Name = "cmb_uyeKitaplar";
            this.cmb_uyeKitaplar.Size = new System.Drawing.Size(298, 21);
            this.cmb_uyeKitaplar.TabIndex = 10;
            this.cmb_uyeKitaplar.SelectedIndexChanged += new System.EventHandler(this.cmb_uyeKitaplar_SelectedIndexChanged);
            // 
            // btn_raporlar
            // 
            this.btn_raporlar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlar.Location = new System.Drawing.Point(623, 151);
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.Size = new System.Drawing.Size(93, 86);
            this.btn_raporlar.TabIndex = 11;
            this.btn_raporlar.Text = "RAPORLAR";
            this.btn_raporlar.UseVisualStyleBackColor = true;
            this.btn_raporlar.Click += new System.EventHandler(this.btn_raporlar_Click);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapEkle.Location = new System.Drawing.Point(521, 12);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(87, 24);
            this.btn_kitapEkle.TabIndex = 12;
            this.btn_kitapEkle.Text = "KİTAP EKLE";
            this.btn_kitapEkle.UseVisualStyleBackColor = true;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // txt_kitapAra
            // 
            this.txt_kitapAra.Location = new System.Drawing.Point(310, 15);
            this.txt_kitapAra.Name = "txt_kitapAra";
            this.txt_kitapAra.Size = new System.Drawing.Size(172, 20);
            this.txt_kitapAra.TabIndex = 13;
            this.txt_kitapAra.TextChanged += new System.EventHandler(this.txt_kitapAra_TextChanged);
            // 
            // btn_uyeEkle
            // 
            this.btn_uyeEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeEkle.Location = new System.Drawing.Point(82, 4);
            this.btn_uyeEkle.Name = "btn_uyeEkle";
            this.btn_uyeEkle.Size = new System.Drawing.Size(90, 48);
            this.btn_uyeEkle.TabIndex = 14;
            this.btn_uyeEkle.Text = "Üye Ekle";
            this.btn_uyeEkle.UseVisualStyleBackColor = true;
            this.btn_uyeEkle.Click += new System.EventHandler(this.btn_uyeEkle_Click);
            // 
            // btn_uyeSil
            // 
            this.btn_uyeSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeSil.Location = new System.Drawing.Point(187, 4);
            this.btn_uyeSil.Name = "btn_uyeSil";
            this.btn_uyeSil.Size = new System.Drawing.Size(90, 48);
            this.btn_uyeSil.TabIndex = 15;
            this.btn_uyeSil.Text = "Üye Sil";
            this.btn_uyeSil.UseVisualStyleBackColor = true;
            this.btn_uyeSil.Click += new System.EventHandler(this.btn_uyeSil_Click);
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Back.BackgroundImage")));
            this.pictureBox_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Back.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(63, 48);
            this.pictureBox_Back.TabIndex = 16;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 459);
            this.Controls.Add(this.pictureBox_Back);
            this.Controls.Add(this.btn_uyeSil);
            this.Controls.Add(this.btn_uyeEkle);
            this.Controls.Add(this.txt_kitapAra);
            this.Controls.Add(this.btn_kitapEkle);
            this.Controls.Add(this.btn_raporlar);
            this.Controls.Add(this.cmb_uyeKitaplar);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btn_borcOde);
            this.Controls.Add(this.txt_uyeAra);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kitapVer);
            this.Controls.Add(this.btn_kitapAl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kütüphane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapAl;
        private System.Windows.Forms.Button btn_kitapVer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_uyeAra;
        private System.Windows.Forms.Button btn_borcOde;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox cmb_uyeKitaplar;
        private System.Windows.Forms.Button btn_raporlar;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.TextBox txt_kitapAra;
        private System.Windows.Forms.Button btn_uyeEkle;
        private System.Windows.Forms.Button btn_uyeSil;
        private System.Windows.Forms.PictureBox pictureBox_Back;
    }
}


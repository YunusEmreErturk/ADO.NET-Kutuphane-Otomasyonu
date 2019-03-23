namespace Kutuphane
{
    partial class YazarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarEkle));
            this.lbl_yazarAdi = new System.Windows.Forms.Label();
            this.lbl_yazarSoyadi = new System.Windows.Forms.Label();
            this.lbl_ozgecmis = new System.Windows.Forms.Label();
            this.txt_yazarAdi = new System.Windows.Forms.TextBox();
            this.txt_yazarSoyadi = new System.Windows.Forms.TextBox();
            this.txt_ozgecmis = new System.Windows.Forms.TextBox();
            this.btn_yazarEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_yazarAdi
            // 
            this.lbl_yazarAdi.AutoSize = true;
            this.lbl_yazarAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazarAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_yazarAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazarAdi.Location = new System.Drawing.Point(259, 102);
            this.lbl_yazarAdi.Name = "lbl_yazarAdi";
            this.lbl_yazarAdi.Size = new System.Drawing.Size(79, 16);
            this.lbl_yazarAdi.TabIndex = 0;
            this.lbl_yazarAdi.Text = "Yazar Adı :";
            // 
            // lbl_yazarSoyadi
            // 
            this.lbl_yazarSoyadi.AutoSize = true;
            this.lbl_yazarSoyadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazarSoyadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_yazarSoyadi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazarSoyadi.Location = new System.Drawing.Point(236, 152);
            this.lbl_yazarSoyadi.Name = "lbl_yazarSoyadi";
            this.lbl_yazarSoyadi.Size = new System.Drawing.Size(102, 16);
            this.lbl_yazarSoyadi.TabIndex = 1;
            this.lbl_yazarSoyadi.Text = "Yazar SoyAdı :";
            // 
            // lbl_ozgecmis
            // 
            this.lbl_ozgecmis.AutoSize = true;
            this.lbl_ozgecmis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ozgecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ozgecmis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ozgecmis.Location = new System.Drawing.Point(259, 207);
            this.lbl_ozgecmis.Name = "lbl_ozgecmis";
            this.lbl_ozgecmis.Size = new System.Drawing.Size(80, 16);
            this.lbl_ozgecmis.TabIndex = 2;
            this.lbl_ozgecmis.Text = "Özgeçmiş :";
            // 
            // txt_yazarAdi
            // 
            this.txt_yazarAdi.Location = new System.Drawing.Point(345, 102);
            this.txt_yazarAdi.Name = "txt_yazarAdi";
            this.txt_yazarAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_yazarAdi.TabIndex = 3;
            // 
            // txt_yazarSoyadi
            // 
            this.txt_yazarSoyadi.Location = new System.Drawing.Point(345, 151);
            this.txt_yazarSoyadi.Name = "txt_yazarSoyadi";
            this.txt_yazarSoyadi.Size = new System.Drawing.Size(99, 20);
            this.txt_yazarSoyadi.TabIndex = 4;
            // 
            // txt_ozgecmis
            // 
            this.txt_ozgecmis.Location = new System.Drawing.Point(345, 190);
            this.txt_ozgecmis.Multiline = true;
            this.txt_ozgecmis.Name = "txt_ozgecmis";
            this.txt_ozgecmis.Size = new System.Drawing.Size(270, 162);
            this.txt_ozgecmis.TabIndex = 5;
            // 
            // btn_yazarEkle
            // 
            this.btn_yazarEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yazarEkle.Location = new System.Drawing.Point(483, 102);
            this.btn_yazarEkle.Name = "btn_yazarEkle";
            this.btn_yazarEkle.Size = new System.Drawing.Size(92, 57);
            this.btn_yazarEkle.TabIndex = 6;
            this.btn_yazarEkle.Text = "Yazar Ekle";
            this.btn_yazarEkle.UseVisualStyleBackColor = true;
            this.btn_yazarEkle.Click += new System.EventHandler(this.btn_yazarEkle_Click);
            // 
            // YazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 391);
            this.Controls.Add(this.btn_yazarEkle);
            this.Controls.Add(this.txt_ozgecmis);
            this.Controls.Add(this.txt_yazarSoyadi);
            this.Controls.Add(this.txt_yazarAdi);
            this.Controls.Add(this.lbl_ozgecmis);
            this.Controls.Add(this.lbl_yazarSoyadi);
            this.Controls.Add(this.lbl_yazarAdi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YazarEkle";
            this.Text = "YazarEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yazarAdi;
        private System.Windows.Forms.Label lbl_yazarSoyadi;
        private System.Windows.Forms.Label lbl_ozgecmis;
        private System.Windows.Forms.TextBox txt_yazarAdi;
        private System.Windows.Forms.TextBox txt_yazarSoyadi;
        private System.Windows.Forms.TextBox txt_ozgecmis;
        private System.Windows.Forms.Button btn_yazarEkle;
    }
}
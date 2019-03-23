namespace Kutuphane
{
    partial class KategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriEkle));
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            this.txt_kategoriAdi = new System.Windows.Forms.TextBox();
            this.lbl_kategoriAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategoriEkle.Location = new System.Drawing.Point(73, 121);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(110, 34);
            this.btn_kategoriEkle.TabIndex = 16;
            this.btn_kategoriEkle.Text = "Kategori Ekle";
            this.btn_kategoriEkle.UseVisualStyleBackColor = true;
            this.btn_kategoriEkle.Click += new System.EventHandler(this.btn_kategoriEkle_Click);
            // 
            // txt_kategoriAdi
            // 
            this.txt_kategoriAdi.Location = new System.Drawing.Point(130, 66);
            this.txt_kategoriAdi.Name = "txt_kategoriAdi";
            this.txt_kategoriAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_kategoriAdi.TabIndex = 15;
            // 
            // lbl_kategoriAdi
            // 
            this.lbl_kategoriAdi.AutoSize = true;
            this.lbl_kategoriAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategoriAdi.Location = new System.Drawing.Point(27, 67);
            this.lbl_kategoriAdi.Name = "lbl_kategoriAdi";
            this.lbl_kategoriAdi.Size = new System.Drawing.Size(97, 16);
            this.lbl_kategoriAdi.TabIndex = 14;
            this.lbl_kategoriAdi.Text = "Kategori Adı :";
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 212);
            this.Controls.Add(this.btn_kategoriEkle);
            this.Controls.Add(this.txt_kategoriAdi);
            this.Controls.Add(this.lbl_kategoriAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KategoriEkle";
            this.Text = "KategoriEkle";
            this.Load += new System.EventHandler(this.KategoriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kategoriEkle;
        private System.Windows.Forms.TextBox txt_kategoriAdi;
        private System.Windows.Forms.Label lbl_kategoriAdi;
    }
}
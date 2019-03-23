namespace Kutuphane
{
    partial class YayineviEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YayineviEkle));
            this.btn_yayineviEkle = new System.Windows.Forms.Button();
            this.txt_yayineviAdi = new System.Windows.Forms.TextBox();
            this.lbl_yayineviAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yayineviEkle
            // 
            this.btn_yayineviEkle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yayineviEkle.Location = new System.Drawing.Point(74, 114);
            this.btn_yayineviEkle.Name = "btn_yayineviEkle";
            this.btn_yayineviEkle.Size = new System.Drawing.Size(110, 34);
            this.btn_yayineviEkle.TabIndex = 13;
            this.btn_yayineviEkle.Text = "Yayınevi Ekle";
            this.btn_yayineviEkle.UseVisualStyleBackColor = true;
            this.btn_yayineviEkle.Click += new System.EventHandler(this.btn_yayineviEkle_Click);
            // 
            // txt_yayineviAdi
            // 
            this.txt_yayineviAdi.Location = new System.Drawing.Point(128, 51);
            this.txt_yayineviAdi.Name = "txt_yayineviAdi";
            this.txt_yayineviAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_yayineviAdi.TabIndex = 10;
            // 
            // lbl_yayineviAdi
            // 
            this.lbl_yayineviAdi.AutoSize = true;
            this.lbl_yayineviAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yayineviAdi.Location = new System.Drawing.Point(25, 52);
            this.lbl_yayineviAdi.Name = "lbl_yayineviAdi";
            this.lbl_yayineviAdi.Size = new System.Drawing.Size(97, 16);
            this.lbl_yayineviAdi.TabIndex = 7;
            this.lbl_yayineviAdi.Text = "Yayınevi Adı :";
            // 
            // YayineviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(279, 208);
            this.Controls.Add(this.btn_yayineviEkle);
            this.Controls.Add(this.txt_yayineviAdi);
            this.Controls.Add(this.lbl_yayineviAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YayineviEkle";
            this.Text = "YayineviEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yayineviEkle;
        private System.Windows.Forms.TextBox txt_yayineviAdi;
        private System.Windows.Forms.Label lbl_yayineviAdi;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        string yazar, yayinevi, kategori,barkod;
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            SqlCommand cmd_yazarGetir = new SqlCommand();
            cmd_yazarGetir.CommandText = "SELECT YazarAdi,YazarSoyadi FROM Yazar";
            cmd_yazarGetir.Connection = Conn;
            cmd_yazarGetir.CommandType = CommandType.Text;
            SqlDataReader dr_yazarOku;
            Conn.Open();
            dr_yazarOku = cmd_yazarGetir.ExecuteReader();
            while (dr_yazarOku.Read())
            {
                var a = dr_yazarOku["YazarAdi"];
                var b = dr_yazarOku["YazarSoyAdi"];
                cmb_yazar.Items.Add(a + " " + b);
            }
            Conn.Close();

            SqlCommand cmd_yayineviGetir = new SqlCommand();
            cmd_yayineviGetir.CommandText = "SELECT YayinEviAdi FROM YayinEvi";
            cmd_yayineviGetir.Connection = Conn;
            cmd_yayineviGetir.CommandType = CommandType.Text;
            SqlDataReader dr_yayineviOku;
            Conn.Open();
            dr_yayineviOku = cmd_yayineviGetir.ExecuteReader();
            while (dr_yayineviOku.Read())
            {
                cmb_yayinevi.Items.Add(dr_yayineviOku["YayinEviAdi"]);
            }
            Conn.Close();

            SqlCommand cmd_kategoriGetir = new SqlCommand();
            cmd_kategoriGetir.CommandText = "SELECT KategoriAdi FROM Kategori";
            cmd_kategoriGetir.Connection = Conn;
            cmd_kategoriGetir.CommandType = CommandType.Text;
            SqlDataReader dr_kategoriOku;
            Conn.Open();
            dr_kategoriOku = cmd_kategoriGetir.ExecuteReader();
            while (dr_kategoriOku.Read())
            {
                cmb_kategori.Items.Add(dr_kategoriOku["KategoriAdi"]);
            }
            Conn.Close();
        }
        private void kategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriEkle = new KategoriEkle();
            kategoriEkle.ShowDialog();


        }

        private void btn_yayineviEkle_Click(object sender, EventArgs e)
        {
            YayineviEkle yayineviEkle = new YayineviEkle();
            yayineviEkle.ShowDialog();
        }

        private void btn_yazarEkle_Click(object sender, EventArgs e)
        {
            YazarEkle yazarEkle = new YazarEkle();
            yazarEkle.ShowDialog();
        }

        private void cmb_yazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Open();

            
            yazar = cmb_yazar.SelectedItem.ToString();
            
            Conn.Close();
        }

        private void cmb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Open();
           
            kategori = cmb_kategori.SelectedItem.ToString();
            

            Conn.Close();
        }

        private void cmb_yayinevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Open();
            
            yayinevi = cmb_yayinevi.SelectedItem.ToString();

            Conn.Close();
        }

        private void btn_kitabiEkle_Click(object sender, EventArgs e)
        {


            int yayineviID, kategoriID, yazarID;
            Conn.Open();

            if (txt_kitapAdi.Text == null || txt_kitapAdi.Text == "" || txt_barkod.Text == null ||
                txt_barkod.Text == "" || txt_tur.Text == null || txt_tur.Text == "" ||
               txt_sayfaSayisi.Text == null  || txt_kitapFiyati.Text == null || txt_basimTarihi.Text == null
               || txt_stokAdedi == null || txt_kitapOzeti == null ||txt_kitapOzeti.Text == "" || yazar == null ||
               yazar == "" || kategori == null || kategori == "" || yayinevi == null || yayinevi == "")
            {
                MessageBox.Show("Eksik Kitap Bilgisi Girdiniz !");
                this.ResetText();

            }
            else
            {
                SqlCommand cmd_barkod = new SqlCommand("SELECT Barkod FROM Kitap WHERE Barkod = '" + txt_barkod.Text + "'", Conn);
                cmd_barkod.CommandType = CommandType.Text;
                cmd_barkod.Connection =  Conn;
                try
                {

                    if (cmd_barkod.ExecuteScalar().ToString().Any())
                    {
                        MessageBox.Show("Bu Barkoda ait kitap mevcut");
                    }
                }
                catch
                {
                    string Sqltmt_yayinevi = "SELECT YayinEviID FROM YayinEvi WHERE YayinEviAdi='" + yayinevi + "'";
                    SqlCommand cmd_yayinevi = new SqlCommand(Sqltmt_yayinevi, Conn);
                    cmd_yayinevi.CommandType = CommandType.Text; 
                    cmd_yayinevi.CommandText = Sqltmt_yayinevi;
                    cmd_yayinevi.Connection = Conn;
                    yayineviID = Convert.ToInt32(cmd_yayinevi.ExecuteScalar());

                    string Sqltmt_kategori = "SELECT KategoriID FROM Kategori WHERE KategoriAdi='" + kategori + "'";
                    SqlCommand cmd_kategori = new SqlCommand(Sqltmt_kategori, Conn);
                    cmd_kategori.CommandType = CommandType.Text; 
                    cmd_kategori.CommandText = Sqltmt_kategori;
                    cmd_kategori.Connection = Conn;
                    kategoriID = Convert.ToInt32(cmd_kategori.ExecuteScalar());

                    SqlCommand cmd_yazarID = new SqlCommand("SP_YAZAR_ID_CEK", Conn);
                    cmd_yazarID.CommandType = CommandType.StoredProcedure;
                    cmd_yazarID.Parameters.AddWithValue("@YazarAdiSoyadi", DbType.String).Value = yazar;
                    yazarID = Convert.ToInt32(cmd_yazarID.ExecuteScalar());


                    //if (barkod != null || barkod != "")
                    //{
                    //    MessageBox.Show("Bu Kitap Mevcut !");
                    //}
                    //else
                    //{
                    try
                    {

                    
                    string sqltmt_kitapEkle = "INSERT INTO Kitap (KitapAdi,Barkod,Tür,SayfaSayisi,KitapFiyati,BasimTarihi,YazarID,KategoriID,YayinEviID,StokAdet,KitapOzeti) VALUES (@KitapAdi,@Barkod,@Tür,@SayfaSayisi,@KitapFiyati,@BasimTarihi,@YazarID,@KategoriID,@YayinEviID,@StokAdet,@KitapOzeti)";
                    SqlCommand cmd_kitapEkleme = new SqlCommand(sqltmt_kitapEkle, Conn);
                    cmd_kitapEkleme.Parameters.AddWithValue("@KitapAdi", txt_kitapAdi.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@Barkod", txt_barkod.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@Tür", txt_tur.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@SayfaSayisi", txt_sayfaSayisi.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@KitapFiyati", txt_kitapFiyati.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@BasimTarihi", txt_basimTarihi.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@YazarID", yazarID);
                    cmd_kitapEkleme.Parameters.AddWithValue("@KategoriID", kategoriID);
                    cmd_kitapEkleme.Parameters.AddWithValue("@YayinEviID", yayineviID);
                    cmd_kitapEkleme.Parameters.AddWithValue("@StokAdet", txt_stokAdedi.Text);
                    cmd_kitapEkleme.Parameters.AddWithValue("@KitapOzeti", txt_kitapOzeti.Text);
                    cmd_kitapEkleme.ExecuteNonQuery();
                    MessageBox.Show("Kitap Eklendi.");
                    }
                    catch 
                    {

                        MessageBox.Show("Girmiş Olduğunuz Bilgiler Hatalı...Bilgilerinizi Tekrar Kontrol Edin!!!!!!!!!!!");

                    }
                }
                //}
            }
            Conn.Close();
            


        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void KitapEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }

        private void cmb_yazar_Click(object sender, EventArgs e)
        {
            cmb_yazar.Items.Clear();
            SqlCommand cmd_yazarGetir = new SqlCommand();
            cmd_yazarGetir.CommandText = "SELECT YazarAdi,YazarSoyadi FROM Yazar";
            cmd_yazarGetir.Connection = Conn;
            cmd_yazarGetir.CommandType = CommandType.Text;
            SqlDataReader dr_yazarOku;
            Conn.Open();
            dr_yazarOku = cmd_yazarGetir.ExecuteReader();
            while (dr_yazarOku.Read())
            {
                var a = dr_yazarOku["YazarAdi"];
                var b = dr_yazarOku["YazarSoyAdi"];
                cmb_yazar.Items.Add(a + " " + b);
            }
            Conn.Close();
        }

        private void cmb_kategori_Click(object sender, EventArgs e)
        {
            cmb_kategori.Items.Clear();
            SqlCommand cmd_kategoriGetir = new SqlCommand();
            cmd_kategoriGetir.CommandText = "SELECT KategoriAdi FROM Kategori";
            cmd_kategoriGetir.Connection = Conn;
            cmd_kategoriGetir.CommandType = CommandType.Text;
            SqlDataReader dr_kategoriOku;
            Conn.Open();
            dr_kategoriOku = cmd_kategoriGetir.ExecuteReader();
            while (dr_kategoriOku.Read())
            {
                cmb_kategori.Items.Add(dr_kategoriOku["KategoriAdi"]);
            }
            Conn.Close();
            
        }

        private void cmb_yayinevi_Click(object sender, EventArgs e)
        {
            cmb_yayinevi.Items.Clear();
            SqlCommand cmd_yayineviGetir = new SqlCommand();
            cmd_yayineviGetir.CommandText = "SELECT YayinEviAdi FROM YayinEvi";
            cmd_yayineviGetir.Connection = Conn;
            cmd_yayineviGetir.CommandType = CommandType.Text;
            SqlDataReader dr_yayineviOku;
            Conn.Open();
            dr_yayineviOku = cmd_yayineviGetir.ExecuteReader();
            while (dr_yayineviOku.Read())
            {
                cmb_yayinevi.Items.Add(dr_yayineviOku["YayinEviAdi"]);
            }
            Conn.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Kutuphane
{
    public partial class Uye : Form
    {
        public Uye()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private void btn_uyeEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_uyeAdi.Text) || string.IsNullOrWhiteSpace(txt_uyeSoyadi.Text) 
                || string.IsNullOrWhiteSpace(txt_uyeEmail.Text) || string.IsNullOrWhiteSpace(txt_uyeTelefon.Text)
                || string.IsNullOrWhiteSpace(txt_uyeTc.Text) || string.IsNullOrWhiteSpace(txt_uyeAdres.Text)
                || string.IsNullOrWhiteSpace(txt_uyeSehir.Text) || string.IsNullOrWhiteSpace(cmb_tip.Text) || string.IsNullOrWhiteSpace(txt_uyeSifre.Text))
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.. Bilgileri kontrol ediniz.");
            }
            else
            {
                Conn.Open();
                SqlCommand tcKontrol = new SqlCommand("SELECT UyeTc FROM Uye WHERE UyeTc = " + txt_uyeTc.Text, Conn);
                tcKontrol.CommandType = CommandType.Text;
                tcKontrol.Connection = Conn;
                try
                {
                    if (tcKontrol.ExecuteScalar().ToString().Any())
                    {
                        MessageBox.Show("Girmiş olduğunuz tc zaten var.");
                    }
                }
                catch
                {

                    try
                    {

                    
                    string sqltmt_uyeEkle = "insert into Uye (UyeAdi,UyeSoyadi,UyeEmail,UyeTelefon,UyeTc,UyeAdres,UyeSehir,PersonelMi,Sifre,Durum) " +
                        "values(@UyeAdi,@UyeSoyadi,@UyeEmail,@UyeTelefon,@UyeTc,@UyeAdres,@UyeSehir,@PersonelMi,@Sifre,@Durum)";
                    SqlCommand uyeEkle = new SqlCommand(sqltmt_uyeEkle, Conn);
                    uyeEkle.Parameters.AddWithValue("@UyeAdi", txt_uyeAdi.Text);
                    uyeEkle.Parameters.AddWithValue("@UyeSoyadi", txt_uyeSoyadi.Text);
                    uyeEkle.Parameters.AddWithValue("@UyeEmail", txt_uyeEmail.Text);
                    uyeEkle.Parameters.AddWithValue("@UyeTelefon", txt_uyeTelefon.Text);
                    uyeEkle.Parameters.AddWithValue("@UyeTc", txt_uyeTc.Text);
                    uyeEkle.Parameters.AddWithValue("@UyeAdres", txt_uyeAdres.Text);
                    uyeEkle.Parameters.AddWithValue("@UyeSehir", txt_uyeSehir.Text);
                    if (cmb_tip.SelectedIndex == 0)
                    {                       
                        uyeEkle.Parameters.AddWithValue("@PersonelMi", 1);
                    }
                    else
                    {
                        uyeEkle.Parameters.AddWithValue("@PersonelMi", 0);
                    }                 
                    uyeEkle.Parameters.AddWithValue("@Sifre", txt_uyeSifre.Text);
                    uyeEkle.Parameters.AddWithValue("@Durum", 1);
                    uyeEkle.ExecuteNonQuery();
                    MessageBox.Show("Üye Eklendi");
                    }
                    catch 
                    {

                        MessageBox.Show("Girmiş Olduğunuz Bilgiler Hatalı...Bilgilerinizi Tekrar Kontrol Edin!!!!!!!!!!!");
                    }
                }
                Conn.Close();
            }
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}

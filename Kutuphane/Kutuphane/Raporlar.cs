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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private void cmb_raporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Open();

            try
            {
                if (cmb_raporlar.SelectedIndex == 0)
                {
                    SqlCommand alinanKitaplar = new SqlCommand("SELECT * FROM [dbo].[VW_DISARIDA_OLAN_KITAPLAR] ", Conn);
                    SqlDataAdapter oku_alinanKitaplar = new SqlDataAdapter(alinanKitaplar);
                    DataTable table_alinanKitaplar = new DataTable();
                    oku_alinanKitaplar.Fill(table_alinanKitaplar);
                    dGvw_raporlar.DataSource = table_alinanKitaplar;
                }
                else if (cmb_raporlar.SelectedIndex == 1)
                {
                    SqlCommand ongorulenTarih = new SqlCommand("SELECT * FROM ONGORULEN_GETIRILME_TARIHLERI ", Conn);
                    SqlDataAdapter oku_ongorulenTarih = new SqlDataAdapter(ongorulenTarih);
                    DataTable table_ongorulenTarih = new DataTable();
                    oku_ongorulenTarih.Fill(table_ongorulenTarih);
                    dGvw_raporlar.DataSource = table_ongorulenTarih;
                }
                else if (cmb_raporlar.SelectedIndex == 2)
                {
                    
                    SqlCommand uyeninOdedigiToplamCeza = new SqlCommand("SELECT * FROM VW_UYENIN_ODEDIGI_TOPLAM_CEZA ORDER BY [Üyenin Bugüne Kadar Ödediği Toplam Ceza Tutarı] DESC", Conn);
                    SqlDataAdapter oku_uyeninOdedigiToplamCeza = new SqlDataAdapter(uyeninOdedigiToplamCeza);
                    DataTable table_uyeninOdedigiToplamCeza = new DataTable();
                    oku_uyeninOdedigiToplamCeza.Fill(table_uyeninOdedigiToplamCeza);
                    dGvw_raporlar.DataSource = table_uyeninOdedigiToplamCeza;
                }
                else if (cmb_raporlar.SelectedIndex == 3)
                {

                    SqlCommand kitapKazanilanPara = new SqlCommand("SELECT * FROM VW_HANGI_KITAPTAN_NE_KADAR_KAZANILMIS ORDER BY [Bu Kitap İçin Bugüne Kadar Ödenmiş Ceza Tutarları Toplamı] DESC", Conn);
                    SqlDataAdapter oku_kitapKazanilanPara = new SqlDataAdapter(kitapKazanilanPara);
                    DataTable table_kitapKazanilanPara = new DataTable();
                    oku_kitapKazanilanPara.Fill(table_kitapKazanilanPara);
                    dGvw_raporlar.DataSource = table_kitapKazanilanPara;
                }
                else if (cmb_raporlar.SelectedIndex == 4)
                {

                    SqlCommand yillikToplamOdenmisCezalar = new SqlCommand("SP_YILA_GORE_ODENMIS_CEZALARIN_TOPLAMI", Conn);
                    yillikToplamOdenmisCezalar.CommandType = CommandType.StoredProcedure;
                    yillikToplamOdenmisCezalar.Parameters.AddWithValue("@TeslimTarihi", DbType.UInt64).Value = txt_tarih.Text;
                    yillikToplamOdenmisCezalar.ExecuteScalar();
                    SqlDataAdapter oku_yillikToplamOdenmisCezalar = new SqlDataAdapter(yillikToplamOdenmisCezalar);
                    DataTable table_yillikToplamOdenmisCezalar = new DataTable();
                    oku_yillikToplamOdenmisCezalar.Fill(table_yillikToplamOdenmisCezalar);
                    dGvw_raporlar.DataSource = table_yillikToplamOdenmisCezalar;
                }
                else if (cmb_raporlar.SelectedIndex == 5)
                {

                    SqlCommand cezaKullanicilar = new SqlCommand("SELECT * FROM VW_3_VEYA_DAHA_FAZLA_CEZA_ODEMIS_KULLANICILAR", Conn);
                    SqlDataAdapter oku_cezaKullanicilar = new SqlDataAdapter(cezaKullanicilar);
                    DataTable table_cezaKullanicilar = new DataTable();
                    oku_cezaKullanicilar.Fill(table_cezaKullanicilar);
                    dGvw_raporlar.DataSource = table_cezaKullanicilar;
                }
                else if (cmb_raporlar.SelectedIndex == 6)
                {

                    SqlCommand enCokGecGetirilenKitaplar = new SqlCommand("SELECT * FROM VW_EN_COK_GEC_GETIRILEN_KITAPLAR ORDER BY [Bu Kitap İçin Bugüne Kadar Ödenmiş Ceza Tutarları Toplamı] DESC", Conn);
                    SqlDataAdapter oku_enCokGecGetirilenKitaplar = new SqlDataAdapter(enCokGecGetirilenKitaplar);
                    DataTable table_enCokGecGetirilenKitaplar = new DataTable();
                    oku_enCokGecGetirilenKitaplar.Fill(table_enCokGecGetirilenKitaplar);
                    dGvw_raporlar.DataSource = table_enCokGecGetirilenKitaplar;
                }
                else
                {
                    SqlCommand enCokTercihEdilenler = new SqlCommand("SELECT * FROM VW_EN_COK_TERCIH_EDILEN_KITAPLAR_VE_KAC_KERE_ODUNC_ALINDIKLARI ORDER BY [Kitabın Ödünç Alınma Sayısı] DESC", Conn);
                    SqlDataAdapter oku_enCokTercihEdilenler = new SqlDataAdapter(enCokTercihEdilenler);
                    DataTable table_enCokTercihEdilenler = new DataTable();
                    oku_enCokTercihEdilenler.Fill(table_enCokTercihEdilenler);
                    dGvw_raporlar.DataSource = table_enCokTercihEdilenler;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Conn.Close();
        }
    }
}

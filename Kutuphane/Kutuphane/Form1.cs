using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string uyeTc, kitap, dtGrid4UyeTc, dtGrid4KitapAdi;
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        GirisEkrani girisEkrani = new GirisEkrani();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Conn.Open();
            SqlCommand cmd_kitap = new SqlCommand("SELECT Barkod,KitapAdi,StokAdet FROM Kitap", Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd_kitap);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            string Sqltmt = "select UyeAdi+' '+UyeSoyadi as [Üye Ad Soyad], UyeTelefon,UyeTc from Uye WHERE Durum = 1 ";
            SqlCommand cmd_uye = new SqlCommand(Sqltmt, Conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd_uye);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            Conn.Close();
        }
        private void btn_kitapVer_Click(object sender, EventArgs e)
        {

            if (uyeTc == null || kitap == null || uyeTc == "" || kitap == "")
            {
                MessageBox.Show(" Uye veya Kitap seçimi yapmadınız");
            }
            else
            {

                Conn.Open();
                SqlCommand cmd_uyeTc = new SqlCommand("select UyeID from Uye WHERE Durum = 1 AND UyeTc=" + uyeTc, Conn);
                cmd_uyeTc.CommandType = CommandType.Text; // or storeprocedure
                cmd_uyeTc.Connection = Conn;
                int tc = Convert.ToInt32(cmd_uyeTc.ExecuteScalar());
                SqlCommand cmd_kitapAdi = new SqlCommand("select KitapAdi from Kitap Where KitapAdi ='" + kitap + "'", Conn);
                cmd_kitapAdi.CommandType = CommandType.Text;
                cmd_kitapAdi.Connection = Conn;
                string kitapAdi = Convert.ToString(cmd_kitapAdi.ExecuteScalar());
                SqlCommand cmd_kitapVer = new SqlCommand("SP_KITAP_VERME", Conn);
                cmd_kitapVer.CommandType = CommandType.StoredProcedure;
                cmd_kitapVer.Parameters.AddWithValue("@UyeID", DbType.UInt64).Value = tc;
                cmd_kitapVer.Parameters.AddWithValue("@KitapAdi", DbType.String).Value = kitapAdi;
                cmd_kitapVer.Parameters.AddWithValue("@KitabiKimVerdi", DbType.UInt32).Value = 5;
                cmd_kitapVer.Parameters.Add("@MESSAGE", SqlDbType.NVarChar, 5000);
                cmd_kitapVer.Parameters["@MESSAGE"].Direction = ParameterDirection.Output;
                cmd_kitapVer.ExecuteScalar();

                MessageBox.Show(cmd_kitapVer.Parameters["@MESSAGE"].Value.ToString());
                Conn.Close();

                Conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Barkod,KitapAdi,StokAdet FROM Kitap", Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Conn.Close();

            }

        

    }
        private void txt_uyeAra_TextChanged(object sender, EventArgs e)
        {
            string Sqltmt = "select UyeAdi+' '+UyeSoyadi as [Üye Ad Soyad], UyeTelefon,UyeTc from Uye WHERE Durum = 1 AND UyeTc like '%" + txt_uyeAra.Text+"%'";
            SqlCommand cmd_uyeAra = new SqlCommand(Sqltmt, Conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd_uyeAra);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void txt_kitapAra_TextChanged(object sender, EventArgs e)
        {
            string Sqltmt = "select Barkod,KitapAdi,StokAdet from Kitap Where Barkod like '%" + txt_kitapAra.Text + "%'";
            SqlCommand cmd_kitapAra = new SqlCommand(Sqltmt, Conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd_kitapAra);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçili satırın Y koordinatı
           
            int ykoordinat = dataGridView2.CurrentCellAddress.Y;


            uyeTc = dataGridView2.Rows[ykoordinat].Cells[2].Value.ToString();

            if (e.RowIndex == -1)

            {

                return;

            }
          
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Seçili satırın Y koordinatı

            int ykoordinat = dataGridView2.CurrentCellAddress.Y;

            uyeTc = dataGridView2.Rows[ykoordinat].Cells[2].Value.ToString();

            if (e.RowIndex == -1)

            {

                return;

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Seçili satırın Y koordinatı
                     
            int ykoordinat = dataGridView1.CurrentCellAddress.Y;

            kitap = dataGridView1.Rows[ykoordinat].Cells[1].Value.ToString();

            if (e.RowIndex == -1)

            {
                return;
            }      
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Seçili satırın Y koordinatı                 
            int ykoordinat = dataGridView1.CurrentCellAddress.Y;

            kitap = dataGridView1.Rows[ykoordinat].Cells[1].Value.ToString();

            if (e.RowIndex == -1)

            {
                return;
            }           
        }

        private void btn_kitapAl_Click(object sender, EventArgs e)
        {
            if (dtGrid4UyeTc == null || dtGrid4KitapAdi == null || dtGrid4UyeTc == "" || dtGrid4KitapAdi == "")
            {
                MessageBox.Show("Üye veya Kitap Seçimi Yapmadınız !");

            }
            else
            {

                Conn.Open();
                SqlCommand cmd_kitapIade = new SqlCommand("SP_KITAP_IADE_ETME", Conn);
                cmd_kitapIade.CommandType = CommandType.StoredProcedure;
                cmd_kitapIade.Parameters.AddWithValue("@UYE_TC", DbType.UInt64).Value = dtGrid4UyeTc;
                cmd_kitapIade.Parameters.AddWithValue("@KITAP_ADI", DbType.String).Value = dtGrid4KitapAdi;
                cmd_kitapIade.Parameters.Add("@MESSAGE", SqlDbType.NVarChar, 5000);
                cmd_kitapIade.Parameters["@MESSAGE"].Direction = ParameterDirection.Output;
                cmd_kitapIade.ExecuteScalar();

                MessageBox.Show(cmd_kitapIade.Parameters["@MESSAGE"].Value.ToString());
                Conn.Close();


                Conn.Open();
                SqlCommand cmd_yenileDtGrid1 = new SqlCommand("SELECT Barkod,KitapAdi,StokAdet FROM Kitap", Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd_yenileDtGrid1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                string Sqltmt = "SELECT UyeTc,KitapAdi,AlimTarihi FROM UYE_USTUNDE_BULUNAN_KITAPLAR WHERE UYETC =" + uyeTc;
                SqlCommand cmd_yenileDtGrid4 = new SqlCommand(Sqltmt, Conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd_yenileDtGrid4);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView4.DataSource = dt1;

                Conn.Close();
            }
        }

        private void btn_raporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
            
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
        }

        private void btn_uyeEkle_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.ShowDialog();
        }

        private void btn_uyeSil_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand alinanKitap = new SqlCommand("SELECT * FROM UYE_USTUNDE_BULUNAN_KITAPLAR WHERE Durum = 1 AND UYETC = " + uyeTc, Conn);
            alinanKitap.CommandType = CommandType.Text;
            alinanKitap.Connection = Conn;
            try
            {
                if (alinanKitap.ExecuteScalar().ToString().Any())
                {
                    MessageBox.Show("Üyenin Üstünde Bulunan Kitap veya Kitaplar var. Önce onları teslim etmsei gerekiyor.");
                }
            }
            catch
            {
                try
                {
                    
                    SqlCommand uyeSil = new SqlCommand("update uye set Durum=0 where UyeTc = " + uyeTc, Conn);
                    uyeSil.CommandType = CommandType.Text;
                    uyeSil.Connection = Conn;
                    uyeSil.ExecuteNonQuery();
                    MessageBox.Show("Üye Silindi");

                    string sqltmt_uye = "select UyeAdi+' '+UyeSoyadi as [Üye Ad Soyad], UyeTelefon,UyeTc from Uye WHERE Durum = 1 ";
                    SqlCommand uyeDataGrid = new SqlCommand(sqltmt_uye, Conn);
                    SqlDataAdapter oku = new SqlDataAdapter(uyeDataGrid);
                    DataTable dataTable = new DataTable();
                    oku.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
                catch
                {

                    MessageBox.Show("Silmek istediğiniz üyeyi Seçiniz..");
                }
            }
            Conn.Close();
        }
        private void cmb_uyeKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (uyeTc == null || uyeTc == "")
            {
                MessageBox.Show("Uye seçimi yapmadınız");
            }
            else
            {
                if (cmb_uyeKitaplar.SelectedIndex == 0)
                {
                    string Sqltmt_uyeKitaplar = "SELECT UyeTc,KitapAdi,AlimTarihi FROM UYE_USTUNDE_BULUNAN_KITAPLAR WHERE UYETC =" + uyeTc;
                    SqlCommand cmd_uyeKitaplar = new SqlCommand(Sqltmt_uyeKitaplar, Conn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd_uyeKitaplar);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    dataGridView4.DataSource = dt1;
                }
                else
                {

                    string Sqltmt_uyeBorc = "SELECT * FROM UYENIN_HANGI_KITAPTAN_NEKADAR_BORCU_VAR WHERE UYETC =" + uyeTc;
                    SqlCommand cmd_uyeBorc = new SqlCommand(Sqltmt_uyeBorc, Conn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd_uyeBorc);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView4.DataSource = dt2;

                }
            }            
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            GirisEkrani frmGirisEkrani = new GirisEkrani();
            frmGirisEkrani.Show();
            this.Hide();
        }

        private void btn_borcOde_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_uyeKitaplar.SelectedIndex == 1)
                {


                    Conn.Open();
                    SqlCommand cmd_kitapAdi = new SqlCommand("select KitapAdi from Kitap Where KitapAdi ='" + dtGrid4KitapAdi + "'", Conn);
                    cmd_kitapAdi.CommandType = CommandType.Text;
                    cmd_kitapAdi.Connection = Conn;
                    string kitapAdi = Convert.ToString(cmd_kitapAdi.ExecuteScalar());
                    SqlCommand cmd_borcOde = new SqlCommand("BORC_ODEME", Conn);
                    cmd_borcOde.CommandType = CommandType.StoredProcedure;
                    cmd_borcOde.Parameters.AddWithValue("@UYE_TC", DbType.UInt64).Value = dtGrid4UyeTc;
                    cmd_borcOde.Parameters.AddWithValue("@KITAP_ADI", DbType.String).Value = kitapAdi;
                    cmd_borcOde.Parameters.Add("@MESSAGE", SqlDbType.NVarChar, 5000);
                    cmd_borcOde.Parameters["@MESSAGE"].Direction = ParameterDirection.Output;
                    cmd_borcOde.ExecuteScalar();

                    MessageBox.Show(cmd_borcOde.Parameters["@MESSAGE"].Value.ToString());
                    Conn.Close();


                    Conn.Open();


                    string Sqltmt = "SELECT UyeTc,KitapAdi,AlimTarihi FROM UYENIN_HANGI_KITAPTAN_NEKADAR_BORCU_VAR WHERE UYETC =" + uyeTc;
                    SqlCommand cmd_yenileDtGrid4 = new SqlCommand(Sqltmt, Conn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd_yenileDtGrid4);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView4.DataSource = dt2;

                    SqlCommand cmd_yenileDtGrid1 = new SqlCommand("SELECT Barkod,KitapAdi,StokAdet FROM Kitap", Conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd_yenileDtGrid1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
                else
                {
                    MessageBox.Show("Teslim tarihi geçmiş kitabı seçiniz!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conn.Close();
        }     
        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ykoordinat = dataGridView4.CurrentCellAddress.Y;

            dtGrid4UyeTc = dataGridView4.Rows[ykoordinat].Cells[0].Value.ToString();
            dtGrid4KitapAdi = dataGridView4.Rows[ykoordinat].Cells[1].Value.ToString();

            if (e.RowIndex == -1)
            {
                return;
            }
           
        }

        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ykoordinat = dataGridView4.CurrentCellAddress.Y;

            dtGrid4UyeTc = dataGridView4.Rows[ykoordinat].Cells[0].Value.ToString();
            dtGrid4KitapAdi = dataGridView4.Rows[ykoordinat].Cells[1].Value.ToString();

            if (e.RowIndex == -1)
            {
                return;
            }
            
        }
    }
}

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
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private void btn_kategoriEkle_Click(object sender, EventArgs e)
        {
            if (txt_kategoriAdi.Text == null)
            {
                MessageBox.Show("Kategori Adı Girilmedi !");
            }
            else
            {
                Conn.Open();
                string sqltmt_kategoriEkle = "INSERT INTO Kategori (KategoriAdi) VALUES (@KategoriAdi)";
                SqlCommand cmd_kategoriEkleme = new SqlCommand(sqltmt_kategoriEkle, Conn);
                cmd_kategoriEkleme.Parameters.AddWithValue("@KategoriAdi", txt_kategoriAdi.Text);
                cmd_kategoriEkleme.ExecuteNonQuery();
                MessageBox.Show("Kategori Eklendi.");
                Conn.Close();

                Conn.Open();
                Conn.Close();

            }            
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}

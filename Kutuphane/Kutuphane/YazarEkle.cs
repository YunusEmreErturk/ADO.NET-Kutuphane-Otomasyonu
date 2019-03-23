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
    public partial class YazarEkle : Form
    {
        public YazarEkle()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private void btn_yazarEkle_Click(object sender, EventArgs e)
        {
            if (txt_yazarAdi.Text == null || txt_yazarSoyadi.Text == null || txt_ozgecmis.Text == null)
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!");
            }
            else
            {
                Conn.Open();
                string sqltmt_yazarEkle = "INSERT INTO Yazar (YazarAdi,YazarSoyadi,Ozgecmis) VALUES(@YazarAdi,@YazarSoyadi,@Ozgecmis)";
                SqlCommand cmd_yazarEkleme = new SqlCommand(sqltmt_yazarEkle, Conn);
                cmd_yazarEkleme.Parameters.AddWithValue("@YazarAdi", txt_yazarAdi.Text);
                cmd_yazarEkleme.Parameters.AddWithValue("@YazarSoyadi", txt_yazarSoyadi.Text);
                cmd_yazarEkleme.Parameters.AddWithValue("@Ozgecmis", txt_ozgecmis.Text);
                cmd_yazarEkleme.ExecuteNonQuery();
                MessageBox.Show("Yazar Eklendi.");
                Conn.Close();

                Conn.Open();
                Conn.Close();

            }
        }
    }
}

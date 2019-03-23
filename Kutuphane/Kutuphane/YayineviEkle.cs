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
    public partial class YayineviEkle : Form
    {
        public YayineviEkle()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private void btn_yayineviEkle_Click(object sender, EventArgs e)
        {
            if (txt_yayineviAdi.Text == null)
            {
                MessageBox.Show("Yayınevi Adı Girilmedi !");
            }
            else
            {
                Conn.Open();
                string sqltmt_yayineviEkle = "INSERT INTO YayinEvi (YayinEviAdi) VALUES (@YayinEviAdi)";
                SqlCommand cmd_yayineviEkleme = new SqlCommand(sqltmt_yayineviEkle, Conn);
                cmd_yayineviEkleme.Parameters.AddWithValue("@YayinEviAdi", txt_yayineviAdi.Text);
                cmd_yayineviEkleme.ExecuteNonQuery();
                MessageBox.Show("Yayınevi Eklendi.");
                Conn.Close();

            }
        }
    }
}

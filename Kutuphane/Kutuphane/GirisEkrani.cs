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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        string personelTc,sifre;
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void GirisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }

        private void btn_uyeOl_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.ShowDialog();
        }

        private void txt_PersonelTc_MouseClick(object sender, MouseEventArgs e)
        {
            txt_PersonelTc.Text = "";
        }

        private void txt_sifre_MouseClick(object sender, MouseEventArgs e)
        {
            txt_sifre.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Conn.Open();
            personelTc = txt_PersonelTc.Text;
            string Sqltmt2 = "select Sifre from Uye where PersonelMi = 1 AND UyeTc=" + personelTc;
            SqlCommand cmd1 = new SqlCommand(Sqltmt2, Conn);
            cmd1.CommandType = CommandType.Text; // or storeprocedure
            cmd1.CommandText = Sqltmt2;
            cmd1.Connection = Conn;
            sifre = Convert.ToString(cmd1.ExecuteScalar());
            if (txt_sifre.Text == sifre && (txt_sifre.Text  != "" ))
            {
                MessageBox.Show("Giris Başarılı");
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Tc veya şifre yanlış");
            }
            Conn.Close();
        }
    }
}

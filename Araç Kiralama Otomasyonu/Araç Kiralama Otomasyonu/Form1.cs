using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Araç_Kiralama_Otomasyonu
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = kullaniciAdi.Text;
            string sifre = parola.Text;
            con = new SqlConnection("Data Source=DESKTOP-LNTS0B0\\SQLEXPRESS;Initial Catalog= aracKiralama; Integrated Security=true");
            com = new SqlCommand();

            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from kullanici_bilgi where kullanici_adi='" + kullaniciAdi.Text + "'And sifre='" + parola.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                main a = new main();
                a.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama_Otomasyonu
{
    public partial class Form1 : Form
    {
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

            if (ad == "admin" && sifre == "admin")
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

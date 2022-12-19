using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Kiralama_Otomasyonu
{
    class aracKiralama
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNTS0B0\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand com, string sorgu)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = sorgu;
            com.ExecuteNonQuery();
            con.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, con);
            adtr.Fill(tablo);
            con.Close();
            return tablo;
        }
    }
}

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

namespace Personel_Kayıt
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UHPV4QF\\SQLEXPRESS01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            //toplam personel sayısı
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select count (*) from Tbl_Personel",baglantı);
            SqlDataReader dr1=komut1.ExecuteReader();
            while(dr1.Read())
            {
                labelToplamPersonel.Text = dr1[0].ToString();
            }
            baglantı.Close();
            
            //evli sayısı
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select count (*) from Tbl_Personel where PerDurum=1", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                labelEvliPersonel.Text = dr2[0].ToString();
            }
            baglantı.Close();

            //bekar sayısı
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select count (*) from Tbl_Personel where PerDurum=0", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                labelBekarPersonel.Text = dr3[0].ToString();
            }
            baglantı.Close();

            //şehir sayısı
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel",baglantı);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                labelŞehirSayı.Text = dr4[0].ToString();
            }
            baglantı.Close();

            //toplam maas
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select Sum(permaas) from Tbl_Personel", baglantı);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while(dr5.Read())
            {
                labelToplamMaas.Text = dr5[0].ToString();
            }
            baglantı.Close();

            //ortalama maas
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) from Tbl_Personel", baglantı);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                labelOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglantı.Close();
        }
    }
}

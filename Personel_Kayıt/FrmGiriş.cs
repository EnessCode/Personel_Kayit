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
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UHPV4QF\\SQLEXPRESS01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");

        private void buttonGiriş_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_yönetici where kullanıcıad=@p1 and sifre=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1", textBoxKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxŞifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if(dr.Read())
            {
                FrmAnaForm frm=new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız!");
            }

            baglantı.Close();
        }
    }
}

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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UHPV4QF\\SQLEXPRESS01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");

        void temizle()
        {
            textBoxPerId.Text = "";
            textBoxPerad.Text = "";
            textBoxPersoyad.Text = "";
            textBoxPermeslek.Text = "";
            maskedTextBoxPermaas.Text = "";
            comboBoxPerşehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBoxPerad.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }


        private void buttonListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerMeslek, PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", textBoxPerad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxPersoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxPerşehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxPermaas.Text);
            komut.Parameters.AddWithValue("@p5", textBoxPermeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel eklendi!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true) 
            {
                label8.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                label8.Text = "False";
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxPerId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxPerad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxPersoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxPerşehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxPermaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBoxPermeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglantı);
            komutsil.Parameters.AddWithValue("@k1", textBoxPerId.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Silindi!"); 
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7",baglantı);
            komutguncelle.Parameters.AddWithValue("@a1",textBoxPerad.Text);
            komutguncelle.Parameters.AddWithValue("@a2",textBoxPersoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3",comboBoxPerşehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4",maskedTextBoxPermaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6",textBoxPermeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7",textBoxPerId.Text);
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Güncellendi!");
        }

        private void buttonİstatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void buttonGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler gr=new FrmGrafikler();
            gr.Show();
        }
    }
}

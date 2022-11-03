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

namespace pansiyonotomasyonu
{
    public partial class YeniMüşteri : Form
    {
        public YeniMüşteri()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdemPansiyonn;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "109";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "108";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "106";
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "105";
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "107";
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları göstermektedir.");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları göstermektedir.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateCikis.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label10.Text = Sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label10.Text) * 200;
            textucret.Text = ucret.ToString();


        }

        private void btnKydt_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,Odano,Ucret,GirisTarihi,CikisTarihi) VALUES ( @adi , @soyadi , @cinsiyet , @telefon , @mail ,  @tc , @odano , @ucret , @giristarihi ,  @cikistarihi )", baglanti);
            komut.Parameters.AddWithValue("@adi", txtAdi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtSoyad.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCnsyt.Text);
            komut.Parameters.AddWithValue("@telefon", maskTel.Text);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@odano", txtOdano.Text);
            komut.Parameters.AddWithValue("@ucret", textucret.Text);
            komut.Parameters.AddWithValue("@giristarihi", dateGiris.Value.Date);
            komut.Parameters.AddWithValue("@cikistarihi", dateCikis.Value.Date);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("uy musteri kaydu yapulmustir");

        }
    }
}


//baglanti.Open();
//SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,Odano,Ucret,GirisTarihi,CikisTarihi) values(' " + txtAdi.Text + " ','" + txtSoyad.Text + " ','" + comboCnsyt.Text + " ','" + maskTel.Text + " ','" + txtMail.Text + " ','" + txtTc.Text + " ','" + txtOdano.Text + " ','" + textucret.Text + " ','" + dateGiris.Value.ToLongDateString() + " ','" + dateCikis.Value.ToLongDateString() + " ' ", baglanti);
//komut.ExecuteNonQuery();
//baglanti.Close();

//MessageBox.Show("uy musteri kaydu yapulmustir");





//@txtAdi , @txtSoyad , @comboCnsyt , @maskTel , @txtMail ,  @txtTc , @txtOdano , @textucret , @dateGiris ,  @dateCikis 

// " ','" + textucret.Text +  " ','" + dateGiris.Value.ToString("dd-MM-yyyy") + " ','" + dateCikis.Value.ToString("dd-MM-yyyy")+  Ucret,GirisTarihi,CikisTarihi
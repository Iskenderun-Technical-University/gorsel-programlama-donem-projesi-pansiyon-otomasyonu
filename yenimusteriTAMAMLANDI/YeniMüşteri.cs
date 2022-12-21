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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }


        //------------------2.HAFTA----------------------------
        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

       

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + txtAdi.Text + "' ,'" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //-----------------1.HAFTA----------------------
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

            ucret = Convert.ToInt32(label10.Text) * 500;
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

            SqlCommand komut2 = new SqlCommand("insert into Oda103 (Adi,Soyadi) VALUES ( @adi , @soyadi  )", baglanti);
            komut2.Parameters.AddWithValue("@adi", txtAdi.Text);
            komut2.Parameters.AddWithValue("@soyadi", txtSoyad.Text);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Müşteri kaydı yapılmıştır.");

        }

        /* -----------------------2.HAFTA---------------------------*/

        private void YeniMüşteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102 ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103 ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104 ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105 ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }



            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106 ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }






            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108 ", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false;
            }


           

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109 ", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
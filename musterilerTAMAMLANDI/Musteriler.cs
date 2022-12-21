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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdemPansiyonn;Integrated Security=True");

        //------------------------------------1.HAFTA----------------------------------
        private void verilerigoster()
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }



        private void btnveriler_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update MusteriEkle set Adi = @adi , Soyadi = @soyadi , Cinsiyet = @cinsiyet , Telefon = @telefon , Mail = @mail , TC = @tc , OdaNo = @odano , Ucret = @ucret , GirisTarihi = @giristarihi , CikisTarihi = @cikistarihi  WHERE Musteriid = '" + id + "' ";

            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
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
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();






        }
        //-------------------------2.HAFTA---------------------------------
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from MusteriEkle where Musteriid = ("+ id +" )", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            

            if (txtOdano.Text == "101")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }


            if (txtOdano.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }



            if (txtOdano.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        //------------------------------------1.HAFTA------------------------------------
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboCnsyt.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateCikis.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyad.Clear();
            comboCnsyt.Text = "";
            maskTel.Clear();
            txtMail.Text = "";
            txtTc.Clear();
            txtOdano.Clear();
            textucret.Clear();
            dateGiris.Text = "";
            dateCikis.Text = "";
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '% " + textisim.Text + " % '", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void txtisim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



// SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid = (" + id + ")", baglanti);

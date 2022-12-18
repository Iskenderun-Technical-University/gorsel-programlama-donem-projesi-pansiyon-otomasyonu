﻿using System;
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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdemPansiyonn;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }



        //---------------2.HAFTA--------------------------
        private void btnhesap_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(txtsayi.Text);
            lblmaas.Text = (personel * 5000).ToString();


            //------------3.HAFTA---------------
            int sonuc;
            sonuc = Convert.ToInt32(lblkasatoplam.Text) - (Convert.ToInt32(lblmaas.Text) + Convert.ToInt32(lbluruntutar.Text) + Convert.ToInt32(lbluruntutar2.Text) + Convert.ToInt32(lbluruntutar3.Text) + Convert.ToInt32(lblfatura.Text) + Convert.ToInt32(lblfatura2.Text) + Convert.ToInt32(lblfatura3.Text));
            lblsonuc.Text = sonuc.ToString();

        }


        //---------------3.HAFTA--------------------------
        private void GelirGider_Load(object sender, EventArgs e)
        {
            //kasada ki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            //gıda giderleri

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lbluruntutar.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();

            //icecek giderleri

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lbluruntutar2.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();


           


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

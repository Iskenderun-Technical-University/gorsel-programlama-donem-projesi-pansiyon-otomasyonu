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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdemPansiyonn;Integrated Security=True");

        
        //--------------------------------2.HAFTA--------------------
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " +  oku1["Soyadi"].ToString();

            }
            baglanti.Close();

            if(btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
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
            }
        }
    }
}

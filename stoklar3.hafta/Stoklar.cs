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
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdemPansiyonn;Integrated Security=True");


        //--------------2.HAFTA--------------------
        private void veriler()
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        //---------------3.HAFTA-----------------
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Fatura", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnstokkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler) VALUES ( @gida , @icecek , @cerez  )", baglanti);
            komut.Parameters.AddWithValue("@gida", txtgida.Text);
            komut.Parameters.AddWithValue("@icecek", txticecek.Text);
            komut.Parameters.AddWithValue("@cerez", txtatistir.Text);


            
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnkydt2_Click(object sender, EventArgs e)
        {
           
        }
    }
}

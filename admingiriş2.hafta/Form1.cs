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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdemPansiyonn;Integrated Security=True");


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //-----------------2.HAFTA-----------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici = @kullanici AND Sifre = @sifre ";
                SqlParameter prm1 = new SqlParameter("kullanici", txtklncad.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    Anasayfa fr = new Anasayfa();
                    fr.Show();
                    this.Hide();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hataludur");

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pansiyonotomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            GirisSayfasi fr = new GirisSayfasi();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniMüşteri fr = new YeniMüşteri();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();
        }


        //------------2.HAFTA-------------
        private void btnstok_Click(object sender, EventArgs e)
        {
            Stoklar fr = new Stoklar();
            fr.Show();
        }

        //--------------3.HAFTA------------
        private void btnradyo_Click(object sender, EventArgs e)
        {
            Radyo fr = new Radyo();
            fr.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        //-------------2.HAFTA----------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        //---------3.Hafta----------------
        private void button5_Click(object sender, EventArgs e)
        {
            SifreGuncelleme fr = new SifreGuncelleme();
            fr.Show();
        }

        //--------------2.HAFTA------------------------
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnmaas_Click(object sender, EventArgs e)
        {
            GelirGider fr = new GelirGider();
            fr.Show();

        }

        //------------3.HAFTA-------------------------------
        private void btngazete_Click(object sender, EventArgs e)
        {
            Haberler fr = new Haberler();
            fr.Show();
        }

        private void btnhakki_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADEM PANSİYON 2022'DE KURULMUŞTUR");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisSayfasi fr = new GirisSayfasi();
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            YeniMüşteri fr = new YeniMüşteri();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GelirGider fr = new GelirGider();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Stoklar fr = new Stoklar();
            fr.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Haberler fr = new Haberler();
            fr.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mesajlar fr = new Mesajlar();
            fr.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Radyo fr = new Radyo();
            fr.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADEM PANSİYON 2022'DE KURULMUŞTUR");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

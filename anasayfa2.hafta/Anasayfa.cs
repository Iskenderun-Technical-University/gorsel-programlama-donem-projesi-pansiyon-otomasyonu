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

        private void btnradyo_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {

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
    }
}

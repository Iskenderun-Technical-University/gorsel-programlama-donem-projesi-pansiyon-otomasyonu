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
    public partial class Radyo : Form
    {
        public Radyo()
        {
            InitializeComponent();
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/ak_dtvh_slowturk";
            
           
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://live.powerapp.com.tr/powerfm/abr/playlist.m3u8";
        }

        private void link3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/dreamturk ";
        }

        private void Radyo_Load(object sender, EventArgs e)
        {

        }
    }


    }


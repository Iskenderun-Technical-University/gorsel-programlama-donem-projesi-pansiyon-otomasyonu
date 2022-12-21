
namespace pansiyonotomasyonu
{
    partial class Radyo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radyo));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.link2 = new System.Windows.Forms.LinkLabel();
            this.link3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(296, 278);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // link1
            // 
            this.link1.AutoSize = true;
            this.link1.Location = new System.Drawing.Point(12, 293);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(69, 13);
            this.link1.TabIndex = 3;
            this.link1.TabStop = true;
            this.link1.Text = "SLOWTURK";
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // link2
            // 
            this.link2.AutoSize = true;
            this.link2.Location = new System.Drawing.Point(12, 320);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(69, 13);
            this.link2.TabIndex = 4;
            this.link2.TabStop = true;
            this.link2.Text = "POWER FM ";
            this.link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link2_LinkClicked);
            // 
            // link3
            // 
            this.link3.AutoSize = true;
            this.link3.Location = new System.Drawing.Point(12, 347);
            this.link3.Name = "link3";
            this.link3.Size = new System.Drawing.Size(82, 13);
            this.link3.TabIndex = 5;
            this.link3.TabStop = true;
            this.link3.Text = "DREAM TURK ";
            this.link3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link3_LinkClicked);
            // 
            // Radyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(301, 367);
            this.Controls.Add(this.link3);
            this.Controls.Add(this.link2);
            this.Controls.Add(this.link1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Radyo";
            this.Text = "Radyo";
            this.Load += new System.EventHandler(this.Radyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.LinkLabel link2;
        private System.Windows.Forms.LinkLabel link3;
    }
}
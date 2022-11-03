
namespace pansiyonotomasyonu
{
    partial class GirisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.klncad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtklncad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // klncad
            // 
            this.klncad.AutoSize = true;
            this.klncad.BackColor = System.Drawing.Color.Transparent;
            this.klncad.Font = new System.Drawing.Font("Arial Narrow", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klncad.Location = new System.Drawing.Point(134, 112);
            this.klncad.Name = "klncad";
            this.klncad.Size = new System.Drawing.Size(117, 24);
            this.klncad.TabIndex = 0;
            this.klncad.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(209, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // txtklncad
            // 
            this.txtklncad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtklncad.Location = new System.Drawing.Point(282, 117);
            this.txtklncad.Name = "txtklncad";
            this.txtklncad.Size = new System.Drawing.Size(100, 20);
            this.txtklncad.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsifre.Location = new System.Drawing.Point(282, 166);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.UseSystemPasswordChar = true;
            this.txtsifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btngirisyap
            // 
            this.btngirisyap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btngirisyap.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngirisyap.Location = new System.Drawing.Point(282, 218);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(100, 30);
            this.btngirisyap.TabIndex = 2;
            this.btngirisyap.Text = "GİRİŞ YAP";
            this.btngirisyap.UseVisualStyleBackColor = false;
            this.btngirisyap.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pansiyonotomasyonu.Properties.Resources.adem;
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::pansiyonotomasyonu.Properties.Resources.WhatsApp_Image_2022_10_30_at_16_45_11;
            this.ClientSize = new System.Drawing.Size(536, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtklncad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.klncad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisSayfasi";
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label klncad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtklncad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


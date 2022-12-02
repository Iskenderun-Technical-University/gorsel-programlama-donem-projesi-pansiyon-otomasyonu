
namespace pansiyonotomasyonu
{
    partial class GelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirGider));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkasatoplam = new System.Windows.Forms.Label();
            this.lblmaas = new System.Windows.Forms.Label();
            this.lbluruntutar = new System.Windows.Forms.Label();
            this.lblfatura = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "KASADA Kİ TOPLAM TUTAR:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "PERSONEL MAAŞLARI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ALINAN ÜRÜNLERİN TUTARI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "FATURALAR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "SONUÇ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(393, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "PERSONEL SAYISI:";
            // 
            // lblkasatoplam
            // 
            this.lblkasatoplam.AutoSize = true;
            this.lblkasatoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkasatoplam.Location = new System.Drawing.Point(262, 21);
            this.lblkasatoplam.Name = "lblkasatoplam";
            this.lblkasatoplam.Size = new System.Drawing.Size(26, 18);
            this.lblkasatoplam.TabIndex = 6;
            this.lblkasatoplam.Text = "00";
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmaas.Location = new System.Drawing.Point(262, 54);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(26, 18);
            this.lblmaas.TabIndex = 7;
            this.lblmaas.Text = "00";
            // 
            // lbluruntutar
            // 
            this.lbluruntutar.AutoSize = true;
            this.lbluruntutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluruntutar.Location = new System.Drawing.Point(262, 85);
            this.lbluruntutar.Name = "lbluruntutar";
            this.lbluruntutar.Size = new System.Drawing.Size(26, 18);
            this.lbluruntutar.TabIndex = 8;
            this.lbluruntutar.Text = "00";
            // 
            // lblfatura
            // 
            this.lblfatura.AutoSize = true;
            this.lblfatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfatura.Location = new System.Drawing.Point(262, 119);
            this.lblfatura.Name = "lblfatura";
            this.lblfatura.Size = new System.Drawing.Size(26, 18);
            this.lblfatura.TabIndex = 9;
            this.lblfatura.Text = "00";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(262, 259);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(26, 18);
            this.lblsonuc.TabIndex = 10;
            this.lblsonuc.Text = "00";
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(582, 22);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 20);
            this.txtsayi.TabIndex = 11;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(582, 114);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(75, 23);
            this.btnhesap.TabIndex = 12;
            this.btnhesap.Text = "HESAPLA";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1592, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.lblfatura);
            this.Controls.Add(this.lbluruntutar);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.lblkasatoplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblkasatoplam;
        private System.Windows.Forms.Label lblmaas;
        private System.Windows.Forms.Label lbluruntutar;
        private System.Windows.Forms.Label lblfatura;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label label12;
    }
}
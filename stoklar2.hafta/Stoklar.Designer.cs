
namespace pansiyonotomasyonu
{
    partial class Stoklar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgida = new System.Windows.Forms.TextBox();
            this.txticecek = new System.Windows.Forms.TextBox();
            this.txtatistir = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnstokkaydet = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIDA TUTAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İÇECEK TUTARI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ATIŞTIRMALIKLAR:";
            // 
            // txtgida
            // 
            this.txtgida.Location = new System.Drawing.Point(136, 24);
            this.txtgida.Name = "txtgida";
            this.txtgida.Size = new System.Drawing.Size(100, 20);
            this.txtgida.TabIndex = 3;
            // 
            // txticecek
            // 
            this.txticecek.Location = new System.Drawing.Point(136, 71);
            this.txticecek.Name = "txticecek";
            this.txticecek.Size = new System.Drawing.Size(100, 20);
            this.txticecek.TabIndex = 4;
            // 
            // txtatistir
            // 
            this.txtatistir.Location = new System.Drawing.Point(136, 121);
            this.txtatistir.Name = "txtatistir";
            this.txtatistir.Size = new System.Drawing.Size(100, 20);
            this.txtatistir.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 244);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnstokkaydet
            // 
            this.btnstokkaydet.Location = new System.Drawing.Point(136, 177);
            this.btnstokkaydet.Name = "btnstokkaydet";
            this.btnstokkaydet.Size = new System.Drawing.Size(100, 37);
            this.btnstokkaydet.TabIndex = 7;
            this.btnstokkaydet.Text = "KAYDET";
            this.btnstokkaydet.UseVisualStyleBackColor = true;
            this.btnstokkaydet.Click += new System.EventHandler(this.btnstokkaydet_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gida";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İcecek";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Atistirmalik";
            this.columnHeader5.Width = 127;
            // 
            // Stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 344);
            this.Controls.Add(this.btnstokkaydet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtatistir);
            this.Controls.Add(this.txticecek);
            this.Controls.Add(this.txtgida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.Stoklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgida;
        private System.Windows.Forms.TextBox txticecek;
        private System.Windows.Forms.TextBox txtatistir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnstokkaydet;
    }
}
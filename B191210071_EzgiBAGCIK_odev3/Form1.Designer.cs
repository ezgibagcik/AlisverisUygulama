namespace B191210071_EzgiBAGCIK_odev3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUpDtel = new System.Windows.Forms.NumericUpDown();
            this.nUpDLaptop = new System.Windows.Forms.NumericUpDown();
            this.nUpDbuzdolabı = new System.Windows.Forms.NumericUpDown();
            this.nUpDtv = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.lbltelstok = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbltelefonfiyat = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbllaptopstok = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbllaptopfiyat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblbuzdolabıstok = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbuzdolabıfiyat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltvstok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltvfiyat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCepTelefonu = new System.Windows.Forms.PictureBox();
            this.pbLaptop = new System.Windows.Forms.PictureBox();
            this.pbBuzdolabı = new System.Windows.Forms.PictureBox();
            this.pbLcdTv = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbKdvliFiyat = new System.Windows.Forms.ListBox();
            this.lbUrun = new System.Windows.Forms.ListBox();
            this.lbAdet = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSepetiTemizle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbltelefonstok = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDtel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDbuzdolabı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCepTelefonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuzdolabı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLcdTv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltelefonstok);
            this.groupBox1.Controls.Add(this.nUpDtel);
            this.groupBox1.Controls.Add(this.nUpDLaptop);
            this.groupBox1.Controls.Add(this.nUpDbuzdolabı);
            this.groupBox1.Controls.Add(this.nUpDtv);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lbltelstok);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lbltelefonfiyat);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbllaptopstok);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbllaptopfiyat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblbuzdolabıstok);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblbuzdolabıfiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbltvstok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltvfiyat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbCepTelefonu);
            this.groupBox1.Controls.Add(this.pbLaptop);
            this.groupBox1.Controls.Add(this.pbBuzdolabı);
            this.groupBox1.Controls.Add(this.pbLcdTv);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünlere Ait KDV\'siz Fiyatlar";
            // 
            // nUpDtel
            // 
            this.nUpDtel.Location = new System.Drawing.Point(326, 386);
            this.nUpDtel.Name = "nUpDtel";
            this.nUpDtel.Size = new System.Drawing.Size(37, 20);
            this.nUpDtel.TabIndex = 27;
            // 
            // nUpDLaptop
            // 
            this.nUpDLaptop.Location = new System.Drawing.Point(105, 381);
            this.nUpDLaptop.Name = "nUpDLaptop";
            this.nUpDLaptop.Size = new System.Drawing.Size(38, 20);
            this.nUpDLaptop.TabIndex = 26;
            // 
            // nUpDbuzdolabı
            // 
            this.nUpDbuzdolabı.Location = new System.Drawing.Point(320, 188);
            this.nUpDbuzdolabı.Name = "nUpDbuzdolabı";
            this.nUpDbuzdolabı.Size = new System.Drawing.Size(34, 20);
            this.nUpDbuzdolabı.TabIndex = 25;
            // 
            // nUpDtv
            // 
            this.nUpDtv.Location = new System.Drawing.Point(96, 186);
            this.nUpDtv.Name = "nUpDtv";
            this.nUpDtv.Size = new System.Drawing.Size(38, 20);
            this.nUpDtv.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(271, 388);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Adet :";
            // 
            // lbltelstok
            // 
            this.lbltelstok.AutoSize = true;
            this.lbltelstok.Location = new System.Drawing.Point(323, 361);
            this.lbltelstok.Name = "lbltelstok";
            this.lbltelstok.Size = new System.Drawing.Size(0, 13);
            this.lbltelstok.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Stok :";
            // 
            // lbltelefonfiyat
            // 
            this.lbltelefonfiyat.AutoSize = true;
            this.lbltelefonfiyat.Location = new System.Drawing.Point(317, 329);
            this.lbltelefonfiyat.Name = "lbltelefonfiyat";
            this.lbltelefonfiyat.Size = new System.Drawing.Size(31, 13);
            this.lbltelefonfiyat.TabIndex = 20;
            this.lbltelefonfiyat.Text = "6000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(271, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Fiyat :";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(55, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Adet :";
            // 
            // lbllaptopstok
            // 
            this.lbllaptopstok.Location = new System.Drawing.Point(102, 352);
            this.lbllaptopstok.Name = "lbllaptopstok";
            this.lbllaptopstok.Size = new System.Drawing.Size(41, 13);
            this.lbllaptopstok.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(55, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Stok :";
            // 
            // lbllaptopfiyat
            // 
            this.lbllaptopfiyat.Location = new System.Drawing.Point(102, 329);
            this.lbllaptopfiyat.Name = "lbllaptopfiyat";
            this.lbllaptopfiyat.Size = new System.Drawing.Size(41, 13);
            this.lbllaptopfiyat.TabIndex = 15;
            this.lbllaptopfiyat.Text = "6000";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(55, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fiyat :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(265, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Adet :";
            // 
            // lblbuzdolabıstok
            // 
            this.lblbuzdolabıstok.Location = new System.Drawing.Point(319, 163);
            this.lblbuzdolabıstok.Name = "lblbuzdolabıstok";
            this.lblbuzdolabıstok.Size = new System.Drawing.Size(35, 13);
            this.lblbuzdolabıstok.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(265, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Stok :";
            // 
            // lblbuzdolabıfiyat
            // 
            this.lblbuzdolabıfiyat.Location = new System.Drawing.Point(317, 134);
            this.lblbuzdolabıfiyat.Name = "lblbuzdolabıfiyat";
            this.lblbuzdolabıfiyat.Size = new System.Drawing.Size(46, 13);
            this.lblbuzdolabıfiyat.TabIndex = 10;
            this.lblbuzdolabıfiyat.Text = "20000";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(265, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fiyat :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(46, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = " Adet :";
            // 
            // lbltvstok
            // 
            this.lbltvstok.Location = new System.Drawing.Point(99, 163);
            this.lbltvstok.Name = "lbltvstok";
            this.lbltvstok.Size = new System.Drawing.Size(35, 13);
            this.lbltvstok.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok :";
            // 
            // lbltvfiyat
            // 
            this.lbltvfiyat.Location = new System.Drawing.Point(99, 134);
            this.lbltvfiyat.Name = "lbltvfiyat";
            this.lbltvfiyat.Size = new System.Drawing.Size(35, 13);
            this.lbltvfiyat.TabIndex = 5;
            this.lbltvfiyat.Text = "4000";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fiyat :";
            // 
            // pbCepTelefonu
            // 
            this.pbCepTelefonu.Image = global::B191210071_EzgiBAGCIK_odev3.Properties.Resources.APPLE_IPHONE_IPHONEX64GBUZAYGRI__Cep_Telefonu_258156;
            this.pbCepTelefonu.Location = new System.Drawing.Point(259, 235);
            this.pbCepTelefonu.Name = "pbCepTelefonu";
            this.pbCepTelefonu.Size = new System.Drawing.Size(118, 91);
            this.pbCepTelefonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCepTelefonu.TabIndex = 3;
            this.pbCepTelefonu.TabStop = false;
            // 
            // pbLaptop
            // 
            this.pbLaptop.Image = global::B191210071_EzgiBAGCIK_odev3.Properties.Resources.asus_zenbook_ux334fl_a4047t_i7_8565u_16_gb_256_gb_ssd_mx250_13_3_full_hd_z;
            this.pbLaptop.Location = new System.Drawing.Point(42, 235);
            this.pbLaptop.Name = "pbLaptop";
            this.pbLaptop.Size = new System.Drawing.Size(118, 91);
            this.pbLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLaptop.TabIndex = 2;
            this.pbLaptop.TabStop = false;
            // 
            // pbBuzdolabı
            // 
            this.pbBuzdolabı.Image = global::B191210071_EzgiBAGCIK_odev3.Properties.Resources._350_thumbnail_V2;
            this.pbBuzdolabı.Location = new System.Drawing.Point(259, 39);
            this.pbBuzdolabı.Name = "pbBuzdolabı";
            this.pbBuzdolabı.Size = new System.Drawing.Size(118, 91);
            this.pbBuzdolabı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuzdolabı.TabIndex = 1;
            this.pbBuzdolabı.TabStop = false;
            // 
            // pbLcdTv
            // 
            this.pbLcdTv.Image = global::B191210071_EzgiBAGCIK_odev3.Properties.Resources.lg_um76_86_82_75_ai_thinq_smart_tv_right;
            this.pbLcdTv.Location = new System.Drawing.Point(42, 40);
            this.pbLcdTv.Name = "pbLcdTv";
            this.pbLcdTv.Size = new System.Drawing.Size(118, 90);
            this.pbLcdTv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLcdTv.TabIndex = 0;
            this.pbLcdTv.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplam);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lbKdvliFiyat);
            this.groupBox2.Controls.Add(this.lbUrun);
            this.groupBox2.Controls.Add(this.lbAdet);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lblUrun);
            this.groupBox2.Controls.Add(this.lblAdet);
            this.groupBox2.Location = new System.Drawing.Point(488, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Özeti";
            // 
            // lblToplam
            // 
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(146, 332);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(85, 23);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "TOPLAM";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(27, 332);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(113, 23);
            this.label24.TabIndex = 6;
            this.label24.Text = "KDV\'li Toplam Fiyat :";
            // 
            // lbKdvliFiyat
            // 
            this.lbKdvliFiyat.FormattingEnabled = true;
            this.lbKdvliFiyat.Location = new System.Drawing.Point(202, 70);
            this.lbKdvliFiyat.Name = "lbKdvliFiyat";
            this.lbKdvliFiyat.Size = new System.Drawing.Size(85, 147);
            this.lbKdvliFiyat.TabIndex = 5;
            // 
            // lbUrun
            // 
            this.lbUrun.FormattingEnabled = true;
            this.lbUrun.Location = new System.Drawing.Point(109, 70);
            this.lbUrun.Name = "lbUrun";
            this.lbUrun.Size = new System.Drawing.Size(79, 147);
            this.lbUrun.TabIndex = 4;
            // 
            // lbAdet
            // 
            this.lbAdet.FormattingEnabled = true;
            this.lbAdet.Location = new System.Drawing.Point(17, 70);
            this.lbAdet.Name = "lbAdet";
            this.lbAdet.Size = new System.Drawing.Size(59, 147);
            this.lbAdet.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(199, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 23);
            this.label23.TabIndex = 2;
            this.label23.Text = "KDV\'li Fİyat";
            // 
            // lblUrun
            // 
            this.lblUrun.Location = new System.Drawing.Point(106, 29);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(66, 23);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün";
            // 
            // lblAdet
            // 
            this.lblAdet.Location = new System.Drawing.Point(14, 29);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(62, 13);
            this.lblAdet.TabIndex = 0;
            this.lblAdet.Text = "Adet";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(63, 442);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(154, 30);
            this.btnSepeteEkle.TabIndex = 2;
            this.btnSepeteEkle.Text = "Üünleri Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSepetiTemizle
            // 
            this.btnSepetiTemizle.Location = new System.Drawing.Point(256, 442);
            this.btnSepetiTemizle.Name = "btnSepetiTemizle";
            this.btnSepetiTemizle.Size = new System.Drawing.Size(151, 30);
            this.btnSepetiTemizle.TabIndex = 3;
            this.btnSepetiTemizle.Text = "Sepeti Temizle";
            this.btnSepetiTemizle.UseVisualStyleBackColor = true;
            this.btnSepetiTemizle.Click += new System.EventHandler(this.btnSepetiTemizle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbltelefonstok
            // 
            this.lbltelefonstok.AutoSize = true;
            this.lbltelefonstok.Location = new System.Drawing.Point(319, 361);
            this.lbltelefonstok.Name = "lbltelefonstok";
            this.lbltelefonstok.Size = new System.Drawing.Size(0, 13);
            this.lbltelefonstok.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 484);
            this.Controls.Add(this.btnSepetiTemizle);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDtel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDbuzdolabı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCepTelefonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuzdolabı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLcdTv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbCepTelefonu;
        private System.Windows.Forms.PictureBox pbLaptop;
        private System.Windows.Forms.PictureBox pbBuzdolabı;
        private System.Windows.Forms.PictureBox pbLcdTv;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbltelstok;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnSepetiTemizle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.NumericUpDown nUpDtel;
        public System.Windows.Forms.NumericUpDown nUpDLaptop;
        public System.Windows.Forms.NumericUpDown nUpDbuzdolabı;
        public System.Windows.Forms.NumericUpDown nUpDtv;
        public System.Windows.Forms.ListBox lbKdvliFiyat;
        public System.Windows.Forms.Label lblToplam;
        public System.Windows.Forms.ListBox lbUrun;
        public System.Windows.Forms.ListBox lbAdet;
        public System.Windows.Forms.Label lbllaptopstok;
        public System.Windows.Forms.Label lblbuzdolabıstok;
        public System.Windows.Forms.Label lbltvstok;
        public System.Windows.Forms.Label lbltelefonfiyat;
        public System.Windows.Forms.Label lbllaptopfiyat;
        public System.Windows.Forms.Label lblbuzdolabıfiyat;
        public System.Windows.Forms.Label lbltvfiyat;
        public System.Windows.Forms.Button btnSepeteEkle;
        public System.Windows.Forms.Label lbltelefonstok;
    }
}


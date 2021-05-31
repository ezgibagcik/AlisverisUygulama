/**********************************************************************************************************************************************************
**                                       SAKARYA UNIVERSITESI BILGİISAYAR VE BILIŞIM BILIMLERI FAKULTESI
**				                                           BILGISAYAR MUHENDISLIĞI BOLUMU
**				                                           NESNEYE DAYALI PROGRAMLAMA DERSI
**					                                           2019-2020 BAHAR DÖNEMİ
* 
**                                                ÖDEV NUMARASI............: 3.ODEV
**                                                ÖĞRENCİ ADI..............: EZGI BAĞCIK
**                                                ÖĞRENCİ NUMARASI.........: B191210071
**                                                DERS GRUBU...............: 1. OĞRETIM C GRUBU
***********************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_odev3
{
    public partial class Form1 : Form
    {
        public Sepet spt = new Sepet(); //Sepet sinifina erismek icin nesne olusturuldu
        public Urun urun; //Urun sinifina erismek icin nesne olusturuldu
        public LedTv ledtv; // LedTv sinifina erismek icin nesne olusturuldu
        public Buzdolabı buzdolabı; // Buzdolabı sinifina erismek icin nesne olusturuldu
        public Laptop laptop; //Laptop sinifina erismek icin nesne olusturuldu
        public CepTel cTel; //CepTel sinifina erismek icin nesne olusturuldu

        public Form1()
        {
            InitializeComponent();
            // Siniflara ait kurucu fonksiyonlar cagirildi.
            ledtv = new LedTv("70", "4K", "Led Tv", "LG", "86UM7600PLB", "AI", 4000, Convert.ToInt32(nUpDtv.Value));
            buzdolabı = new Buzdolabı(716, "A++", "Buzdolabı", "LG", "GR-X31FTKHL", "No Frost", 20000, Convert.ToInt32(nUpDbuzdolabı.Value));
            laptop = new Laptop("15", "1366x768 piksel", "512GB", "8GB", "10 saat", "Laptop", "ASUS", "ZenBook", "Touchpad", 6000, Convert.ToInt32(nUpDLaptop.Value));
            cTel = new CepTel("64", "3", "7 saat", "CepTel", "Apple", "XR", "FaceID", 6000, Convert.ToInt32(nUpDtel.Value));

        }

        private void Form1_Load(object sender, EventArgs e)
        {   //"Numeric updown" nesnesinin minimum degerinin 0 atamasi yapildi.
            nUpDbuzdolabı.Minimum = 0;
            nUpDtv.Minimum = 0;
            nUpDLaptop.Minimum = 0;
            nUpDtel.Minimum = 0;
            //"Numeric updown" nesnesinin maksimum degerinin stokadedince oldugunun atamasi yapildi.
            nUpDbuzdolabı.Maximum = buzdolabı.urunStokAdedi;
            nUpDtv.Maximum = ledtv.urunStokAdedi;
            nUpDLaptop.Maximum = laptop.urunStokAdedi;
            nUpDtel.Maximum = cTel.urunStokAdedi;

            //Urunlerin ham fiyatinin atamasi siniflardaki degiskenlerine atandi.
            buzdolabı.urunHamFiyat = Convert.ToInt32(lblbuzdolabıfiyat.Text);
            ledtv.urunHamFiyat = Convert.ToInt32(lbltvfiyat.Text);
            cTel.urunHamFiyat = Convert.ToInt32(lbltelefonfiyat.Text);
            laptop.urunHamFiyat = Convert.ToInt32(lbllaptopfiyat.Text);

            //Siniflardaki random atanan stok adetleri form ekranina yazdirilir.
            lbltvstok.Text = ledtv.urunStokAdedi.ToString();
            lblbuzdolabıstok.Text = buzdolabı.urunStokAdedi.ToString();
            lbltelefonstok.Text = cTel.urunStokAdedi.ToString();
            lbllaptopstok.Text = laptop.urunStokAdedi.ToString();

        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lbAdet.Items.Count > 0) // Form ekraninda adetlerin yazildigi Listbox'ın dolulugunu kontrol eden kosuldur.
                                        //Sepete ekle butonuna basildiginda doluysa önce temzler sonra yeniler.
            {   
                //Siparis ozeti kisminda yazanlar temizlenir
                lbAdet.Items.Clear(); 
                lbUrun.Items.Clear(); 
                lbKdvliFiyat.Items.Clear();
                lblToplam.Text = string.Empty; 
           

                spt.sepeteUrunEKle(urun); //Sepete secilen urunleri ekleyecek fonksiyon cagirilir.
                spt.StoktanAzalt(); //Sepete eklenen urun sayisini stoktan dusecek fonksiyon cagirilir.

            }
            else
            {
                spt.sepeteUrunEKle(urun); //Sepete secilen urunleri ekleyecek fonksiyon cagirilir.
                spt.StoktanAzalt(); //Sepete eklenen urun sayisini stoktan dusecek fonksiyon cagirilir.
            }

        }
        private void btnSepetiTemizle_Click(object sender, EventArgs e)
        {
            spt.StokEskiHal();  //Sepete eklenen urun sayisini stoga geri ekleyen fonksiyon cagirilir.
            spt.SepetiTemizle(); //Sepetteki urunleri temizleyen fonksiyon cagirilir.

        }


    }
}
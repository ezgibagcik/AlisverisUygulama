using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_odev3
{
    public class Sepet
    {

        public Sepet spt ; //Sepet sinifina erismek icin nesne olusturuldu
        public Urun urun; //Urun sinifina erismek icin nesne olusturuldu
        public LedTv ledtv; // LedTv sinifina erismek icin nesne olusturuldu
        public Buzdolabı buzdolabı; // Buzdolabı sinifina erismek icin nesne olusturuldu
        public Laptop laptop; //Laptop sinifina erismek icin nesne olusturuldu
        public CepTel cTel; //CepTel sinifina erismek icin nesne olusturuldu


        public void sepeteUrunEKle(Urun urun) //Her bir ürün için secilen siparis adedince KDV’li fiyatlar ve KDV’li toplam fiyatin hesaplandıgı fonksiyonların cagirildigi fonksiyondur.
        {                                     
            Form1 frm = (Form1)Application.OpenForms["Form1"]; // Acik olan forma erisim saglandi.

            if (frm.nUpDtv.Value != 0) //Ledtv urunun secilip secilmedigini kontrol eden kosuldur.
            {
                frm.lbAdet.Items.Add(Convert.ToString(frm.nUpDtv.Value)); // Urun adedinin yazildigi listboxa numericUpDown da secilen adet yazdirilir.
                frm.lbUrun.Items.Add("Led Tv"); //Urun ismi listboxa yazdirilir.
                frm.ledtv.urunSecilenAdet = Convert.ToInt32(frm.nUpDtv.Value); // ledtv sinifindaki urunsecilenadet degiskenine numericUpDown da secilen adet atanir.
                frm.ledtv.KdvUygula(); //ledtv sinifindaki KdvUygula metodu cagirilir.
                frm.lbKdvliFiyat.Items.Add(frm.ledtv.kdvliFiyat.ToString()); //ledtv sinifinda hesaplanan kdvli fiyat siparis ozeti kismindaki listboxa yazdirilir.
            }

            if (frm.nUpDbuzdolabı.Value != 0) //Buzdolabi urunun secilip secilmedigini kontrol eden kosuldur.
            {
                frm.lbAdet.Items.Add(Convert.ToString(frm.nUpDbuzdolabı.Value)); // Urun adedinin yazildigi listboxa numericUpDown da secilen adet yazdirilir.
                frm.lbUrun.Items.Add("Buzdolabı"); //Urun ismi listboxa yazdirilir.
                frm.buzdolabı.urunSecilenAdet = Convert.ToInt32(frm.nUpDbuzdolabı.Value); // buzdolabi sinifindaki urunsecilenadet degiskenine numericUpDown da secilen adet atanir.
                frm.buzdolabı.KdvUygula(); //buzdolabi sinifindaki KdvUygula metodu cagirilir.
                frm.lbKdvliFiyat.Items.Add(frm.buzdolabı.kdvliFiyat.ToString()); //buzdolabi sinifinda hesaplanan kdvli fiyat siparis ozeti kismindaki listboxa yazdirilir.
            }

            if (frm.nUpDLaptop.Value != 0) //Laptop urunun secilip secilmedigini kontrol eden kosuldur.
            {
                frm.lbAdet.Items.Add(Convert.ToString(frm.nUpDLaptop.Value)); // Urun adedinin yazildigi listboxa numericUpDown da secilen adet yazdirilir.
                frm.lbUrun.Items.Add("Laptop"); //Urun ismi listboxa yazdirilir.
                frm.laptop.urunSecilenAdet = Convert.ToInt32(frm.nUpDLaptop.Value); // laptop sinifindaki urunsecilenadet degiskenine numericUpDown da secilen adet atanir.
                frm.laptop.KdvUygula(); //laptop sinifindaki KdvUygula metodu cagirilir.
                frm.lbKdvliFiyat.Items.Add(frm.laptop.kdvliFiyat.ToString()); //laptop sinifinda hesaplanan kdvli fiyat siparis ozeti kismindaki listboxa yazdirilir.
            }
            if (frm.nUpDtel.Value != 0) //cepTel urunun secilip secilmedigini kontrol eden kosuldur.
            {
                frm.lbAdet.Items.Add(Convert.ToString(frm.nUpDtel.Value)); // Urun adedinin yazildigi listboxa numericUpDown da secilen adet yazdirilir.
                frm.lbUrun.Items.Add("Cep Telefonu"); //Urun ismi listboxa yazdirilir.
                frm.cTel.urunSecilenAdet = Convert.ToInt32(frm.nUpDtel.Value); // cepTel sinifindaki urunsecilenadet degiskenine numericUpDown da secilen adet atanir.
                frm.cTel.KdvUygula(); //cepTel sinifindaki KdvUygula metodu cagirilir.
                frm.lbKdvliFiyat.Items.Add(frm.cTel.kdvliFiyat.ToString()); //cepTel sinifinda hesaplanan kdvli fiyat siparis ozeti kismindaki listboxa yazdirilir.
            }
            frm.lblToplam.Text = string.Empty;
            double toplam; 
            toplam = frm.buzdolabı.kdvliFiyat + frm.laptop.kdvliFiyat + frm.cTel.kdvliFiyat + frm.ledtv.kdvliFiyat; //Siparislerdeki toplam kdvli fiyati hesaplar.
            frm.lblToplam.Text = toplam.ToString(); //Hesaplanan kdvli fiyat labela yazdirilir.
           
        
        }

        public void SepetiTemizle() //Sepetin icindeki degerleri ve formdakiaraclarin degerlerini temizleyen fonksiyondur
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"]; // Acik olan forma erisim saglandi.

            //Listboxlar temizlenir
            frm.lbAdet.Items.Clear();
            frm.lbUrun.Items.Clear();
            frm.lbKdvliFiyat.Items.Clear();

            //Toplam fiyatin bulundugu label temizlenir.
             frm.lblToplam.Text = string.Empty;
           

            //Formdaki aracalr sifirlanir.
            frm.nUpDbuzdolabı.Value = 0;
            frm.nUpDLaptop.Value = 0;
            frm.nUpDtel.Value = 0;
            frm.nUpDtv.Value = 0;
            
        }
       public void StoktanAzalt()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"]; // Acik olan forma erisim saglandi.

            if (Convert.ToInt32(frm.lbltvstok.Text) != 0) //Stogun - li ifadelere dusmemesi kontrolunu saglayan kosuldur.
            { 
                frm.lbltvstok.Text = (Convert.ToInt32(frm.lbltvstok.Text) - Convert.ToInt32(frm.nUpDtv.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari dusulur ve stok kismi güncellenir.
            }
            if (Convert.ToInt32(frm.lbllaptopstok.Text) != 0) //Stogun - li ifadelere dusmemesi kontrolunu saglayan kosuldur.
            {
                frm.lbllaptopstok.Text = (Convert.ToInt32(frm.lbllaptopstok.Text) - Convert.ToInt32(frm.nUpDLaptop.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari dusulur ve stok kismi güncellenir.
            }
            if (Convert.ToInt32(frm.lblbuzdolabıstok.Text) != 0) //Stogun - li ifadelere dusmemesi kontrolunu saglayan kosuldur.
            {
                frm.lblbuzdolabıstok.Text = (Convert.ToInt32(frm.lblbuzdolabıstok.Text) - Convert.ToInt32(frm.nUpDbuzdolabı.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari dusulur ve stok kismi güncellenir.
            }
            if (Convert.ToInt32(frm.lbltelefonstok.Text) != 0) //Stogun - li ifadelere dusmemesi kontrolunu saglayan kosuldur.
            {
                frm.lbltelefonstok.Text = (Convert.ToInt32(frm.lbltelefonstok.Text) - Convert.ToInt32(frm.nUpDtel.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari dusulur ve stok kismi güncellenir.
            }
            
        }
        public void StokEskiHal() //Sepetten silinen urun miktarini stoga geri ekleyen fonksiyondur.
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"]; // Acik olan forma erisim saglandi.

            frm.lbltvstok.Text = (Convert.ToInt32(frm.lbltvstok.Text) + Convert.ToInt32(frm.nUpDtv.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari stok kismina geri eklenir.
            frm.lbllaptopstok.Text = (Convert.ToInt32(frm.lbllaptopstok.Text) + Convert.ToInt32(frm.nUpDLaptop.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari stok kismina geri eklenir.
            frm.lblbuzdolabıstok.Text = (Convert.ToInt32(frm.lblbuzdolabıstok.Text) + Convert.ToInt32(frm.nUpDbuzdolabı.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari stok kismina geri eklenir.
            frm.lbltelefonstok.Text = (Convert.ToInt32(frm.lbltelefonstok.Text) + Convert.ToInt32(frm.nUpDtel.Value)).ToString(); //Stok ifadesinden secilen adetteki urun miktari stok kismina geri eklenir.
        }
    }
}

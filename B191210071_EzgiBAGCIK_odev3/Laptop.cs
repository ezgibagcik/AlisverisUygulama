using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210071_EzgiBAGCIK_odev3
{
    public class Laptop : Urun
    {
        private string ekranBoyutu;
        private string ekranCozunurlugu;
        private string dahiliHafiza;
        private string ramKapasitesi;
        private string pilGucu;
        public double kdvliFiyat;
      
        //Parametreli kurucu metodu yazildi
        public Laptop(string boyut, string cozunurluk, string hafiza, string rKapasite, string pGucu, string ad, string marka, string model, string ozellik, double hFiyat, int sclnAdet) : base(ad, marka, model, ozellik, hFiyat, sclnAdet)
        {
            ekranBoyutu = boyut;
            ekranCozunurlugu = cozunurluk;
            dahiliHafiza = hafiza;
            ramKapasitesi = rKapasite;
            pilGucu = pGucu;
            urunStokAdedi = randomsayi1.Next(1, 100); //Stok adedi random olarak atandi
        }

        public void KdvUygula() //Laptop icin %15 kdv uygulayan fonksiyondur
        {
            kdvliFiyat = urunHamFiyat * 1.15 * urunSecilenAdet;
        }
    }
}

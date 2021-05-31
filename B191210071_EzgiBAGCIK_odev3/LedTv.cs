using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210071_EzgiBAGCIK_odev3
{
   public class LedTv :Urun
    {
        private string ekranBoyutu;
        private string ekranCozunurlugu;
        public double kdvliFiyat;

        //Parametreli kurucu metodu yazildi
        public LedTv(string boyut, string cozunurluk, string ad, string marka, string model, string ozellik, double hFiyat, int sclnAdet) : base(ad, marka, model, ozellik, hFiyat, sclnAdet)
        {
            ekranBoyutu = boyut;
            ekranCozunurlugu = cozunurluk;
            urunStokAdedi = randomsayi1.Next(1, 100); //Stok adedi random olarak atandi
        }

        public void KdvUygula() //Led Tv icin %18 kdv uygulayan fonksiyondur.
        {
            kdvliFiyat = urunHamFiyat * 1.18 * urunSecilenAdet;
        }
    }
}

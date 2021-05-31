using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210071_EzgiBAGCIK_odev3
{
    public class Buzdolabı : Urun
    {
        private int icHacim;
        private string enerjiSinifi;
        public double kdvliFiyat;

        //Parametreli kurucu metodu yazildi
        public Buzdolabı(int hacim, string eSinifi, string ad, string marka, string model, string ozellik, double hFiyat, int sclnAdet) : base(ad, marka, model, ozellik, hFiyat, sclnAdet)
        {
            icHacim = hacim;
            enerjiSinifi = eSinifi;
            urunStokAdedi = randomsayi1.Next(1, 100); //Stok adedi random olarak atandi
        }

        public void KdvUygula() //Buzdolabı icin %5 kdv uygulayan fonksiyondur.
        {
            kdvliFiyat = urunHamFiyat * 1.05 * urunSecilenAdet;
        }
    }
}

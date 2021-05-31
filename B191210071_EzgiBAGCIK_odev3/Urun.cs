using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_odev3
{

    public class Urun
    {

        public static Random randomsayi1 = new Random(); //Random sayiya diger claslardan erisim saglanacak nesne olsuturuldu.

        public string urunAd { get; set; }
        public string urunMarka { get; set; }
        public string urunModel { get; set; }
        public string urunOzellik { get; set; }
        public int urunStokAdedi { get; set; }
        public double urunHamFiyat { get; set; }
        public int urunSecilenAdet { get; set; }

        //Parametreli kurucu metodu yazildi
        public Urun(string ad, string marka, string model, string ozellik, double hFiyat, int sclnAdet)
        {
            urunAd = ad;
            urunMarka = marka;
            urunModel = model;
            urunOzellik = ozellik;
            urunHamFiyat = hFiyat;
            urunSecilenAdet = sclnAdet;
        }
      
    }

}
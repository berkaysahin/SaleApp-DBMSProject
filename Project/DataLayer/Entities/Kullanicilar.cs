using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class KULLANICILAR
    {
        private int kullanicilarID;
        public int KullanicilarID
        {
            get { return kullanicilarID; }
            set { kullanicilarID = value; }
        }

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        private string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        private string adSoyad;
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        private bool kullaniciTuru;
        public bool KullaniciTuru
        {
            get { return kullaniciTuru; }
            set { kullaniciTuru = value; }
        }
    }
}
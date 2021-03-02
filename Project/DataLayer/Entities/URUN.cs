using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class URUN
    {
        private int urunID;
        private string adi;
        private string barkodu;
        private int birimID;
        private int kategoriID;
        private double satisFiyati;

        public int UrunID
        {
            get { return urunID; }
            set { urunID = value; }
        }

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        public string Barkodu
        {
            get { return barkodu; }
            set { barkodu = value; }
        }

        public int BirimID
        {
            get { return birimID; }
            set { birimID = value; }
        }

        public int KategoriID
        {
            get { return kategoriID; }
            set { kategoriID = value; }
        }

        public double SatisFiyati
        {
            get { return satisFiyati; }
            set { satisFiyati = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class SATISDETAY
    {
        private int satisDetayID;
        private int satisID;
        private int urunID;
        private double miktar;
        private double birimFiyat;
        private double tutar;

        public int SatisDetayID
        {
            get { return satisDetayID; }
            set { satisDetayID = value; }
        }

        public int SatisID
        {
            get { return satisID; }
            set { satisID = value; }
        }

        public int UrunID
        {
            get { return urunID; }
            set { urunID = value; }
        }

        public double Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        public double BirimFiyat
        {
            get { return birimFiyat; }
            set { birimFiyat = value; }
        }

        public double Tutar
        {
            get { return tutar; }
            set { tutar = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class SATIS
    {
        private int satisID;
        private DateTime tarih;
        private int musteriID;
        private double toplamTutar;
        private int sorumluID;

        public int SatisID
        {
            get { return satisID; }
            set { satisID = value; }
        }

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }

        public int MusteriID
        {
            get { return musteriID; }
            set { musteriID = value; }
        }

        public double ToplamTutar
        {
            get { return toplamTutar; }
            set { toplamTutar = value; }
        }

        public int SorumluID
        {
            get { return sorumluID; }
            set { sorumluID = value; }
        }
    }
}
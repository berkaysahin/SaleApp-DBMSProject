using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class KASA
    {
        private int kasaID;
        private DateTime tarih;
        private int musteriID;
        private double tutar;
        private string aciklama;
        private int sorumluID;

        public int KasaID
        {
            get { return kasaID; }
            set { kasaID = value; }
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

        public double Tutar
        {
            get { return tutar; }
            set { tutar = value; }
        }

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }

        public int SorumluID
        {
            get { return sorumluID; }
            set { sorumluID = value; }
        }
    }
}
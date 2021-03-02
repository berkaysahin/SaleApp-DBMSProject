using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class MUSTERI
    {
        private int musteriID;
        private string telefonu;
        private string adresi;
        private string adiSoyadi;

        public int MusteriID
        {
            get { return musteriID; }
            set { musteriID = value; }
        }

        public string Telefonu
        {
            get { return telefonu; }
            set { telefonu = value; }
        }

        public string Adresi
        {
            get { return adresi; }
            set { adresi = value; }
        }

        public string AdiSoyadi
        {
            get { return adiSoyadi; }
            set { adiSoyadi = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class SATISDANISMANI
    {
        private int satisDanismaniID;
        private int kullanicilarID;

        public int SatisDanismaniID
        {
            get { return satisDanismaniID; }
            set { satisDanismaniID = value; }
        }

        public int KullanicilarID
        {
            get { return kullanicilarID; }
            set { kullanicilarID = value; }
        }
    }
}
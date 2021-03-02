using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class YONETICI
    {
        private int kullanicilarID;
        public int KullanicilarID
        {
            get { return kullanicilarID; }
            set { kullanicilarID = value; }
        }

        private int yoneticiID;
        public int YoneticiID
        {
            get { return yoneticiID; }
            set { yoneticiID = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class BIRIM
    {
        private int birimID;
        private string birimAdi;

        public int BirimID
        {
            get { return birimID; }
            set { birimID = value; }
        }

        public string BirimAdi
        {
            get { return birimAdi; }
            set { birimAdi = value; }
        }
    }
}
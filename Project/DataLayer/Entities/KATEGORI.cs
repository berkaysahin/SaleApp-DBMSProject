using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class KATEGORI
    {
        private int kategoriID;
        private string kategoriAdi;

        public int KategoriID
        {
            get { return kategoriID; }
            set { kategoriID = value; }
        }

        public string KategoriAdi
        {
            get { return kategoriAdi; }
            set { kategoriAdi = value; }
        }
    }
}
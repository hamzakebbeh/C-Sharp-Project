using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBilet
{
    class Bilet
    {
        public string FilmAdi;
        public int no;
        public static int fiyat=12;
        public int Id;

        private static int yeniid = 0;

        public Bilet()
        {
            yeniid++;
            this.Id = yeniid;
        }
    }
}

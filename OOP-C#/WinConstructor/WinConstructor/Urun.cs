using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinConstructor
{
    class Urun
    {
        public Urun() // Default Constructor
        {

        }

        public Urun(string ismi) // Parametrik Constructor
        {
            this.Adi = ismi;
        }


        public int Sayisal() // Metot
        {
            return 2;
        }

        
        public int Fiyat;
        public string Adi;
        public int Stok;

        
    }
}

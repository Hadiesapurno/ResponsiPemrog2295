using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2295
{
    class Kariawan {
        public string nama { get; set; }
        public string nik { get; set; }
        public int gajih { get; set; } 

       

        public Kariawan (string Nama, string NIK, int Gajih) 
        {
            if (Gajih < 0) { gajih = 0; } else { gajih = Gajih; };
            nama = Nama;
            nik = NIK;
        }
        
    }
}

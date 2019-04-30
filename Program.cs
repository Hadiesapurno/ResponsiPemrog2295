using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2295
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("NAMA\t\t|\tNIK\t|\tGAJI");
            Console.WriteLine("==================================================");
            Kariawan org1 = new Kariawan("Sukijan", "34567", 1000000);
            cetak(org1);
            Kariawan org2 = new Kariawan("Sukit", "2571", 1500000);
            cetak(org2);
            NaikGajih(org1);
            NaikGajih(org2);
            Console.WriteLine("==================================================");
            Console.WriteLine("NAMA\t\t|\tNIK\t|\tGAJI");
            Console.WriteLine("==================================================");
            cetak(org1);
            cetak(org2);
            Console.ReadKey();
        }


        static void cetak(Kariawan org) {
            Console.WriteLine("{0}\t\t|\t{1}\t|\t{2}",org.nama,org.nik,org.gajih);
        }

        static void NaikGajih( Kariawan uang) {
            int gajihKariawan = uang.gajih;
            int hasil = 0;
            hasil = (gajihKariawan / 100) * 10;
            uang.gajih = hasil + gajihKariawan;
        }

    }
}

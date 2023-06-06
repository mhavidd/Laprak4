using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net7._0
{
    class Program
    {
        static void Main(String[]args )
        {
            mobil mobil1 = new mobil();
            mobil1.Merk ="Conda";
            mobil1.Warna = "Putih";
            mobil1.Model = "Briot";
            mobil1.Jumlahpintu = "5";
            mobil1.Tahunkeluaran = "2018";
            mobil1.Kecepatan = "145km/jam";

            mobil1.Kecepatanmobil();
            mobil1.Klaksonmobil();
            mobil1.Keterangan();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net7._0
{
    public class mobil
    {
        //field 
        private string _Warna;
        private string _Jumlahpintu;
        private string _Merk;
        private string _Model;
        private string _Tahunkeluaran;
        private string _Kecepatan;

        //property
        public string Warna
        {
            get
            {
                return _Warna;
            }
            set
            {
                _Warna = value;
            }
        }
        public string Jumlahpintu
        {
            get
            {
                return _Jumlahpintu;
            }
            set
            {
                _Jumlahpintu = value;
            }
        }
        public string Merk
        {
            get
            {
                return _Merk;
            }
            set
            {
                _Merk = value;
            }
        }
        public string Model
        {
            get
            {
                return _Model;
            }
            set
            {
                _Model = value;
            }
        }
        public string Tahunkeluaran
        {
            get
            {
                return _Tahunkeluaran;
            }
            set
            {
                _Tahunkeluaran = value;
            }
        }
        public string Kecepatan
        {
            get
            {
                return _Kecepatan;
            }
            set
            {
                _Kecepatan = value;
            }
        }
        
        //method
        public void Kecepatanmobil()
        {
            Console.WriteLine($"Mobil {Model} melaju dengan kecepatan {Kecepatan}");
        }
        public void Klaksonmobil()
        {
            Console.WriteLine($"Mobil {Model} dengan klakson berbunyi twin twin twin");
        }
         public void Keterangan()
        {
            Console.WriteLine($"Mobil saya berwarna {Warna}, merek {Merk}, model {Model}, keluaran tahun {Tahunkeluaran}, dengan jumlah pintu sebanyak {Jumlahpintu} ");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        //program menghitung luas dan keliling lingkaran
        static void Main(string[] args)
        {
            //deklarasi
            double jari,keliling,luas;  

            Console.Write("Masukkan jari-jari lingkaran : ");
            jari = Convert.ToInt32(Console.ReadLine());

            //rumus keliling lingkarang
            if (jari % 2 = 0)
            {
                keliling = 2 * 22 / 7 * jari - jari;
            }
            else
            {
                keliling = 3.14 * jari * jari;

            }

            //rumus luas lingkaran
            if (jari % 2 = 0)
            {
                luas = 22 / 7 * jari * jari;
            }
            else
            {
                luas = 3.14 * jari * jari;
            }
            Console.WriteLine("Keliling lingkaran di atas adalah : " + keliling);
            Console.WriteLine("Luas lingkaran di atas adalah : "+ luas);
                
        }
    }
}

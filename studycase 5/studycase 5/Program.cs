using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //program menghitung luas persegi panjang
            
            //deklarasi
            int panjang, lebar,luas;
            //membutuhkan inputan pengguna
            Console.Write("Masukkan Panjang :");
            panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Lebar :");
            lebar = Convert.ToInt32(Console.ReadLine());

            //menghitung luas

            luas = panjang * lebar;

            Console.WriteLine("Jadi luas persegi panjang di atas adalah " + luas);


        }
    }
}

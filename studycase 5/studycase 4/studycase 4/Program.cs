using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //program mencetak biodata studycase 4

            //deklarasikan variable menggunakan tipedata
            string namalengkap, tempattanggal, alamat;
            int notel;

            //membutuhkan inputan dari user atau pengguna
            Console.WriteLine("Masukkan data diri anda");
            Console.Write("Nama lengkap : ");
            //merekam atau menangkap inputan
            namalengkap = Console.ReadLine();
            Console.Write("Tempat / Tangal Lahir : ");
            tempattanggal = Console.ReadLine();
            Console.Write("Alamat : ");
            alamat = Console.ReadLine();
            Console.Write("No Telp : ");
            notel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=====DATA PESERTA=====");
            Console.WriteLine("Nama lengkap          :" + namalengkap);
            Console.WriteLine("Tempat/Tanggal Lahir  :" + tempattanggal);
            Console.WriteLine("Alamat                :" + alamat);
            Console.WriteLine("No Telp               :" + notel);
            Console.WriteLine("======Data Peserta Berhasil Terekam======");   

        }
    }
}

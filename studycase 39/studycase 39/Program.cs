using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //Studycase 39 by Aprisha Nauratul Jannah
        static void Main(string[] args)
        {
            int jumlah = 0;
            for(int i = 0; i <= 10; i++)
            {
                jumlah = jumlah + i;
                Console.WriteLine(i+ " "+jumlah);

            }
            Console.ReadKey();
        }
    }
}

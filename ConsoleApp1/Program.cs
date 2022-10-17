using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarpimTablosu1(10,10);
            Console.ReadLine();
        }
        static void CarpimTablosu(int carpan, int adim)
        {

            int sonuc = 0;
            for (int i = 1; i <= adim; i++)
            {

                sonuc = i * carpan;
                Console.WriteLine("{0}x{1}={2}", i, carpan, sonuc);
            }

        }



        static void CarpimTablosu1(int carpan, int adim)
        {
            int sonuc = 0;
            ;
            for (int i = 1; i < carpan; i++)
            {
                for (int j = 1; j < adim; j++)
                {
                    sonuc = i * j;
                    if (sonuc >= 10)
                    {
                        Console.Write("{0}*{1}= " + sonuc + "   ", j, i);
                    }
                    else
                    {
                        Console.Write("{0}*{1}= " + sonuc + "    ", j, i);
                    }
                }
                Console.WriteLine();
            }



        }

    }
}

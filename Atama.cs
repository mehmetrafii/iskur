using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atama
{
    public class Atama
    {
       public void Rastgele()
        {
            string[] SinifListesi = {"Salih","Cihat Han","Neval","İlker","Devrim","Muhammet",
            "Burak","Bedirhan","Mısra","Büşra","Mert K","Mert T","Sena","Erhan","Berkcan"};
            Random rastgeleSayi=new Random();
            
            for (int i = 0; i < SinifListesi.Length; i++)
            {
                int sectigimSayi=rastgeleSayi.Next(0,SinifListesi.Length-i);
                Console.WriteLine("{0} {1}", (i + 1),(SinifListesi[sectigimSayi]));
                SinifListesi[sectigimSayi] = SinifListesi[SinifListesi.Length - 1 - i];

            }

        }
    }
}

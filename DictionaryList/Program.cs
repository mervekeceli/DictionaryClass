using System;
using System.Collections.Generic;

namespace DictionaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            //c#'ın sözlüğü
            var kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Merve");
            kullanicilar.Add(2, "Berkant");


            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine("ID:" + kullanici.Key + "   " + "Ad Soyad: " + kullanici.Value);
            }
            Console.WriteLine("\n");


            //benim yazdığım sözlük
            MyDictionary<int, string> kullanicilar1 = new MyDictionary<int, string>();
            kullanicilar1.Add(1, "Beyza");
            kullanicilar1.Add(2, "Hilal");
            kullanicilar1.Add(3, "Damla");

            kullanicilar1.List();


        }
    }
}
﻿using System.Runtime.InteropServices;

namespace _02._14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Karakter> karakterek = [];

            Beolvasas("karakterek.txt", karakterek);

            Console.WriteLine("\n2.feladat");
            LegmagasabbEletero(karakterek);

            Console.WriteLine("\n3.feladat");
            KarakterAtlagSzint(karakterek);

            Console.WriteLine("\n4.feladat");
            RendezesErossegiSzint(karakterek);

            Console.WriteLine("\n5.feladat");
            ErosebbE(30, karakterek);
            


        }

        static void Beolvasas(string filnenev, List<Karakter> karakterek)
        {
            StreamReader sr = new(filnenev);

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] szavak = sor.Split(';');

                Karakter karakter = new(szavak[0], Convert.ToInt16(szavak[1]), Convert.ToInt16(szavak[2]), Convert.ToInt16(szavak[3]));
                karakterek.Add(karakter);
            }
        }

        static void LegmagasabbEletero(List<Karakter> karakterek)
        {
            int max = karakterek[0].Eletero;
            int index = 0;
            for (int i = 1; i < karakterek.Count; i++)
            {
                if (karakterek[i].Eletero > max)
                {
                    max = karakterek[i].Eletero;
                    index = i;
                }
            }
            Console.WriteLine(karakterek[index]);
        }

        static void KarakterAtlagSzint(List<Karakter> karakterek)
        {
            int osszeg = 0;
            for (int i = 0; i < karakterek.Count; i++)
            {
                osszeg += karakterek[i].Szint;
            }
            Console.WriteLine(osszeg / karakterek.Count);
        }

        static void RendezesErossegiSzint(List<Karakter> karakterek)
        {
            karakterek.Sort((x, y) => x.Ero.CompareTo(y.Ero));
            for (int i = 0; i < karakterek.Count; i++)
            {
                Console.WriteLine(karakterek[i]);
            }
        }

        static void ErosebbE(int ero, List<Karakter> karakterek)
        {
            foreach (var karakter in karakterek)
            {
                if (karakter.Ero > ero)
                {
                    Console.WriteLine($" {karakter}");
                }
            }
        }
    }
}

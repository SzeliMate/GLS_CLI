using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI
{
    internal class Program
    {
        static List<GLS_CLI.GLS> adatok = new List<GLS_CLI.GLS>();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("GLS.txt"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    adatok.Add(new GLS_CLI.GLS(sr.ReadLine()));
                }
            }

            Console.WriteLine("1.Feladat:");
            foreach (var kliens in adatok)
            {
                Console.WriteLine(kliens);
            }
            HashSet<string> egyediNapok = new HashSet<string>();
            foreach (var kliens in adatok)
            {
                egyediNapok.Add(kliens.datum);
            }
            Console.WriteLine("2.Feladat:");
            Console.WriteLine($"Az autó használatban töltött napjainak száma: {egyediNapok.Count}");

            Console.WriteLine("3.Feladat");

            HashSet<string> sofőrök = new HashSet<string>();
            foreach (var kliens in adatok)
            {
                sofőrök.Add(kliens.sofornev);
            }

            Console.WriteLine($"Különböző sofőrök száma: {sofőrök.Count}");

        }
    }
}

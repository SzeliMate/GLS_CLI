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

            foreach (var kliens in adatok)
            {
                Console.WriteLine(kliens);
            }
        }
    }
}

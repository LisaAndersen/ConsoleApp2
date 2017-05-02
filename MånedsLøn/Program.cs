using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MånedsLøn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Array.Sort(månedsløn);

            Console.WriteLine("\n Sorteret:");
            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            double gennemsnit = (double) månedsløn.Sum() / månedsløn.Length;
            Console.WriteLine("Gennemsnit "+gennemsnit.ToString("N2"));

            Console.WriteLine("Skriv navn: ");
            string s = null;//Console.ReadLine();
            string t = s?.ToUpper() ?? "no string";
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}

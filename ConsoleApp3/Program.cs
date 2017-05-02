using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal *= 2.0;
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd MM yyyy"));
            Console.WriteLine(dt.ToString("dd-MM-yy")); // er m minutes?

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);

            int i = 0, j = 112;
            Point pt;
            pt.X = 42;
            var l = (87 * Math.Sin(11.2) / Math.PI) + "Yo!";
            string s = l;

            {
                int k = 255;
                pt.X++;
                i = k;

            }
            int[] a = { 1};
            int[] b = { 1};


            Console.ReadKey();
        }
    }

    enum FilTyper {
        csv,
        pdf,
        txt
    }

    struct Point {
        public int X,Y;
    }
    struct Person {
        public int Id;
        public string Navn;
    
    }
}

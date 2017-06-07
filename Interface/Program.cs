using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFælles[] arr = new IFælles[4];

            arr[0] = new Hund { Navn = "joe" };
            arr[1] = new Hund { Navn = "1234" };
            arr[2] = new Ubåd { Nummer = 123, Turbine = 1.0 };
            arr[3] = new Hund { Navn = "abel" }; ;
            
            foreach (var item in arr)
            {
                item.Gem();
            }
            Console.WriteLine("sortere");

            Array.Sort(arr);
            foreach (var item in arr)
            {
                item.Gem();
            }
        }
    }
}

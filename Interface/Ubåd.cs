using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ubåd:IFælles,IComparable
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public int CompareTo(object obj)
        {
            try
            {
                var u = (Ubåd) obj;
                return Nummer.CompareTo(u.Nummer);
            }
            catch {
                var h = (Hund) obj;
                return (Nummer.ToString()).CompareTo(h.Navn);
            }
        }

        public void Gem()
        {
            Console.WriteLine("gemmer ubåd...");
        }
    }
}

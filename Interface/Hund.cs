using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Hund : IFælles,IComparable
    {
        public string Navn { get; set; }

        public int CompareTo(object obj)
        {
            try
            {
                var u = (Ubåd) obj;
                return Navn.CompareTo(u.Nummer.ToString());
            }
            catch
            {
                var h = (Hund) obj;
                return Navn.CompareTo(h.Navn);
            }
        }

        public void Gem()
        {
            Console.WriteLine("gemmer hund...");
        }
    }
}

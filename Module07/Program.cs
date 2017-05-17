using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(125,82);
            double k = t.Areal;
            Console.WriteLine(t.Areal);

            // Areal Beregninger
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
        }
    }
}

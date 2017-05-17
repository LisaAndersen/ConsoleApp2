using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07
{
    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(int højde, int bredde) {
            return højde * bredde;
        }

        public static double BeregnArealCirkel(float radius) {
            return radius * radius * System.Math.PI;
        }
    }
}

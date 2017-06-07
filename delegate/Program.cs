using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTest
{

    public delegate void MathOperation(int i, int j);
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation m = new MathOperation(SimpleMath.Add);
            m += SimpleMath.Add;
            m += SimpleMath.Multiply;
            m -= SimpleMath.Add;
            m(5, 7);
        }
    }

    class SimpleMath
    {
        public static void Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }

        public static void Multiply(int i, int j)
        {
            Console.WriteLine(i * j);
        }
    }
}

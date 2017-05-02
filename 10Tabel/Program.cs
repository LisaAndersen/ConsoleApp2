using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 1; j < 11; j++)
                {
                    if (i * j > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    string tal = (i * j).ToString();
                    Console.Write(tal.PadLeft(4));
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}

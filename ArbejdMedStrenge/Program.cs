using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbejdMedStrenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string enavn = "Cronberg";

            string samletStreng =$"{fornavn} {enavn}";
            Console.WriteLine(samletStreng);
            Console.WriteLine(samletStreng.ToUpper());
            Console.WriteLine(samletStreng.ToLower());
            Console.WriteLine(samletStreng.Substring(7, 4));

            string[] s = samletStreng.Split(' ');

            Console.WriteLine(s[1]);
            Console.ReadKey();
        }
    }
}

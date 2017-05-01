using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            Console.WriteLine("Welcome {0}", navn.ToUpper());
            MakeDuck();
            Console.WriteLine("tryk tast for at fortsætte!");
            Console.ReadKey();
        }
        static void MakeDuck()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("=");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" )");
            Console.WriteLine(" (  > )/");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("^^^^^^^^^^^^");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
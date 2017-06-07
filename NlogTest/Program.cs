using System;
using NLog;
namespace LogDmeo
{
    class Program
    {
        private static Logger log = new LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            // mangler log
            test1(5, 5);
            test2();
        }

        static void test1(int i, int x)
        {
            // mangler log
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            // mangler log
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
            }
        }
    }
}

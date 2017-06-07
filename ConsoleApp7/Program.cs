using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System;

namespace LogDemo
{
    class Program
    {
        static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Debug("Enter");
            test1(5, 5);
            test2();
            log.Debug("Return");
        }

        static void test1(int i, int x)
        {
            log.Debug("Enter");
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            log.Debug("Return");
        }

        static void test2()
        {
            // mangler log
            try
            {
                log.Debug("Enter");
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
                log.Debug("Return");
            }
            catch (Exception ex)
            {
                log.Error("Error!: " + ex);
            }
        }
    }
}

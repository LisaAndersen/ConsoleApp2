using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher w = new FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | NotifyFilters.Size;
            w.Created += (s, e) => Console.WriteLine("new");
            w.Changed += (s, e) => Console.WriteLine("changes");
            w.Deleted += (s, e) => Console.WriteLine("deleted file: "+e.Name);
            do
            {}
            while(true);
        }
    }
}

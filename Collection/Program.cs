using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst = new List<Person>();
            var p1 = new Person() { Id = 1, Navn = "john" };
            var p2 = new Person() { Id = 2, Navn = "joe" };
            var p3 = new Person() { Id = 3, Navn = "Birthe" };
            lst.Add(p1);
            lst.Add(p2);
            lst.Add(p3);

            foreach (var item in lst)
            {
                Console.WriteLine("navn: " + item.Navn);
            }

            Dictionary<int, Person> ht = new Dictionary<int, Person>();
            ht.Add(7, p1);
            ht.Add(9, p2);
            ht.Add(11, p3);
            Console.WriteLine(ht[9].Navn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);

            //foreach (var person in people)
            //     Console.WriteLine(person.Name);

            //var p1 = people.OrderBy(x => x.Name);
            //foreach (var person in p1)
            //     Console.WriteLine(person.Name);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personer
            Person p1 = new Person { Fornavn = "per", Efternavn = "Larsen" };
            Instruktør i = new Instruktør { Fornavn = "joe", Efternavn = "juice", NøgleId = 5};
            Elev e = new Elev { Fornavn = "elev", Efternavn = "elevsen", Klasselokale = "lokale 3" };
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());
            Console.WriteLine(e.FuldtNavn());

            Person[] lst = new Person[3];
            lst[0] = p1;
            lst[1] = i;
            lst[2] = e;
            foreach (Person pers in lst)
                pers.Skriv();
            
            //Terning
            Terning t1 = new Terning(2);
            Terning t2 = new Terning();
            t1.Skriv();
            t2.Skriv();

            LudoTerning l1 = new LudoTerning(3);
            LudoTerning l2 = new LudoTerning();
            l1.Skriv();
            l2.Skriv();

            //Dyr
            string sti = @"X:\Michell\Filer\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            Dyr[] dyr = new Dyr[navne.Length];
            for (int k = 0; k<navne.Length;k++) {
                dyr[k] = Dyr.TilfældigtDyr();
                dyr[k].Navn = navne[k];
            }
            foreach(Dyr d in dyr) {
                d.SigNoget();
            }
        }
    }
}

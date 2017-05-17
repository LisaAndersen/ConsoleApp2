using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn() {
            return this.Fornavn + " " + this.Efternavn;
        }

        public virtual void Skriv() {
            Console.WriteLine(this.FuldtNavn());
        }
    }
}

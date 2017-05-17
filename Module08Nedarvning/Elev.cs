using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Elev:Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(this.FuldtNavn() + " Klasselokale: " + this.Klasselokale);
        }
    }
}

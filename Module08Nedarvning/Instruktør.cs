using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Instruktør:Person
    {
        public int NøgleId { get; set; }
        public override void Skriv()
        {
            Console.WriteLine(this.FuldtNavn() + " NøgleId: " + this.NøgleId);
        }
    }
}

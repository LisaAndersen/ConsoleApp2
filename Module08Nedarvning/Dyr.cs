using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Dyr
    {
        private static Random rnd = new Random();
        public string Navn { get; set; }
        public virtual void SigNoget() {
            Console.WriteLine("Jeg er et dyr og hedder: " + this.Navn);
        }

        public static Dyr TilfældigtDyr() {
            int val = rnd.Next(1, 3);
            if (val == 1)
                return new Hund();
            else
                return new Kat();
        }
    }
}

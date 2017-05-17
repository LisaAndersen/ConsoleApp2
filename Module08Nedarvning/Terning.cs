using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Terning
    {
        private static Random rnd = new Random();
        private int værdi;
        public int Værdi { get
            {
                return værdi;
            }
            set{
                if (value > 6 || value <1)
                    this.værdi = 1;
                else
                    this.værdi = value;
            }
        }

        public Terning() {
            this.Værdi = this.Ryst();
        }

        public Terning(int v)
        {
            this.Værdi = v;
        }

        public int Ryst() {
            return rnd.Next(1,7);
        }

        public void Skriv() {
            Console.WriteLine("["+this.værdi+"]");
        }

    }
}

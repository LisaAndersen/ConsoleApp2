using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection2
{
    class Bunke
    {
        private Stack<Kort> bunke;
        public Bunke() {
            this.bunke = new Stack<Kort>();
        }

        public void TilføjKort(Kort k) {
            this.bunke.Push(k);
        }

        public Kort FjernKort()
        {
            if(bunke.Count > 0)
                return this.bunke.Pop();
            return null;
        }

        public void Vis() {
            foreach (var item in this.bunke)
            {
                Console.WriteLine(item);
            }
        }

    }
}

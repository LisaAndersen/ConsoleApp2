﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class Hund:Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + this.Navn);
        }
    }
}

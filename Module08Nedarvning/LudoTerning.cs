using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Nedarvning
{
    class LudoTerning:Terning
    {
        public bool ErGlobus() {
            return (this.Værdi == 3);
        }

        public bool ErStjerne()
        {
            return (this.Værdi == 5);
        }

        public LudoTerning(int værdi): base(værdi)
        {   }
        public LudoTerning():base()
        {   }
    }
}

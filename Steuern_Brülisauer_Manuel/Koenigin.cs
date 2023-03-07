using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Koenigin : Person
    {
        public Koenigin(int einkommen) : base(einkommen)
        {

        }

        public override int berechneSteuer()
        {
            return 0;
        }

    }
}

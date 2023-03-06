using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    internal class Finanzamt
    {
        public int BerechneSteuer(ISteuerzahler[] steuerzahler) {

            int sum = 0;
            foreach (ISteuerzahler s in steuerzahler)
            {
                sum += s.berechneSteuer();
            }
            return sum;
        }
    }
}

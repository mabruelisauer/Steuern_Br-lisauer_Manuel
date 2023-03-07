using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Finanzamt
    {
        /// <summary>
        /// Takes an object array of steuerzahler. Then calculates the taxes for each steuerzahler and adds it to a sum variable which represents the sum of all the taxes to be paid. 
        /// </summary>
        /// <param name="steuerzahler">is an array of Persons which implement the interface ISteuerzahler</param>
        /// <returns>The sum of the taxes of all the Objects inside the steuerzahler array</returns>
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

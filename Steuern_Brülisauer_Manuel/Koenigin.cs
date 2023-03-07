using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Koenigin : Person
    {
        /// <summary>
        /// Constructor connected to the constructor of Person
        /// </summary>
        /// <param name="einkommen">Defines the income that a person has which is also used to claculate the taxes to pay</param>
        public Koenigin(int einkommen) : base(einkommen)
        {

        }

        /// <summary>
        /// Override of the basic berechneSteuer method of the Person class for the queen specifically
        /// </summary>
        /// <returns>The taxes to be paid</returns>
        public override int berechneSteuer()
        {
            return 0;
        }

    }
}

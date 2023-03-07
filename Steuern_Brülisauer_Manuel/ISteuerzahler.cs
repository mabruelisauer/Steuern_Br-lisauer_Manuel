using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public interface ISteuerzahler
    {
        /// <summary>
        /// Is an empty method to calculate the taxes to be paid which every person has to implement
        /// </summary>
        /// <returns>An int which represents the taxes to be paid</returns>
        int berechneSteuer();

    }
}

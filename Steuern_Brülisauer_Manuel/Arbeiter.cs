using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Arbeiter : Person
    {
        /// <summary>
        /// Constructor connected to the constructor of Person
        /// </summary>
        /// <param name="einkommen">Defines the income that a person has which is also used to claculate the taxes to pay</param>
        public Arbeiter(int einkommen) : base(einkommen)
        {

        }
        /// <summary>
        /// Override of the basic berechneSteuer method of the Person class for workers specifically
        /// </summary>
        /// <returns>The taxes to be paid</returns>
        public override int berechneSteuer()
        {
            double steuern = einkommen / 4;
            int gerundet = Convert.ToInt32(Math.Round(steuern)) - 2400;
            if (gerundet < 0 || gerundet > einkommen)
            {
                Console.WriteLine("Es liegt ein Fehler vor! Ein Betrag konnte nicht richtig berechnet werden.");
                return 0;
            }
            else
            {
                return gerundet;
            }
        }
    }
}

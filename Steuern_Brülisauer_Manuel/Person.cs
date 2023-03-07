using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Person : ISteuerzahler
    {
        /// <summary>
        /// Is the base constructor which all the different Persons refer to
        /// </summary>
        /// <param name="einkommen">Is the income which every Person has to define on creation and is used to calculate the taxes to be paid</param>
        public Person(int einkommen) {
        this.einkommen = einkommen;
        }
        /// <summary>
        /// Is the income which every Person has to define on creation and is used to calculate the taxes to be paid
        /// </summary>
        protected int einkommen { get; set; }

        /// <summary>
        /// Is the base method for persons to calculate the taxes to be paid
        /// </summary>
        /// <returns>The taxes to be paid</returns>
        public virtual int berechneSteuer() 
        {
            double steuern = einkommen / 4;
            int gerundet = Convert.ToInt32(Math.Round(steuern));
            if (gerundet < 0 ) 
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

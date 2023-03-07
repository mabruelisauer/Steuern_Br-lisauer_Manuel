using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Unternehmen : ISteuerzahler
    {
        /// <summary>
        /// Is the constructor for the companies which defines the profit that is like the income of the persons
        /// </summary>
        /// <param name="gewinn">Is the profit which every company has to define on creation and is used to calculate the taxes to be paid</param>
        public Unternehmen(int gewinn)
        {
            this.gewinn = gewinn;
        }
        private int gewinn { get; set; }

        /// <summary>
        /// Implementation of the berechneSteuer method of the interface ISteuerzahler for companies specifically
        /// </summary>
        /// <returns>The taxes to be paid</returns>
        public int berechneSteuer ()
        {
            double steuern = gewinn * 0.07;
            int gerundet = Convert.ToInt32(Math.Round(steuern));
            if (gerundet< 0 || gerundet> gewinn)
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

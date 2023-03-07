using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Unternehmen : ISteuerzahler
    {
        public Unternehmen(int gewinn)
        {
            this.gewinn = gewinn;
        }
        private int gewinn { get; set; }
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

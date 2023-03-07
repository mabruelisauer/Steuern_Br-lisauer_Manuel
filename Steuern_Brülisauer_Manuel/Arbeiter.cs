using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Brülisauer_Manuel
{
    public class Arbeiter : Person
    {
        public Arbeiter(int einkommen) : base(einkommen)
        {

        }
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

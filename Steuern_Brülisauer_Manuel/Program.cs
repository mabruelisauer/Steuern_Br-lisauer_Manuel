namespace Steuern_Brülisauer_Manuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Finanzamt finanzamt = new Finanzamt();
            //List<ISteuerzahler> Steuerzahlende = new List<ISteuerzahler>();
            ISteuerzahler[] Steuerzahlende = new ISteuerzahler[5];

            Person Joe_Miller = new Person(6400);
            Steuerzahlende[0] = Joe_Miller;
            Joe_Miller.berechneSteuer();

            Arbeiter Jonny_Worker = new Arbeiter(36000);
            Steuerzahlende[1] = Jonny_Worker;
            Jonny_Worker.berechneSteuer();

            Banker Fred_Moneymaker = new Banker(4000000);
            Steuerzahlende[2] = Fred_Moneymaker;
            Fred_Moneymaker.berechneSteuer();

            Koenigin Silvia = new Koenigin(1000000);
            Steuerzahlende[3] = Silvia;
            Silvia.berechneSteuer();

            Unternehmen MeierHansAG = new Unternehmen(500000);
            Steuerzahlende[4] = MeierHansAG;
            MeierHansAG.berechneSteuer();

            Console.WriteLine(finanzamt.BerechneSteuer(Steuerzahlende));
        }
    }
}
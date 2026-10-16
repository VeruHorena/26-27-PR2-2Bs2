namespace Dedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto bezvaKara = new Auto("toyota", 2013, "5H61234", 5.5);
            bezvaKara.vypisInfo();
            bezvaKara.Jed();
            Kolo kolecko = new Kolo("author", 2025, 1245678, 5);
            kolecko.vypisInfo();
            kolecko.Slapej();

           List<DopravniProstredek> seznam = new List<DopravniProstredek>();
            seznam.Add(bezvaKara);
            seznam.Add(kolecko);
            
            Console.WriteLine("Vypis seznamu:");
             foreach(DopravniProstredek d in seznam)
            {
                d.vypisInfo();         
            }
        }
    }
}

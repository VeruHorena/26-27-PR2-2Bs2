using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class Kolo:DopravniProstredek
    {
        private int vyrCislo;
        private int prevody;

        public Kolo(string nazev, int rokVyroky, int vyroba, int prevody) : base(nazev, rokVyroky)
        {
            Console.WriteLine("Spustil se konstruktor kola.");
            this.vyrCislo = vyroba;
            this.prevody = prevody;
        }

        public int VyrCislo { get => vyrCislo; set => vyrCislo = value; }
        public int Prevody { get => prevody; set => prevody = value; }

        public void Slapej()
        {
            Console.WriteLine("Slapu, slapu jako das.");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class Auto:DopravniProstredek
    {
        private string spz;
        private double spotreba;

        public Auto(string nazev, int rokVyroky,string spz, double spotreba) : base(nazev, rokVyroky)
        {
            Console.WriteLine("Spustil se konstruktor auta.");
            this.spz = spz;
            this.spotreba = spotreba;
        }

        public string Spz { get => spz; set => spz = value; }
        public double Spotreba { get => spotreba; set => spotreba = value; }

        public void Jed()
        {
            Console.WriteLine("Ohoo jedu si po silnici.");
        }
    }
}

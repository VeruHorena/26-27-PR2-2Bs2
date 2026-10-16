using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class DopravniProstredek
    {
        private string nazev;
        private int rokVyroby;

        public string Nazev { get => nazev; set => nazev = value; }
        public int RokVyroby { get => rokVyroby; set => rokVyroby = value; }

        public DopravniProstredek(string nazev, int rokVyroky)
        {
            Console.WriteLine("Spustil se konstruktor DopravniProstredek.");
            this.nazev = nazev;
            this.rokVyroby = rokVyroky;
        }
        public void vypisInfo()
        {
            Console.WriteLine($"Nazev: {nazev} Rok výroby: {rokVyroby}");
        }
    }
}

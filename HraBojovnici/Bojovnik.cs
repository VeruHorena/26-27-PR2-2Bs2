using System;
using System.Collections.Generic;
using System.Text;

namespace HraBojovnici
{
    internal class Bojovnik : Postava
    {
        static Random generator = new Random();
        private int sila;
        public Bojovnik(string jmeno, int zivoty) : base(jmeno, zivoty)
        {
            zivoty = 70;
            sila = generator.Next(10, 31) ;
            Console.WriteLine($"Bojovník má sílu: {sila}");
        }

        public int Sila { get => sila; set => sila = value; }
    }
}

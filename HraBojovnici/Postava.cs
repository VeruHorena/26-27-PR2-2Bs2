using System;
using System.Collections.Generic;
using System.Text;

namespace HraBojovnici
{
    internal class Postava
    {
        private string jmeno;
        private int zivoty;

        public Postava(string jmeno, int zivoty)
        {
            this.jmeno = jmeno;
            this.zivoty = zivoty;
            PredstavSe();
        }

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public int Zivoty { get => zivoty; set => zivoty = value; }

        public void PredstavSe()
        {
            Console.WriteLine("Ahoj já jsem " + jmeno + " a mám " + zivoty + " životů.");

        }
        public void UtrpZraneni()
        {
            if (zivoty >= 15)
            {
                zivoty = zivoty - 15;
                PredstavSe();
            }
            else
            {
                Console.WriteLine("Trénink ukončen.");
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    public class Hrac
    {
        public string Jmeno { get; }
        public List<Karta> Ruka { get; }

        public Hrac(string jmeno)
        {
            Jmeno = jmeno;
            Ruka = new List<Karta>();
        }

        public void PridejKartu(Karta karta)
        {
            Ruka.Add(karta);
        }

        public int SpoctiSoucet()
        {
            int soucet = Ruka.Sum(karta => karta.GetCiselnouHodnotu());
            int pocetEs = Ruka.Count(karta => karta.Hodnota == "A");

            while (soucet > 21 && pocetEs > 0)
            {
                soucet -= 10;
                pocetEs--;
            }

            return soucet;
        }

        public void VypisRuku()
        {
            Console.WriteLine($"{Jmeno} má karty: {string.Join(", ", Ruka)} (Součet: {SpoctiSoucet()})");
        }
    }
}
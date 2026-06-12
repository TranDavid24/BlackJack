using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Balicek
    {
        private List<Karta> karty;
        private Random rnd = new Random();

        public Balicek()
        {
            ResetujBalicek();
        }

        public void ResetujBalicek()
        {
            karty = new List<Karta>();
            string[] barvy = { "♣", "♠", "♥", "♦" };
            string[] hodnoty = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (var barva in barvy)
            {
                foreach (var hodnota in hodnoty)
                {
                    karty.Add(new Karta(hodnota, barva));
                }
            }
        }

        public void Zamichej()
        {
            int n = karty.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Karta hodnota = karty[k];
                karty[k] = karty[n];
                karty[n] = hodnota;
            }
        }

        public Karta LizniKartu()
        {
            if (karty.Count == 0)
            {
                ResetujBalicek();
                Zamichej();
            }
            Karta vybrana = karty[0];
            karty.RemoveAt(0);
            return vybrana;
        }

        public void VypisBalicek()
        {
            Console.WriteLine(string.Join(" ", karty));
        }
    }
}
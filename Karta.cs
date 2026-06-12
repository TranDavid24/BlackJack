using System;

namespace Blackjack
{
    publick class Karta
    {
        public string Hodnota { get; private set; }
        public string Barva { get; private set; }

        public Karta(string hodnota, string barva)
        {
            Hodnota = hodnota;
            Barva = barva;
        }

        public int GetCiselnouHodnotu()
        {
            if (Hodnota == "J" || Hodnota == "Q" || Hodnota == "K")
                return 10;
            if (Hodnota == "A")
                return 11; 
            return int.Parse(Hodnota);
        }

        public override string ToString()
        {
            return $"{Hodnota} {Barva}";
        }
    }
}
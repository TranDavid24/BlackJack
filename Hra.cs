using System;

namespace Blackjack
{
    public class Hra
    {
        private Balicek balicek;

        public Hra()
        {
            balicek = new Balicek();
        }

        public void HrajKolo()
        {
            balicek.ResetujBalicek();
            balicek.Zamichej();

            Hrac hrac = new Hrac("Hráč");
            Hrac dealer = new Hrac("Krupiér");

            hrac.PridejKartu(balicek.LizniKartu());
            hrac.PridejKartu(balicek.LizniKartu());
            dealer.PridejKartu(balicek.LizniKartu());

            Console.WriteLine("--- NOVÉ KOLO ---");
            hrac.VypisRuku();
            Console.WriteLine($"Krupiér má kartu: {dealer.Ruka[0]}");

            while (hrac.SpoctiSoucet() < 21)
            {
                int volba = NacteniVstupu.NactiCislo("\nChcete (1) Další kartu (Hit) nebo (2) Stát (Stand)? ", 1, 2);
                if (volba == 1)
                {
                    hrac.PridejKartu(balicek.LizniKartu());
                    hrac.VypisRuku();
                }
                else
                {
                    break;
                }
            }

            int soucetHrace = hrac.SpoctiSoucet();

            if (soucetHrace > 21)
            {
                Console.WriteLine("\nPrekročil jsi 21! Prohráváš.");
                return;
            }

            Console.WriteLine("\n--- TAH KRUPIÉRA ---");
            while (dealer.SpoctiSoucet() < 17)
            {
                dealer.PridejKartu(balicek.LizniKartu());
            }
            dealer.VypisRuku();

            int soucetDealera = dealer.SpoctiSoucet();

            // Vyhodnocení výsledků
            if (soucetDealera > 21 || soucetHrace > soucetDealera)
            {
                Console.WriteLine("\nGratulujeme! Vyhráváš!");
            }
            else if (soucetHrace < soucetDealera)
            {
                Console.WriteLine("\nBohužel, krupiér vyhrává.");
            }
            else
            {
                Console.WriteLine("\nRemíza!");
            }
        }
    }
}
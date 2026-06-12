using System;

namespace Blackjack
{
    public static class NacteniVstupu
    {
        public static void NactiVolbuMenu(string vyzva, string[] moznosti, out int vybranyIndex)
        {
            Console.WriteLine(vyzva);
            for (int i = 0; i < moznosti.Length; i++)
            {
                Console.WriteLine(moznosti[i]);
            }

            vybranyIndex = NactiCislo("\nZadejte svou volbu: ", 1, moznosti.Length);
        }

        public static int NactiCislo(string vyzva, int min, int max)
        {
            int cislo;
            while (true)
            {
                Console.Write(vyzva);

                if (int.TryParse(Console.ReadLine(), out cislo) && cislo >= min && cislo <= max)
                {
                    return cislo;
                }
                Console.WriteLine($"Neplatná volba! Zadejte číslo od {min} do {max}.");
            }
        }
    }
}
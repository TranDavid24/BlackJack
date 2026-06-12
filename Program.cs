using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Console.Title = "♣ ♠ Blackjack ♥ ♦";
            Console.WindowHeight = 35;
            Console.WindowWidth = 80;

            bool beziProgram = true;
            string vyzva = "Co byste chtěli udělat?";
            string[] moznostiMenu = new string[] { "(1) Hrát Blackjack", "(2) Zamíchat a ukázat balíček", "(3) Ukončit hru" };
            int volbaMenu;

            while (beziProgram)
            {
                Console.Clear();
                NacteniVstupu.NactiVolbuMenu(vyzva, moznostiMenu, out volbaMenu);
                
                switch (volbaMenu)
                {
                    case 1:
                        Console.Clear();
                        Hra instanceHry = new Hra();
                        bool hratZnovu = true;
                        while (hratZnovu)
                        {
                            instanceHry.HrajKolo();
                            int volba = NacteniVstupu.NactiCislo("\nChcete hrát znovu?\n(1) Ano   (2) Ne ", 1, 2);
                            if (volba == 1)
                            {
                                Console.Clear();
                                hratZnovu = true;
                            }
                            else break;
                        }
                        break;
                        
                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- ZAMÍCHANÝ BALÍČEK KARET ---");
                        Balicek testovaciBalicek = new Balicek();
                        testovaciBalicek.Zamichej();
                        testovaciBalicek.VypisBalicek();
                        Console.WriteLine("\nStiskněte libovolnou klávesu pro návrat do menu...");
                        Console.ReadKey();
                        break;
                        
                    case 3:
                        beziProgram = false;
                        break;
                }
            }
        }
    }
}
using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Blackjack";

            Hra hra = new Hra();
            hra.Spustit();
        }
    }
}
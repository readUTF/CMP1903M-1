using System;
using System.Linq;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            var pack = new Pack();
            Pack.shuffleCardPack(1);
            Console.WriteLine("Shuffle 1: " + String.Join(", ", Pack.pack.Select(card => card.ToString())));
            Pack.shuffleCardPack(2);
            Console.WriteLine("Shuffle 2: " + String.Join(", ", Pack.pack.Select(card => card.ToString())));
            Pack.shuffleCardPack(3);
            Console.WriteLine("Shuffle 3: " + String.Join(", ", Pack.pack.Select(card => card.ToString())));

            Console.WriteLine("Pack.deal() : " + Pack.deal());
            Console.WriteLine("Pack.dealCards(7) : " + String.Join(", ", Pack.dealCards(7).Select(card => card.ToString())));
        }
    }
}

using System;
using System.Linq;

namespace CMP1903M_A01_2223
{
    public class ShuffleApp
    {
        public ShuffleApp()
        {
            Pack pack = new Pack();

            Console.WriteLine("Please select from one of the following shuffle types:");
            Console.WriteLine("1. Fisher-Yates");
            Console.WriteLine("2. Riffle");
            Console.WriteLine("3. No shuffle");

            bool shuffled = false;
            while (!shuffled)
            {
                string shuffleTypeInput = Console.ReadLine();

                if (Int32.TryParse(shuffleTypeInput, out int shuffleType))
                {
                    try
                    {
                        pack.ShuffleCardPack(shuffleType);
                        shuffled = true;
                    }
                    catch (Exception ignored)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }
            

            
            while (pack.pack.Count > 0)
            {
                Console.WriteLine("Please specify the number of cards to draw:");
                string amountToDrawInput = Console.ReadLine();
                Int32.TryParse(amountToDrawInput, out int amountToDraw);
                try
                {
                    var dealCards = pack.DealCards(amountToDraw);
                    String drawn = String.Join(", ", dealCards.Select(card => card.ToString()));
                    
                    Console.WriteLine($"You have drawn {drawn}");
                    Console.WriteLine($"There are {pack.pack.Count} cards left in the pack.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }
    }
}
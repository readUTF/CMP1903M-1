using System;
using System.Linq;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {

            var pack = new Pack();
            
            Action dealCards = () =>  Pack.dealCards(53);
            new Pack();
            Action dealCardsMin = () => Pack.dealCards(0);
            new Pack();
            Action invalidShuffle = () => Pack.shuffleCardPack(5);
            new Pack();
            Pack.dealCards(52);
            Action noCardsLeft = () => Pack.deal();
            
            testMethod(dealCards, "Did not throw error on invalid deal", "Success, Cannot deal more cards than in the pack");
            testMethod(dealCardsMin, "Did not throw error on invalid deal", "Success, Cannot deal less than 1 card");
            testMethod(invalidShuffle, "Did not throw error on invalid shuffle", "Success, Cannot shuffle with invalid shuffle type");
            testMethod(noCardsLeft, "Did not throw error on invalid shuffle", "Success, No cards left in pack");
        }

        public static void testMethod(Action action, String success, String error)
        {
            try
            {
                action();
                Console.WriteLine(success);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Error: " + e.Message);
                Console.WriteLine(error);
            }
        }
        
    }
}

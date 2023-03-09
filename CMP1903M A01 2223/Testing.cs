using System;
using System.Linq;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public Testing()
        {
            TestInputExceptions();
            TestShuffle();
            TestDeal();
        }

        private void TestDeal()
        {
            Pack pack = new Pack();
            Console.WriteLine(String.Join(", ", pack.pack.Select(card => card.ToString())));
            pack.ShuffleCardPack(1);
            Console.WriteLine(String.Join(", ", pack.pack.Select(card => card.ToString())));
        }

        private void TestShuffle()
        {
        }

        private void TestInputExceptions()
        {
            Pack pack = new Pack();
            void DealCards() => pack.DealCards(53);
            pack = new Pack();
            void DealCardsMin() => pack.DealCards(0);
            pack = new Pack();
            void InvalidShuffle() => pack.ShuffleCardPack(5);
            pack = new Pack();
            pack.DealCards(52);
            void NoCardsLeft() => pack.Deal();

            testMethod(DealCards, "Failure, Did not throw error on invalid deal",
                "Success, Cannot deal more cards than in the pack");
            testMethod(DealCardsMin, "Failure, Did not throw error on invalid deal",
                "Success, Cannot deal less than 1 card");
            testMethod(InvalidShuffle, "Failure, Did not throw error on invalid shuffle",
                "Success, Cannot shuffle with invalid shuffle type");
            testMethod(NoCardsLeft, "Failure, Did not throw error on invalid shuffle",
                "Success, No cards left in pack");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        /**
         * The single instance of the card pack
         */
        public static List<Card> pack { get; private set; }

        /**
         * Constructor for the card pack, generates the 52 cards
         */
        public Pack()
        {
            pack = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    pack.Add(new Card(i+1, j+1));
                }
            }
        }

        
        /**
         * Used to shuffle the single instance of the card pack
         * typeOfShuffle references the type of shuffle to be used
         * 
         * 1 - Fisher-Yates Shuffle
         * 2 - Riffle Shuffle
         * 3 - No Shuffle
         */
        public static void shuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                case 1:
                    for (var i = pack.Count-1; i >= 0; i--)
                    {
                        Random random = new Random();
                        var rand1 = random.Next(i);
                        var rand2 = random.Next(i);
                        (pack[rand1], pack[rand2]) = (pack[rand2], pack[rand1]);
                    }

                    return;
                case 2:
                    List<Card> clone = new List<Card>();
                    var halfCount = pack.Count / 2;
                    for (var i = 0; i < halfCount; i++)
                    {
                        var card1 = pack[i];
                        var card2 = pack[halfCount+i];
                        clone.Add(card1);
                        clone.Add(card2);
                    }

                    pack = clone;
                    return;
                case 3:
                    return;
                default:
                    throw new Exception("Invalid shuffle type");
            } 
        }

        /**
         * Deals a single card from the pack
         */
        public static Card deal()
        {
            if(pack.Count == 0)
                throw new Exception("No cards left in the pack");
            var card = pack[0];
            pack.Remove(card);
            return card;
        }

        /**
         * Deals a specified amount of cards from the pack
         * amount cannot be negative nor greater than the current size of the pack
         */
        public static List<Card> dealCards(int amount)
        {
            if (amount <= 0 || amount > pack.Count)
            {
                throw new Exception("Invalid amount of cards to deal");
            }
            List<Card> cards = new List<Card>();
            for (int x = 0; x < amount; x++)
            {
                cards.Add(deal());
            }

            return cards;
        }
    }
}
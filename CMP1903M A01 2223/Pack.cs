using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        /// <summary>
        /// The current pack of cards
        /// </summary>
        public List<Card> pack { get; private set; }

        /// <summary>
        /// Generates the current pack and inputs all 52 cards
        /// </summary>
        public Pack()
        {
            pack = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    pack.Add(new Card(i + 1, j + 1));
                }
            }
        }

        /// <summary>
        /// Used to shuffle the single instance of the card pack
        /// typeOfShuffle references the type of shuffle to be used
        /// 
        /// 1 - Fisher-Yates Shuffle
        /// 2 - Riffle Shuffle
        /// 3 - No Shuffle
        ///
        /// The global pack is permuted by the shuffle
        /// </summary>
        /// <param name="typeOfShuffle"></param>
        /// <exception cref="Exception"></exception>
        public void ShuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                case 1:
                    
                    Random random = new Random();
                    for (var i = pack.Count - 1; i >= 0; i--)
                    {
                        var rand1 = random.Next(i);
                        var rand2 = random.Next(i);
                        Console.WriteLine("Swapping " + rand1 + " and " + rand2);
                        (pack[rand1], pack[rand2]) = (pack[rand2], pack[rand1]);
                    }

                    return;
                case 2:
                    List<Card> clone = new List<Card>();
                    var halfCount = pack.Count / 2;
                    for (var i = 0; i < halfCount; i++)
                    {
                        var card1 = pack[i];
                        var card2 = pack[halfCount + i];
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

        /// <summary>
        /// Deals a single card from the pack
        /// </summary>
        /// <returns>The top card on the pack</returns>
        /// <exception cref="Exception">Thrown if no cards are left in the pack when drawing</exception>
        public Card Deal()
        {
            if (pack.Count == 0) throw new Exception("No cards left in the pack");
            var card = pack[0];
            pack.Remove(card);
            return card;
        }

        /// <summary>
        /// Deals a specified amount of cards from the pack
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Specified amount of cards from the top</returns>
        /// <exception cref="Exception">Thrown if less than 1 card is drawn or there are not enough cards in the pack</exception>
        public List<Card> DealCards(int amount)
        {
            if (amount <= 0 || amount > pack.Count)
            {
                throw new Exception("Invalid amount of cards to deal");
            }

            List<Card> cards = new List<Card>();
            for (int x = 0; x < amount; x++)
            {
                cards.Add(Deal());
            }

            return cards;
        }
    }
}
using System;

namespace CMP1903M_A01_2223
{
    class Card
    {
        public int Value { get; } // 1 - 13
        public int Suit; // 1 - 4

        /// <summary>
        /// Instantiates the card with a suit and value
        /// </summary>
        /// <param name="suit">Integer between 1 and 4 describing the cards Suit</param>
        /// <param name="value">Integer between 1 and 13 describing the card type</param>
        /// <exception cref="Exception">If value or suit is not within their respective ranges</exception>
        public Card(int suit, int value)
        {
            if (suit > 4 || suit < 1)
            {
                throw new Exception("Suit must be between 1 and 4");
            }

            if (value > 13 || value < 1)
            {
                throw new Exception("Value must be between 1 and 13");
            }

            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            return values[Value - 1] + " of " + suits[Suit - 1];
        }
    }
}
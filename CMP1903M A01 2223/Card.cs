using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        public int Value { get; set; } // 1 - 13
        public int Suit; // 1 - 4

        
        public Card(int suit, int value)
        {
            if (suit > 4 || suit < 1)
            {
                throw new Exception("Suit must be between 1 and 4");
            }
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return "[Suit: " + Suit + ", Value: " + Value + "]";
        }

    }
}

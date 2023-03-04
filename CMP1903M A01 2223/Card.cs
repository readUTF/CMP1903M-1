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
            Suit = suit;
            Value = value;
        }

        public int getId()
        {
            return (Suit - 1) * 13 + Value;
        }

        public override string ToString()
        {
            return "[Suit: " + Suit + ", Value: " + Value + "]";
        }

        public void printCard()
        {
            Console.WriteLine("Value: " + Value + " Suit: " + Suit);
        }

    }
}

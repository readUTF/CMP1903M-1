using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        public static List<Card> pack;

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

        public static bool shuffleCardPack(int typeOfShuffle)
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
                    return true;
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
                    return true;
                case 3:
                    return true;
            }

            return false;
        }

        public static Card deal()
        {
            var card = pack[0];
            pack.Remove(card);
            return card;
        }

        public static List<Card> dealCards(int amount)
        {
            List<Card> cards = new List<Card>();
            for (int x = 0; x < amount; x++)
            {
                cards.Add(deal());
            }

            return cards;
        }
    }
}
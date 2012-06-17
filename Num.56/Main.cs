using System;

namespace Num._56
{
    public static class Main
    {

        public static Card[] GetNewPack()
        {
            Array values = Enum.GetValues(typeof (Value));
            Array suits = Enum.GetValues(typeof (Suit));

            var packOfCards = new Card[values.Length*suits.Length];
            int index = 0;

            foreach (Suit suit in suits)
                foreach (Value value in values)
                    packOfCards[index++] = new Card(suit, value);

            return packOfCards;
        }


        /// <summary>
        /// <see cref="http://msdn.microsoft.com/en-us/magazine/cc163551.aspx#S3"/>
        /// </summary>
        /// <param name="packOfCards"></param>
        public static void ShufflePack(Card[] packOfCards)
        {

            for (int i = 0; i < packOfCards.Length; i++)
            {
                int r = Random.Next(i, packOfCards.Length);
                Card temp = packOfCards[r];
                packOfCards[r] = packOfCards[i];
                packOfCards[i] = temp;
            }
        }

        private static readonly Random Random = new Random();

    }
}
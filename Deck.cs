using System;
using System.Collections.Generic;

namespace BlackJack
{
    static public class Deck
    {
        const int CardsValue = 52;
        public static List<ICard> CreateDeck()
        {
            var suit = new char[] { '♥', '♦', '♣', '♠' };
            var cardGen = 0;
            var deck = new List<ICard>();
            var hierarchy = 0;
            for (var i = 0; i < CardsValue; i++)
            {
                var cards = new ICard[]
                {
                    new Two(),
                    new Three(),
                    new Four(),
                    new Five(),
                    new Six(),
                    new Seven(),
                    new Eight(),
                    new Nine(),
                    new Ten(),
                    new Jack(),
                    new Queen(),
                    new King(),
                    new Ace()
                };

                deck.Add(cards[hierarchy]);
                deck[i].Suit = suit[cardGen];
                hierarchy++;
                if (hierarchy == cards.Length)
                {
                    hierarchy = 0;
                    cardGen++;
                }
            }
            return deck;
        }

        public static void Shuffle(List<ICard> deck)
        {
            var rnd = new Random();
            for (var i = 0; i < deck.Count; i++)
            {
                var j = rnd.Next(i + 1);
                var tmp = deck[j];
                deck[j] = deck[i];
                deck[i] = tmp;
            }
        }
    }
}

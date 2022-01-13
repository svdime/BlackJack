using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Game
    {
        private int DealerScore = 0;
        private int PlayerScore = 0;

        public void Start()
        {
            Console.WriteLine("Подождите пока готовится колода.");
            var deck = Deck.CreateDeck();
            Deck.Shuffle(deck);
            Deck.Shuffle(deck);
            Deck.Shuffle(deck);

            Console.WriteLine("Колода готова. \nЧтобы продолжить нажмите любую клавишу.");
            Console.ReadKey();
            Console.Clear();

            var dealerHand = new List<ICard>();
            while (DealerScore <= 13)
            {
                var actualCard = deck.Count - 1;
                dealerHand.Add(deck[actualCard]);
                if (deck[actualCard] is Ace && DealerScore >= 11)
                    DealerScore += 1;
                else
                    DealerScore += deck[actualCard].Value;
                deck.RemoveAt(actualCard);
            }
            var tmpName = dealerHand[1].Value >= 10 ? dealerHand[1].Name[0].ToString() : dealerHand[1].Value.ToString();
            var tmpScore = dealerHand[1].Value;

            Console.WriteLine("Диллер готов.");
            Console.WriteLine("Напишите 1, если хотите взять карту.\nНапишите 2, если хотите вскрыть карты.");
            Console.WriteLine();
            Console.WriteLine("Рука диллера");
            Console.WriteLine();
            Console.WriteLine("+---+    +---+");
            Console.WriteLine("|///|    |{0}  |", tmpName);
            Console.Write("|///|");
            Console.Write("    |");
            if (dealerHand[1].Suit == '♥' || dealerHand[1].Suit == '♦')
                Console.ForegroundColor = ConsoleColor.Red;
            else if (dealerHand[1].Suit == '♣' || dealerHand[1].Suit == '♠')
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" {0} ", dealerHand[1].Suit);
            Console.ResetColor();
            Console.WriteLine("|");
            Console.WriteLine("|///|    |  {0}|", tmpName);
            Console.WriteLine("+---+    +---+");
            Console.WriteLine("Счет диллера: {0}", tmpScore);
            Console.WriteLine();
            Console.WriteLine("Ваша рука");
            Console.WriteLine();

            var playerHand = new List<ICard>();
            playerHand.Add(deck[deck.Count - 1]);
            PlayerScore += playerHand[0].Value;
            deck.RemoveAt(deck.Count - 1);
            playerHand.Add(deck[deck.Count - 1]);
            PlayerScore += playerHand[1].Value;
            deck.RemoveAt(deck.Count - 1);
            Print(playerHand);
            Console.WriteLine();
            Console.WriteLine("Ваш счет: {0}", PlayerScore);
            Console.WriteLine();
            while (true)
            {
                if (PlayerScore >= 21) break;
                var userData = Console.ReadLine().Trim();
                if (userData == "2")
                    break;
                else if (userData == "1")
                {
                    var actualCard = deck.Count - 1;
                    if (deck[actualCard] is Ace)
                    {
                        if (PlayerScore >= 11)
                            PlayerScore += 1;
                        else
                            PlayerScore += 11;
                        playerHand.Add(deck[actualCard]);
                        deck.RemoveAt(actualCard);
                        Console.WriteLine();
                        Print(playerHand);
                        Console.WriteLine();
                        Console.WriteLine("Ваш счет: {0}", PlayerScore);
                        continue;
                    }
                    playerHand.Add(deck[actualCard]);
                    PlayerScore += deck[actualCard].Value;
                    deck.RemoveAt(actualCard);
                    Console.WriteLine();
                    Print(playerHand);
                    Console.WriteLine();
                    Console.WriteLine("Ваш счет: {0}", PlayerScore);
                    Console.WriteLine();
                }
            }
            string result;
            if ((PlayerScore > DealerScore) && PlayerScore <= 21 || PlayerScore <= 21 && DealerScore > 21)
                result = "Win";
            else if ((DealerScore > PlayerScore) && DealerScore <= 21 || PlayerScore > 21 && DealerScore <= 21)
                result = "Lose";
            else
                result = "Draw";
            Console.WriteLine();
            Console.WriteLine("Рука диллера");
            Print(dealerHand);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Счет диллера: {0}\nВаш счет: {1} \nИтог: {2}\n", DealerScore, PlayerScore, result);
        }

        static void Print(List<ICard> hand)
        {
            for (var i = 0; i < hand.Count; i++)
            {
                Console.Write("+---+    ");
            }
            Console.WriteLine();
            for (var i = 0; i < hand.Count; i++)
            {
                if (hand[i].Value < 10)
                    Console.Write("|{0}  |    ", hand[i].Value);
                else
                    Console.Write("|{0}  |    ", hand[i].Name[0]);
            }
            Console.WriteLine();
            for (var i = 0; i < hand.Count; i++)
            {
                Console.Write("| ");
                if (hand[i].Suit == '♥' || hand[i].Suit == '♦')
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (hand[i].Suit == '♣' || hand[i].Suit == '♠')
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}", hand[i].Suit);
                Console.ResetColor();
                Console.Write(" |    ");
            }
            Console.WriteLine();
            for (var i = 0; i < hand.Count; i++)
            {
                if (hand[i].Value < 10)
                    Console.Write("|  {0}|    ", hand[i].Value);
                else
                    Console.Write("|  {0}|    ", hand[i].Name[0]);
            }
            Console.WriteLine();
            for (var i = 0; i < hand.Count; i++)
                Console.Write("+---+    ");
        }
    }
}

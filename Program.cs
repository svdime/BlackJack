using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var game = new Game();
                game.Start();
                Console.WriteLine("Нажмите любую клавишу, чтобы начать игру снова.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

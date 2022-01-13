namespace BlackJack
{
    public class Two : ICard
    {
        public string Name
        {
            get { return "Two"; }
        }
        public int Value
        {
            get { return 2; }
        }

        public char Suit { get; set; }
    }

    public class Three : ICard
    {
        public string Name
        {
            get { return "Three"; }
        }
        public int Value
        {
            get { return 3; }
        }
        public char Suit { get; set; }
    }

    public class Four : ICard
    {
        public string Name
        {
            get { return "Four"; }
        }
        public int Value
        {
            get { return 4; }
        }
        public char Suit { get; set; }
    }

    public class Five : ICard
    {
        public string Name
        {
            get { return "Five"; }
        }
        public int Value
        {
            get { return 5; }
        }
        public char Suit { get; set; }
    }

    public class Six : ICard
    {
        public string Name
        {
            get { return "Six"; }
        }

        public int Value
        {
            get { return 6; }
        }
        public char Suit { get; set; }
    }

    public class Seven : ICard
    {
        public string Name
        {
            get { return "Seven"; }
        }
        public int Value
        {
            get { return 7; }
        }
        public char Suit { get; set; }
    }

    public class Eight : ICard
    {
        public string Name
        {
            get { return "Eight"; }
        }
        public int Value
        {
            get { return 8; }
        }
        public char Suit { get; set; }
    }

    public class Nine : ICard
    {
        public string Name
        {
            get { return "Nine"; }
        }
        public int Value
        {
            get { return 9; }
        }
        public char Suit { get; set; }
    }

    public class Ten : ICard
    {
        public string Name
        {
            get { return "Ten"; }
        }
        public int Value
        {
            get { return 10; }
        }
        public char Suit { get; set; }
    }

    public class Jack : ICard
    {
        public string Name
        {
            get { return "Jack"; }
        }

        public int Value
        {
            get { return 10; }
        }
        public char Suit { get; set; }
    }

    public class Queen : ICard
    {
        public string Name
        {
            get { return "Queen"; }
        }
        public int Value
        {
            get { return 10; }
        }
        public char Suit { get; set; }
    }

    public class King : ICard
    {
        public string Name
        {
            get { return "King"; }
        }
        public int Value
        {
            get { return 10; }
        }
        public char Suit { get; set; }
    }

    public class Ace : ICard
    {
        public string Name
        {
            get { return "Ace"; }
        }
        public int Value
        {
            get { return 11; }
        }
        public char Suit { get; set; }
    }
}

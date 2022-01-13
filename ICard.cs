namespace BlackJack
{
    public interface ICard
    {
        string Name { get; }
        int Value { get; }
        char Suit { get; set; }
    }
}
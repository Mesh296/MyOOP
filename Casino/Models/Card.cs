namespace OOP_ICT;

public class Card
{
    public enum Suites
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
    public enum Values
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public Values Value;
    public Suites Suite;

    public Card(Values value, Suites suite)
    {
        Value = value;
        Suite = suite;
    }

    public override string ToString()
    {
        return Value + " of " + Suite;
    }
}
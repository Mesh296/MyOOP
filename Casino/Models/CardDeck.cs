namespace OOP_ICT;

public class CardDeck
{
    private const int maxCount = 54;
    public Card[] Deck = new Card[maxCount];

    public void FillDeck()
    {
        Deck = (from value in Enum.GetValues(typeof(Card.Values)).Cast<Card.Values>()
                from suite in Enum.GetValues(typeof(Card.Suites)).Cast<Card.Suites>()
                select new Card(value, suite)).ToArray();
    }
}


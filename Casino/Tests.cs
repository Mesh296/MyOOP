using Xunit;
using Xunit.Sdk;

namespace OOP_ICT;
public class TestMyCasino
{
    // TODO: Обратите внимание, что для коллекций и проверок есть разные виды Assert
    [Fact]
    public void CardTest_True()
    {
        Card Card_A = new Card(Card.Values.Ace, Card.Suites.Clubs);
        Card Card_J = new Card(Card.Values.Jack, (Card.Suites)1);
        Card Card_5 = new Card((Card.Values)5, Card.Suites.Hearts);

        Assert.Equal(Card_A.ToString(), "Ace of Clubs");
        Assert.Equal(Card_J.ToString(), "Jack of Diamonds");
        Assert.Equal(Card_5.ToString(), "Five of Hearts");
    }

    [Fact]
    public void DeckIsShulffedTest_True()
    {
        Dealer _casino = new Dealer();
        CardDeck raw_deck = new CardDeck();
        CardDeck shuffled_deck= new CardDeck();

        raw_deck.FillDeck();
        shuffled_deck.FillDeck();
        for (int i = 0; i < 52; i++)
        {
            Assert.Equal(raw_deck.Deck[i].ToString(), shuffled_deck.Deck[i].ToString());
        }

        _casino.Shuffle(shuffled_deck);

        Assert.NotEqual(raw_deck.Deck, shuffled_deck.Deck);
    }
}
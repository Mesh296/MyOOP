using OOP_ICT.Interfaces;

namespace OOP_ICT;

public class Dealer : IDealer
{
    public static CardDeck temp_deck = new CardDeck();
   
    public void Shuffle(CardDeck card_deck)
    {
        if (card_deck == null)
            throw new ArgumentNullException(nameof(card_deck), "The deck of cards cannot be null.");

        temp_deck.FillDeck();
        for (int i = 0; i < 52; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                temp_deck.Deck[(i + 1) / 2 + 51 / 2].Value = card_deck.Deck[i].Value;
                temp_deck.Deck[(i + 1) / 2 + 51 / 2].Suite = card_deck.Deck[i].Suite;
            }

            else
            {
                temp_deck.Deck[(i) / 2 ].Value = card_deck.Deck[i].Value;
                temp_deck.Deck[(i) / 2 ].Suite = card_deck.Deck[i].Suite;
            }
        }

        for (int i = 0; i < 52; i++)
        {
            card_deck.Deck[i].Value = temp_deck.Deck[i].Value;
            card_deck.Deck[i].Suite = temp_deck.Deck[i].Suite;
        }
        
    }

    public void DealCard(CardDeck card_deck)
    {

        if (card_deck == null)
            throw new ArgumentNullException(nameof(card_deck), "The deck of cards cannot be null.");

        UserDeck player = new UserDeck();
        int index = 0;

        for (int val = 0; val < 52; val++)
        {
            player.user[index, val%13] = card_deck.Deck[val];
            
            if ((val + 1) % 13 == 0)
                index++;

        }
    }
}
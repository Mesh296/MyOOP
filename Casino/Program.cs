using System;
using System.Reflection;

public class Dealer
{
    public string[,] tempDeck = new string[2,52];
    public int[] tempSuit = new int[52];

    public void Shuffle(Deck newDeck)
    {

        for (int i = 0; i < 52; i ++)
        {
            if ((i + 1) % 2 == 0)
            {
                tempDeck[0, (i + 1)/2 + 51/2] = newDeck.deck[i].Value.ToString();
                tempDeck[1, (i + 1) / 2 + 51 / 2] = newDeck.deck[i].Suit;
            }
            else
            {
                tempDeck[0, (i) / 2] = newDeck.deck[i].Value.ToString();
                tempDeck[1, (i) / 2] = newDeck.deck[i].Suit;
            }
        }

        for (int i = 0; i < 52; i++)
        {
            newDeck.deck[i].Value = int.Parse(tempDeck[0, i]);
            newDeck.deck[i].Suit = tempDeck[1, i];
        }

    }

    public void DealCard(Deck newDeck)
    {

        for (int val = 0; val < 52; val++)
        {
            Console.WriteLine(newDeck.deck[val].Name);
            if ((val + 1) % 13 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

public class Card
{
    public int Value;
    public static string[] SuitArr = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
    public string Suit;

    public Card(int val, string suit)
    {

        Value = val;

        Suit = suit;
    }

    public string Name
    {
        get
        {
            string name = string.Empty;
            switch (Value)
            {
                case (14):
                    name = "Ace";
                    break;
                case (13):
                    name = "King";
                    break;
                case (12):
                    name = "Queen";
                    break;
                case (11):
                    name = "Jack";
                    break;
                default:
                    name = Value.ToString();
                    break;
            }
            return name + " of " + Suit;
        }
    }
}

public class Deck
{
    public Card[] deck = new Card[54];
    
    public void FillDeck()
    {
        int index = 0;
        for (int i=0; i<Card.SuitArr.Length;i++)
        {
            for(int val=14;val>1;val--)
            {
                Card card = new Card(val, Card.SuitArr[i]);
                deck[index] = card;
                index++;
            }
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Dealer Casino1= new Dealer();
        Deck deck1 = new Deck();
        deck1.FillDeck();
        Casino1.Shuffle(deck1);
        Casino1.Shuffle(deck1);
      
        Casino1.DealCard(deck1);
    }
}

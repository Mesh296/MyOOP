namespace OOP_ICT;

public class UserDeck
{
    private const int numOfCards = 13;
    private const int numOfPlayers = 4;
    public Card[ , ] user = new Card[numOfPlayers, numOfCards];
}
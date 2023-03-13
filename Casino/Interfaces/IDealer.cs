namespace OOP_ICT.Interfaces;

// Todo: возможна и другая сигнатура Dealer, я тут скорее просто показываю примерный план работы
public interface IDealer
{
    public void Shuffle(CardDeck card_deck);
    public void DealCard(CardDeck card_deck);

}
namespace exercise_28;

class Program{
    static void Main()
    {
        List<Card> listCards = new List<Card>();
        Card c1 = new Card("ABC", "A", 16);
        Card c2 = new Card("Duolingo", "new York", 10);
        Card c3 = new Card("Programming C++", "Null", 12);
        listCards.Add(c1);
        listCards.Add(c2);
        listCards.Add(c3);

        Card.sortCards(listCards);
        foreach(var element in listCards){
            element.display();
        }
    }
}
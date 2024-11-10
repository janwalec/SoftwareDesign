namespace _1._1OOBasics;

public class Player
{
    public String Name { get; set; }
    private List<Card> Hand { get; set; }

    public Player(string name)
    {
        Name = name;
        this.Hand = new List<Card>();
    }

    public int TotalHandValue()
    {
        int i = 0;
        foreach (Card card in Hand)
            i += card.GetValue();
        return i;
    }

    public String ShowHand()
    {
        String output = "I (" + this.Name + ") have those cards:";
        foreach (Card card in Hand)
            output += "\n\t\t" + card;
        return output;
    }

    public void AcceptCard(Card card)
    {
        Hand.Add(card);
    }
}
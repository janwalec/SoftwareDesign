namespace _1._1OOBasics;

public class GreenCard : Card
{
    public GreenCard(int numberOnCard)
    {
        this.NumberOnCard = numberOnCard;
        this.Value = 3;
    }

    public override string ToString()
    {
        return "GREEN " + base.ToString();
    }
}
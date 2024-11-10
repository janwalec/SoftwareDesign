namespace _1._1OOBasics;

public class RedCard : Card
{
    public RedCard(int numberOnCard)
    {
        this.NumberOnCard = numberOnCard;
        this.Value = 1;
    }
    
    public override string ToString()
    {
        return "RED " + base.ToString();
    }
}
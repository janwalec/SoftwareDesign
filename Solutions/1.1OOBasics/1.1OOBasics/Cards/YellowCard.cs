using System.Runtime.CompilerServices;

namespace _1._1OOBasics;

public class YellowCard : Card
{
    public YellowCard(int numberOnCard)
    {
        this.NumberOnCard = numberOnCard;
        this.Value = 4;
    }
    
    public override string ToString()
    {
        return "YELLOW " + base.ToString();
    }
}
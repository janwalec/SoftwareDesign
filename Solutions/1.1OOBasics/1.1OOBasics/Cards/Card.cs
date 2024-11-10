namespace _1._1OOBasics;

public abstract class Card
{
    public int Value { get; protected set; }
    public int NumberOnCard { get; protected set; }

    public int GetValue()
    {
        return Value * NumberOnCard;
    }

    public override string ToString()
    {
        return "value:" + Value.ToString() + " number on card:" + NumberOnCard.ToString() + "\t#total:" + GetValue().ToString();
    }
    
}
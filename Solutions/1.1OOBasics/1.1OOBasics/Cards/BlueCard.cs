namespace _1._1OOBasics;

public class BlueCard : Card
{
   public BlueCard(int numberOncard)
   {
      this.NumberOnCard = numberOncard;
      this.Value = 2;
   }
   
   public override string ToString()
   {
      return "BLUE " + base.ToString();
   }
}
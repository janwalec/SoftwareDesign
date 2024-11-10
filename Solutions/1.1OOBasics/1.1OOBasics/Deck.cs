namespace _1._1OOBasics;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();
    private readonly Random _random = new Random();


    public Deck()
    {
        this.CreateCards();
        this.Shuffle();
    }

    private void Shuffle()
    {
        int n = this.Cards.Count;
        // shuffle 2 random cards n * 100 times
        
        for (int i = 0; i < n * 100; i++)
        {
            int ind1 = _random.Next(0, n - 1);
            int ind2 = _random.Next(0, n - 1);
            
            Card card1 = this.Cards[ind1];
            this.Cards[ind1] = this.Cards[ind2];
            this.Cards[ind2] = card1;
        }
    }

    private void CreateCards()
    {
        int amountToCreate = 20;
        int maxNumberOnCard = 10;
        
        for (int i = 1; i <= amountToCreate; i++)
        {
            if (i > amountToCreate - amountToCreate / 4)
            {
                this.Cards.Add(new RedCard(_random.Next(1, maxNumberOnCard)));        
            }
            else if (i > amountToCreate - 2 * amountToCreate / 4)
            {
                this.Cards.Add(new YellowCard(_random.Next(1, maxNumberOnCard)));
            }
            else if (i > amountToCreate - 3 * amountToCreate / 4)
            {
                this.Cards.Add(new GreenCard(_random.Next(1, maxNumberOnCard)));
            }
            else
            {
                this.Cards.Add(new BlueCard(_random.Next(1, maxNumberOnCard)));
            }
        }
    }

    public void DealToPlayer(Player player, int amountToDeal)
    {
        for (int i = 0; i < amountToDeal; i++)
        {
            Card card = this.Cards[_random.Next(0, Cards.Count)];
            player.AcceptCard(card);
            this.Cards.Remove(card);
        }
    }
    
    
    
}
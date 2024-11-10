namespace _1._1OOBasics;

public class HighHand : IGameType
{
    public HighHand() {}
    
    public string AnnounceWinner(List<Player> players)
    {
        String name = "";
        int currMin = -1000000000; // very low number
        foreach (Player player in players)
        {
            if (player.TotalHandValue() > currMin)
            {
                currMin = player.TotalHandValue();
                name = player.Name;
            }
        }
        
        return "Player " + name + " wins!";
    }
}
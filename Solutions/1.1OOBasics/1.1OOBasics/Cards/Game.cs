namespace _1._1OOBasics.Cards;

public class Game
{
    private readonly List<Player> _players = new List<Player>();
    private int _numberOfPlayers; // amount of players, to be set when game starts
    private bool _started;
    
    private readonly Deck _deck = new Deck();
    private readonly int _amountToDeal = 5;
    
    private readonly IGameType _gameType = new HighHand(); // game type

    public void AddPlayer(Player player)
    {
        if (!_started) // if game has not started yet
        {
             _players.Add(player);
             Console.WriteLine(player.Name + " is playing.");
        }
    }

    public void Start()
    {
        _started = true;
        _numberOfPlayers = _players.Count;
        DealCards();
        
        Console.WriteLine("game has started!");
    }

    private void DealCards()
    {
        if (_amountToDeal * _numberOfPlayers > _deck.Cards.Count)
        {
            throw new InvalidOperationException("Dealing cards is too big.");
        }
        
        foreach (Player player in _players)
        {
            _deck.DealToPlayer(player, _amountToDeal);
        }
    }

    public string AnnounceWinner()
    {   
        if (!_started)
            return "Game has not started yet!";
        return this._gameType.AnnounceWinner(_players);
    }


}
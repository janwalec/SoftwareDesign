using _1._1OOBasics;
using _1._1OOBasics.Cards;


Game game = new Game();
Player p1 = new Player("John");
Player p2 = new Player("Eva");
Player p3 = new Player("Martin");
Player p4 = new Player("Bob");

game.AddPlayer(p1);
game.AddPlayer(p2);
game.AddPlayer(p3);
game.AddPlayer(p4);
game.Start();


Console.WriteLine(p1.Name + " " + p1.TotalHandValue());
Console.WriteLine(p2.Name + " " + p2.TotalHandValue());
Console.WriteLine(p3.Name + " " + p3.TotalHandValue());
Console.WriteLine(p4.Name + " " + p4.TotalHandValue());
Console.WriteLine(game.AnnounceWinner());
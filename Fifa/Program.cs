using Fifa;
Game game = new Game();
Team teamA, teamB;

Goalkeeper goalkeeperA = new Goalkeeper("Nick", 22, 35, 180);
Defender defender1A = new Defender("Tommy", 8, 18, 177);
Defender defender2A = new Defender("Tyler", 1, 28, 175);
Defender defender3A = new Defender("Aboubakar", 2, 28, 175.5);
Defender defender4A = new Defender("Toney", 6, 28, 173.5);
Midfielder midfield1A = new Midfielder("Jesus", 8, 27, 182);
Midfielder midfield2A = new Midfielder("Tomey", 6, 27, 181);
Midfielder midfield3A = new Midfielder("Kim", 9, 27, 188);
Striker striker1A = new Striker("Donald", 16, 20, 180);
Striker striker2A = new Striker("Partey", 33, 30, 176);
Striker striker3A = new Striker("Benzema", 99, 30, 191);

Goalkeeper goalkeeperB = new Goalkeeper("Neuer", 1, 37, 185);
Defender defender1B = new Defender("Cancelo", 2, 28, 175.5);
Defender defender2B = new Defender("Upamecano", 3, 24, 182);
Defender defender3B = new Defender("Jones", 8, 30, 173);
Defender defender4B = new Defender("Laporte", 5, 28, 171);
Midfielder midfield1B = new Midfielder("Fernandinho", 26, 31, 181);
Midfielder midfield2B = new Midfielder("Bruno", 17, 31, 172);
Midfielder midfield3B = new Midfielder("De Bruyne", 4, 31, 185);
Striker striker1B = new Striker("Grealish", 9, 30, 172);
Striker striker2B = new Striker("Holland", 10, 30, 176);
Striker striker3B = new Striker("Mahrez", 11, 33, 189);

teamA = new Team(new Coach("Petur", 42),
    new List<FootballPlayer>
{
    goalkeeperA,
    defender1A,
    defender2A,
    defender3A,
    defender3A,
    midfield1A,
    midfield2A,
    midfield3A,
    striker1A,
    striker2A,
    striker3A
});
teamB = new Team(new Coach("Tinko", 29),
    new List<FootballPlayer>
{
    goalkeeperB,
    defender1B,
    defender2B,
    defender3B,
    defender3B,
    midfield1B,
    midfield2B,
    midfield3B,
    striker1B,
    striker2B,
    striker3B
});

game.TeamA = teamA;
game.TeamB = teamB;
game.Referee = new Referee("Ivan", 37);
game.AssistantReferees.Add(new Referee("Niki", 41));
game.AssistantReferees.Add(new Referee("Tosho", 26));
game.Goals.Add(new Goals(11, striker1A));
game.Goals.Add(new Goals(32, striker2B));
game.Goals.Add(new Goals(83, defender2B));

Console.WriteLine("Game Result: " + game.GameResult());
Console.WriteLine("Winner: " + game.Winner());
Console.WriteLine("TeamA Coach: " + game.TeamA.Coach.Name);
Console.WriteLine("TeamA AverageAge: " + game.TeamA.AverageAge());
Console.WriteLine("TeamB Coach: " + game.TeamB.Coach.Name);
Console.WriteLine("TeamB AverageAge: " + game.TeamB.AverageAge());
Console.WriteLine("Goals:");

foreach (var goal in game.Goals)
{
    Console.WriteLine($"Player: {goal.Player.Name}, Minute: {goal.Minute}");
}
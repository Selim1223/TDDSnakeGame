using TDDSnakeGame;

class Program
{

    private static void Main(string[] args)
    {
        StartSnakeGame();
    }

    private static void StartSnakeGame()
    {
        int gameTurn = 50;
        List<Player> players = new List<Player>();
        players.Add(new Player("John"));
        players.Add(new Player("Tom"));
        Game board = new Game(gameTurn, players);
        board.StartGame();
    }

}
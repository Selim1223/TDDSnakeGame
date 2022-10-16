using TDDSnakeGame;

class Program
{

    private static void Main(string[] args)
    {
        StartSnakeGame();
    }

    private static void StartSnakeGame()
    {
        Game game = new Game();
        game.GameTurn = 50;
        game.Start();
    }

}
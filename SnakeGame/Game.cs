using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSnakeGame;

namespace TDDSnakeGame
{
    public class Game
    {
        public int GameTurn { get; set; }
        public bool GameIsFinished { get; set; }
        public List<Player> Players { get; set; }
        public bool IsStarted { get; set; }
        public int CurrentTurn { get; set; }
        public bool HasEnded { get; set; }

        public Game()
        {
            GameTurn = 50;
            Players = new List<Player>();
            IsStarted = false;
            CurrentTurn = 1;
            HasEnded = false;


        }

        public int CountPlayers()
        {
            return Players.Count;
        }

        public void AddPlayer(string name)
        {
            if (CountPlayers() == 2)
                throw new UnhandledNumberOfPlayersException("You can't play with more than two players");

            Players.Add(new Player(name));
        }

        public void SetIsStarted()
        {
            if (CountPlayers() != 2)
                throw new UnhandledNumberOfPlayersException("You can't start a game if there is not exactly two players");

            IsStarted = true;
        }

        public void AskPlayersNames()
        {
            Console.WriteLine("Please set player one name : ");
            AddPlayer(Console.ReadLine());
            Console.WriteLine("Please set player two name : ");
            AddPlayer(Console.ReadLine());
        }

        public Player GetPlayerTurn()
        {
            if (CurrentTurn % 2 != 0)
                return Players[0];

            return Players[1];
        }

        public void Start()
        {
            AskPlayersNames();
            SetIsStarted();
            while (!GameIsFinished)
                foreach (Player player in Players)
                {
                    player.DiceRoll();
                    if (CheckIfPlayerWin())
                        break;
                }
        }

        public bool CheckIfPlayerWin()
        {
            foreach (Player player in Players)
                if (player.newPosition == GameTurn)
                    return GetWinnerPlayer(player);
            return HasEnded;
        }

        public bool GetWinnerPlayer(Player player)
        {
            GameIsFinished = true;
            Console.WriteLine("Le joueur " + player.Name + " a gagné la partie !");
            return true;
        }

    

        public class UnhandledNumberOfPlayersException : Exception
        {
            public UnhandledNumberOfPlayersException(string message) : base(message)
            {

            }
        }

    }
}

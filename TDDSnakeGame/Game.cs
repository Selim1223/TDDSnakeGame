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
        private int GameTurn { get; set; }
        private List<Player> Players { get; set; }
        bool GameIsFinished { get; set; }

        public Game(int turn, List<Player> players)
        {
            GameTurn = turn;
            this.Players = players;
            GameIsFinished = false;
        }

        public void StartGame()
        {
            while (!GameIsFinished)
                foreach (Player player in Players)
                {
                    player.DiceRoll();
                    if (CheckIfPlayerWin())
                        break;
                }
        }

        private bool CheckIfPlayerWin()
        {
            foreach (Player player in Players)
                if (player.newPosition == GameTurn)
                    return GetWinnerPlayer(player);
            return false;
        }

        private bool GetWinnerPlayer(Player player)
        {
            GameIsFinished = true;
            Console.WriteLine("Le joueur " + player.name + " a gagné la partie !");
            return true;
        }
    }
}

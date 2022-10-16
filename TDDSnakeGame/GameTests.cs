using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TDDSnakeGame.Game;

namespace TDDSnakeGame
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void InitTests()
        {
            game = new Game();
        }

        [TestMethod]
        public void StartingGameWithNoPlayers()
        {
            Assert.AreEqual(game.CountPlayers(), 0);
        }

        [TestMethod]
        public void AddingOnePlayers_WillGiveOnePlayersCount()
        {
            game.AddPlayer("Tom");
            Assert.AreEqual(game.CountPlayers(), 1);
        }

        [TestMethod]
        public void AddingTwoPlayers_WillGiveTwoPlayersCount()
        {
            game.AddPlayer("Tom");
            game.AddPlayer("John");
            Assert.AreEqual(game.CountPlayers(), 2);
        }

        [TestMethod]
        public void AddingThreePlayers_WillThrowUnhandleNumberOfPlayersException()
        {
            game.AddPlayer("Tom");
            game.AddPlayer("John");
            Assert.ThrowsException<UnhandledNumberOfPlayersException>(() => game.AddPlayer("Paul"));
        }

        public void AskPlayersNames_WillSetPlayerNames()
        {
            var input = new StringReader(@"Tom
John");
            Console.SetIn(input);

            game.AskPlayersNames();

            Assert.AreEqual(game.Players[0].Name, "Tom");
            Assert.AreEqual(game.Players[1].Name, "John");
        }


  

        [TestMethod]
        public void SetIsStarted_SetItToTrue()
        {
            game.AddPlayer("Tom");
            game.AddPlayer("John");
            game.SetIsStarted();
            Assert.IsTrue(game.IsStarted);
        }



        [TestMethod]
        public void GameFinalPositionEquals50()
        {
            Assert.AreEqual(game.GameTurn, 50);
        }

        [TestMethod]
        public void GameWillEndWhenGameIsFinished()
        {
            Assert.AreEqual(game.GameIsFinished, false);
        }

        [TestMethod]
        public void GameWillEndIfOneOfPlayersWin()
        {
            Assert.AreEqual(game.CheckIfPlayerWin(), false);
        }
    }
}

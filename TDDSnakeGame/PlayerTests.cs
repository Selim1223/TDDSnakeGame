using TDDSnakeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSnakeGame
{
    [TestClass]
    public class PlayerTests
    {
        private Player _player;

        private Game game;
        private Player playerOne;
        private Player playerTwo;

        [TestInitialize]
        public void InitTests()
        {
            game = new Game();
            game.AddPlayer("Tom");
            game.AddPlayer("John");
            playerOne = game.Players.First();
            playerTwo = game.Players.Last();
        }

        public PlayerTests()
        {
            _player = new Player("");
           
        }

        [TestMethod]
        public void ScoreDiceOfPlayers_ShouldNotBeNull()
        {
            Assert.IsNotNull(_player.ScoreDice);
        }

    
        [TestMethod]
        public void GetPlayersName()
        {
            Assert.AreEqual(playerOne.Name, "Tom");
            Assert.AreEqual(playerTwo.Name, "John");
            
        }


        [TestMethod]
        public void PlayersPositions_ShouldBe25IfPositionExceed50()
        {
            if(_player.newPosition > 50)
                _player.newPosition.Equals(25);
        }
    }
}

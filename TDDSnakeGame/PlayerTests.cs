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

        public PlayerTests()
        {
            _player = new Player("");
           
        }

        [TestMethod]
        public void NbPlayers_ShouldNotBeNull()
        {
            Assert.IsNotNull(_player.number);
        }
   

        [TestMethod]
        public void NbPlayers_ShouldBe2()
        {
            _player.number.Equals(2);
        }


        [TestMethod]
        public void PlayersPositions_ShouldBe25IfPositionExceed50()
        {
            if(_player.newPosition >50)
                _player.newPosition.Equals(25);
        }
    }
}

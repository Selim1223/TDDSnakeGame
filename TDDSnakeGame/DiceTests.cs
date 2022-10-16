namespace TDDSnakeGame
{
    [TestClass]
    public class DiceTests
    {
        private Dice _dice;

        public DiceTests()
        {
            _dice = new Dice();
           
        }

        [TestMethod]
        public void DiceRoll_ShouldNotBeNull()
        {
            Assert.IsNotNull(Dice.Roll());
        }

    }
}
namespace TDDSnakeGame
{
    public class Dice
    {
        public static Random random = new Random();

        public static int Roll()
        {
            return random.Next(1, 7);
        }
    }
}
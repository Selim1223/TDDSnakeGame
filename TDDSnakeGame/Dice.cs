﻿namespace TDDSnakeGame
{
    public class Dice
    {
        private static Random random = new Random();

        public static int Roll()
        {
            return random.Next(1, 7);
        }
    }
}
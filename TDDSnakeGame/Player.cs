using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSnakeGame;

namespace TDDSnakeGame
{
    public class Player
    {
        public string name { get; set; }
        public int newPosition { get; set; }

        public int number { get; set; }

        public Player(string name)
        {
            this.name = name;
        }
       

        public void DiceRoll()
        {
            int number = Dice.Roll();
            newPosition += number;
            Console.WriteLine(name + " a jeté son dé et à obtenu le score de " + number + " sa position est de " + newPosition);
            if (newPosition > 50)
            {
                newPosition = 25;
                Console.WriteLine(name + " a dépassé la position 50, il retombe à 25");
            }
            Console.WriteLine("\n");
        }

    }
}

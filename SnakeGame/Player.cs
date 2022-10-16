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
        public string Name { get; set; }
        public int newPosition { get; set; }

        public int ScoreDice { get; set; }


        public Player(string name)
        {
            this.Name = name;
        }
       

        public void DiceRoll()
        {
            int ScoreDice = Dice.Roll();
            newPosition += ScoreDice;
            Console.WriteLine(Name + " a jeté son dé et à obtenu le score de " + ScoreDice + " sa position est de " + newPosition);
            if (newPosition > 50)
            {
                newPosition = 25;
                Console.WriteLine(Name + " a dépassé la position 50, il retombe à 25");
            }
            Console.WriteLine("\n");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class ComputerPlayer: Game
    {
        public void PlayerName(string name)
        {
            name =  ("Sheldon");
            Console.WriteLine("Player 2 name is Sheldon");
        }

        public override string PlayerChoice()
        {
            Random random = new Random();
            int choice = random.Next(0, 4);
            if (choice == 0)
            {
                return "Paper";
            }
            else if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Scissors";
            }
            else if (choice == 3)
            {
                return "Lizard";
            }
            else
            {
                return "Spock";
            }

        }
    }
}

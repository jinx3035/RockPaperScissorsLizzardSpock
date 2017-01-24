using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class ComputerPlayer: Player
    {
       
        public override string GetPlayerName(string name)
        {
            Console.WriteLine("Enter computer player name:");
            return Console.ReadLine();
        }
        public override void ShowPlayerName()
        {
            Console.WriteLine("Hello. Press enter to begin.");
            Console.ReadLine();
        }

        public override string ChoosePlayerChoice()
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
        public override void ShowPlayerChoice()
        {
            Player choice = new Player();
            choice.ChoosePlayerChoice();
        }
    }
}

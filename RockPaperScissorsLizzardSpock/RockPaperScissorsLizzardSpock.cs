using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Player
    {


        
        public string PlayerChoice()
        {
            Console.WriteLine("Choose from Rock, Paper, Scissors, Lizard or Spock:");
            string choice = Console.ReadLine();
            if (choice == "Rock")
            {
                return "Rock";
            }
            else if (choice == "Paper")
            {
                return "Paper";
            }
            else if (choice == "Scissors")
            {
                return "Scissors";
            }
            else if (choice == "Lizard")
            {
                return "Lizard";
            }
            else 
            {
                return "Spock";
            }
        }
        public  string AiChoice()
        {
            Random random = new Random();
            int number = random.Next(0,5);
            if(number == 0)
            {
                return "Paper";
            }
            else if(number == 1)
            {
                return "Rock";
            }
            else if(number == 2)
            {
                return "Scissors";
            }
            else if(number == 3)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Player
    {

        public void PlayGame()
        {
            string UserInput = PlayerChoice();
            string ComInput = GetAiChoice();
            Console.WriteLine("Your choice:{0}", UserInput);
            Console.WriteLine("The computer choice:{0}", ComInput);
            Winner(UserInput, ComInput);
            Console.ReadLine();
        }
        private string PlayerChoice()
        {
            Console.WriteLine("Choose from Rock, Paper, Scissors, Lizzard or Spock:");
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
        private string GetAiChoice()
        {
            Random random = new Random();
            int number = random.Next(1, 6);
            if(number == 1)
            {
                return "Paper";
            }
            else if(number == 2)
            {
                return "Rock";
            }
            else if(number == 3)
            {
                return "Scissors";
            }
            else if(number == 4)
            {
                return "Lizard";
            }
            else
            {
                return "Spock";
            }
        }

        private void Winner(string PlayerInput, string AiInput)
        {
            if((PlayerInput == "P") && (AiInput == "R") || (AiInput == "Sp"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "R") && (AiInput == "S") || (AiInput == "L"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "S") && (AiInput == "P") || (AiInput == "L"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "L") && (AiInput == "P") || (AiInput == "Sp"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "Sp") && (AiInput == "S") || (AiInput == "R"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            else if(PlayerInput == AiInput)
            {
                Console.WriteLine("How boring. It's a tie.");
            }
            else
            {
                Console.WriteLine("Resistance is futile. You have been defeated.");
            }
        }
    }
}

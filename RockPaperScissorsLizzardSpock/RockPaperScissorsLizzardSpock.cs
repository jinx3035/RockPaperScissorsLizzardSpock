using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class RockPaperScissorsLizzardSpock
    {

        public void PlayGame()
        {
            string UserInput = PlayerInput();
            string ComInput = GetAiChoice();
            Console.WriteLine("Your choice:{0}", LetterToWord(UserInput));
            Console.WriteLine("The computer choice:{0}", LetterToWord(ComInput));
            Winner(UserInput, ComInput);
            Console.ReadLine();
        }
        private string PlayerInput()
        {
            Console.WriteLine("Choose R(ock), P(aper), S(cissors), L(izzard) or Sp(ock):");
            string choice = Console.ReadLine();
            if (choice == "R")
            {
                return "R";
            }
            else if (choice == "P")
            {
                return "P";
            }
            else if (choice == "S")
            {
                return "S";
            }
            else if (choice == "L")
            {
                return "L";
            }
            else 
            {
                return "Sp";
            }
        }
        private string GetAiChoice()
        {
            Random random = new Random();

            int number = random.Next(1, 6);
            if(number == 1)
            {
                return "P";
            }
            else if(number == 2)
            {
                return "R";
            }
            else if(number == 3)
            {
                return "S";
            }
            else if(number == 4)
            {
                return "L";
            }
            else
            {
                return "Sp";
            }
        }
        private string LetterToWord(string input)
        {
            if (input == "P")
            {
                return "paper";
            }
            else if (input == "R")
            {
                return "rock";
            }
            else if (input == "S")
            {
                return "scissors";
            }
            else if (input == "L")
            {
                return "lizard";
            }
            else
            {
                return "spock";
            }
        }
        private void Winner(string PlayerInput, string AiInput)
        {
            if((PlayerInput == "P") && (AiInput == "R") || (AiInput == "Sp"))
            {
                Console.WriteLine("You have beat the computer.");
            }
            if ((PlayerInput == "R") && (AiInput == "S") || (AiInput == "L"))
            {
                Console.WriteLine("You have beat the computer.");
            }
            if ((PlayerInput == "S") && (AiInput == "P") || (AiInput == "L"))
            {
                Console.WriteLine("You have beat the computer.");
            }
            if ((PlayerInput == "L") && (AiInput == "P") || (AiInput == "Sp"))
            {
                Console.WriteLine("You have beat the computer.");
            }
            if ((PlayerInput == "Sp") && (AiInput == "L") || (AiInput == "R"))
            {
                Console.WriteLine("You have beat the computer.");
            }
            else if(PlayerInput == AiInput)
            {
                Console.WriteLine("It's a tie.");
            }
            else
            {
                Console.WriteLine("The computer defeated you.");
            }
        }               
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class HumanPlayer : Player
    {
        
        public override string GetPlayerName(string name)
        {
            Console.WriteLine("Enter human player name:");
            return Console.ReadLine();
        }

        public override void ShowPlayerName()
        {
            Console.WriteLine("Hello. Press enter to begin.");
            Console.ReadLine();


        }

        //public void ShowPlayerChoice()
        //{
        //playerOne.GetPlayerChoice();
        //playerTwo.GetPlayerChoice();
        //}

        public override string ChoosePlayerChoice()
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
            else if (choice == "Spock") 
            {
                return "Spock";
            }
            else
            {
                return ChoosePlayerChoice();
            }
        }
        public override void ShowPlayerChoice()
        {
            Player choice = new Player();
            choice.ChoosePlayerChoice();
        }
        //public string ResetPlayerChoice()
        //{
        //    Console.WriteLine("Enter valid information");
        //    Console.ReadLine();
        //    PlayerChoice();
        //}
    }
}

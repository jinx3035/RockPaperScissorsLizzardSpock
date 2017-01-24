using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Game
    {


        //public HumanPlayer name;
        public Player playerOne;
        public Player playerTwo;
        public Player choice;
        public string name;

        public void ChooseOnePlayer()
        {
           playerOne = new HumanPlayer();
           playerTwo = new ComputerPlayer();            
        }

        public void ChooseTwoPlayers()
        {
            playerOne = new HumanPlayer();            
            playerTwo = new HumanPlayer();

        }

 

        public void PlayGame()
        {
            Console.WriteLine("Hello. And welcome to Rock, Paper, Scissors, Lizzard, Spock.\n Press any key to continue.");
            Console.ReadKey();            
            Console.WriteLine("Is there '1' or '2' players?");
            string GameType = Console.ReadLine();

            if(GameType == "1")
            {
                ChooseOnePlayer();
                playerOne.GetPlayerName(name);
                playerOne.ShowPlayerName();
                playerOne.ChoosePlayerChoice();
                playerTwo.GetPlayerName(name);
                playerTwo.ShowPlayerName();
                playerTwo.ChoosePlayerChoice();
                ShowChoices();
            }
            else if(GameType == "2")
            {
                ChooseTwoPlayers();
                ShowChoices();
            }
            else
            {
                PlayGame();
            }            
        }



        public void ShowChoices()
        {
            Console.WriteLine(playerOne.GetPlayerName(name) + "'s choice: " + playerOne.ChoosePlayerChoice());
            Console.WriteLine(playerOne.GetPlayerName(name) + "'s choice: " + playerTwo.ChoosePlayerChoice());
            Console.ReadLine();
            DetermineWinner();
        }



        private void DetermineWinner()
        {
            if ((playerOne.ChoosePlayerChoice() == "Paper") && (playerTwo.ChoosePlayerChoice() == "Rock") || (playerTwo.ChoosePlayerChoice() == "Spock"))
            {
                Console.WriteLine("Congratulations " + playerOne.GetPlayerName(name) + "'s choice: " + playerOne.ChoosePlayerChoice() + " defeats " + playerOne.GetPlayerName(name) + "'s choice: "+ playerTwo.ChoosePlayerChoice() + " --> " + playerOne.GetPlayerName(name) + " wins.");
            }
            else if ((playerOne.ChoosePlayerChoice() == "Rock") && (playerTwo.ChoosePlayerChoice() == "Scissors") || (playerTwo.ChoosePlayerChoice() == "Lizard"))
            {
                Console.WriteLine("Congratulations " + playerOne.GetPlayerName(name) + "'s choice: " + playerOne.ChoosePlayerChoice() + " defeats " + playerOne.GetPlayerName(name) + "'s choice: " + playerTwo.ChoosePlayerChoice() + " --> " + playerOne.GetPlayerName(name) + " wins.");
            }
            else if ((playerOne.ChoosePlayerChoice() == "Scissors") && (playerTwo.ChoosePlayerChoice() == "Paper") || (playerTwo.ChoosePlayerChoice() == "Lizard"))
            {
                Console.WriteLine("Congratulations " + playerOne.GetPlayerName(name) + "'s choice: " + playerOne.ChoosePlayerChoice() + " defeats " + playerOne.GetPlayerName(name) + "'s choice: " + playerTwo.ChoosePlayerChoice() + " --> " + playerOne.GetPlayerName(name) + " wins.");
            }
            else if ((playerOne.ChoosePlayerChoice() == "Lizard") && (playerTwo.ChoosePlayerChoice() == "Paper") || (playerTwo.ChoosePlayerChoice() == "Spock"))
            {
                Console.WriteLine("Congratulations " + playerOne.GetPlayerName(name) + "'s choice: " + playerOne.ChoosePlayerChoice() + " defeats " + playerOne.GetPlayerName(name) + "'s choice: " + playerTwo.ChoosePlayerChoice() + " --> " + playerOne.GetPlayerName(name) + " wins.");
            }
            else if ((playerOne.ChoosePlayerChoice() == "Spock") && (playerTwo.ChoosePlayerChoice() == "Scissors") || (playerTwo.ChoosePlayerChoice() == "Rock"))
            {
                Console.WriteLine("Congratulations " + playerOne.GetPlayerName(name) + "'s choice: " + playerOne.ChoosePlayerChoice() + " defeats " + playerOne.GetPlayerName(name) + "'s choice: " + playerTwo.ChoosePlayerChoice() + " --> " + playerOne.GetPlayerName(name) + " wins.");
            }
            else if (playerOne.ChoosePlayerChoice() == playerTwo.ChoosePlayerChoice())
            {
                Console.WriteLine(playerOne.ChoosePlayerChoice() + " and " + playerTwo.ChoosePlayerChoice() + " but heads. How boring. It's a tie.");
            }
            else
            {
                Console.WriteLine("Congratulations " + playerTwo.ChoosePlayerChoice() + " defeats " + playerOne.ChoosePlayerChoice() + " " + playerOne.GetPlayerName(name) + " has been defeated by " + playerTwo.GetPlayerName(name));
            }
        }
    }
}

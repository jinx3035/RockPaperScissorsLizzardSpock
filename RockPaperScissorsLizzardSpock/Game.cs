using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Game
    {

        public string name;
        public string choice;
        private int numberOfPlayers;
        public string playerOne;
        public string playerTwo;

        public void ChooseOnePlayer(int numberOfPlayers)
        {
            HumanPlayer playerOne = new HumanPlayer();
            playerOne.PlayerChoice();
            ComputerPlayer playerTwo = new ComputerPlayer();
            playerTwo.PlayerChoice();
        }
        public void ChooseTwoPlayers(int numberOfPlayers)
        {
            HumanPlayer playerOne = new HumanPlayer();
            playerOne.PlayerChoice();
            HumanPlayer playerTwo = new HumanPlayer();
            playerTwo.PlayerChoice();
        }



        public virtual string PlayerChoice()
        {
            return ""; 
        }
        public virtual string PlayerName()
        {
            return "";
        }

        public void PlayGame()
        {            
            Console.WriteLine("Is there 'one' or 'two' players?");
            string GameType = Console.ReadLine();

            if(GameType == "one")
            {
                ChooseOnePlayer(numberOfPlayers);
            }

            else if(GameType == "two")
            {
                ChooseTwoPlayers(numberOfPlayers);
            }
            else
            {
                Console.WriteLine("Enter 'one' or 'two'.");
                PlayGame();
            }            
        }

        public void ShowChoices()
        {
            Console.WriteLine("Player one's choice:" + playerOne.PlayerChoice());
            Console.WriteLine("Player two's choice:" + playerTwo.PlayerChoice());
            Console.ReadLine();
            DetermineWinner();
        }


        private void DetermineWinner()
        {
            if ((playerOne.PlayerChoice() == "Paper") && (playerTwo.choice == "Rock") || (playerTwo.choice == "Spock"))
            {
                Console.WriteLine("Congratulations " + playerOne.name + "'s choice: " + playerOne.choice + " defeats " + playerOne.name + "'s choice: "+ playerTwo.choice + " --> " + playerOne.name + " wins.");
            }
            else if ((playerOne.choice == "Rock") && (playerOne.choice == "Scissors") || (playerTwo.choice == "Lizard"))
            {
                Console.WriteLine("Congratulations " + playerOne.name + "'s choice: " + playerOne.choice + " defeats " + playerOne.name + "'s choice: " + playerTwo.choice + " --> " + playerOne.name + " wins.");
            }
            else if ((playerOne.choice == "Scissors") && (playerTwo.choice == "Paper") || (playerTwo.choice == "Lizard"))
            {
                Console.WriteLine("Congratulations " + playerOne.name + "'s choice: " + playerOne.choice + " defeats " + playerOne.name + "'s choice: " + playerTwo.choice + " --> " + playerOne.name + " wins.");
            }
            else if ((playerOne.choice == "Lizard") && (playerTwo.choice == "Paper") || (playerTwo.choice == "Spock"))
            {
                Console.WriteLine("Congratulations " + playerOne.name + "'s choice: " + playerOne.choice + " defeats " + playerOne.name + "'s choice: " + playerTwo.choice + " --> " + playerOne.name + " wins.");
            }
            else if ((playerOne.choice == "Spock") && (playerTwo.choice == "Scissors") || (playerTwo.choice == "Rock"))
            {
                Console.WriteLine("Congratulations " + playerOne.name + "'s choice: " + playerOne.choice + " defeats " + playerOne.name + "'s choice: " + playerTwo.choice + " --> " + playerOne.name + " wins.");
            }
            else if (playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine(playerOne.choice + " and " + playerTwo.choice + " but heads. How boring. It's a tie.");
            }
            else
            {
                Console.WriteLine("Congratulations " + playerTwo.choice + " defeats " + playerOne.choice + " " + playerOne.name + " has been defeated by " + playerTwo.name);
            }
        }
    }
}

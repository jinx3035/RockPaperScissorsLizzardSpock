using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Game
    {
        HumanPlayer playerOne;
        HumanPlayer player2;
        ComputerPlayer playerTwo;
        public string name;
        public string choice;


        public void ChoosePlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                playerOne = new HumanPlayer();
                playerTwo = new ComputerPlayer();
            }
            else
            {
                playerOne = new HumanPlayer();
                player2 = new HumanPlayer();
            }
        }
        public void PlayGame()
        {            
            Console.WriteLine("Is there 'one' or 'two' players?");
            string GameType = Console.ReadLine();

            if(GameType == "one")
            {
                name = playerOne.PlayerName(name);
                choice = playerOne.PlayerChoice();
                choice = playerTwo.AiChoice(); 
            }

            else if(GameType == "two")
            {
                name = playerOne.PlayerName(name);
                name = player2.PlayerName(name);
                choice = playerOne.PlayerChoice();
                choice = player2.PlayerChoice();
            }
            else
            {
                Console.WriteLine("Enter 'one' or 'two'.");
                PlayGame();
            }

            Console.WriteLine("Player one's choice:{0}", playerOne.choice);
            Console.WriteLine("Player two's choice:{0}", playerTwo.choice);
            Console.ReadLine();
            DetermineWinner();            

        }
        private void DetermineWinner()
        {
            if ((playerOne.choice == "Paper") && (playerTwo.choice == "Rock") || (playerTwo.choice == "Spock"))
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

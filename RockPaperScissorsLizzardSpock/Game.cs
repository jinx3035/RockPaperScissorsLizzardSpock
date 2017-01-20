using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Game
    {
        static void Main(string[] args)
        {
            Game start = new Game();
            start.PlayGame();
        }
        public void PlayGame()
        {
            string PlayerOne;
            string PlayerTwo;
             
            Console.WriteLine("Is there 'one' or 'two' players?");
            string GameType = Console.ReadLine();
            if(GameType == "one")
            {
                Player Humanplayer = new Player();
                PlayerOne = Humanplayer.PlayerChoice();
                Player Aiplayer = new Player();
                PlayerTwo = Aiplayer.AiChoice();
            }
            else
            {
                Player Humanplayer1 = new Player();
                PlayerOne = Humanplayer1.PlayerChoice();
                Player Humanplayer2 = new Player();
                PlayerTwo = Humanplayer2.PlayerChoice();
            }

            Console.WriteLine("Your choice:{0}", PlayerOne);
            Console.WriteLine("The computer choice:{0}", PlayerTwo);
            Winner(PlayerOne, PlayerTwo);
            Console.ReadLine();
        }
        private void Winner(string PlayerOne, string PlayerTwo)
        {
            if ((PlayerOne == "Paper") && (PlayerTwo == "Rock") || (PlayerTwo == "Spock"))
            {
                Console.WriteLine("Congratulations " + PlayerOne + " defeats " + PlayerTwo + " Player 1 wins.");
            }
           else if ((PlayerOne == "Rock") && (PlayerTwo == "Scissors") || (PlayerTwo == "Lizard"))
            {
                Console.WriteLine("Congratulations " + PlayerOne + " defeats " + PlayerTwo + " Player 1 wins.");
            }
            else if ((PlayerOne == "Scissors") && (PlayerTwo == "Paper") || (PlayerTwo == "Lizard"))
            {
                Console.WriteLine("Congratulations " + PlayerOne + " defeats " + PlayerTwo + " Player 1 wins.");
            }
            else if ((PlayerOne == "Lizard") && (PlayerTwo == "Paper") || (PlayerTwo == "Spock"))
            {
                Console.WriteLine("Congratulations " + PlayerOne + " defeats " + PlayerTwo + " Player 1 wins.");
            }
            else if ((PlayerOne == "Spock") && (PlayerTwo == "Scissors") || (PlayerTwo == "Rock"))
            {
                Console.WriteLine("Congratulations " +PlayerOne+ " defeats " +PlayerTwo+ " Player 1 wins.");
            }
            else if (PlayerOne == PlayerTwo)
            {
                Console.WriteLine(PlayerOne + " and " +PlayerTwo+ " but heads. How boring. It's a tie.");
            }
            else
            {
                Console.WriteLine("Resistance is futile. " +PlayerTwo+ " defeats " +PlayerOne+ " You have been defeated.");
            }
        }
    }
}

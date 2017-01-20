using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Game
    {
        public void PlayGame()
        {
            string PlayerOne;
            string PlayerTwo;
             
            Console.WriteLine("Is there 'one' or 'two' players?");
            string GameType = Console.ReadLine();
            if(GameType == "one")
            {
                Player Aiplayer = new Player();
                PlayerTwo = Aiplayer.AiChoice();
                Player Humanplayer = new Player();
                PlayerOne = Humanplayer.PlayerChoice();
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
        private void Winner(string PlayerInput, string AiInput)
        {
            if ((PlayerInput == "Paper") && (AiInput == "Rock") || (AiInput == "Spock"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "Rock") && (AiInput == "Scissors") || (AiInput == "Lizard"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "Scissors") && (AiInput == "Paper") || (AiInput == "Lizard"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "Lizard") && (AiInput == "Paper") || (AiInput == "Spock"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            if ((PlayerInput == "Spock") && (AiInput == "Scissors") || (AiInput == "Rock"))
            {
                Console.WriteLine("Congratulations! You have bested artificial intelligence.");
            }
            else if (PlayerInput == AiInput)
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

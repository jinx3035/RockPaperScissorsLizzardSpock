﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class HumanPlayer: Game
    {
        public string choice;
        
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizzardSpock
{
    class Player
    {
        public string name;

        public virtual string GetPlayerName(string name)
        {
            Console.WriteLine("Enter player 2 name:");
            return Console.ReadLine();
           
        }
        public virtual string ChoosePlayerChoice()
        {
            return "";
        }
        public virtual void ShowPlayerName()
        {
            Console.WriteLine("Hello " + GetPlayerName(name));
        }
        public virtual void ShowPlayerChoice()
        {
            Player choice = new Player();
            choice.ChoosePlayerChoice();
        }
    }
}

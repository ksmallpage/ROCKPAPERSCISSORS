using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Human : Player
    {
        // Variables

        
 


        // Constructor
        public Human()
        {

        }


        // Methods
     

        public override void PlayerChoice()
        {
            Console.WriteLine($"{playerName} What is your choice enter: ROCK, PAPER, SCISSORS, LIZZARD or SPOCK");
            playerChoice = Console.ReadLine();
            Console.WriteLine($"{playerChoice }");

        }
    }
}

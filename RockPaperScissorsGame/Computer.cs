using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Computer : Player
    {
        //variables


        //Contructor
        public Computer()
        {

        }


        //Methods



        public override void PlayerChoice()
        {
            // write case
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            if (randomNumber == 1)
            {
                playerChoice = "ROCK";
            }
            else if (randomNumber == 2)
            {
                playerChoice = "PAPER";
            }
            else if (randomNumber == 3)
            {
                playerChoice = "SCISSORS";
            }
            else if (randomNumber == 4)
            {
                playerChoice = "LIZZARD";
            }
            else
            {
                playerChoice = "SPOCK";
            }
           
        }


    }
}

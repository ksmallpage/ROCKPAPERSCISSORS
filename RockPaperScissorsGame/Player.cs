using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    abstract class Player
    {
        // Variables

        public string playerName;
        public string playerChoice;
        public int numberOfWins;
      //  public string player1;
      //  public string player2;

        //Contructor

        public Player()
        {
            numberOfWins = 0;
        }

        // Methods
        

        public abstract void PlayerChoice();
       
            
       


    }
}

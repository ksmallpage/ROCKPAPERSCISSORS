using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
   class Game
    {
        // Variables

        public Player player1;
        public Player player2;
        public string secondHumanPlayerChoice;
        // Constructor
           
        public Game()
        {

           player1 = new Human();
          // player2 = new Computer();

        }

        //Methods

       

        public void TrackWhoseTurn()
        {

        }

        public void CalculateWinnerOfRound()
        {
           // player1.playerChoice = "ROCK";
            //player2.playerChoice = "ROCK";
            // see if player1 one wins
            if (player1.playerChoice == "SCISSORS" && ((player2.playerChoice == "PAPER") || (player2.playerChoice == "LIZZARD")))
            {
                Console.WriteLine($"{player1.playerName} wins");
                player1.numberOfWins++;
            }
            else if (player1.playerChoice == "PAPER" && ((player2.playerChoice == "ROCK") || (player2.playerChoice == "SPOCK")))
            {
                Console.WriteLine($"{player1.playerName} wins");
                player1.numberOfWins++;
            }
            else if (player1.playerChoice == "ROCK" && ((player2.playerChoice == "LIZZARD") || (player2.playerChoice == "SCISSORS")))
            {
                Console.WriteLine($"{player1.playerName} wins");
                player1.numberOfWins++;
            }
            else if (player1.playerChoice == "LIZZARD" && ((player2.playerChoice == "SPOCK") || (player2.playerChoice == "PAPER")))
            {
                Console.WriteLine($"{player1.playerName} wins");
                player1.numberOfWins++;
            }
       
            else if (player1.playerChoice == "SPOCK" && ((player2.playerChoice == "SCISSORS") || (player2.playerChoice == "ROCK")))
            {
                Console.WriteLine($"{player1.playerName} wins the round");
                player1.numberOfWins++;
            }
            else if(player1.playerChoice == player2.playerChoice)
            {
                Console.WriteLine("That round was a DRAW");
            }else
            {
                Console.WriteLine($"{player2.playerName } wins this round");
                player2.numberOfWins++;
            }



        }

        public void DisplayScore()
        {
            Console.WriteLine($"{player1.playerName} has won {player1.numberOfWins}, {player2.playerName} has won {player2.numberOfWins}");
        }

        public void DisplayWinner()
        {

        }

        public void WhoIsPlaying()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizzard Spock" + System.Environment.NewLine);
            Console.WriteLine("Who is player One: Enter your name." + System.Environment.NewLine);
            player1.playerName = Console.ReadLine();
            Console.WriteLine($"{player1.playerName} Are you playing another person or the Computer?\n");
            secondHumanPlayerChoice = Console.ReadLine();
            Console.Clear();
            if(secondHumanPlayerChoice == "Computer")
            {
                player2 = new Computer();
                player2.playerName = "ZORF";
            }
            else
            {
                player2 = new Human();

                 Console.WriteLine("Who is player Two: Enter your name \n");
                player2.playerName = Console.ReadLine();

            }
            Console.WriteLine($"{player1.playerName} is Playing {player2.playerName} the game is the best of three rounds.\n");
            Console.WriteLine("Live Long and Prosper!!");
        }

        public void RunGame()
        {
            WhoIsPlaying();
            while(player1.numberOfWins < 2 && player2.numberOfWins < 2)
            {
                player1.PlayerChoice();
                player2.PlayerChoice();
                CalculateWinnerOfRound();
                DisplayScore();

            }

                 DisplayScore();




        }
                

    
    }
}

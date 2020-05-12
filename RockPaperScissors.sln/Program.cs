using System;
using System.Reflection.Metadata.Ecma335;

namespace RockPaperScissors.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            string[] gameChoice = new string[] { "Rock", "Paper", "Scissors" };
            Random rnd = new Random();
            Console.Write("Hello, how many rounds of Rock Paper Scissors would you like to play? (Minimum: 1; Maximum: 10) ");
            int numberOfRounds = Convert.ToInt32(Console.ReadLine());
                if (numberOfRounds < 1 || numberOfRounds > 10)
                {
                    Console.WriteLine("Error: Number of rounds is outside range.");

                }
                else
                {
                    int tieNumber = 0;
                    int userWinNumber = 0;
                    int computerWinNumber = 0;
                    int roundNumber = 1;

                    while (roundNumber <= numberOfRounds)
                    {
                        Console.Write("Choose: (1 = Rock, 2 = Paper, 3 = Scissors) ");
                        int userIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                        int cIndex = rnd.Next(gameChoice.Length);
                        bool userWin = (userIndex == 0 && cIndex == 2) || (userIndex == 1 && cIndex == 0) || (userIndex == 2 && cIndex == 1);
                        bool computerWin = (userIndex == 0 && cIndex == 1) || (userIndex == 1 && cIndex == 2) || (userIndex == 2 && cIndex == 0);

                        Console.WriteLine($"You chose {gameChoice[userIndex]} and the computer chose {gameChoice[cIndex]}");

                        if (userIndex == cIndex)
                        {
                            Console.WriteLine("This round is a tie");
                            tieNumber++;
                            roundNumber++;
                        }
                        else if (userWin)
                        {
                            Console.WriteLine("You win this round!");
                            userWinNumber++;
                            roundNumber++;
                        }
                        else if (computerWin)
                        {
                            Console.WriteLine("Computer Wins this round.");
                            computerWinNumber++;
                            roundNumber++;
                        }
                    }
                    Console.WriteLine($"Number of Rounds You Won: {userWinNumber}  \nNumber of Rounds Computer Won: {computerWinNumber} rounds \nNumber of ties: {tieNumber}");
                    if (userWinNumber > computerWinNumber)
                    {
                        Console.WriteLine("Congrats are the winner!");
                    }
                    else if (computerWinNumber > userWinNumber)
                    {
                        Console.WriteLine("The computer is the winner!");
                    }
                    else
                    {
                        Console.WriteLine("This game was a tie");
                    }
                    Console.Write("Would you like to play again? (y/n) ");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower().Equals("y"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        break;
                    }
                }
            }
        }
    }
}

using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string compChoice = "", playerChoice = "";
            int compScore = 0, playerScore = 0;
            bool c = true;

            do
            {
                Console.WriteLine("Rock–Paper–Scissors? (r/p/s)");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'r':
                        playerChoice = "rock";
                        break;
                    case 'p':
                        playerChoice = "paper";
                        break;
                    case 's':
                        playerChoice = "scissors";
                        break;
                }

                switch (r.Next(0, 3))
                {
                    case 0:
                        compChoice = "rock";
                        break;
                    case 1:
                        compChoice = "paper";
                        break;
                    case 2:
                        compChoice = "scissors";
                        break;
                }

                if ((playerChoice == "rock" && compChoice == "paper")
                    ||
                    (playerChoice == "paper" && compChoice == "scissors")
                    ||
                    (playerChoice == "scissors" && compChoice == "rock"))
                {
                    Console.WriteLine("You lost! The result:\nComputer: {0}\nPlayer:{1}",
                    ++compScore, playerScore);
                }
                else if (playerChoice == compChoice)
                {
                    Console.WriteLine("Draw! The result:\nComputer: {0}\nPlayer:{1}",
                    compScore, playerScore);
                }
                else
                {
                    Console.WriteLine("You won! The result\nComputer: {0}\nPlayer:{1}",
                    compScore, ++playerScore);
                }

                Console.WriteLine("Do you want to play again? y/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                    c = false;

                Console.WriteLine();

            } while (c);

            Console.ReadKey();
        }   
    }
}

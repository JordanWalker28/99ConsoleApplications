using System;

namespace HigherOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
            Console.WriteLine("Thank you for playing");
        }

        private static void playGame()
        {
            bool flag = true;

            while (flag)
            {
                Random rnd = new Random();
                int gameNumber = rnd.Next(1, 100);
                mainGameLoop(gameNumber);
                Console.WriteLine("Do you want to play again? y/n");
                flag = continueGame();
                if (flag)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        private static bool continueGame()
        {
            string choice = Console.ReadLine();
            bool result = true;
            choice = choice.ToLower();
            Console.WriteLine("Speak priest!");
            if (choice == "y")
            {
                return true;
            }
            else if (choice == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("only values y/n apply here");
                continueGame();
            }
         

            return result;
        }

        private static void mainGameLoop(int gameNumber)
        {
            Console.WriteLine(gameNumber);
            int playerChoice = -1;
            int computerChoice = -1;
            while (playerChoice != gameNumber || computerChoice != gameNumber)
            {
                string guess = Console.ReadLine();
                playerChoice = Convert.ToInt32(guess);
                Console.WriteLine(playerChoice);

            }
        }

    }
}

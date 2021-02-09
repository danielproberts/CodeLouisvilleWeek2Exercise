using System;

namespace CodeLouisvilleWeek2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameState = true;
            string playAgain;
            do
            {
                Random randNum = new Random();
                int guess;
                string playerGuess;
                int numToGuess;
                //Generate Random Number between 1 and 100 and set to numToGuess
                Console.WriteLine("I have selected a random number between 1 and 100. See if you can guess what it is!");
                Console.WriteLine(numToGuess);
                Console.Write("Please enter a guess: ");
                //Get player input from keyboard and set to playerGuess
                int.TryParse(playerGuess, out guess); //IMPORTANT

                while (gameState)
                {
                    if (guess == numToGuess)
                    {
                        Console.WriteLine("You guessed correctly!!!");
                        Console.WriteLine("Do you want to play again?");
                        Console.WriteLine("Enter y/n");
                        //Get player input and set to playAgain
                        if (playAgain == "y")
                        {
                            //Break the inner loop and continue with a new game
                        }
                        else if (playAgain == "n")
                        {
                            //Set gameState to a value that will break the loop and end the game
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Starting a new game...");
                        }
                    }

                    else if (guess < numToGuess)
                    {
                        Console.WriteLine("Your guess is too low!");
                        Console.Write("Please enter a guess: ");
                        //Get player input from keyboard and set to playerGuess
                        int.TryParse(playerGuess, out guess);
                    }

                    else if (guess > numToGuess)
                    {
                        Console.WriteLine("Your guess is too high!");
                        Console.Write("Please enter a guess: ");
                        //Get player input from keyboard and set to playerGuess
                        int.TryParse(playerGuess, out guess);
                    }

                }
            } while (gameState);

            Console.WriteLine("Thanks for playing! Press any key to close this window...");
            Console.ReadKey();
        }
    }
}

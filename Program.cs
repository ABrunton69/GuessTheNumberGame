using System.Reflection.PortableExecutable;

namespace GuessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initiate random number generator
            Random rnd = new Random();

            // Generate a random number
            int randomNumber = rnd.Next(101);

            // Users current guess
            int userGuess = -1;

            // Users guesses left
            int guessesLeft = 20;
            
            // Set a variable for a correct guess
            Boolean correctNumber = false;

            do
            {
                
                // Take a number from the user
                Console.Write("Enter a number: ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                // Compare the numbers
                if (userGuess != randomNumber)
                {
                    if ((guessesLeft - 1) < 1)
                    {
                        Console.WriteLine("Incorrect! You lose!");
                        break;
                    }
                    Console.WriteLine($"Incorrect {guessesLeft-1} guesses left!");
                    Console.WriteLine(GetHint(randomNumber, userGuess));
                    guessesLeft--;
                } else
                {
                    correctNumber = true;
                    Console.WriteLine($"Congratulations! you guessed the correct number - {randomNumber}");
                }
            } while (correctNumber != true);
        }
        public static string GetHint(int gameNumber, int guessedNumber)
        {
            if (gameNumber > guessedNumber)
            {
                return "Go Higher!";
            } 
            return "Go Lower!";
        }
    }

    
}

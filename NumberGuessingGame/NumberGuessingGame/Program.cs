namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game v1.0\n\n");
            bool again = true;

            while (again)
            {
                int guessCount = 1;
                Random r = new Random();
                int randomNumber = r.Next(1, 101);
                Console.WriteLine("Guess a number between 1 and 100!");
                int guess = int.Parse(Console.ReadLine());

                while (guess != randomNumber)
                {

                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Lower!");
                    }

                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Higher!");
                    }

                    guess = int.Parse(Console.ReadLine());
                    guessCount++;
                }

                Console.WriteLine($"You guessed it right! You have guessed {guessCount} times.");
                Console.WriteLine("Do you want to play again? (Y/N)");
                string answer = Console.ReadLine().ToUpper();

                while (answer[0] != 'Y' && answer[0] != 'N')
                {
                    Console.WriteLine("Do you want to play again? (Y/N)");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer[0] == 'N')
                {
                    again = false;
                }

                Console.Clear();

                if (again)
                {
                    Console.WriteLine("Number Guessing Game v1.0\n\n");
                }

            }
            Console.WriteLine("Thanks for playing with me!");
            Console.WriteLine("Press a button to exit");
            Console.ReadKey();

        }
    }
}
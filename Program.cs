using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string userName;
        string userInput;
        string userGuess;
        int score = 0;
        int numberOfFlips;
        Random coinFlip = new Random();
        int result = coinFlip.Next();

        Console.WriteLine("Welcome to the coin flip challange.");
        Console.WriteLine("What is your name?");
        userName = Console.ReadLine();
        Console.WriteLine($"Welcome {userName}. Do you want to do the Coin Flip Challange? yes/no");
        userInput = Console.ReadLine();
        if (userInput == "yes")
        {
            for (numberOfFlips = 0; numberOfFlips < 5; numberOfFlips++)
            {
                coinFlip = new Random();
                result = coinFlip.Next(0, 2);
                Console.WriteLine("heads or tails ?");
                userGuess = Console.ReadLine();
                if (userGuess == "heads" && result == 0)
                {
                    Console.WriteLine("Hell Yeah!");
                    score++;
                }
                else if (userGuess == "heads" && result == 1)
                {
                    Console.WriteLine("Hell Nah!");
                }
                else if (userGuess == "tails" && result == 1)
                {
                    Console.WriteLine("Hell Yeah!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Hell Nah");
                }

            }

            Console.WriteLine($"Thank you for playing {userName}. You got a score of {score}!");
        }
        else
        {
            Console.WriteLine($"You are a coward {userName}.");
        }


    }
}
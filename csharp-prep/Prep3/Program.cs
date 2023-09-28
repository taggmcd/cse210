using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        int guess = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        while (play == "yes" || play == "y" || play == "Y")
        {
            while (true)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed the correct number!");
                    break;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Too low");
                }
            }
            Console.WriteLine("Would you like to play again? (Yes/No): ");
            play = Console.ReadLine();
        }
    }
}
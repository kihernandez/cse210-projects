using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int userGuess = -1;


        while (userGuess != magicNumber)
        {
            Console.Write("What is your number guess? ");
            userGuess = int.Parse(Console.ReadLine());
            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
    
    
}
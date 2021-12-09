using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = 7;
            int guessCount = 0;
            Console.Write("Guess The Secret Number - ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != targetNumber)
            {
                Console.Write("Guess The Secret Number - ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;
            }

            Console.WriteLine("You Got It!");
            Console.WriteLine("Attempts - " + guessCount);
        }
    }
}
using System;

namespace w5_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Random random = new Random();
            int number = random.Next(0, 100);
            int loop = 0;
            int guess;
            Console.WriteLine("AHOY! I'm the Dread Pirate Roberts, and I have a secret! It is a number from 1 to 99. I'll give you 6 tries.");
            do
            {
                Console.Write("What's Your Guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess != number & loop++ == 5)
                {
                    Console.WriteLine("No more Guess! Better luck next time");
                    break;
                }
                else if (guess == number)
                {
                    Console.WriteLine("You got it!!!");
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low!");
                }
                
            } while (true);
        }
    }
}

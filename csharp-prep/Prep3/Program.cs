using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the madgic number? ");
        // int madgicNumber = int.Parse(Console.ReadLine()):

        Random randomGenerator = new Random();
        int madgicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != madgicNumber) {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (madgicNumber > guess){
                Console.WriteLine("Higher");
            }
            else if (madgicNumber < guess){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
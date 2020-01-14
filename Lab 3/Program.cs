using System;

namespace Lab_3
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("What is your number?");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess % 2 != 0){
                Console.WriteLine(guess + " Odd.");
            }
            else if (guess % 2 == 0 && guess >= 2 && guess <= 25)
            {
                Console.WriteLine("Even and less than 25.");
            }
            else if (guess % 2 == 0 && guess >= 26 && guess <= 60)
            {
                Console.WriteLine("Even.");
            }
            else if (guess % 2 == 0 && guess > 60)
            {
                Console.WriteLine(guess + " Even.");
            }
        }
    }
}

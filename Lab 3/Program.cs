using System;

namespace Lab_3
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            int guess = 0;
            string output = "";

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("What is your number? Please choose between 1 and 100");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                output = "";
            }
            if (guess % 2 != 0){
                output = guess.ToString() + " odd.";
            }
            else if (guess % 2 == 0 && guess >= 2 && guess <= 25)
            {
                output = "even and less than 25.";
            }
            else if (guess % 2 == 0 && guess >= 26 && guess <= 60)
            {
                output = guess.ToString() + " and even.";
            }
            else if (guess % 2 == 0 && guess > 60)
            {
                output = "even.";
            }

            Console.WriteLine(name + ", Your number is " + output);
        }
    }
}

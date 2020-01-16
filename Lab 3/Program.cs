using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial user input and variable declaration
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            int guess;
            string output;

            //user input for numbers and converting from a string to int
            Console.WriteLine("What is your number? Please choose between 1 and 100.");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            //input validation for number
            while (guess < 1 || guess > 100)
            {
                Console.WriteLine("Please input a valid number. Please choose between 1 and 100.");
                input = Console.ReadLine();
                guess = int.Parse(input);
            }

            //checking the number against test conditions
            if (guess % 2 == 0 && guess >= 2 && guess <= 25)
            {
                output = "even and less than 25.";
            }
            else if (guess % 2 == 0 && guess >= 26 && guess <= 60)
            {
                output = "even.";
            }
            else if (guess % 2 == 0 && guess > 60)
            {
                output = guess.ToString() + " and even.";
            }
            else
            {
                output = guess.ToString() + " and odd.";
            }

            //final output for number
            Console.WriteLine(name + ", Your number is " + output);

            //ending program successfully
            Environment.Exit(1);
        }
    }
}

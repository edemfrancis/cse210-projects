using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // Get hold of a Random number and print it on the terminal
        Random magicNumber = new Random();
        int secretnumber = magicNumber.Next(1, 100);
        Console.WriteLine($"Magic number is {secretnumber}");

        int guessed = 0;
        //Get hold of the Guess num by setting it to 0
        int numberOfGuesses = 0;
        // do while loop
        do
        {
            Console.WriteLine("Guess a number");
            string guess = Console.ReadLine();
            guessed = int.Parse(guess);
            // get hold of num of times guess is made by add +1
            // after the asking the user for guess.
            numberOfGuesses += 1;

            if (guessed > secretnumber) {

                Console.WriteLine("Higher");
                Console.WriteLine("Wrong choice, Guess again");
            }
            else if (guessed == secretnumber){
                Console.WriteLine("Got it!! Guessed Right");
                Console.WriteLine($"NUmber of Guesses {numberOfGuesses}");
            }
            else{
                Console.WriteLine("Lower");
                Console.WriteLine("Wrong choice, Guess again");
            }

        } while (guessed != secretnumber);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void FirstProgram(){
            Console.WriteLine("Welcome to the program");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your favourite Number:");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            Console.WriteLine($"{name}, The square of your favorite number is {num * num}");

        }
        FirstProgram();
    }
}
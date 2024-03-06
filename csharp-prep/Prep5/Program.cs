using System;
using program;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        // static void FirstProgram(){
        //     Console.WriteLine("Welcome to the program");
        //     Console.Write("Please enter your name: ");
        //     string name = Console.ReadLine();
        //     Console.Write("Please enter your favourite Number:");
        //     string number = Console.ReadLine();
        //     int num = int.Parse(number);
        //     Console.WriteLine($"{name}, The square of your favorite number is {num * num}");

        // }
        // FirstProgram();

       Assignment mathematic = new Assignment();
       mathematic.SetStudentName("Mary Waters");
       mathematic.SetTopic("European History");
       Console.WriteLine(mathematic.GetSummary());

       MathAssignment textbook = new MathAssignment();
       
       textbook.SetTextbook("7.3");
       textbook.SetProblems("8-19");
       Console.WriteLine(textbook.GetMathSummary());

       WrittingAssignment historybook = new WrittingAssignment();
       historybook.SetHistory("World war II");


        Console.WriteLine($"{historybook.GetWrittingHistory()} {mathematic.GetstudentName()}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What your grade percentage%");
        string grade = Console.ReadLine();

        int grade1 = int.Parse(grade);

        if (grade1 >= 90){
            Console.WriteLine("Congratulations you are A student");
        }
        else if (grade1 >= 80) {
            Console.WriteLine("Congratulations, You are on B");
        }

        else if (grade1 >= 70) {
            Console.WriteLine("Your score is C");
        }

        else if (grade1 >= 60) {
            Console.WriteLine("Conratulations, You on D");
        }

        else {
            Console.WriteLine("You are on F, and you will fail, if you dont improve");
        }
    }
}
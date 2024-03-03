using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Prep4 World!");


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = 1;
        List<int> nums = new List<int>();

        int total = 0;
        int average = 0;
        int largest = 0;


        while (number != 0){
            Console.WriteLine("Enter Number:");
            string numbers = Console.ReadLine();
            if (number != 0){
                number = int.Parse(numbers);
                nums.Add(number);
            }
            else{
                Console.WriteLine("Wrong input, type in the correct input!!");
            }
            
        }
        foreach (int num in nums){
                total += num;
                average = total / nums.Count;
                if (largest < num){
                    largest = num;
                }
                }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The average is: {largest}");
    }
}
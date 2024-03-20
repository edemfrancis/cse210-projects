using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {        
        Console.WriteLine("Hello Develop03 World!");

        Reference newReference = new("Mathew", 4, 1, 3);
        
        Word newWord = new("Mathew");

        Scripture newScript = new(newReference, "Then was Jesus aled up of the Spirit into the wilderness to be tempted of the devil. And when he had fasted forty days and forty nights, he was afterward an hungred.And when the tempter came to him, he said, If thou be the Son of God, command that these stones be made bread.");

        Console.WriteLine($"{newReference.GetDisplayText()} {newScript.GetDisplayText()}");
        
        string exit = "";
        int newCount = newScript.WordCount;
        bool exit1 = Console.ReadKey().Key == ConsoleKey.Enter;
        Console.WriteLine(newScript.GetDisplayText());
        while (exit != "quit"){
            if (exit1){
                newScript.HideRandomWords(newCount - 5);
                newWord.Hide();
                                
                Console.Clear();
                Console.WriteLine($"{newReference.GetDisplayText()} {newScript.GetDisplayText()}" );
                Console.WriteLine("Press Enter to continue or type quit to exit");
                exit = Console.ReadLine();
                if (newScript.isCompletelyHidden() == true){
                    exit = "quit";
                }
            }
            else if (exit == "start"){
                exit = "quit";
            }

            else {
                Console.WriteLine("Wroong entry");
                Console.WriteLine("Press Enter to continue or type quit to exit");

            }
            
            
        }
        // while (Console.ReadKey().Key == ConsoleKey.Enter){
        //     Console.WriteLine("Hello Develop03 World!");
        //     Reference reference = new Reference("John", 3, 16, 18);

        //     // Create a scripture
        //     string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        //     Scripture scripture = new Scripture(reference, text);

        //     // Display the scripture
        //     Console.WriteLine("Original Scripture:");
        //     Console.WriteLine(scripture.GetDisplayText());

        //     // Hide random words
        //     scripture.HideRandomWords(5);

        //     // Display the scripture with hidden words
        //     Console.WriteLine("\nScripture with Hidden Words:");
        //     Console.WriteLine(scripture.GetDisplayText());

        //     // Check if all words are completely hidden
        //     Console.WriteLine("\nAll words hidden? " + (scripture.isCompletelyHidden() ? "Yes" : "No"));
            

        // }
    }
}
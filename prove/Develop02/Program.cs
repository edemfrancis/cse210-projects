using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop02 World!");
        string[] menuList = { "Add Things to Journal", "Display journal", "SaveToFile", "LoadFromFile", "Quit" };
        string nothing = "";
        int notEqualTo = 0;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Journal newJournal = new();
        Entry newEntry = new();


        while (notEqualTo != 5){
            Console.WriteLine("Write on Your Journal from the following->");
            for (int i = 0; i < menuList.Length; i++)
            {
            nothing = menuList[i];
            Console.WriteLine($"{i + 1} - {nothing}");
            }  
            string StringEnt = Console.ReadLine();
            notEqualTo = int.Parse(StringEnt);
            Console.WriteLine();
            

            if (notEqualTo == 1){
                PromptMe promptme = new();
                    
                string OneTimeCatch = promptme.GetRandomPromptText();
                Console.WriteLine($"{OneTimeCatch}");

                string UserEnters = Console.ReadLine();
                Console.WriteLine("");

                newEntry._date = dateText;
                newEntry._promptText = OneTimeCatch;
                newEntry._UserEntryText = UserEnters;
                Journal journal = new();
                Console.WriteLine();
                newJournal._entries.Add(newEntry);
                newEntry.Display();
            }

            else if (notEqualTo == 2){
                newJournal.Display();
            }

            else if (notEqualTo == 3){
            Console.Write("Enter a file name in .txt or .csv: ");
            Journal newValue = new();
            Entry enter = new();
            enter.Display();
            string filname = Console.ReadLine();

            newJournal.SaveToFile(filname);
            }
            else if (notEqualTo == 4){
                Console.WriteLine("Enter file name in that has being save in .txt or .csv");
                string filename = Console.ReadLine();
                newJournal.LoadFromFile(filename);
            }

        }
              
        // enter.Date = dateText;
        // enter.UserEntryText = "fuck you";
        // enter.PromptText = "What the fuck";
        // enter.Display();
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {

                //     for (int i = 5; i > 0; i--){
                //     Console.Write("i");
                //     Thread.Sleep(1000);
                //     Console.Write("\b \b");
                // }
        
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Loading....");
        Console.WriteLine("Please be Patient");
        for (int i = 5; i > 0; i--){
            Console.Write("...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
            
        Console.WriteLine("Welcome to:");
        string[] menuList = { "Breathing Activity", "Reflecting Activity", "Listing Activity", "Quit" };
        string nothing = "";
        int notEqualTo = 0;
        while (notEqualTo != 4){
            Console.WriteLine("Mindfulness Program");

            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menuList.Length; i++)
            {
            nothing = menuList[i];
            Console.WriteLine($"{i + 1} - {nothing}");
            } 
            Console.Write("Select a Number from the menu to start to execute the Activity -> ");
            string enter = Console.ReadLine();
            notEqualTo = int.Parse(enter);

            if (notEqualTo == 1){
                BreathingActivity newBreathing = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                newBreathing.DisplayBreathingWelcomeMessage();
                Console.WriteLine("");
                newBreathing.Run();
                Console.WriteLine("");
                Console.Write("How long, in second would you like for your session? > ");
                // converting a string to an integer
                string stringNum = Console.ReadLine();
                int intNum = int.Parse(stringNum);
                double num2 = intNum / 4;
                int roundNumber = (int)Math.Round(num2, 0);

                BreathingActivity newBreathing1 = new(intNum);
                Console.Clear();
                Console.Write("Getting ready...");
                newBreathing1.DisplayBreathingInAndOut(roundNumber);
                Console.WriteLine("");
                Console.WriteLine("");

                
                for (int i = 4; i > 0; i--){
                    Console.Write("breath in.....");
                    newBreathing1.DisplayBreathingInAndOut(roundNumber);
                    Console.WriteLine("");
                    Console.Write("Now Breath Out.....");
                    newBreathing1.DisplayBreathingInAndOut(roundNumber);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                BreathingActivity newBreathing3 = new("Breathing Activity", intNum);
                newBreathing3.DisplayEndingMessage();
                newBreathing3.DisplayBreathingInAndOut(roundNumber);
                Console.Clear();


            }

            else if (notEqualTo == 2){
                Console.Clear();
                ReflectActivity newReflex = new("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                newReflex.DisplayReflectingWelcomeMessage();
                Console.WriteLine("");
                newReflex.DisplayStartingMessage();
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like to take for this session? -> ");
                string stringNum = Console.ReadLine();
                int intNum = int.Parse(stringNum);
                ReflectActivity newFlex1 = new(intNum);
                double num2 = intNum / 4;
                int roundNumber = (int)Math.Round(num2, 0);

                Console.Clear();
                Console.WriteLine("Get Ready...");
                for (int i = 6; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("Consider the Following prompt:");
                ReflectActivity newReflect2 = new();
                Console.Write("---- "); newReflect2.DisplayPrompt();  Console.WriteLine("");
                Console.WriteLine("When You have something in mind, press Enter to continue.");
                bool Bool = Console.ReadKey().Key == ConsoleKey.Enter;
                Console.WriteLine("");
                string e = newReflect2.GetRandomQuestion();
                Console.WriteLine("Now ponder on each of the following question as they are related to this experience.");
                Console.Write("You may begin>> ");
                for (int i = 7; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.Clear();
                string e1 = "";
                if (e == newReflect2.GetRandomQuestion()){
                    Console.Write("> ");
                     e1 = newReflect2.GetRandomQuestion();
                    newReflect2.DisplayQuestion();
                    newFlex1.ShowSpinner();
                    }
                else{
                        Console.Write("> ");
                        newReflect2.DisplayQuestion();
                        newFlex1.ShowSpinner();
                    }
                    for (int i = 7; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                    if (e1 == newReflect2.GetRandomQuestion()){
                    Console.Write("> ");
                    e1 = newReflect2.GetRandomQuestion();
                    newReflect2.DisplayQuestion();
                    newFlex1.ShowSpinner();
                    }
                else{
                        Console.Write("> ");
                        newReflect2.DisplayQuestion();
                        newFlex1.ShowSpinner();
                    }

                    Console.WriteLine("Well done..");
                    Console.WriteLine("");
                    Console.WriteLine("Congratulation");
                    Console.WriteLine("You have completed another 30 seconds of the Reflecting Activity");
                    newFlex1.ShowSpinner();

            }

            else if (notEqualTo == 3){
                Console.Clear();
                ListActivity newActivity1 = new();
                ListActivity newActivity = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                newActivity.DisplayListActivityWelcomeMessage();
                Console.WriteLine("");
                newActivity.DisplayStartingMessage();
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like to take this session -> ");
                string stringNum = Console.ReadLine();
                int intNum = int.Parse(stringNum);
                ListActivity newActivty2 = new(intNum);
                Console.Clear();
                Console.WriteLine("Getting Ready...");
                newActivty2.ShowSpinner();
                Console.WriteLine("");
                newActivity1.GetRandomPrompt();
                Console.WriteLine("");
                Console.Write("You may begin>> ");
                for (int i = 5; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("");
                Console.Write("What are the 'Number' of thing you want to write:> ");
                string userNum = Console.ReadLine();
                int num = int.Parse(userNum);
                
                List<string> noOfInput = new();

                for (int i = 0; i < num; i++){
                    Console.Write("> ");
                    string inputFromUser = Console.ReadLine();
                    noOfInput.Add(inputFromUser);
                }
                Console.WriteLine($"You have just listed {noOfInput.Count}");
                Console.WriteLine("");
                Console.WriteLine("Well done");
                
                for (int i = 7; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("");

                Console.WriteLine($"You have completed another {intNum} of the listing Activity");
                for (int i = 7; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.Clear();

            }
            
        }
        
        
    }
}
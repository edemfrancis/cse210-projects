using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(){
        _name = "Annonymous";
        _description = "Unkown";
        _duration = 0;
    }

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    public Activity(string name, int time){
        _name = name;
        _duration = time;
    }
    public Activity(int time){
        _duration = time;
    }

    public string GetProperties(){
        return _name;
    }
    public void SetProperties(string name){
        _name = name;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("Well Done");
        Console.WriteLine("");
        Console.WriteLine($"You have completead {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(){
        List<string> rotation = new();
        rotation.Add("|");
        rotation.Add("\\");
        rotation.Add("--");
        rotation.Add("/");
        rotation.Add("|");
        rotation.Add("\\");
        rotation.Add("--");
        rotation.Add("/");
        rotation.Add("|");
        rotation.Add("\\");
        DateTime startTime = DateTime.UtcNow;
        DateTime endTime = startTime.AddSeconds(_duration);

        int x = 0;
        
        while (DateTime.UtcNow < endTime){
            string i = rotation[x];
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");

            x++;

            if (x >= rotation.Count){
                x = 0;
            }
        }
        // foreach (string x in rotation){
        //     Console.Write(x);
        //     Thread.Sleep(600);
        //     // Console.Write("\b\b\b   \b\b\b");
        // }

    }

    public void ShowCountDown(){
        for (int i = _duration; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }


}
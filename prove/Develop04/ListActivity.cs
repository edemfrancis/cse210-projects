using System.Collections.Generic;
public class ListActivity : Activity{
    private int _count;
    private List<string> _prompt = new();

    public ListActivity(){
        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that you have helped this week?");
        _prompt.Add("Who are some of your personal heroes?");
        _prompt.Add("When have you felt the Holy Ghost this month?");
    }

    public void SetPrompt(string name){
        _prompt.Add(name);
    }

    public ListActivity(string name, string description) : base(name, description){}

    public ListActivity(int time) : base(time){}
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next( _prompt.Count - 1); // Generate a random index within the range of _prompt list
        string randomPrompt = _prompt[index];
        Console.WriteLine(randomPrompt);

    }

    public void DisplayListActivityWelcomeMessage(){
        string display = $"Welcome to {GetProperties()}";
        Console.WriteLine(display);
    }


    // public string GetListFromTheUser(List<string> list){
        
    // }
}
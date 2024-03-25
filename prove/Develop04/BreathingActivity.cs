public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description) : base(name, description){
    }

    public BreathingActivity(int time) : base(time){
    }

    public BreathingActivity(string name, int time) : base(name, time){}

    public void DisplayBreathingWelcomeMessage(){
        string display = $"Welcome to {GetProperties()}";
        Console.WriteLine(display);
    }

    public void Run(){
        DisplayStartingMessage();
    }

    public void DisplayBreathingInAndOut(int num){
        
        for (int i = num; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
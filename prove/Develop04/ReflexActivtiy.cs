public class ReflectActivity : Activity {
    private List<string> _prompts = new();
    private List<string> _question = new();

    public ReflectActivity(string name, string description) : base(name, description){
    }
    public ReflectActivity(int time) : base(time){
    }

    public ReflectActivity(){
        _prompts.Add("Think of a time when you stood up for someone else."); 
        _prompts.Add("Think of a time when you did something really difficult."); 
        _prompts.Add("Think of a time when you helped someone in need"); 
        _prompts.Add("Think of a time when you did something truly selfless");
        _question.Add("Why was this experience meaningful to you?");
        _question.Add("How did you feel when it was complete?");
        _question.Add("How did you get started?");
        _prompts.Add("Think of the beautiful moment You have had so far."); 
        _question.Add("Have you ever done anything like this before?");
        _question.Add("What made this time different than other times when you were not as successful?");
        _question.Add("What is your favorite thing about this experience?"); 
        _question.Add("What could you learn from this experience that applies to other situations?");
        _question.Add("What did you learn about yourself through this experience?"); 
        _question.Add("How can you keep this experience in mind in the future?");
    }

    public void DisplayReflectingWelcomeMessage(){
        string display = $"Welcome to {GetProperties()}";
        Console.WriteLine(display);
    }

    public void Run(){

    }

    

    public string GetRandomPrompt()
    {
        Random random = new();
        int index = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
    
     public string GetRandomQuestion()
    {
        Random random = new();
        int index = random.Next(0, _question.Count);
        string randomPrompt = _question[index];
        return randomPrompt;
    }

    public void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion(){
        Console.WriteLine(GetRandomQuestion());
    }

}
public class Entry{    
    public string _date = "";
    public string _promptText = "";
    public string _UserEntryText = "";
    public int _Userinput;


    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt Text: {_promptText}");
        Console.WriteLine($"Entry Text:  {_UserEntryText}" );
        Console.WriteLine();
    }
}
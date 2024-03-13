using System.Collections.Generic;
using System.IO;
public class Journal
{

    public List<Entry> _entries = new();

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void SetEntriesSummary(){

    }

    public void AddEntry(Entry newEntry){
        
    }
    public void Display(){
        foreach (var entry in _entries){
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new(file))
        {
            foreach (Entry entry in _entries)
            {
                if (entry != null){
                outputFile.WriteLine("Date: " + entry._date);
                outputFile.WriteLine("Prompt Text: " + entry._promptText);
                outputFile.WriteLine("Entry Text: " + entry._UserEntryText);
                outputFile.WriteLine(); // Separate entries with an empty line
                }

            }
        }
    }
    public void LoadFromFile(string file){
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines){
        string[] parts = line.Split(", ");
        Entry entry = new();
        foreach (string part in parts)
            {
                if (part.StartsWith("Date: "))
                    {
                        string date = part[6..];
                        entry._date = date;
                    }
                else if (part.StartsWith("Prompt Text: "))
                    {
                        string promptText = part[13..];
                        entry._promptText = promptText;
                    }
                else if (part.StartsWith("Entry Text: "))
                    {
                        string entryText = part[11..];
                        entry._UserEntryText = entryText;
                    }
                 _entries.Add(entry);
                Display();
            }
        // if (parts.Length >= 3)
        //     {
        //         string date = parts[0][6..]; // Remove "Date: "
        //         string promptText = parts[1][13..]; // Remove "Prompt Text: "
        //         string entryText = parts[2][11..]; // Remove "Entry Text: "
        //         entry._date = date;
        //         entry._promptText = promptText;
        //         entry._UserEntryText = entryText;
        //         _entries.Add(entry);
        //         Display();   
        //     }
            

        }
    }
}

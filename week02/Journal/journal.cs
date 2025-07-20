using System.Collections.Generic;
using System.IO;

public class Journal
{

    public List<Entry> entries = new List<Entry>();
    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date} ");
            Console.WriteLine($"Question: {entry.Question} ");
            Console.WriteLine($"Answer: {entry.Answer} ");
            Console.WriteLine("");
        }

    }

    public List<Entry> GetEntries()
    {
        return entries;
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void SaveToFile(string myJournal)
    {
        using (StreamWriter outputFile = new StreamWriter(myJournal))
        {
            foreach (Entry entry in entries)
            {
                string line = $"{entry.Date}|{entry.Question}|{entry.Answer}";
                outputFile.WriteLine(line);
            }
        }
    }

    //Method to load the journal: when this is called it allow the user to write in the same journal without clear the last text, read the last text and work with it.
    //if the journal is not loaded when the user wants to work on it the last text will disapear.
    public void LoadFromFile(string myJournal)
    {

        string[] lines = File.ReadAllLines(myJournal);
        foreach (string line in lines)
        {
            Entry newEntry = Entry.ParseFromFile(line);
            entries.Add(newEntry);
        }
    }

}



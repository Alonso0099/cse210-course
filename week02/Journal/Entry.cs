
public class Entry
{
    public string Date { get; }
    public string Question { get; }
    public string Answer { get; }

    //constructor that initialize the new entry object.
    public Entry(string date, string question, string answer)
    {

        this.Date = date;
        this.Question = question;
        this.Answer = answer;
    }
    public static Entry ParseFromFile(string line)
    {
        string[] parts = line.Split("|"); //divide the parts using "|".
        return new Entry(parts[0], parts[1], parts[2]);
    }

    //return the line with the specific information.
    public string FormatForFile()
    {
        return $"{Date}|{Question}|{Answer}";
    }
}
using System.IO;

public static class ScriptureLoader
{
    public static List<Scripture> LoadFromFile(string ScripturesLoad)
    {
        var scriptures = new List<Scripture>();

        foreach (var line in File.ReadAllLines(ScripturesLoad))
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                var reference = new Reference(parts[0]);
                var scripture = new Scripture(reference, parts[1]);
                scriptures.Add(scripture);
            }
        }

        return scriptures;
    }
}

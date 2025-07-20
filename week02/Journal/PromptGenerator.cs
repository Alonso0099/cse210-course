//This class povide random prompts to give ideas to the user and encourage daily reflection.
public class PromptGenerator
{
    public List<string> prompts;
    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "What blessings am I grateful for today, and why?",
            "What things could I have done better today and improve tomorrow?",
            "Did any important event happen today?",
            "Was I kind with someone today?",
            "What is something that I can feel proud today?",
            "Did  I improve in something today? how it happened",
            "What's one thing I learned today? (skill, word, insight)",
            "Did I give my best today in my job, family, school? How do I know"
        };
    }
    //Random method, return random prompts from the list (prompts).
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
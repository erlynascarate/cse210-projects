public class PromptGenerator
{
    public string[]  _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What would you say to your past self (your self from a week ago)?",
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(1,_prompts.Count());
        
        string prompt = _prompts[index];
        return prompt;
    }
}
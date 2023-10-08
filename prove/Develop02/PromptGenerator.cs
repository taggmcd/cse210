using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public string _prompt;
    public PromptGenerator()
    {
        var _prompts = new List<string> { "What was something beautiful that was witnessed today?",
         "What was the best thing that happened today?",
         "What was the worst thing that happened today?",
         "What was the most challenging thing I faced today?",
         "What am I grateful for today?",
         "What did I learn today?",
         "What was the most fun thing I did today?",
         "What was the most surprising thing that happened today?",
         "What did I do today that I am proud of?",
         "What was the most interesting thing I saw or heard today?",};
        Random random = new();
        int index = random.Next(_prompts.Count);
        _prompt = _prompts[index];
    }

}
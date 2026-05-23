using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What made me smile today?",
        "If I could do one thing over today, what would it be?",
        "What is something I learned today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        return _prompts[index];
    }
}
using System;

// EXCEEDS CORE REQUIREMENTS:
// In addition to the required journal features, the program keeps track
// of how many entries are currently stored and displays the total after
// writing, loading, or displaying journal entries.

Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

int choice = 0;

while (choice != 5)
{
    Console.WriteLine();
    Console.WriteLine("Welcome to the Journal Program!");
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");

    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();

        Entry entry = new Entry();
        entry._date = dateText;
        entry._promptText = prompt;
        entry._entryText = response;

        journal.AddEntry(entry);

        Console.WriteLine($"Entry saved. Total entries: {journal._entries.Count}");
    }
    else if (choice == 2)
    {
        journal.DisplayAll();
        Console.WriteLine($"Total entries: {journal._entries.Count}");
    }
    else if (choice == 3)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);

        Console.WriteLine("Journal loaded successfully.");
        Console.WriteLine($"Total entries: {journal._entries.Count}");
    }
    else if (choice == 4)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);

        Console.WriteLine("Journal saved successfully.");
    }
    else if (choice == 5)
    {
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.WriteLine("Please select a valid option.");
    }
}
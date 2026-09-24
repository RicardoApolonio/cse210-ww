using System;

// EXCEEDS CORE REQUIREMENTS:
// The program keeps track of how many rounds the user completes
// while practicing the scripture and displays the total at the end.

Reference reference = new Reference("John", 3, 16);

Scripture scripture = new Scripture(
    reference,
    "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
);

int rounds = 0;
string input = "";

while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
{
    Console.Clear();

    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();
    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    input = Console.ReadLine() ?? "";

    if (input.ToLower() != "quit")
    {
        scripture.HideRandomWords(3);
        rounds++;
    }
}

Console.Clear();
Console.WriteLine(scripture.GetDisplayText());
Console.WriteLine();
Console.WriteLine($"Practice rounds completed: {rounds}");
Console.WriteLine("Goodbye!");
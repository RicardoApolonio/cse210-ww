using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();

            Console.WriteLine($"You have {_score} points.\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Record Event");
        Console.WriteLine("  4. Save Goals");
        Console.WriteLine("  5. Load Goals");
        Console.WriteLine("  6. Quit");

        Console.Write("Select a choice from the menu: ");
        choice = Console.ReadLine();

        if (choice == "1")
            CreateGoal();
        else if (choice == "2")
            ListGoals();
        else if (choice == "3")
            RecordEvent();
        else if (choice == "4")
            SaveGoals();
        else if (choice == "5")
            LoadGoals();
    }
}

private void CreateGoal()
{
    Console.WriteLine("\nThe types of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    Console.Write("Which type of goal would you like to create? ");
    string type = Console.ReadLine();

    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());

    if (type == "1")
    {
        _goals.Add(new SimpleGoal(name, description, points));
    }
    else if (type == "2")
    {
        _goals.Add(new EternalGoal(name, description, points));
    }
    else if (type == "3")
    {
        Console.Write("How many times does this goal need to be accomplished? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it? ");
        int bonus = int.Parse(Console.ReadLine());

        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
    }
}

private void ListGoals()
{
    Console.WriteLine("\nYour Goals:");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}

private void RecordEvent()
{
    Console.WriteLine("\nYour Goals:");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    Console.Write("Which goal did you accomplish? ");
    int goalNumber = int.Parse(Console.ReadLine());

    int pointsEarned = _goals[goalNumber - 1].RecordEvent();

    _score += pointsEarned;

    Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

private void SaveGoals()
{
    Console.Write("Enter filename: ");
    string filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        outputFile.WriteLine(_score);

        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }

    Console.WriteLine("Goals saved!");
    Console.ReadLine();
}

private void LoadGoals()
{
    Console.Write("Enter filename: ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);
    }

    Console.WriteLine("Goals loaded!");
    Console.ReadLine();
}


}
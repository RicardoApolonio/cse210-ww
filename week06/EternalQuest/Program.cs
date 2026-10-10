
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program checks for invalid goal numbers
        // and handles missing save files without crashing.
        // Completed checklist goals cannot earn extra points.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
